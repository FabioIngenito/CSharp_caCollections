namespace caCollections;

internal class ConsultandSequenciasElementosLINQ
{
    static int PrimeiroT;

    public static void Inicio()
    {
        char? opcao = '0';

        // PROBLEMA: pegar o primeiro trimestre

        List<Mes> meses = new()
        {
            new Mes("Janeiro     ", 31),
            new Mes("Fevereiro   ", 28),
            new Mes("Março       ", 31),
            new Mes("Abril       ", 30),
            new Mes("Maio        ", 31),
            new Mes("Junho       ", 30),
            new Mes("Julho       ", 31),
            new Mes("Agosto      ", 31),
            new Mes("Setembro    ", 30),
            new Mes("Outubro     ", 31),
            new Mes("Novembro    ", 30),
            new Mes("Dezembro    ", 31)
        };

        PrimeiroT = meses.Count / 4;

        while (opcao != 'X' && opcao != 'x')
        {
            Console.Clear();
            Console.WriteLine("=================================================");
            Console.WriteLine("===      Sequências de Elementos LINQ C#      ===");
            Console.WriteLine("=== 1 - Consultando Sequências - 1º Trimestre ===");
            Console.WriteLine("=== 2 - Consultando Após 1º Trimestre         ===");
            Console.WriteLine("=== 3 - Consultando 3º Trimestre              ===");
            Console.WriteLine("=== 4 - Até mês que começa com 'S'            ===");
            Console.WriteLine("=== 5 - Pular mês até começar com 'S'         ===");
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
                        ConsultandoSequencias(meses);
                        break;
                    case '2':
                        ConsultandoApos1Trimestre(meses);
                        break;
                    case '3':
                        Consultando3Trimestre(meses);
                        break;
                    case '4':
                        AteMesComeca_S(meses);
                        break;
                    case '5':
                        PularMesComeca_S(meses);
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
    /// O "Take()" pega a quantidade de elementos indicados.
    /// </summary>
    /// <param name="meses"></param>
    private static void ConsultandoSequencias(List<Mes> meses)
    {
        IEnumerable<Mes> consulta = meses.Take(PrimeiroT);

        Suporte.Imprimir(consulta);
        Suporte.Finaliza();
    }

    /// <summary>
    /// O "Skip()" pula o numero de elementos indicados.
    /// </summary>
    /// <param name="meses"></param>
    private static void ConsultandoApos1Trimestre(List<Mes> meses)
    {
        IEnumerable<Mes> consulta = meses.Skip(PrimeiroT);

        Suporte.Imprimir(consulta);
        Suporte.Finaliza();
    }

    private static void Consultando3Trimestre(List<Mes> meses)
    {
        IEnumerable<Mes> consulta = meses.Skip((PrimeiroT) * 2).Take(3);

        Suporte.Imprimir(consulta);
        Suporte.Finaliza();
    }

    /// <summary>
    /// O método ".Take()" NÃO recebe parâmentros, então use o método ".TakeWhile("
    /// O método ".TakeWhile(" vai vai processar até encontrar o char 'S'.
    /// </summary>
    /// <param name="meses"></param>
    private static void AteMesComeca_S(List<Mes> meses)
    {
        // ".TakeWhile(" recebe um "PREDICATE" (Pode ser uma expressão Lambda)
        IEnumerable<Mes> consulta = meses.TakeWhile(m => !m.Nome.StartsWith('S'));

        Suporte.Imprimir(consulta);
        Suporte.Finaliza();
    }

    /// <summary>
    /// O método ".Skip()" NÃO recebe parâmentros, então use o método ".SkipWhile("
    /// O método ".SkipWhile(" vai os valores iniciais que começam com o char 'S'.
    /// </summary>
    /// <param name="meses"></param>
    private static void PularMesComeca_S(List<Mes> meses)
    {
        // ".SkipWhile(" recebe um "PREDICATE" (Pode ser uma expressão Lambda)
        IEnumerable<Mes> consulta = meses.SkipWhile(m => !m.Nome.StartsWith('S'));

        Suporte.Imprimir(consulta);
        Suporte.Finaliza();
    }
}
