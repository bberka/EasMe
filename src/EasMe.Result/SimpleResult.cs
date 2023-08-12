namespace EasMe.Result;

public readonly struct SimpleResult
{
  public SimpleResult(string message, ResultLevel level, int httpStatus, object? data = null)
  {
    Message = message;
    Level = level;
    HttpStatusCode = httpStatus;
    Data = data;
  }
  public string Message { get; }

  public ResultLevel Level { get; }
  public int HttpStatusCode { get; }
  public object? Data { get;  }

}