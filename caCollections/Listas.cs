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
        // Suprimi propositalmente para mostrar o formato antigo:
#pragma warning disable IDE0028 // Simplificar a inicialização de coleção
        List<string> aulas2 = new();
#pragma warning restore IDE0028 // Simplificar a inicialização de coleção

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
        Suporte.Imprimir(aula1);
        Console.WriteLine();
        Console.WriteLine("---------- Populando e imprimindo Aula 2:");
        Suporte.Imprimir2(aula2);
        Console.WriteLine();
        Console.WriteLine("---------- Populando e imprimindo Aula 3:");
        Suporte.Imprimir(aulas3);
        Suporte.Finaliza();
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
        // Suprimi propositalmente esta mensagem para mostrar o formato:
#pragma warning disable IDE0056 // Usar operador de índice
        Console.WriteLine($"Último elemento: Aula1[{aula1.Count - 1}]: {aula1[^1]} - Aula2[{aula2.Count - 1}]: {aula2[aula2.Count - 1]}");
#pragma warning restore IDE0056 // Usar operador de índice
        Console.WriteLine($"Último elemento: Aula1.Last(): {aula1.Last()} - Aula2.Last(): {aula2.Last()}");
        Suporte.Finaliza();
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
        Suporte.Finaliza();
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
        Suporte.Finaliza();
    }

    /// <summary>
    /// Inverter Ordem
    /// </summary>
    /// <param name="aula">List aula</param>
    private static void InverterOrdem(List<string> aula)
    {
        Console.WriteLine("---------- Ordem original:");
        Suporte.Imprimir(aula);
        Console.WriteLine();
        Console.WriteLine("---------- Inverter a ordem:");
        aula.Reverse();
        Suporte.Imprimir2(aula);
        Suporte.Finaliza();
    }

    /// <summary>
    /// Redimensionando Array
    /// </summary>
    /// <param name="aula">List aula</param>
    private static void RedimensionandoArray(List<string> aula)
    {
        Console.WriteLine("---------- Array Original");
        Suporte.Imprimir2(aula);
        Console.WriteLine();
        Console.WriteLine("---------- Removendo o último elemento");
        aula.RemoveAt(aula.Count - 1);
        Suporte.Imprimir(aula);
        Console.WriteLine();
        Console.WriteLine("---------- Adicionando outra aula");
        aula.Add("Conclusão");
        Suporte.Imprimir(aula);
        Suporte.Finaliza();
    }

    /// <summary>
    /// Ordenando Lista
    /// </summary>
    /// <param name="aula">List aula</param>
    private static void OrdenandoLista(List<string> aula)
    {
        Console.WriteLine("---------- Ordenando ou 'Sort' uma coleção List. Não é idempotente como o Reverse().");
        aula.Sort();
        Suporte.Imprimir2(aula);
        Suporte.Finaliza();
    }

    /// <summary>
    /// Copiando Lista
    /// </summary>
    /// <param name="aula">List aula</param>
    private static void CopiandoLista(List<string> aula)
    {
        Console.WriteLine("---------- Copiando uma coleção List");
        List<string> copia = aula.GetRange(aula.Count - 2, 2);
        Suporte.Imprimir(copia);
        Console.WriteLine();
        Suporte.Finaliza();
    }

    /// <summary>
    /// Clonando Lista (emulando)
    /// </summary>
    /// <param name="aula">List aula</param>
    private static void ClonandoLista(List<string> aula)
    {
        Console.WriteLine("---------- Clonando (emulando) uma coleção List");
        List<string>? clone = new(aula);
        Suporte.Imprimir2(clone);
        Suporte.Finaliza();
    }

    /// <summary>
    /// Limpando Lista
    /// </summary>
    /// <param name="aula">List aula</param>
    private static void LimpandoLista(List<string> aula)
    {
        Console.WriteLine("---------- Relação de itens:");
        Suporte.Imprimir(aula);

        if (aula.Count >= 2)
        {
            Console.WriteLine("---------- Limpando as duas últimas posições.");
            aula.RemoveRange(aula.Count - 2, 2);
            Suporte.Imprimir(aula);
        }
        else
        {
            Console.WriteLine("---------- Menos de 2 itens:");
            Suporte.Imprimir(aula);
        }

        Suporte.Finaliza();
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
        Suporte.Imprimir(copiaArray);
        Console.WriteLine();
        Suporte.Finaliza();
    }
}