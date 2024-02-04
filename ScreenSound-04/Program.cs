
/*
 *      Escrever um programa que solicite dois números a e b lidos do teclado e realize a divisão de a por b.
 * Caso essa operação não seja possível, mostrar uma mensagem no console que deixe claro o erro ocorrido.
 */
    Console.Write("Digite um valor 'a': ");
    int a = int.Parse(Console.ReadLine()!);
    Console.Write("Digite um valor 'b': ");
    int b = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Agora vamos dividir a por b");
    Thread.Sleep(1500);
    try
    {
        double resp = a / b;
        Console.WriteLine(resp);
    }
    catch (Exception e)
    {
        Console.WriteLine("Parece que a não pode ser dividido por b");
        Console.WriteLine(e.Message);
        
    }
