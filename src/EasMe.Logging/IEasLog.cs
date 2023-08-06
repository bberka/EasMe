﻿using EasMe.Result;

namespace EasMe.Logging;

public interface IEasLog
{
   void LogResult(Result.Result result);
   void LogResult<T>(ResultData<T> result);
   void LogResult(Result.Result result, object message);
   void LogResult<T>(ResultData<T> result, object message);

   //void LogBool(bool status, string trueMessage, string falseMessage,
   //    ResultSeverity falseResultSeverity = ResultSeverity.Warn);
   void Info(params object[] param);
   void Info(object obj1);
   void Info(object obj1, object obj2);
   void Info(object obj1, object obj2, object obj3);
   void Info(object obj1, object obj2, object obj3, object obj4);
   void Info(object obj1, object obj2, object obj3, object obj4, object obj5);
   void Info(object obj1, object obj2, object obj3, object obj4, object obj5, object obj6);
   void Info(object obj1, object obj2, object obj3, object obj4, object obj5, object obj6, object obj7);
   void Info(object obj1, object obj2, object obj3, object obj4, object obj5, object obj6, object obj7, object obj8);
   void Error(params object[] param);
   void Error(object obj1);
   void Error(object obj1, object obj2);
   void Error(object obj1, object obj2, object obj3);
   void Error(object obj1, object obj2, object obj3, object obj4);
   void Error(object obj1, object obj2, object obj3, object obj4, object obj5);
   void Error(object obj1, object obj2, object obj3, object obj4, object obj5, object obj6);
   void Error(object obj1, object obj2, object obj3, object obj4, object obj5, object obj6, object obj7);
   void Error(object obj1, object obj2, object obj3, object obj4, object obj5, object obj6, object obj7, object obj8);
   void Warn(params object[] param);
   void Warn(object obj1);
   void Warn(object obj1, object obj2);
   void Warn(object obj1, object obj2, object obj3);
   void Warn(object obj1, object obj2, object obj3, object obj4);
   void Warn(object obj1, object obj2, object obj3, object obj4, object obj5);
   void Warn(object obj1, object obj2, object obj3, object obj4, object obj5, object obj6);
   void Warn(object obj1, object obj2, object obj3, object obj4, object obj5, object obj6, object obj7);
   void Warn(object obj1, object obj2, object obj3, object obj4, object obj5, object obj6, object obj7, object obj8);
   void Exception(Exception ex);
   void Exception(Exception ex, params object[] param);
   void Exception(Exception ex, object obj1);
   void Exception(Exception ex, object obj1, object obj2);
   void Exception(Exception ex, object obj1, object obj2, object obj3);
   void Exception(Exception ex, object obj1, object obj2, object obj3, object obj4);
   void Exception(Exception ex, object obj1, object obj2, object obj3, object obj4, object obj5);
   void Exception(Exception ex, object obj1, object obj2, object obj3, object obj4, object obj5, object obj6);

   void Exception(Exception ex, object obj1, object obj2, object obj3, object obj4, object obj5, object obj6,
      object obj7);

   void Exception(Exception ex, object obj1, object obj2, object obj3, object obj4, object obj5, object obj6,
      object obj7, object obj8);

   void Fatal(params object[] param);
   void Fatal(object obj1);
   void Fatal(object obj1, object obj2);
   void Fatal(object obj1, object obj2, object obj3);
   void Fatal(object obj1, object obj2, object obj3, object obj4);
   void Fatal(object obj1, object obj2, object obj3, object obj4, object obj5);
   void Fatal(object obj1, object obj2, object obj3, object obj4, object obj5, object obj6);
   void Fatal(object obj1, object obj2, object obj3, object obj4, object obj5, object obj6, object obj7);
   void Fatal(object obj1, object obj2, object obj3, object obj4, object obj5, object obj6, object obj7, object obj8);
   void Fatal(Exception ex, params object[] param);
   void Fatal(Exception ex, object obj1);
   void Fatal(Exception ex, object obj1, object obj2);
   void Fatal(Exception ex, object obj1, object obj2, object obj3);
   void Fatal(Exception ex, object obj1, object obj2, object obj3, object obj4);
   void Fatal(Exception ex, object obj1, object obj2, object obj3, object obj4, object obj5);
   void Fatal(Exception ex, object obj1, object obj2, object obj3, object obj4, object obj5, object obj6);
   void Fatal(Exception ex, object obj1, object obj2, object obj3, object obj4, object obj5, object obj6, object obj7);

   void Fatal(Exception ex, object obj1, object obj2, object obj3, object obj4, object obj5, object obj6, object obj7,
      object obj8);

   void Debug(params object[] param);
   void Debug(object obj1);
   void Debug(object obj1, object obj2);
   void Debug(object obj1, object obj2, object obj3);
   void Debug(object obj1, object obj2, object obj3, object obj4);
   void Debug(object obj1, object obj2, object obj3, object obj4, object obj5);
   void Debug(object obj1, object obj2, object obj3, object obj4, object obj5, object obj6);
   void Debug(object obj1, object obj2, object obj3, object obj4, object obj5, object obj6, object obj7);
   void Debug(object obj1, object obj2, object obj3, object obj4, object obj5, object obj6, object obj7, object obj8);
   void Debug(Exception ex, params object[] param);
   void Debug(Exception ex, object obj1);
   void Debug(Exception ex, object obj1, object obj2);
   void Debug(Exception ex, object obj1, object obj2, object obj3);
   void Debug(Exception ex, object obj1, object obj2, object obj3, object obj4);
   void Debug(Exception ex, object obj1, object obj2, object obj3, object obj4, object obj5);
   void Debug(Exception ex, object obj1, object obj2, object obj3, object obj4, object obj5, object obj6);
   void Debug(Exception ex, object obj1, object obj2, object obj3, object obj4, object obj5, object obj6, object obj7);

   void Debug(Exception ex, object obj1, object obj2, object obj3, object obj4, object obj5, object obj6, object obj7,
      object obj8);

   void Trace(params object[] param);
   void Trace(object obj1);
   void Trace(object obj1, object obj2);
   void Trace(object obj1, object obj2, object obj3);
   void Trace(object obj1, object obj2, object obj3, object obj4);
   void Trace(object obj1, object obj2, object obj3, object obj4, object obj5);
   void Trace(object obj1, object obj2, object obj3, object obj4, object obj5, object obj6);
   void Trace(object obj1, object obj2, object obj3, object obj4, object obj5, object obj6, object obj7);
   void Trace(object obj1, object obj2, object obj3, object obj4, object obj5, object obj6, object obj7, object obj8);

   bool IsLogLevelEnabled(EasLogLevel logLevel);
}