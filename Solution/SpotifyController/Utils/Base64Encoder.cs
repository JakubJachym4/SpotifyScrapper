using System.Text;

namespace SpotifyController;

internal static class Base64Encoder
{
    internal static string Encode(string text)
    {
        var bytes = Encoding.UTF8.GetBytes(text);
        return Convert.ToBase64String(bytes);
    }
}