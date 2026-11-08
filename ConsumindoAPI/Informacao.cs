using System.Text.Json.Serialization;

namespace ConsumindoAPI
{
    internal class Teste
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}