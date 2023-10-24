namespace Engine.Entities.Exceptions;

public class AuthorizationException : Exception
{
    public int? ResponseCode { get; set; }

    public AuthorizationException(int responseCode)
    {
        ResponseCode = responseCode;
    }

    public AuthorizationException()
    {
    }
}