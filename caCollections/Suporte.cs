namespace caCollections;

public static class Suporte
{
    ///// <summary>
    ///// Varrendo com "foreach Array"
    ///// </summary>
    public static void Imprimir(string[] arrayString)
    {
        foreach (string AS in arrayString)
            Console.WriteLine(AS);
    }

    /// <summary>
    /// Varrendo com o "for Array"
    /// </summary>
    /// <param name="aulas">Uma Array Aulas</param>
    public static void Imprimir2(string[] arrayString)
    {
        for (int i = 0; i < arrayString.Length; i++)
            Console.WriteLine(arrayString[i]);
    }

    /// <summary>
    /// Sobrecarga string[,]
    /// </summary>
    /// <param name="resultados">Array Resultados 2 Dimensões</param>
    public static void Imprimir(string[,] arrayString2D)
    {
        foreach (string AS2 in arrayString2D)
            Console.WriteLine(AS2);
    }

    /// <summary>
    /// Sobrecarga para imprimir Jagged Array
    /// </summary>
    /// <param name="familias"></param>
    public static void Imprimir(string[][] jaggedArrayString)
    {
        foreach (string[] JAS in jaggedArrayString)
            Console.WriteLine(string.Join(", ", JAS));
    }

    /// <summary>
    /// Varrendo com "foreach List"
    /// </summary>
    /// <param name="aulas">Uma Array Aulas</param>
    public static void Imprimir(List<string> listaString)
    {
        foreach (string LS in listaString)
            Console.WriteLine(LS);
    }

    /// <summary>
    /// Varrendo com o "for List"
    /// </summary>
    /// <param name="aulas">Uma Array Aulas</param>
    public static void Imprimir2(List<string> listaString)
    {
        for (int i = 0; i < listaString.Count; i++)
            Console.WriteLine(listaString[i]);
    }

    /// <summary>
    /// Varrendo com "foreach List"
    /// </summary>
    /// <param name="aulas">Uma Array Aulas</param>
    public static void Imprimir(List<Mes> listaMeses)
    {
        foreach (Mes LM in listaMeses)
            Console.WriteLine(LM);
    }

    /// <summary>
    /// Varrendo com "foreach"
    /// </summary>
    /// <param name="aulas">Uma Array Aulas</param>
    public static void Imprimir(IList<Aula> interfaceListaAulas)
    {
        foreach (Aula ILA in interfaceListaAulas)
            Console.WriteLine(ILA);
    }

    /// <summary>
    /// Sobrecarga para IList Aluno
    /// </summary>
    /// <param name="aulas"></param>
    public static void Imprimir(IList<Aluno> interfaceListaAluno)
    {
        foreach (Aluno ILA in interfaceListaAluno)
            Console.WriteLine(ILA);
    }

    /// <summary>
    /// Varrendo com "foreach"
    /// </summary>
    /// <param name="aulas">SET Aulas</param>
    public static void Imprimir(ISet<string> interfaceSetString)
    {
        foreach (string ISS in interfaceSetString)
            Console.WriteLine(ISS);
    }

    /// <summary>
    /// Sobrecarga para IDictionary int, Aluno
    /// </summary>
    /// <param name="aulas"></param>
    public static void Imprimir(IDictionary<int, Aluno> interfaceDicionarioAluno)
    {
        foreach (KeyValuePair<int, Aluno> IDA in interfaceDicionarioAluno)
            Console.WriteLine(IDA);
    }

    /// <summary>
    /// Sobrecarga para IDictionary string, Aluno
    /// </summary>
    /// <param name="aulas"></param>
    public static void Imprimir(IDictionary<string, Aluno> interfaceDicionarioAluno)
    {
        foreach (KeyValuePair<string, Aluno> IDA in interfaceDicionarioAluno)
            Console.WriteLine(IDA);
    }

    /// <summary>
    /// Sobrecarga para Queue<string>
    /// </summary>
    /// <param name="aulas"></param>
    public static void Imprimir(Queue<string> queueString)
    {
        foreach (var QS in queueString)
            Console.WriteLine(QS);
    }

    /// <summary>
    /// Sobrecarga para LinkedList string
    /// </summary>
    /// <param name="dias"></param>
    public static void Imprimir(LinkedList<string> linkedListString)
    {
        foreach (string LLS in linkedListString)
            Console.WriteLine(LLS);
    }

    /// <summary>
    /// Sobrecarga para SortedList string, Aluno
    /// </summary>
    /// <param name="aulas"></param>
    public static void Imprimir(SortedList<string, Aluno> sortedListAluno)
    {
        foreach (KeyValuePair<string, Aluno> SLA in sortedListAluno)
            Console.WriteLine(SLA);
    }

    /// <summary>
    /// Sobrecarga para SortedDictionary string, Aluno
    /// </summary>
    /// <param name="aulas"></param>
    public static void Imprimir(SortedDictionary<string, Aluno> sortedDictionaryAluno)
    {
        foreach (KeyValuePair<string, Aluno> SDA in sortedDictionaryAluno)
            Console.WriteLine(SDA);
    }

    /// <summary>
    /// Sobrecarga para IEnumerable<string>
    /// </summary>
    /// <param name="nomeMeses"></param>
    public static void Imprimir(IEnumerable<string> interfaceEnumerableString)
    {
        foreach (string IES in interfaceEnumerableString)
            Console.WriteLine(IES);
    }

    /// <summary>
    /// Sobrecarga para IEnumerable<Mes>
    /// </summary>
    /// <param name="nomeMeses"></param>
    public static void Imprimir(IEnumerable<Mes> interfaceEnumerableMeses)
    {
        foreach (Mes IEM in interfaceEnumerableMeses)
            Console.WriteLine(IEM);
    }

    /// <summary>
    /// Sobrecarga para IEnumerable de Objeto
    /// </summary>
    /// <param name="obj"></param>
    public static void Imprimir(IEnumerable<object> interfaceEnumerableObjeto)
    {
        foreach (string IEO in interfaceEnumerableObjeto.Cast<string>())
            Console.WriteLine(IEO);
    }

    /// <summary>
    /// Sobrecarga para Objeto
    /// </summary>
    /// <param name="obj"></param>
    public static void Imprimir(object obj)
    {
        Console.WriteLine(obj);
    }

    /// <summary>
    /// Sobrecarga para Array de Objetos
    /// </summary>
    /// <param name="obj"></param>
    public static void Imprimir(object[] arrayObj)
    {
        foreach (string AO in arrayObj.Cast<string>())
            Console.WriteLine(AO);
    }

    /// <summary>
    /// Parar a tela para ler.
    /// </summary>
    public static void EmpacaTela()
    {
        Console.WriteLine("Pressione qq tecla para continuar...");
        Console.ReadKey();
    }

    /// <summary>
    /// Somente para finalizar.
    /// </summary>
    public static void Finaliza()
    {
        Console.WriteLine();
        Console.WriteLine("Digite QQ Tecla.");
        Console.ReadKey();
    }
}
