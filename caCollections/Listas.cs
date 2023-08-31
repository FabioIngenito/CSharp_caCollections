using System.Linq;

namespace caCollections;

/// <summary>
/// Lista, a coleção flexível.
/// </summary>
public class Listas
{
    public static void Inicio()
    {
        char? opcao = '0';

        string aulaIntro = "Introdução às Coleções";
        string aulaModelando = "Modelando a Classe Aula";
        string aulaSets = "Trabalhando com Conjuntos";

        // Um forma de declarar uma Lista:
        List<string> aulas1 = new()
        {
            aulaIntro,
            aulaModelando,
            aulaSets
        };

        // Outra forma de declarar um array:
        // Um array é uma coleção de tamanho FIXO.
        List<string> aulas2 = new();

        //É recomendada a primeira forma.
        aulas2.Add(aulaIntro);
        aulas2.Add(aulaModelando);
        aulas2.Add(aulaSets);

        while (opcao != 'X' && opcao != 'x')
        {
            Console.Clear();
            Console.WriteLine("=================================================");
            Console.WriteLine("===           Listas Collection C#            ===");
            Console.WriteLine("=== 1 - Populando e imprimindo Aula 1, 2 e 3  ===");
            Console.WriteLine("=== 2 - Primeiro e Último elemento            ===");
            Console.WriteLine("=== 3 - Modificando a lista                   ===");
            Console.WriteLine("=== 4 - Operações - Procurar o texto passado  ===");
            Console.WriteLine("=== 5 - Trocar a Ordem                        ===");
            Console.WriteLine("=== 6 - Redimensionando a lista               ===");
            Console.WriteLine("=== 7 - Ordenando a lista                     ===");
            Console.WriteLine("=== 8 - Copiando a lista                      ===");
            Console.WriteLine("=== 9 - Clonando a lista                      ===");
            Console.WriteLine("=== A - Limpando a lista                      ===");
            Console.WriteLine("=== B - Copiando a lista para ARRAY           ===");
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
                        ModificandoLista(aulas1);
                        break;
                    case '4':
                        ProcurarTexto(aulas2);
                        break;
                    case '5':
                        InverterOrdem(aulas1);
                        break;
                    case '6':
                        RedimensionandoArray(aulas2);
                        break;
                    case '7':
                        OrdenandoLista(aulas1);
                        break;
                    case '8':
                        CopiandoLista(aulas1);
                        break;
                    case '9':
                        ClonandoLista(aulas1);
                        break;
                    case 'A':
                    case 'a':
                        LimpandoLista(aulas1);
                        break;
                    case 'B':
                    case 'b':
                        CopiandoListaParaArray(aulas1);
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
    /// <param name="aula1">List Aula</param>
    /// <param name="aula2">List Aula</param>
    private static void PopulandoImprimindo(List<string> aula1, List<string> aula2)
    {
        string aulaC_Sharp = "Aula C#";
        string aulaJavascript = "Aula Javascript";
        string aulaPython = "Aula Python";

        List<string> aulas3 = new()
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
        Imprimir3(aulas3);
        Finaliza();
    }

    /// <summary>
    /// Resgatando o primeiro e o último valor
    /// </summary>
    /// <param name="aula1">List aula</param>
    /// <param name="aula2">List aula</param>
    private static void PrimeiroUltimo(List<string> aula1, List<string> aula2)
    {
        Console.WriteLine("---------- Primeiro elemento das duas coleções Listas criadas:");
        Console.WriteLine($"Primeiro elemento: Aula1[0]: {aula1[0]} - Aula2[0]: {aula2[0]}");
        Console.WriteLine($"Primeiro elemento: Aula1.First(): {aula1.First()} - Aula2.First(): {aula2.First()}");
        Console.WriteLine();
        Console.WriteLine("---------- Último elemento das duas coleções Listas criadas:");
        Console.WriteLine($"Último elemento: Aula1[{aula1.Count - 1}]: {aula1[^1]} - Aula2[{aula2.Count - 1}]: {aula2[aula2.Count - 1]}");
        Console.WriteLine($"Último elemento: Aula1.Last(): {aula1.Last()} - Aula2.Last(): {aula2.Last()}");
        Finaliza();
    }

    /// <summary>
    /// Modificando a lista
    /// </summary>
    /// <param name="aula1">aula</param>
    private static void ModificandoLista(List<string> aula1)
    {
        Console.WriteLine("---------- Modificando a lista 1:");
        string aulaIntro = "Trabalhando com listas";
        Console.WriteLine($"Primeiro elemento: Aula1[0]: {aula1[0]}");

        aula1[0] = aulaIntro;
        //ERRO:
        //aula1.First() = aulaIntro;

        Console.WriteLine($"Primeiro elemento: Aula1.First(): {aula1.First()}");
        Finaliza();
    }

    /// <summary>
    /// Procurar o texto passado
    /// </summary>
    /// <param name="aula">List aula</param>
    /// <param name="textoPassado">Texto para Procurar</param>
    private static void ProcurarTexto(List<string> aula)
    {
        aula[0] = "Trabalhando com listas";
        Console.WriteLine("---------- Operações - Procurar o texto passado.");
        Console.WriteLine($"A aula 'Trabalhando' está no índice: {aula.First(aula => aula.Contains("Trabalhando"))}");
        Console.WriteLine($"A aula 'Trabalhando' está no índice: {aula.Last(aula => aula.Contains("Trabalhando"))}");
        //ERRO:
        //Console.WriteLine($"A aula 'Conclusão' está no índice: {aula.First(aula => aula.Contains("Conclusão"))}");
        Console.WriteLine($"A aula 'Conclusão' está no índice: {aula.FirstOrDefault(aula => aula.Contains("Conclusão"))}");
        Finaliza();
    }

    /// <summary>
    /// Inverter Ordem
    /// </summary>
    /// <param name="aula">List aula</param>
    private static void InverterOrdem(List<string> aula)
    {
        Console.WriteLine("---------- Ordem original:");
        Imprimir3(aula);
        Console.WriteLine();
        Console.WriteLine("---------- Inverter a ordem:");
        aula.Reverse();
        Imprimir2(aula);
        Finaliza();
    }

    /// <summary>
    /// Redimensionando Array
    /// </summary>
    /// <param name="aula">List aula</param>
    private static void RedimensionandoArray(List<string> aula)
    {
        Console.WriteLine("---------- Array Original");
        Imprimir2(aula);
        Console.WriteLine();
        Console.WriteLine("---------- Removendo o último elemento");
        aula.RemoveAt(aula.Count - 1);
        Imprimir1(aula);
        Console.WriteLine();
        Console.WriteLine("---------- Adicionando outra aula");
        aula.Add("Conclusão");
        Imprimir1(aula);
        Finaliza();
    }

    /// <summary>
    /// Ordenando Lista
    /// </summary>
    /// <param name="aula">List aula</param>
    private static void OrdenandoLista(List<string> aula)
    {
        Console.WriteLine("---------- Ordenando ou 'Sort' uma coleção List. Não é idempotente como o Reverse().");
        aula.Sort();
        Imprimir2(aula);
        Finaliza();
    }

    /// <summary>
    /// Copiando Lista
    /// </summary>
    /// <param name="aula">List aula</param>
    private static void CopiandoLista(List<string> aula)
    {
        Console.WriteLine("---------- Copiando uma coleção List");
        List<string> copia = aula.GetRange(aula.Count -2, 2);
        Imprimir1(copia);
        Console.WriteLine();
        Finaliza(); 
    }

    /// <summary>
    /// Clonando Lista (emulando)
    /// </summary>
    /// <param name="aula">List aula</param>
    private static void ClonandoLista(List<string> aula)
    {
        Console.WriteLine("---------- Clonando (emulando) uma coleção List");
        List<string>? clone = new(aula);
        Imprimir2(clone);
        Finaliza();
    }

    /// <summary>
    /// Limpando Lista
    /// </summary>
    /// <param name="aula">List aula</param>
    private static void LimpandoLista(List<string> aula)
    {
        Console.WriteLine("---------- Limpando uma coleção List");
        aula.RemoveRange(aula.Count-2, 2);  
        Imprimir1(aula);
        Finaliza();
    }

    /// <summary>
    /// Copiando de uma Lista direto para uma ARRAY
    /// </summary>
    /// <param name="aula">List aula</param>
    private static void CopiandoListaParaArray(List<string> aula)
    {
        Console.WriteLine("---------- Copiando uma coleção List para uma Array");
        string[] copiaArray = new string[aula.Count];
        aula.CopyTo(copiaArray, 0);
        Imprimir1(copiaArray);
        Console.WriteLine();
        Finaliza();
    }

    #region SUPORTE
    /// <summary>
    /// Varrendo com "foreach"
    /// </summary>
    /// <param name="aulas">Uma Array Aulas</param>
    private static void Imprimir1(List<string> aulas)
    {
        foreach (string aula in aulas)
            Console.WriteLine(aula);
    }

    /// <summary>
    /// Varrendo com o "for"
    /// </summary>
    /// <param name="aulas">Uma Array Aulas</param>
    private static void Imprimir2(List<string> aulas)
    {
        for (int i = 0; i < aulas.Count; i++)
            Console.WriteLine(aulas[i]);
    }

    /// <summary>
    /// Varrendo com o "foreach" de dentro da coleção lista (Action) método anônimo;
    /// </summary>
    /// <param name="aulas">Uma Array Aulas</param>
    private static void Imprimir3(List<string> aulas)
    {
        //aulas.ForEach(aula =>
        //{
        //    Console.WriteLine(aula);
        //});

        aulas.ForEach(Console.WriteLine);
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

    /// <summary>
    /// Imprimindo ARRAY com foreach - Sobrecarga de método
    /// </summary>
    /// <param name="aulas">Array aulas</param>
    private static void Imprimir1(string[] aulas)
    {
        foreach (var aula in aulas)
            Console.WriteLine(aula);
    }
    #endregion
}