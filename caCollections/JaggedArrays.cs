namespace caCollections;

internal class JaggedArrays
{
    public static void Inicio()
    {
        char? opcao = '0';

        string[] familias = new[]{
            "Fred", "Wilma", "Pedrita",
            "Homer", "Marge", "Lisa", "Bart", "Meg",
            "Florinda", "Kiko"
        };

        // PROBLEMA - NÂO é um array retangular.
        string[,] familiasArrayMultidimensional = new string[3, 5]{
            { "Fred", "Wilma", "Pedrita", "", "" },
            { "Homer", "Marge", "Lisa", "Bart", "Meg" },
            { "Florinda", "Kiko", "", "", "" }
        };

        // JAGGED ARRAY == Array Denteado ou Array Serrilhado (Array de Arrays)
        string[][] familiasJaggedArray = new string[3][];

        familiasJaggedArray[0] = new string[] { "Fred", "Wilma", "Pedrita" };
        familiasJaggedArray[1] = new string[] { "Homer", "Marge", "Lisa", "Bart", "Meg" };
        familiasJaggedArray[2] = new string[] { "Florinda", "Kiko" };

        while (opcao != 'X' && opcao != 'x')
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("===              Jagged Arrays C#              ===");
            Console.WriteLine("=== 1 - Problema prático - Pessoas de Família  ===");
            Console.WriteLine("=== 2 - PROBLEMA - NÂO é um array retangular   ===");
            Console.WriteLine("=== 3 - JAGGED ARRAY == Denteado ou Serrilhado ===");
            Console.WriteLine("=== X - Sair do Sistema                        ===");
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.Write("Digite a opção desejada: ");

            try
            {
                opcao = Console.ReadLine()![0];

                Console.WriteLine();

                switch (opcao)
                {
                    case '1':
                        ProblemaPratico(familias);
                        break;
                    case '2':
                        FamiliaArrayMultidimensional(familiasArrayMultidimensional);
                        break;
                    case '3':
                        FamiliaJaggedArray(familiasJaggedArray);
                        break;
                    case '4':
                        //ProcurarTexto(aulas2, aulaModelando);
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

    /// <summary>
    /// Lista de pessoas da familia.
    /// </summary>
    /// <param name="familias">Array de pessoas</param>
    private static void ProblemaPratico(string[] familias)
    {
        Suporte.Imprimir(familias);
        Suporte.Finaliza();
    }

    /// <summary>
    /// // PROBLEMA - NÂO é um array retangular.
    /// </summary>
    /// <param name="familiasArrayMultidimensional">Array de família em duas dimensões.</param>
    private static void FamiliaArrayMultidimensional(string[,] familiasArrayMultidimensional)
    {
        Suporte.Imprimir(familiasArrayMultidimensional);
        Suporte.Finaliza();
    }

    /// <summary>
    /// JAGGED ARRAY = Array Denteado ou Array Serrilhado (Array de Arrays)
    /// 
    /// Um array denteado ou matriz denteada (jagged array) é uma matriz 
    /// cujos elementos são matrizes.
    /// 
    /// A expressão familias[1][2] acessa o segundo elemento (índice 1) do 
    /// array familias, e dentro dele acessa o terceiro elemento (índice 2).
    /// </summary>
    /// <param name="FamiliaJaggedArray">Array de família em Jagged Array</param>
    private static void FamiliaJaggedArray(string[][] FamiliaJaggedArray)
    {
        Suporte.Imprimir(FamiliaJaggedArray);
        Suporte.Finaliza();
    }
}
