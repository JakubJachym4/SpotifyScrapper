using Flurl;
using Flurl.Http;

namespace SpotifyController;

public class Caller
{
    public static async Task<string> CallTest()
    {
        const string clientId = "8dae465c0ec64b9cb75e081d86124db6";

        var responseString = "https://accounts.spotify.com/";


        return await responseString.GetStringAsync();
    }
}