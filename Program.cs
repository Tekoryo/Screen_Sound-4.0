using Screen_Sound_4._0.Modelo;
using System.Text.Json;

/*
 Exibir todos os gêneros musicais da lista;

Ordenar os artistas por nome;

Filtrar artistas por gênero musical;

Filtrar as músicas de um artista.
 */

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[1998].ExibirDetalheDaMusica();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}