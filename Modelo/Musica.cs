using System;
using System.Text.Json.Serialization;

namespace Screen_Sound_4._0.Modelo;

internal class Musica
{
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void ExibirDetalheDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Duração em segundo: {Duracao/1000}");
        Console.WriteLine($"Genero: {Genero}");
    }
}
