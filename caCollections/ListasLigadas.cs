namespace caCollections
{
    public class ListasLigadas
    {
        /// <summary>
        /// Cada elemento de um LinkedList é um nó, ou seja, um objeto LinkedListNode, 
        /// que mantém duas referências, apontando para o nó anterior e outra apontando 
        /// para o próximo nó, e essa lista pode ser navegada pela ordem definida pela 
        /// associação entre esses nós.
        /// </summary>
        public static void Inicio()
        {
            char? opcao = '0';

            LinkedList<string> dias = new();

            while (opcao != 'X' && opcao != 'x')
            {
                Console.Clear();
                Console.WriteLine("=================================================");
                Console.WriteLine("===       Listas Ligadas Collection C#        ===");
                Console.WriteLine("=== 1 - Adicionar Lista Ligada                ===");
                Console.WriteLine("=== 2 - Pesquisar Lista Ligada                ===");
                Console.WriteLine("=== 3 - Remover Lista Ligada                  ===");
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
                            Adicionar(dias);
                            break;
                        case '2':
                            Pesquisar(dias);
                            break;
                        case '3':
                            Remover(dias);
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
        /// Apresentando LISTA LIGADA (LINKED LIST)
        /// - Elementos NÃO precisam estar e, sequencia na memória;
        /// - Cada elemento sabe quem é o anteriro e o próximo;
        /// - Cada elemento é um "nó" que contém um valor;
        /// 
        /// Podemos adicionar de 4 formas:
        /// - 1. Como primeiro nó - AddFirst(T value) serve para adicionar um elemento como 
        /// primeiro nó do LinkedList.;
        /// - 2. Como último nó - O método AddLast(T value) serve para adicionar um elemento 
        /// como último nó do LinkedList.;
        /// - 3. Antes de um nó conhecido - O método AddBefore(LinkedListNode<T> node, T value) 
        /// serve para adicionar um elemento antes do nó especificado.;
        /// - 4. Depois de nó conhecido - O método AddAfter(LinkedListNode<T> node, T value) 
        /// serve para adicionar um elemento depois do nó especificado.;
        /// </summary>
        /// <param name="dias"></param>
        private static void Adicionar(LinkedList<string> dias)
        {
            LinkedListNode<string> d4 = dias.AddFirst("quarta");

            Console.WriteLine($"d4.Value: {d4.Value}");
            Console.WriteLine("---------------------------");

            LinkedListNode<string> d2 = dias.AddBefore(d4, "segunda");
            Console.WriteLine($"d2.Value: {d2.Value}");
            Console.WriteLine("---------------------------");

            LinkedListNode<string> d3 = dias.AddAfter(d2, "terça");
            Console.WriteLine($"d3.Value: {d3.Value}");
            Console.WriteLine("---------------------------");

            LinkedListNode<string> d6 = dias.AddAfter(d4, "sexta");
            Console.WriteLine($"d6.Value: {d6.Value}");
            Console.WriteLine("---------------------------");

            LinkedListNode<string> d7 = dias.AddAfter(d6, "sábado");
            Console.WriteLine($"d7.Value: {d7.Value}");
            Console.WriteLine("---------------------------");

            LinkedListNode<string> d5 = dias.AddBefore(d6, "quinta");
            Console.WriteLine($"d5.Value: {d5.Value}");
            Console.WriteLine("---------------------------");

            LinkedListNode<string> d1 = dias.AddBefore(d2, "domingo");
            Console.WriteLine($"d1.Value: {d1.Value}");
            Console.WriteLine("---------------------------");

            // LinkedList NÃO dá suporte ao acesso de índice: 
            // dias[0]
            // por isso poodemos fazer o laço "foreach" mas NÃO o laço "for".
            var quarta = dias.Find("quarta");
            Console.WriteLine(quarta);

            Console.WriteLine();

            Suporte.Imprimir(dias);
            Suporte.Finaliza();
            dias.Clear();
        }

        private static void Pesquisar(LinkedList<string> dias)
        {
            LinkedListNode<string> d4 = dias.AddFirst("quarta");
            LinkedListNode<string> d2 = dias.AddBefore(d4, "segunda");
            _ = dias.AddAfter(d2, "terça");
            LinkedListNode<string> d6 = dias.AddAfter(d4, "sexta");
            _ = dias.AddAfter(d6, "sábado");
            _ = dias.AddBefore(d6, "quinta");
            _ = dias.AddBefore(d2, "domingo");
            Console.WriteLine("---------------------------");

            // LinkedList NÃO dá suporte ao acesso de índice: 
            // dias[0]
            // por isso poodemos fazer o laço "foreach" mas NÃO o laço "for".
            LinkedListNode<string>? quarta = dias.Find("quarta");
            Console.WriteLine($"Quarta-feira: {quarta?.Value}");
            Console.WriteLine("---------------------------");

            Suporte.Imprimir(dias);
            Suporte.Finaliza();
            dias.Clear();
        }

        private static void Remover(LinkedList<string> dias)
        {
            LinkedListNode<string> d4 = dias.AddFirst("quarta");
            LinkedListNode<string> d2 = dias.AddBefore(d4, "segunda");
            _ = dias.AddAfter(d2, "terça");
            LinkedListNode<string> d6 = dias.AddAfter(d4, "sexta");
            _ = dias.AddAfter(d6, "sábado");
            _ = dias.AddBefore(d6, "quinta");
            LinkedListNode<string> d7 = dias.AddBefore(d2, "domingo");
            Console.WriteLine("---------------------------");

            dias.Remove("quarta");
            dias.Remove(d7);
            Console.WriteLine();

            Suporte.Imprimir(dias);
            Suporte.Finaliza();
            dias.Clear();
        }
    }
}
