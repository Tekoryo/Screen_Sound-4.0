using Screen_Sound_4._0.Modelo;
using System.Linq;


namespace Screen_Sound_4._0.Filtro;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicas(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }
    public static void FiltrarArtistaPorGenerosMusicas(List<Musica> musicas, string genero)
    {
        var ArtistaPorGenerosMusicas = musicas.Where(musica => musica.Genero!.Contains(genero)).OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct();
        Console.WriteLine($"Fitrando artista por gênero musical >>> {genero}");
        foreach (var artista in ArtistaPorGenerosMusicas)
        {
            Console.WriteLine($"- {artista}");
        }
    }
    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string NomeDoArtista)
    {
        var MusicasDeUmArtista = musicas.Where(musica => musica.Artista!.Equals(NomeDoArtista)).OrderBy(musica => musica.Nome).Select(musica => musica.Nome).Distinct().ToList();
        Console.WriteLine($"Fitrando musica do Artitas {NomeDoArtista}");
        foreach (var musica in MusicasDeUmArtista)
        {
            Console.WriteLine($"- {musica}");
        }
    }
    public static void FiltrarMusicasPorAno(List<Musica> musicas, int Ano)
    {
        var MusicasPorAno = musicas.Where(musica => musica.Ano == Ano).OrderBy(musica => musica.Nome).Select(musica => musica.Nome).Distinct().ToList();
        Console.WriteLine($"Fitrando musica do Ano {Ano}");
        foreach (var musica in MusicasPorAno)
        {
            Console.WriteLine($"- {musica}");
        }
    }
    public static void FiltraMusicaPorCSharp(List<Musica> musicas, string indice)
    {
        var MusicaPorTonalidade = musicas.Where(musica => musica.Tonalidade!.Equals(indice)).OrderBy(musica => musica.Nome).Select(musica => musica.Nome).Distinct().ToList();
        Console.WriteLine($" Musica da Tonalidade C#");
        foreach (var musica in MusicaPorTonalidade)
        {
            Console.WriteLine($"- {musica}");
        }
    }
    
}
