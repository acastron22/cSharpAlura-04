
/*
 Declarar uma lista de inteiros e tente acessar um elemento em um índice inexistente. Tratar a exceção apropriada.
 */
List<string> numeros = new List<string>(["0", "10", "15", "20", "25", "30"]);

Console.WriteLine("Qual índice da lista de numeros você deseja acessar? campos de 0 a 5");
int escolha = int.Parse(Console.ReadLine()!);
try
{
 Console.WriteLine(numeros[escolha]);
}
catch (Exception e)
{
 Console.WriteLine("Oh não! Valor digitado não está no índice da nossa lista!");
 Console.WriteLine(e.Message);
}
