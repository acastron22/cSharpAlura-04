// Modelar e desserializar a classe Pais,

using System.Text.Json;
using AluraCSharp4.Modelos;

using (HttpClient client = new HttpClient())
{
    string resposta =
        await client.GetStringAsync(
            "https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
    try
    {
        var paises = JsonSerializer.Deserialize<List<Pais>>(resposta);
        paises?[2].ExibirDetalhesDoPais();
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        throw;
    }
}
