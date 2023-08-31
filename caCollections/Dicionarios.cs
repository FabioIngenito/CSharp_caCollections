namespace caCollections;

public class Dicionarios
{
    public static void Inicio()
    {
        char? opcao = '0';

        Curso csharpcolecoes = new("C# Colecoes", "Marcelo Oliveira");

        csharpcolecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
        csharpcolecoes.Adiciona(new Aula("Criando uma Aula", 20));
        csharpcolecoes.Adiciona(new Aula("Modelando com Coleçoes", 24));

        csharpcolecoes.Matricula(new("Vanessa Tonini", 34672));
        csharpcolecoes.Matricula(new("Ana Losnak", 5617));
        csharpcolecoes.Matricula(new("Rafael Nercessian", 17645));

        while (opcao != 'X' && opcao != 'x')
        {
            Console.Clear();
            Console.WriteLine("=================================================");
            Console.WriteLine("===         Dicionário Collection C#          ===");
            Console.WriteLine("=== 1 - Introdução a dicionário               ===");
            Console.WriteLine("=== 2 - Adicionar e pesquisar                 ===");
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
                        Introducao(csharpcolecoes);
                        break;
                    case '2':
                        AdicionarPesquisar(csharpcolecoes);
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

    private static void Introducao(Curso csharpcolecoes)
    {
        Console.WriteLine($"Quem é o aluno com a matrícula 5617?");

        Aluno aluno5617 = csharpcolecoes.BuscaMatriculado1(5617);

        Console.WriteLine($"Aluno5617: {aluno5617}");
        Console.WriteLine("---------------------------");
        Console.WriteLine();

        Console.WriteLine($"Quem é o aluno com a matrícula 5618?");

        Aluno? aluno5618 = csharpcolecoes.BuscaMatriculado(5618);

        Console.WriteLine($"Aluno5618: {aluno5618}");
        Console.WriteLine("---------------------------");
        Console.WriteLine();

        Imprimir(csharpcolecoes.Alunos);
        Finaliza();
    }

    /// <summary>
    /// O dicionário também faz uso do CÓDIGO DE DISPERSÃO.
    /// É pelo Hash Code da chave (key) do elemento que o dicionário sabe onde 
    /// posicionar o elemento na memória.
    /// </summary>
    /// <param name="csharpcolecoes"></param>
    private static void AdicionarPesquisar(Curso csharpcolecoes)
    {
        Console.WriteLine($"Adicionando a mesma matrícula 5617 para outro aluno.");

        Aluno? fabio = new("Fabio Gushiken", 5617);

        // ERRO: A chave já está associada a outro aluno. NÃO pode matricular desta forma:
        //csharpcolecoes.Matricula(fabio);

        //Console.WriteLine($"Aluno5617: {fabio}");
        //Console.WriteLine("---------------------------");
        //Console.WriteLine();

        // e se quisermos trocar o aluno que tem a mesma chave?
        csharpcolecoes.SubstituiAluno(fabio);

        Console.WriteLine($"Quem é o aluno 5617, agora?");
        Console.WriteLine(csharpcolecoes.BuscaMatriculado(5617));
        Console.WriteLine("---------------------------");

        Imprimir(csharpcolecoes.dicionarioAlunos);
        Finaliza();
    }

    #region SUPORTE
    /// <summary>
    /// Sobrecarga para IList Aluno
    /// </summary>
    /// <param name="aulas"></param>
    private static void Imprimir(IList<Aluno> aulas)
    {
        foreach (Aluno aula in aulas)
            Console.WriteLine(aula);
    }

    /// <summary>
    /// Sobrecarga para IDictionary int, Aluno
    /// </summary>
    /// <param name="aulas"></param>
    private static void Imprimir(IDictionary<int, Aluno> aulas)
    {
        foreach (KeyValuePair<int, Aluno> aula in aulas)
            Console.WriteLine(aula);
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
