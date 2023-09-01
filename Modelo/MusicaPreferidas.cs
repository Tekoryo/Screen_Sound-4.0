using System.Text.Json;

namespace Screen_Sound_4._0.Modelo;

internal class MusicaPreferidas
{
    public MusicaPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }    

    public string? Nome {  get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }

    public void AdicionarMusicaFavorita(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }
    public void ExibirMusicaFavoritas()
    {
        Console.WriteLine($"\nLista de musica favorita de {Nome}:\n");
        foreach(var musicas in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musicas.Nome} - {musicas.Artista}");
        }
    }

    public void GerandoArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });
        string nomeDoArquivo = $"musica-favoritas-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"\nO Arquivo Json foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }

}
