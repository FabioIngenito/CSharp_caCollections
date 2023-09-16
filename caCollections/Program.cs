using caCollections;
using System.Runtime.InteropServices;

// Totalmente baseado nos cursos da Alura:
//
// Curso de
// C# Collections parte 1: Listas, arrays, listas ligadas, dicionários e conjuntos
// Instrutor: Marcelo Oliveira
// https://cursos.alura.com.br/course/csharp-collections
//
// Curso de
// C# Collections parte 2: Coleções ordenadas, arrays multidimensionais e LINQ
// Instrutor: Marcelo Oliveira
// https://cursos.alura.com.br/course/csharp-collections-parte-2

char? opcao = '0';

while (opcao != 'X' && opcao != 'x')
{
    Console.Clear();
    Console.WriteLine("====================================================");
    Console.WriteLine("===                Collections C#                ===");
    Console.WriteLine("=== 1 - Arrays                                   ===");
    Console.WriteLine("=== 2 - List (Listas, 'a + usada')               ===");
    Console.WriteLine("=== 3 - List (Listas 2)                          ===");
    Console.WriteLine("=== 4 - Sets (Conjuntos)                         ===");
    Console.WriteLine("=== 5 - Directories (Dicionários)                ===");
    Console.WriteLine("=== 6 - LinkedList (Listas Ligadas)              ===");
    Console.WriteLine("=== 7 - Stack (Pilha)                            ===");
    Console.WriteLine("=== 8 - Queue (Fila)                             ===");
    Console.WriteLine("=== 9 - Qual coleção usar?                       ===");
    Console.WriteLine("=== A - Sorted List                              ===");
    Console.WriteLine("=== B - Sorted Dictionary                        ===");
    Console.WriteLine("=== C - Sorted Set                               ===");
    Console.WriteLine("=== D - Array Multidimensional                   ===");
    Console.WriteLine("=== E - Jagged Arrays                            ===");
    Console.WriteLine("=== F - Consultando Collections LINQ             ===");
    Console.WriteLine("=== G - Consultando Sequências de Elementos LINQ ===");
    Console.WriteLine("=== H - Operadores de Conjuntos LINQ             ===");
    Console.WriteLine("=== I - Covariância (Conversões de Coleções)     ===");
    Console.WriteLine("=== J - O Laço Foreach                           ===");
    Console.WriteLine("=== X - Sair do Sistema                          ===");
    Console.WriteLine("====================================================");
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
            case '9':
                QualColecaoUsar.Inicio();
                break;
            case 'A':
            case 'a':
                SortedList.Inicio();
                break;
            case 'B':
            case 'b':
                SortedDictionary.Inicio();
                break;
            case 'C':
            case 'c':
                SortedSet.Inicio();
                break;
            case 'D':
            case 'd':
                ArrayMultidimensional.Inicio();
                break;
            case 'E':
            case 'e':
                JaggedArrays.Inicio();
                break;
            case 'F':
            case 'f':
                ConsultandoCollectionsLINQ.Inicio();
                break;
            case 'G':
            case 'g':
                ConsultandSequenciasElementosLINQ.Inicio();
                break;
            case 'H':
            case 'h':
                OperadoresConjuntosLINQ.Inicio();
                break;
            case 'I':
            case 'i':
                CovarianciaIEnumerable.Inicio();
                break;
            case 'J':
            case 'j':
                LacoForeach.Inicio();
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
        Console.WriteLine("ABEND - abnormal end.");
        Console.WriteLine($"ERRO: {ex.Message}");
        Console.ReadKey();
    }
}
