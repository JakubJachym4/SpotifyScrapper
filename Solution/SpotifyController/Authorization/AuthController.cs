using Engine.Entities;
using Engine.Entities.Exceptions;
using Flurl.Http;

namespace SpotifyController.Authorization;

public class AuthController
{
    private const string TokenUrl = "https://accounts.spotify.com/api/tokenfd";
    public async Task<Outcome<TokenResponse>> AuthorizeUser()
    {
        const string clientId = "8dae465c0ec64b9cb75e081d86124db6";
        const string clientSecret = "d49d0a439ee24d959c93a373e75c7014";
        
        
        Outcome<TokenResponse> outcome;
        
        var encodedAuthHeader = string.Concat("Basic ", Base64Encoder.Encode($"{clientId}:{clientSecret}"));

        var request = TokenUrl
            .WithHeaders(new
            {
                Content_Type = "application/x-www-form-urlencoded", //Flurl renders '_' to '-' in headers automatically
                Authorization = encodedAuthHeader
            })
            .PostUrlEncodedAsync(new
            {
                grant_type = "client_credentials"
            });

        IFlurlResponse response;
        
        try
        {
            response = await request;
        }
        catch (FlurlHttpException e)
        {
            var exception = new AuthorizationException();
            string msg = "There was an error while authorizing user";
            outcome = new(Result.Exception, exception, msg);

            return outcome;
        }
        
        outcome = new(Result.Success, await response.GetJsonAsync<TokenResponse>());

        return outcome;
    }
}