namespace caCollections;

/// <summary>
/// Stack - LIFO - Last In First Out
/// </summary>
public class Pilha
{
    public static void Inicio()
    {
        char? opcao = '0';

        while (opcao != 'X' && opcao != 'x')
        {
            Console.Clear();
            Console.WriteLine("=================================================");
            Console.WriteLine("===        Pilha (Stack) Collection C#        ===");
            Console.WriteLine("=== 1 - Introdução a pilha (Stack)            ===");
            Console.WriteLine("=== X - Sair do Sistema                       ===");
            Console.WriteLine("=================================================");
            Console.WriteLine();
            Console.Write("Digite a opção desejada: ");

            try
            {
                opcao = Console.ReadLine()![0];

                Console.WriteLine();

                switch (opcao)
                {
                    case '1':
                        Introducao();
                        break;
                    case 'X':
                    case 'x':
                        break;
                    default:
                        Console.WriteLine("Opcao não implementada.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERRO: {ex.Message}");
                Console.ReadKey();
            }
        }
    }

    private static void Introducao()
    {
        Navegador navegador = new();

        navegador.NavegarPara("google.com");
        navegador.NavegarPara("caelum.com.br");
        navegador.NavegarPara("alura.com.br");
        Console.WriteLine("------------------------");
        navegador.NavegarAnterior();
        navegador.NavegarAnterior();
        navegador.NavegarAnterior();
        navegador.NavegarAnterior();
        navegador.NavegarAnterior();
        navegador.NavegarAnterior();
        Console.WriteLine("------------------------");
        navegador.NavegarProximo();
        navegador.NavegarProximo();
        navegador.NavegarProximo();
        navegador.NavegarProximo();
        navegador.NavegarProximo();
        Console.WriteLine("------------------------");

        //Imprimir(csharpcolecoes.Alunos);
        Suporte.Finaliza();
    }
}

internal class Navegador
{
    private readonly Stack<string> historicoAnterior = new();
    private readonly Stack<string> historicoProximo = new();
    private string atual = "vazia";

    internal Navegador()
    {
        Console.WriteLine($"Página atual: {atual}");
    }

    internal void NavegarAnterior()
    {
        if (historicoAnterior.Any())
        {
            historicoProximo.Push(atual);
            atual = historicoAnterior.Pop();
            Console.WriteLine($"Página atual: {atual}");
        }
    }

    internal void NavegarPara(string url)
    {
        historicoAnterior.Push(atual);
        atual = url;
        Console.WriteLine($"Página atual: {atual}");
    }

    internal void NavegarProximo()
    {
        if (historicoProximo.Any())
        {
            historicoAnterior.Push(atual);
            atual = historicoProximo.Pop();
            Console.WriteLine($"Página atual: {atual}");
        }
    }
}