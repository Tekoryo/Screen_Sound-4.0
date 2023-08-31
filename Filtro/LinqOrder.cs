using Screen_Sound_4._0.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screen_Sound_4._0.Filtro;

internal class LinqOrder
{
    public static void ExibirArtistasEmOrdem(List<Musica> musicas)
    {
        var ArtistaEmOrdem = musicas.OrderBy(musicas => musicas.Artista).Select(musicas => musicas.Artista).ToList();
        Console.WriteLine("Lista ordenada de Artista: ");
        foreach(var artista in ArtistaEmOrdem)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
