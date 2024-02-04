using System.Text.Json.Serialization;

namespace AluraCSharp4.Modelos;

public class Musica
{
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    
    
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    
    
    [JsonPropertyName("duration_ms")]
    public int? Duracao { get; set; }
    
    
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Nome da música: {Nome}");
        Console.WriteLine($"Duracao: {Duracao / 1000} segundos");
        Console.WriteLine($"Genero: {Genero}");
    }
    
}
