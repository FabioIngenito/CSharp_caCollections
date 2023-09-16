namespace caCollections;

public class Sets
{
    public static void Inicio()
    {
        char? opcao = '0';

        // SETS = CONJUNTOS

        // Duas propriedades do Set
        // 1. não permite duplicidade
        // 2. os elementos não são mantidos em ordem específica

        // Um HashSet não permite duplicação, porém ele também não gera
        // exceção caso o elemento a ser adicionado já exista na coleção.

        // declarando o set de alunos

        ISet<string> alunos = new HashSet<string>
        {
            "Vanessa Tonini",
            "Ana Losnak",
            "Rafael Nercessian"
        };

        while (opcao != 'X' && opcao != 'x')
        {
            Console.Clear();
            Console.WriteLine("=================================================");
            Console.WriteLine("===            Sets (Conjuntos) C#            ===");
            Console.WriteLine("=== 1 - Declarando Set                        ===");
            Console.WriteLine("=== 2 - Adicionando                           ===");
            Console.WriteLine("=== 3 - Removendo e Adicionando               ===");
            Console.WriteLine("=== 4 - Sort (Ordenar)                        ===");
            Console.WriteLine("=== 5 - Set dentro do modelo                  ===");
            Console.WriteLine("=== 6 - Equals e HashCode                     ===");
            Console.WriteLine("=== 7 - HashSet e List                        ===");
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
                        DeclarandoSet(alunos);
                        break;
                    case '2':
                        Adicionado(alunos);
                        break;
                    case '3':
                        RemovendoAdicionado(alunos);
                        break;
                    case '4':
                        Ordenar(alunos);
                        break;
                    case '5':
                        Modelo();
                        break;
                    case '6':
                        Equals_HashCode();
                        break;
                    case '7':
                        HashSet_List();
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
    private static void DeclarandoSet(ISet<string> alunos)
    {
        Console.WriteLine(alunos);
        Console.WriteLine(string.Join(",", alunos));
        Console.WriteLine("-----------------------------------");
        Suporte.Imprimir(alunos);
        Suporte.Finaliza();
    }

    private static void Adicionado(ISet<string> alunos)
    {
        alunos.Add("Priscila Stuani");
        alunos.Add("Rafael Rollo");
        alunos.Add("Fabio Gushiken");

        Console.WriteLine(string.Join(", ", alunos));
        Console.WriteLine("-----------------------------------");
        Suporte.Imprimir(alunos);
        Suporte.Finaliza();
    }

    private static void RemovendoAdicionado(ISet<string> alunos)
    {
        alunos.Add("Priscila Stuani");
        alunos.Add("Rafael Rollo");
        alunos.Add("Fabio Gushiken");

        alunos.Remove("Ana Losnak");
        alunos.Add("Marcelo Oliveira");

        Console.WriteLine(string.Join(", ", alunos));
        Console.WriteLine("-----------------------------------");

        //adicionando Fabio de novo
        alunos.Add("Fabio Gushiken");

        Console.WriteLine(string.Join(", ", alunos));
        Console.WriteLine("-----------------------------------");

        Suporte.Imprimir(alunos);
        Suporte.Finaliza();
    }

    private static void Ordenar(ISet<string> alunos)
    {
        // TABELA DE ESPALHAMENTO
        // Desempenho HashSet x List: escabilidade X memória

        // Não tem ".Sort()"

        alunos.Add("Priscila Stuani");
        alunos.Add("Rafael Rollo");
        alunos.Add("Fabio Gushiken");
        alunos.Remove("Ana Losnak");
        alunos.Add("Marcelo Oliveira");

        List<string> alunosEmLista = new(alunos);
        alunosEmLista.Sort();

        Console.WriteLine(string.Join(", ", alunosEmLista));
        Console.WriteLine("-----------------------------------");

        Suporte.Imprimir(alunosEmLista);
        Suporte.Finaliza();
    }

    private static void Modelo()
    {
        Curso csharpcolecoes = new("C# Colecoes", "Marcelo Oliveira");

        csharpcolecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
        csharpcolecoes.Adiciona(new Aula("Criando uma Aula", 20));
        csharpcolecoes.Adiciona(new Aula("Modelando com Coleçoes", 24));

        Aluno a1 = new("Vanessa Tonini", 34672);
        Aluno a2 = new("Ana Losnak", 5617);
        Aluno a3 = new("Rafael Nercessian", 17645);

        csharpcolecoes.Matricula(a1);
        csharpcolecoes.Matricula(a2);
        csharpcolecoes.Matricula(a3);

        Console.WriteLine("Imprimindo os alunos matriculados");
        Suporte.Imprimir(csharpcolecoes.Alunos);
        Suporte.Finaliza();
    }

    private static void Equals_HashCode()
    {
        Curso csharpcolecoes = new("C# Colecoes", "Marcelo Oliveira");

        csharpcolecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
        csharpcolecoes.Adiciona(new Aula("Criando uma Aula", 20));
        csharpcolecoes.Adiciona(new Aula("Modelando com Coleçoes", 24));

        Aluno a1 = new("Vanessa Tonini", 34672);
        Aluno a2 = new("Ana Losnak", 5617);
        Aluno a3 = new("Rafael Nercessian", 17645);

        csharpcolecoes.Matricula(a1);
        csharpcolecoes.Matricula(a2);
        csharpcolecoes.Matricula(a3);

        Console.WriteLine($"O aluno a1 {a1.Nome} está matriculado?" + csharpcolecoes.EstaMatriculado(a1));

        Aluno tonini = new("Vanessa Tonini", 34672);
        Console.WriteLine("Tonini está matriculado? " + csharpcolecoes.EstaMatriculado(tonini));
        Console.WriteLine("------------------------");
        // Mas a1 == a Tonini?
        Console.WriteLine("a1 == a Tonini? " + (a1 == tonini));
        Console.WriteLine("------------------------");
        Console.WriteLine("a1 é equals a Tonini? " + (a1.Equals(tonini)));

        Suporte.Imprimir(csharpcolecoes.Alunos);
        Suporte.Finaliza();
    }

    private static void HashSet_List()
    {
        //HashSet<string> alunosHash = new();
        ISet<string> alunos = new HashSet<string>
        {
            "Priscila Stuani",
            "Rafael Rollo",
            "Fabio Gushiken"
        };

        Console.WriteLine(alunos);

        Console.WriteLine("------------------------");
        Console.WriteLine(string.Join(",", alunos));

        Console.WriteLine("------------------------");
        alunos.Add("Fabio Gushiken");

        Suporte.Imprimir(alunos);
        Suporte.Finaliza();
    }

}