using Screen_Sound_4._0.Filtro;
using Screen_Sound_4._0.Modelo;
using System.Text.Json;


using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        // musicas[1].ExibirDetalheDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicas(musicas);
        //LinqOrder.ExibirArtistasEmOrdem(musicas);
        //LinqFilter.FiltrarArtistaPorGenerosMusicas(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
        //LinqFilter.FiltrarMusicasPorAno(musicas, 2012);
        LinqFilter.FiltraMusicaPorCSharp(musicas, "C#");

        //var musicasPreferidasDoDaniel = new MusicaPreferidas("Daniel");
        //musicasPreferidasDoDaniel.AdicionarMusicaFavorita(musicas[1]);
        //musicasPreferidasDoDaniel.AdicionarMusicaFavorita(musicas[377]);
        //musicasPreferidasDoDaniel.AdicionarMusicaFavorita(musicas[4]);
        //musicasPreferidasDoDaniel.AdicionarMusicaFavorita(musicas[6]);
        //musicasPreferidasDoDaniel.AdicionarMusicaFavorita(musicas[1467]);
        //musicasPreferidasDoDaniel.ExibirMusicaFavoritas();

        //var musicasPreferidasDoThiago = new MusicaPreferidas("Thiago");
        //musicasPreferidasDoThiago.AdicionarMusicaFavorita(musicas[99]);
        //musicasPreferidasDoThiago.AdicionarMusicaFavorita(musicas[1998]);
        //musicasPreferidasDoThiago.AdicionarMusicaFavorita(musicas[23]);
        //musicasPreferidasDoThiago.AdicionarMusicaFavorita(musicas[45]);
        //musicasPreferidasDoThiago.AdicionarMusicaFavorita(musicas[7]);
        //musicasPreferidasDoThiago.ExibirMusicaFavoritas();
        //musicasPreferidasDoThiago.GerandoArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
    
}
