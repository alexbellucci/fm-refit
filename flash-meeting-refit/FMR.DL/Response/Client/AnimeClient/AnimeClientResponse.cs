using Newtonsoft.Json;

namespace FMR.DL.Response.Client.AnimeClient
{
    public class AnimeClientResponse
    {
        [JsonProperty("anime")] public string Anime { get; set; }
        [JsonProperty("character")] public string Personagem { get; set; }
        [JsonProperty("quote")] public string Fala { get; set; }

    }
}
