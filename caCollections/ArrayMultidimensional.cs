namespace caCollections;

internal class ArrayMultidimensional
{
    public static void Inicio()
    {
        char? opcao = '0';

        string[] resultados = new[]
        {
            "Alemanha", "Espanha", "Itália",
            "Argentina", "Holanda", "França",
            "Holanda", "Alemanha", "Alemanha"
        };

        string[,] resultados2D = new string[3, 3]
        {
            { "Alemanha", "Espanha", "Itália" },
            { "Argentina", "Holanda", "França" },
            { "Holanda", "Alemanha", "Alemanha" }
        };

        string[,] resultados2DIndexador = new string[3, 3];

        resultados2DIndexador[0, 0] = "Alemanha";
        resultados2DIndexador[1, 0] = "Argentina";
        resultados2DIndexador[2, 0] = "Holanda";

        resultados2DIndexador[0, 1] = "Espanha";
        resultados2DIndexador[1, 1] = "Holanda";
        resultados2DIndexador[2, 1] = "Alemanha";

        resultados2DIndexador[0, 2] = "Itália";
        resultados2DIndexador[1, 2] = "França";
        resultados2DIndexador[2, 2] = "Alemanha";

        while (opcao != 'X' && opcao != 'x')
        {
            Console.Clear();
            Console.WriteLine("=================================================");
            Console.WriteLine("===    Array Multidimensional Collection C#   ===");
            Console.WriteLine("=== 1 - Montando e Imprimindo Tabela          ===");
            Console.WriteLine("=== 2 - Montando as Dimensões                 ===");
            Console.WriteLine("=== 3 - Montando as Dimensões com Indexador   ===");
            Console.WriteLine("=== 4 - Colocando em Linhas                   ===");
            Console.WriteLine("=== 5 - Incluindo uma Linha                   ===");
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
                        MontandoTabela(resultados);
                        break;
                    case '2':
                        MontandoDimensoes(resultados2D);
                        break;
                    case '3':
                        MontandoDimensoesIndexador(resultados2DIndexador);
                        break;
                    case '4':
                        ColocandoEmLinhas(resultados2DIndexador);
                        break;
                    case '5':
                        IncluindoLinha(resultados2DIndexador);
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

    private static void MontandoTabela(string[] resultados)
    {
        Suporte.Imprimir(resultados);
        Suporte.Finaliza();
    }

    private static void MontandoDimensoes(string[,] resultados2)
    {
        Suporte.Imprimir(resultados2);
        Suporte.Finaliza();
    }

    private static void MontandoDimensoesIndexador(string[,] resultadosIndex)
    {
        Suporte.Imprimir(resultadosIndex);
        Suporte.Finaliza();
    }

    private static void ColocandoEmLinhas(string[,] resultadosIndex)
    {
        Imprimir2(resultadosIndex);
        Suporte.Finaliza();
    }

    /// <summary>
    /// Observação:
    /// - O método Array.Resize T (T[], Int32) SOMENTE redimendiona
    /// arrays de UMA dimensão.
    /// Criei um laço FOR duplo para coopiar da array [3,3] para a array [4,3]
    /// </summary>
    /// <param name="resultadosIndex"></param>
    private static void IncluindoLinha(string[,] resultadosIndex)
    {
        string[,] arrRedimensona = new string[4, 3];

        for (int x = 0; x <= resultadosIndex.GetUpperBound(0); x++)
            for (int y = 0; y <= resultadosIndex.GetUpperBound(1); y++)
                arrRedimensona[x, y] = resultadosIndex[x, y];

        arrRedimensona[3, 0] = "Brasil";
        arrRedimensona[3, 1] = "Uruguai";
        arrRedimensona[3, 2] = "Portugal";

        Imprimir2(arrRedimensona);
        Suporte.Finaliza();
    }

    #region SUPORTE
    /// <summary>
    /// Imprimindo com "foreach"
    /// </summary>
    /// <param name="resultados">Array Resultados</param>

    private static void Imprimir2(string[,] resultados)
    {
        for (int copa = 0; copa <= resultados.GetUpperBound(1); copa++)
        {
            int ano = 2014 - copa * 4;
            Console.Write(ano.ToString().PadRight(12));
        }

        Console.WriteLine();

        for (int posicao = 0; posicao <= resultados.GetUpperBound(0); posicao++)
        {
            for (int copa = 0; copa <= resultados.GetUpperBound(1); copa++)
                Console.Write(resultados[posicao, copa].PadRight(12));

            Console.WriteLine();
        }
    }

    #endregion
}
