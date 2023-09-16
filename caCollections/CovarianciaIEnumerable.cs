using Microsoft.VisualBasic;

namespace caCollections;

/// <summary>
/// Covariância e contravariância (C#)
/// Artigo - 15/02/2023
/// 
/// No C#, a covariância e a contravariância habilitam a conversão de referência implícita 
/// para tipos de matriz, tipos de delegados e argumentos de tipo genérico. A covariância 
/// preserva a compatibilidade de atribuição, e a contravariância reverte.
/// 
/// https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/concepts/covariance-contravariance/
/// </summary>
internal class CovarianciaIEnumerable
{
    public static void Inicio()
    {
        char? opcao = '0';

        string titulo = "meses";
        object obj = titulo;

        IList<string> listaMeses = new List<string>()
        {
            "Janeiro", "Fevereiro", "Março",
            "Abril", "Maio", "Junho",
            "Julho", "Agosto", "Setembro",
            "Outubro", "Novembro", "Dezembro"
        };
        // Não é possível fazer essa conversão IList
        //IList<object> listaObj = (IList<object>)listaMeses;

        string[] arrayMeses = new string[]
        {
            "Janeiro", "Fevereiro", "Março",
            "Abril", "Maio", "Junho",
            "Julho", "Agosto", "Setembro",
            "Outubro", "Novembro", "Dezembro"
        };

        object[] arrayObj = arrayMeses;

        IEnumerable<object> enumObj = listaMeses;

        while (opcao != 'X' && opcao != 'x')
        {
            Console.Clear();
            Console.WriteLine("======================================================");
            Console.WriteLine("===         CovarianciaI Enumerable C#             ===");
            Console.WriteLine("=== 1 - Conversão String para Object               ===");
            Console.WriteLine("=== 2 - Conversão Array String para Array Object   ===");
            Console.WriteLine("=== 3 - Alteração na Array de Object               ===");
            Console.WriteLine("=== 4 - Conversao List<string> IEnumerable<object> ===");
            Console.WriteLine("=== X - Sair do Sistema                            ===");
            Console.WriteLine("======================================================");
            Console.WriteLine();
            Console.Write("Digite a opção desejada: ");

            try
            {
                opcao = Console.ReadLine()![0];

                Console.WriteLine();

                switch (opcao)
                {
                    case '1':
                        ConversaoStringObject(obj);
                        break;
                    case '2':
                        ConversaoArrayStringObject(arrayObj);
                        break;
                    case '3':
                        AlteracaoArrayObject();
                        break;
                    case '4':
                        ConversaoListIEnumerable(enumObj);
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
    /// Todas as classes herdam de object, por isso é possível 
    /// fazer a conversão implícita.
    /// </summary>
    /// <param name="obj"></param>
    private static void ConversaoStringObject(object obj)
    {
        Console.WriteLine("string para object");
        Console.Write("Conteúdo do objeto: ");

        Suporte.Imprimir(obj);
        Suporte.Finaliza();
    }

    /// <summary>
    /// O nome disso é "covariância".
    /// Aqui foi realizada uma conversão implícita.
    /// 
    /// A classe Array herda de object (como todas as classes).
    /// A classe "string[]" e a classe "object[]" herdam 
    /// de Array, mas "string[]" e "object[]" estão no 
    /// mesmo nível! 
    /// </summary>
    /// <param name=""></param>
    private static void ConversaoArrayStringObject(object[] obj)
    {
        Console.WriteLine("string[] para object[]");

        Suporte.Imprimir(obj);
        Suporte.Finaliza();
    }

    /// <summary>
    /// A "COVARIÂNCIA DO ARRAY" deve ser evitada sempre!
    /// É uma funcionalidade quebrada no .Net Framework, 
    /// jamais faça isso.
    /// 
    /// Nunca use. NÃO É ACONSELHÁVEL, por causa de erros de 
    /// execução que podem ocorrer devido a essa conversão.
    /// 
    /// O programa vai compilar, porque o array no .NET 
    /// Framework é covariante (permite conversão de string[] 
    /// para object[]) mas o array objArray só poderá armazenar 
    /// strings, apesar de ser um array de object. O programa 
    /// irá gerar uma exceção caso você tente armazenar números 
    /// ou datas ou outros objetos nesse array de object.
    /// </summary>
    private static void AlteracaoArrayObject()
    {
        string[] arrayMeses = new string[]
        {
            "Janeiro", "Fevereiro", "Março",
            "Abril", "Maio", "Junho",
            "Julho", "Agosto", "Setembro",
            "Outubro", "Novembro", "Dezembro"
        };
        object[] arrayObj = arrayMeses;

        Console.WriteLine("Alteração na object[]");

        arrayObj[0] = "Primeiro Mês";

        //ERRO? NÃO PODE ARMAZENAR NADA QUE NÃO FOR UMA STRING:
        //arrayObj[0] = 12345;

        Suporte.Imprimir(arrayObj);
        Suporte.Finaliza();
    }

    /// <summary>
    /// COVARIÂNCIA
    /// O IEnumerable é covariante.
    /// 
    /// É possível converter implicitamente uma coleção List<string> 
    /// para um IEnumerable<object>. A interface IEnumerable<object> 
    /// permite covariância.
    /// </summary>
    /// <param name="obj"></param>
    private static void ConversaoListIEnumerable(IEnumerable<object> enumObj)
    {
        Console.WriteLine("Conversao List<string> para IEnumerable<object>");

        // Erro: NÃo pode moficar para um tipo que NÃO seja string.
        ///enumObj[0] = 12345;

        Suporte.Imprimir(enumObj);
        Suporte.Finaliza();
    }
}
