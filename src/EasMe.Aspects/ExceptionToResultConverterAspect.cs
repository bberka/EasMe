using AspectInjector.Broker;
using EasMe.Result;

namespace EasMe.Aspects;

/// <summary>
///    Catches exceptions and converts them to Result Type
/// </summary>
[Aspect(Scope.PerInstance)]
[Injection(typeof(ExceptionToResultConverterAspect))]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
public class ExceptionToResultConverterAspect : Attribute
{
   private readonly bool _enablelogging;
   public ExceptionToResultConverterAspect(bool enablelogging)
   {
      _enablelogging = enablelogging;
   }
   public ExceptionToResultConverterAspect()
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
         var isResultType = returnType == typeof(Result.Result) || returnType == typeof(ResultData<>);
         if (!isResultType) throw;
         return Result.Result.Exception(ex, "Exception", new[]
         {
            new Param("methodName", methodName)
         });
      }
   }
}