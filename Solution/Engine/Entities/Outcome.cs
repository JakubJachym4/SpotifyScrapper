namespace Engine.Entities;

public class Outcome<T>
{
    public Result Result { get; set; }
    public Exception? Exception { get; set; }
    public T? Body { get; set; }
    public string Message { get; set; }

    public Outcome(Result result, T? body)
    {
        Result = result;
        Body = body;
    }

    public Outcome(Result result, Exception? exception, T? body)
    {
        Result = result;
        Exception = exception;
        Body = body;
    }

    public Outcome(Result result, Exception? exception)
    {
        Result = result;
        Exception = exception;
    }

    public Outcome(Result result, Exception? exception, string message)
    {
        Result = result;
        Exception = exception;
        Message = message;
    }
}