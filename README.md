🐉 Consumindo PokéAPI com C#

Projeto desenvolvido em C# utilizando a PokéAPI para realizar consultas de Pokémon através de uma aplicação de console.

O projeto foi feito com o objetivo de praticar requisições HTTP, consumo de APIs, desserialização de JSON e tratamento de erros.

🛠️ Tecnologias utilizadas
C#
.NET
HttpClient
System.Text.Json

📌 Funcionalidades
Consulta inicial do Pikachu para testar a conexão com a API.
Busca de Pokémon pelo nome ou ID.
Normalização do texto digitado utilizando .ToLower().Trim().
Tratamento de erros HTTP, incluindo o status 404 quando um Pokémon não é encontrado.

📂 Estrutura do projeto
text
ConsumindoAPI/
├── Program.cs      # Código principal e requisições HTTP
├── Response.cs     # Modelo dos dados retornados pela API
└── Informacao.cs   # Modelo utilizado na busca

▶️ Como executar
Clone o repositório:
bash
git clone https://github.com/HenriqueMatheusNunes/ConsumindoPokeAPI/tree/main/ConsumindoAPI

Entre na pasta do projeto:
bash
cd ConsumindoAPI

Execute a aplicação:
bash
dotnet run

🌐 API utilizada
PokéAPI
https://pokeapi.co/

<img width="516" height="210" alt="image" src="https://github.com/user-attachments/assets/7fa8cdf5-1278-45e1-9b62-65126c27ddb9" />
