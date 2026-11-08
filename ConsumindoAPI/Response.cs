using System.Text.Json.Serialization;

namespace ConsumindoAPI
{
    internal class Response
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }
    }
}