// Totalmente baseado nos cursos da Alura:
//
// Curso de
// C# Collections parte 1: Listas, arrays, listas ligadas, dicionários e conjuntos
// https://cursos.alura.com.br/course/csharp-collections
//
// Curso de
// C# Collections parte 2: Coleções ordenadas, arrays multidimensionais e LINQ
// https://cursos.alura.com.br/course/csharp-collections-parte-2
//
// Instrutor: Marcelo Oliveira

using caCollections;

char? opcao = '0';

while (opcao != 'X' && opcao != 'x')
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===      Collections C#     ===");
    Console.WriteLine("=== 1 - Arrays              ===");
    Console.WriteLine("=== 2 - Listas, 'a + usada' ===");
    Console.WriteLine("=== 3 - Listas 2            ===");
    Console.WriteLine("=== 4 - Sets (conjuntos)    ===");
    Console.WriteLine("=== 5 - Dicionários         ===");
    Console.WriteLine("=== 6 - Listas Ligadas      ===");
    Console.WriteLine("=== 7 - Pilha (Stack)       ===");
    Console.WriteLine("=== 8 - Fila (Queue)        ===");
    Console.WriteLine("=== 9 - Sorted List         ===");
    Console.WriteLine("=== A - Sorted Dictionary   ===");
    Console.WriteLine("=== B - Sorted Set          ===");
    Console.WriteLine("=== X - Sair do Sistema     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.Write("Digite a opção desejada: ");

    try
    {
        opcao = Console.ReadLine()![0];

        Console.WriteLine();

        switch (opcao)
        {
            case '1':
                Arrays.Inicio();
                break;
            case '2':
                Listas.Inicio();
                break;
            case '3':
                Listas2.Inicio();
                break;
            case '4':
                Sets.Inicio();
                break;
            case '5':
                Dicionarios.Inicio();
                break;
            case '6':
                ListasLigadas.Inicio();
                break;
            case '7':
                Pilha.Inicio();
                break;
            case '8':
                Fila.Inicio();
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
    }
}