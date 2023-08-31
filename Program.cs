using Screen_Sound_4._0.Modelo;
using Screen_Sound_4._0.Filtro;
using System.Text.Json;

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
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
        LinqFilter.FiltrarMusicasPorAno(musicas, 2012);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
