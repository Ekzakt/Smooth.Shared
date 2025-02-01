namespace Smooth.Shared;

public class Result<T>
{
    public bool IsSuccess { get; }

    public T? Value { get; }

    public string? ErrorMessage { get; }


    private Result(T value)
    {
        IsSuccess = true;
        Value = value;
    }

    private Result(string errorMessage)
    {
        IsSuccess = false;
        ErrorMessage = errorMessage;
    }

    public static Result<T> Success(T value) => new(value);

    public static Result<T> Failure(string errorMessage) => new(errorMessage);
}