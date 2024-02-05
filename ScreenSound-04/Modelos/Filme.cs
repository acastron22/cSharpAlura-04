using System.Text.Json.Serialization;

namespace AluraCSharp4.Modelos;

public class Filme
{
    [JsonPropertyName("title")] public string? Titulo { get; set; }

    [JsonPropertyName("year")] public string? Ano { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome do filme: {Titulo}");
        Console.WriteLine($"Ano de lançamento: {Ano}");
    }
    
    
}
