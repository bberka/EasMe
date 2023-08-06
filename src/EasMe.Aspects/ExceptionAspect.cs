using AspectInjector.Broker;
using Serilog;

namespace EasMe.Aspects;

/// <summary>
/// Catches exceptions and re-throws them with a more detailed message.
///
/// 
/// </summary>
[Aspect(Scope.PerInstance)]
[Injection(typeof(ExceptionAspect))]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
public class ExceptionAspect : Attribute
{
   private readonly bool _enablelogging;
   public ExceptionAspect(bool enablelogging)
   {
      _enablelogging = enablelogging;
   }
   public ExceptionAspect()
   {
      _enablelogging = true;
   }
   [Advice(Kind.Around)]
   public object Around(
      [Argument(Source.Target)] Func<object[], object> target,
      [Argument(Source.Arguments)] object[] args,
      [Argument(Source.Name)] string methodName,
      [Argument(Source.Type)] Type type,
      [Argument(Source.ReturnType)] Type returnType)
   {
      var className = type.Name;
      var argList = string.Join(",", args);
      try {
         return target(args);
      }
      catch (Exception ex) {
         var msg = $"Exception in {className}.{methodName}({argList}) Message:{ex.Message}";
         if (_enablelogging)
            Log.Fatal(ex, msg);
         throw new Exception(msg, ex);
      }
   }

}