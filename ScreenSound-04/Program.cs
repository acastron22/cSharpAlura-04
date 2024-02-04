using System.Text.Json;
using AluraCSharp4.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.
            GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[1998].ExibirDetalhesDaMusica();
    }
    catch (Exception e)
    {
        Console.WriteLine($"Temos um problema: {e.Message}");
        throw;
    }

}
