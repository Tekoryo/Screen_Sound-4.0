using System;
using System.Text.Json.Serialization;

namespace Screen_Sound_4._0.Modelo;

internal class Musica
{
    private string[] tonalidade = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    [JsonPropertyName("year")]
    public String? AnoString { get; set; }
    public int Ano
    {
        get
        {
            return int.Parse(AnoString!);
        }
    }
    [JsonPropertyName("key")]
    public int key { get; set; }
    public string Tonalidade
    {
        get
        {
            return tonalidade[key];
        }
    }
   
    public void ExibirDetalheDaMusica()
    {
      
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Duração em segundo: {Duracao/1000}");
        Console.WriteLine($"Genero: {Genero}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
    }
}
