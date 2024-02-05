using System.Text.Json.Serialization;

namespace AluraCSharp4.Modelos;

public class Pais
{
    [JsonPropertyName("nome")] public string? Nome { get; set; }
    [JsonPropertyName("capital")] public string? Capital { get; set; }
    [JsonPropertyName("populacao")] public int? Populacao { get; set; }
    [JsonPropertyName("continente")] public string? Continente { get; set; }
    [JsonPropertyName("idioma")] public string? Idioma { get; set; }

    public void ExibirDetalhesDoPais()
    {
        Console.WriteLine($"Nome do país: {Nome}");
        Console.WriteLine($"Capital do país: {Capital}");
        Console.WriteLine($"Número de população: {Populacao}");
        Console.WriteLine($"Continente: {Continente}");
        Console.WriteLine($"Idioma falado: {Idioma}");
    }
}
