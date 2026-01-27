namespace IJDEVLibrary;

public class IJCustomExceptionsV2
{
    public int ErrorCode { get; }
    public string ErrorMessage { get; }

    public IJCustomExceptionsV2(int errorCode, string errorMessage)
    {
        ErrorCode = errorCode;
        ErrorMessage = errorMessage;
    }


}

public class IJCustomExceptions : Exception
{
    public int ExCode { get; }
    public IJCustomExceptions(int code, string message) : base(message)
    {
        ExCode = code;
    }

}
