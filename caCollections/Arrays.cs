namespace caCollections;

public class Arrays
{
    public static void Inicio()
    {
        char? opcao = '0';

        string aulaIntro = "Introdução às Coleções";
        string aulaModelando = "Modelando a Classe Aula";
        string aulaSets = "Trabalhando com Conjuntos";

        // Um forma de declarar um Array:
        string[] aulas1 = new[]
        {
            aulaIntro,
            aulaModelando,
            aulaSets
        };

        // Outra forma de declarar um array:
        // Um array é uma coleção de tamanho FIXO.
        string[] aulas2 = new string[3];

        aulas2[0] = aulaIntro;
        aulas2[1] = aulaModelando;
        aulas2[2] = aulaSets;
        
        while (opcao != 'X' && opcao != 'x')
        {
            Console.Clear();
            Console.WriteLine("=================================================");
            Console.WriteLine("===            Array Collection C#            ===");
            Console.WriteLine("=== 1 - Populando e imprimindo Aula 1, 2 e 3  ===");
            Console.WriteLine("=== 2 - Primeiro e Último elemento            ===");
            Console.WriteLine("=== 3 - Modificando a array                   ===");
            Console.WriteLine("=== 4 - Operações - Procurar o texto passado  ===");
            Console.WriteLine("=== 5 - Trocar a Ordem                        ===");
            Console.WriteLine("=== 6 - Redimensionando a Array               ===");
            Console.WriteLine("=== 7 - Ordenando a Array                     ===");
            Console.WriteLine("=== 8 - Copiando a Array                      ===");
            Console.WriteLine("=== 9 - Clonando a Array                      ===");
            Console.WriteLine("=== A - Limpando a Array                      ===");
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
                        PopulandoImprimindo(aulas1, aulas2);
                        break;
                    case '2':
                        PrimeiroUltimo(aulas1, aulas2);
                        break;
                    case '3':
                        ModificandoArray(aulas1);
                        break;
                    case '4':
                        ProcurarTexto(aulas2, aulaModelando);
                        break;
                    case '5':
                        InverterOrdem(aulas1);
                        break;
                    case '6':
                        RedimensionandoArray(aulas2);
                        break;
                    case '7':
                        OrdenandoArray(aulas1);
                        break;
                    case '8':
                        CopiandoArray(aulas1);
                        break;
                    case '9':
                        ClonandoArray(aulas1);
                        break;
                    case 'A':
                    case 'a':
                        LimpandoArray(aulas1);
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
    /// Populando e Imprimindo
    /// </summary>
    /// <param name="aula1">Array Aula</param>
    /// <param name="aula2">Array Aula</param>
    private static void PopulandoImprimindo(string[] aula1, string[] aula2)
    {
        string aulaC_Sharp = "Aula C#";
        string aulaJavascript = "Aula Javascript";
        string aulaPython = "Aula Python";

        string[] aulas3 = new[]
        {
            aulaC_Sharp,
            aulaJavascript,
            aulaPython
        };

        Console.WriteLine("---------- Populando e imprimindo Aula 1:");
        Imprimir1(aula1);
        Console.WriteLine();
        Console.WriteLine("---------- Populando e imprimindo Aula 2:");
        Imprimir2(aula2);
        Console.WriteLine();
        Console.WriteLine("---------- Populando e imprimindo Aula 3:");
        Imprimir1(aulas3);
        Finaliza();
    }

    /// <summary>
    /// Resgatando o primeiro e o último valor
    /// </summary>
    /// <param name="aula1">Array aula</param>
    /// <param name="aula2">Array aula</param>
    private static void PrimeiroUltimo(string[] aula1, string[] aula2)
    {
        Console.WriteLine("---------- Primeiro elemento das duas coleções Array criadas:");
        Console.WriteLine($"Primeiro elemento: Aula1[0]: {aula1[0]} - Aula2[0]: {aula2[0]}");
        Console.WriteLine();
        Console.WriteLine("---------- Último elemento das duas coleções Array criadas:");
        Console.WriteLine($"Último elemento: Aula1[{aula1.Length - 1}]: {aula1[^1]} - Aula2[{aula2.Length - 1}]: {aula2[aula2.Length - 1]}");
        Finaliza();
    }

    /// <summary>
    /// Modificando a array
    /// </summary>
    /// <param name="aula1">aula</param>
    private static void ModificandoArray(string[] aula1)
    {
        Console.WriteLine("---------- Modificando a array 1:");
        string aulaIntro = "Trabalhando com arrays";
        Console.WriteLine($"Primeiro elemento: Aula1[0]: {aula1[0]}");
        aula1[0] = aulaIntro;
        Console.WriteLine($"Primeiro elemento: Aula1[0]: {aula1[0]}");
        Finaliza();
    }

    /// <summary>
    /// Procurar o texto passado
    /// </summary>
    /// <param name="aula">Array aula</param>
    /// <param name="textoPassado">Texto para Procurar</param>
    private static void ProcurarTexto(string[] aula, string textoPassado)
    {
        Console.WriteLine("---------- Operações - Procurar o texto passado.");
        Console.WriteLine($"A aula 'modelando' está no índice: {Array.IndexOf(aula, textoPassado)} ");
        Console.WriteLine($"A aula 'modelando' está no índice: {Array.LastIndexOf(aula, textoPassado)} ");
        Finaliza();
    }

    /// <summary>
    /// Inverter Ordem
    /// </summary>
    /// <param name="aula">Array aula</param>
    private static void InverterOrdem(string[] aula)
    {
        Console.WriteLine("---------- Ordem original:");
        Imprimir1(aula);
        Console.WriteLine();
        Console.WriteLine("---------- Inverter a ordem:");
        Array.Reverse(aula);
        Imprimir2(aula);
        Finaliza();
    }

    /// <summary>
    /// Redimensionando Array
    /// </summary>
    /// <param name="aula">Array aula</param>
    private static void RedimensionandoArray(string[] aula)
    {
        Console.WriteLine("---------- Array Original");
        Imprimir2(aula);
        Console.WriteLine();
        Console.WriteLine("---------- Redimensionando a Array Diminuindo");
        Array.Resize(ref aula, 2);
        Imprimir1(aula);
        Console.WriteLine();
        Console.WriteLine("---------- Redimensionando a Array Aumentando");
        Array.Resize(ref aula, 3);
        Imprimir1(aula);
        Console.WriteLine("---------- Atribuindo uma string no lugar do valor NULL");
        aula[aula.Length - 1] = "Conclusão";
        Imprimir1(aula);
        Finaliza();
    }

    /// <summary>
    /// Ordenando array
    /// </summary>
    /// <param name="aula">Array aula</param>
    private static void OrdenandoArray(string[] aula)
    {
        Console.WriteLine("---------- Ordenando ou 'Sort' uma coleção Array. Não é idempotente como o Reverse().");
        Array.Sort(aula);
        Imprimir2(aula);
        Finaliza();
    }

    /// <summary>
    /// Copiando Array
    /// </summary>
    /// <param name="aula">Array aula</param>
    private static void CopiandoArray(string[] aula)
    {
        Console.WriteLine("---------- Copiando uma coleção Array");
        string[] copia = new string[2];
        Array.Copy(aula, 1, copia, 0, 2);
        Imprimir2(copia);
        Console.WriteLine();
        Finaliza();
    }

    /// <summary>
    /// Clonando Array
    /// </summary>
    /// <param name="aula">Array aula</param>
    private static void ClonandoArray(string[] aula)
    {
        Console.WriteLine("---------- Clonando uma coleção Array");
        string[]? clone = aula.Clone() as string[];
        Imprimir2(clone);
        Finaliza();
    }

    /// <summary>
    /// Limpando Array
    /// </summary>
    /// <param name="aula">Array aula</param>
    private static void LimpandoArray(string[] aula) {

        Console.WriteLine("---------- Limpando uma coleção Array");
        Array.Clear(aula, 1, 2);
        Imprimir1(aula);
        Finaliza();
    }

    #region SUPORTE
    /// <summary>
    /// Varrendo com "foreach"
    /// </summary>
    /// <param name="aulas">Uma Array Aulas</param>
    private static void Imprimir1(string[] aulas)
    {
        foreach (var aula in aulas)
            Console.WriteLine(aula);
    }

    /// <summary>
    /// Varrendo com o "for"
    /// </summary>
    /// <param name="aulas">Uma Array Aulas</param>
    private static void Imprimir2(string[] aulas)
    {
        for (int i = 0; i < aulas.Length; i++)
            Console.WriteLine(aulas[i]);
    }

    /// <summary>
    /// Somente para finalizar.
    /// </summary>
    private static void Finaliza()
    {
        Console.WriteLine();
        Console.WriteLine("Digite QQ Tecla.");
        Console.ReadKey();
    }
    #endregion
}
