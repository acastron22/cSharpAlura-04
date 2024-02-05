using System.Text.Json;
using AluraCSharp4.Modelos;


using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.
            GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        

        var filme = JsonSerializer.Deserialize<List<Filme>>(resposta)!;
        filme[0].ExibirDetalhes();
    }
    catch (Exception e)
    {
        Console.WriteLine($"Temos um problema: {e.Message}");
        throw;
    }

}
