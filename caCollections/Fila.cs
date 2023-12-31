﻿namespace caCollections;

/// <summary>
/// Queue - FIFO - First in First Out
/// </summary>
internal class Fila
{
    static readonly Queue<string> pedagio = new();

    public static void Inicio()
    {
        char? opcao = '0';

        while (opcao != 'X' && opcao != 'x')
        {
            Console.Clear();
            Console.WriteLine("=================================================");
            Console.WriteLine("===            Fila Collection C#             ===");
            Console.WriteLine("=== 1 - Introdução a Fila (Queue)             ===");
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
        Console.WriteLine("-------------------------");
        //entrou: van
        Enfileirar("van");

        //entrou: kombi
        Enfileirar("kombi");

        //entrou: kombi
        Enfileirar("guincho");

        //entrou: kombi
        Enfileirar("pick-up");

        //carro liberado
        Desenfileirar();

        //carro liberado
        Desenfileirar();

        //carro liberado
        Desenfileirar();

        //carro liberado
        Desenfileirar();

        //carro liberado
        Desenfileirar();
        Desenfileirar();
        Desenfileirar();

        Suporte.Finaliza();
    }

    private static void Desenfileirar()
    {
        if (pedagio.Any())
        {
            if (pedagio.Peek() == "guincho")
                Console.WriteLine("Guincho está fazendo o pagamento.");

            string veiculo = pedagio.Dequeue();
            Console.WriteLine($"Saiu da fila: {veiculo}");
            Suporte.Imprimir(pedagio);
            Console.WriteLine("-------------------------");
        }
    }

    private static void Enfileirar(string veiculo)
    {
        Console.WriteLine($"Entrou na fila: {veiculo}");
        pedagio.Enqueue(veiculo);
        Console.WriteLine("FILA:");
        Suporte.Imprimir(pedagio);
        Console.WriteLine("-------------------------");
    }
}
