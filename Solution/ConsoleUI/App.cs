using Engine.Entities;
using SpotifyController;
using SpotifyController.Authorization;

var controler = new AuthController();
var response = await controler.AuthorizeUser();
if(response.Result == Result.Success)
    Console.WriteLine($"Success! - auth token: {response.Body!.access_token}");
else
    Console.WriteLine($"Failure! message - {response.Message}");