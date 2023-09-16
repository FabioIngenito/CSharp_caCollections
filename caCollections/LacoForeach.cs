using System.Diagnostics.Metrics;
using System.Linq.Expressions;

namespace caCollections;

/// <summary>
/// Todas as coleções que implementam a interface IEnumerable podem ser 
/// iteradas pelo laço "foreach".
/// 
/// O laço foreach pode varrer qualquer coleção que implementa a interface 
/// IEnumerable.
/// </summary>
internal class LacoForeach
{
    public static void Inicio()
    {
        char? opcao = '0';

        List<string> meses = new()
        {
                    "Janeiro", "Fevereiro", "Março",
                    "Abril", "Maio", "Junho",
                    "Julho", "Agosto", "Setembro",
                    "Outubro", "Novembro", "Dezembro"
        };

        string[] mesesArray = new[]
        {
                    "Janeiro", "Fevereiro", "Março",
                    "Abril", "Maio", "Junho",
                    "Julho", "Agosto", "Setembro",
                    "Outubro", "Novembro", "Dezembro"
        };

        while (opcao != 'X' && opcao != 'x')
        {
            Console.Clear();
            Console.WriteLine("=================================================");
            Console.WriteLine("===           For Each C# (para cada)         ===");
            Console.WriteLine("=== 1 - Imprimir no Console LIST              ===");
            Console.WriteLine("=== 2 - Colocar Tudo em Maiúsculo LIST        ===");
            Console.WriteLine("=== 3 - Colocar JANEIRO em Maiúsculo ARRAY    ===");
            Console.WriteLine("=== 4 - Colocar Tudo em Maiusculo IEnumerable ===");
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
                        ImprimirConsole(meses);
                        break;
                    case '2':
                        ColocarTudoMaiusculo(meses);
                        break;
                    case '3':
                        ColocarTudoMaiusculoArray(mesesArray);
                        break;
                    case '4':
                        ColocarTudoMaiusculoIEnumerable(mesesArray);
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
    /// O "foreach" herda a interface IEnumerable T
    /// </summary>
    /// <param name="meses"></param>
    private static void ImprimirConsole(List<string> meses)
    {
        Suporte.Imprimir(meses);
        Suporte.Finaliza();
    }

    private static void ColocarTudoMaiusculo(List<string> meses)
    {
        ImprimirMaiuscula(meses);
        Suporte.Finaliza();
    }

    private static void ColocarTudoMaiusculoArray(string[] mesesArray)
    {
        ImprimirMaiusculaArray(mesesArray);
        Suporte.Finaliza();
    }

    private static void ColocarTudoMaiusculoIEnumerable(IEnumerable<string> meses)
    {
        ImprimirMaiusculaIEnumerable(meses);
        Suporte.Finaliza();
    }

    #region SUPORTE

    /// <summary>
    /// No caso de um LIST, você NÃO pode alterar o item ou a coleção do laço "foreach".
    /// Mas é um pouco diferente para o Array.
    /// </summary>
    /// <param name="meses"></param>
    private static void ImprimirMaiuscula(List<string> meses)
    {
        foreach (string mes in meses)
        {
            // Erro: CS1656 - Não é possível atribuir a "m" porque
            // ele é um "variável de iteração foreach"
            // mes = mes.ToUpper();

            // ERRO: Collection was modified; enumeration operation may not execute.
            // meses[0] = meses[0].ToUpper();

            //Mas desta forma sem problemas:
            Console.WriteLine(mes.ToUpper());
        }
    }

    /// <summary>
    /// O laço foreach trablha de uma forma diferente para o Array.
    /// É como se fosse um laço "for".
    /// </summary>
    /// <param name="meses"></param>
    private static void ImprimirMaiusculaArray(string[] meses)
    {
        foreach (string mes in meses)
        {
            // Erro: CS1656 - Não é possível atribuir a "m" porque
            // ele é um "variável de iteração foreach"
            // mes = mes.ToUpper();

            // No caso de Array não dá erro...
            meses[0] = meses[0].ToUpper();

            //Mas desta forma sem problemas:
            Console.WriteLine(mes);
        }
    }

    private static void ImprimirMaiusculaIEnumerable(IEnumerable<string> meses)
    {
        foreach (string mes in meses)
        {
            // Erro: CS1656 - Não é possível atribuir a "m" porque
            // ele é um "variável de iteração foreach"
            //mes = mes.ToUpper();

            // Erro: CS0021 - Não é possível aplicar a indexação com[]
            // a uma expressão do tipo "IEnumerable<string>"
            // meses[0] = meses[0].ToUpper();

            //Mas desta forma sem problemas:
            Console.WriteLine(mes.ToUpper());
        }
    }

    #endregion
}
