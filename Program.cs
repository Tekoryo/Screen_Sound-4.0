using Screen_Sound_4._0.Modelo;
using Screen_Sound_4._0.Filtro;
using System.Text.Json;

/*
 Exibir todos os gêneros musicais da lista; x

Ordenar os artistas por nome; x

Filtrar artistas por gênero musical;

Filtrar as músicas de um artista.
 */

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //musicas[1998].ExibirDetalheDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicas(musicas);
        //LinqOrder.ExibirArtistasEmOrdem(musicas);
        //LinqFilter.FiltrarArtistaPorGenerosMusicas(musicas, "rock");
        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
