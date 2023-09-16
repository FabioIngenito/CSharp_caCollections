namespace caCollections;

internal class ConsultandoCollectionsLINQ
{
    public static void Inicio()
    {
        char? opcao = '0';

        // PROBLEMA: obter os nomes dos meses do ano que
        // tem 31 dias, em maiúsculo e em ordem alfabética

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

        while (opcao != 'X' && opcao != 'x')
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("===         Consultando Collections C#     ===");
            Console.WriteLine("=== 1 - Consultando Collections            ===");
            Console.WriteLine("=== 2 - Somente 31 dias Ordenado           ===");
            Console.WriteLine("=== 3 - Somente 31 dias Ordenado Maiúsculo ===");
            Console.WriteLine("=== 4 - Consultas com LINQ                 ===");
            Console.WriteLine("=== X - Sair do Sistema                    ===");
            Console.WriteLine("==============================================");
            Console.WriteLine();
            Console.Write("Digite a opção desejada: ");

            try
            {
                opcao = Console.ReadLine()![0];

                Console.WriteLine();

                switch (opcao)
                {
                    case '1':
                        ConsultandoCollectionsMeses(meses);
                        break;
                    case '2':
                        Somente31DiasMaiusculo(meses);
                        break;
                    case '3':
                        Somente31DiasMaiusculoOrdenado(meses);
                        break;
                    case '4':
                        ConsultasLINQ(meses);
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

    private static void ConsultandoCollectionsMeses(List<Mes> meses)
    {
        Suporte.Imprimir(meses);
        Suporte.Finaliza();
    }

    private static void Somente31DiasMaiusculo(List<Mes> meses)
    {
        List<string> mesesAlterado = new();

        foreach (Mes mes in meses) 
            if (mes.Dias == 31)
                mesesAlterado.Add(mes.Nome.ToUpper());

        Suporte.Imprimir(mesesAlterado);
        Suporte.Finaliza();
    }

    private static void Somente31DiasMaiusculoOrdenado(List<Mes> meses)
    {
        List<string> mesesAlteradoOrdenado = new();

        meses.Sort();

        foreach (Mes mes in meses)
            if (mes.Dias == 31)
                mesesAlteradoOrdenado.Add(mes.Nome.ToUpper());

        Suporte.Imprimir(mesesAlteradoOrdenado);

        Suporte.Finaliza();
    }

    /// <summary>
    /// LINQ =  CONSULTA INTEGRADA A LINGUAGEM
    /// 
    /// NÃO precisa implementar o "IComparable" na classe "Mes"
    /// para usar o "OrderBy()".
    /// 
    /// Qualquer coleção que implementa a interface IEnumerable 
    /// pode ser fonte de dados de uma consulta LINQ.
    /// 
    /// O método Where é o operador LINQ para filtrar os dados.
    /// 
    /// O método OrderBy ordena os elementos de uma sequência. 
    /// Ele recebe uma coleção IEnumerable<T> e retorna uma 
    /// coleção IOrderedEnumerable<T> ordenada.
    /// 
    /// The .NET Programmer’s Playground
    /// The Ultimate Scratchpad for C#, F# and VB
    /// https://www.linqpad.net/
    /// </summary>
    /// <param name="meses">Lista de meses meses</param>
    private static void ConsultasLINQ(List<Mes> meses)
    {
        // Montagem da Consulta
        IEnumerable<string> 
            consulta = meses
                .Where(m => m.Dias == 31)
                .OrderBy(m => m.Nome)
                .Select(m => m.Nome.ToUpper());

        // Utilização da Consulta
        Suporte.Imprimir(consulta);
        Suporte.Finaliza();
    }
}