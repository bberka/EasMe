namespace EasMe.Result;

public interface IResultLocalizer
{
  public string GetResultMessage(string errorCode,Param[] @params);
}