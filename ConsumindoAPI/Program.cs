using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsumindoAPI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Reutilização de uma única instância do HttpClient
            using var httpClient = new HttpClient();

            // 1. Teste fixo com o Pikachu
            var response = await httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon/pikachu");

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Sucesso 200 OK");

                var jsonString = await response.Content.ReadAsStringAsync();
                var pokemon = JsonSerializer.Deserialize<Response>(jsonString);

                if (pokemon != null)
                {
                    Console.WriteLine($"Nome: {pokemon.Name}");
                    Console.WriteLine($"ID: {pokemon.Id}");
                    Console.WriteLine($"Altura: {pokemon.Height}");
                }
            }
            else
            {
                Console.WriteLine("Não foi encontrado: " + response.StatusCode);
            }

            Console.WriteLine("\nPressione ENTER para continuar para a busca por nome...");
            Console.ReadLine();

            // 2. Busca dinâmica por input do usuário
            Console.WriteLine("Digite o nome ou ID de um Pokémon:");
            string entradaUsuario = Console.ReadLine()?.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(entradaUsuario))
            {
                Console.WriteLine("Entrada inválida!");
                return;
            }

            var request = await httpClient.GetAsync($"https://pokeapi.co/api/v2/pokemon/{entradaUsuario}");

            if (request.IsSuccessStatusCode)
            {
                var json = await request.Content.ReadAsStringAsync();
                var pokemonName = JsonSerializer.Deserialize<Informacao>(json);

                if (pokemonName != null)
                {
                    Console.WriteLine($"Pokémon encontrado: {pokemonName.Name}");
                }
            }
            else if (request.StatusCode == HttpStatusCode.NotFound)
            {
                Console.WriteLine("Erro: Pokémon não encontrado. Tente novamente.");
            }
            else
            {
                Console.WriteLine($"Ocorreu um erro inesperado: {request.StatusCode}");
            }
        }
    }
}