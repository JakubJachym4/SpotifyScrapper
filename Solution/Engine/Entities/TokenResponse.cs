namespace Engine.Entities;

public class TokenResponse
{
    public string access_token { get; set; }
    public string token_type { get; set; }
    public int expires_in { get; set; }
    
    public TokenResponse(string accessToken, string tokenType, int expiresIn)
    {
        access_token = accessToken;
        token_type = tokenType;
        expires_in = expiresIn;
    }
}