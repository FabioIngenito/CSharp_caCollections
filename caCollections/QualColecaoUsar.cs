using System.Text.Json;

namespace caCollections
{
    internal class QualColecaoUsar
    {
        private static readonly Queue<Aluno> filaBancoConsultorio = new();

        public static void Inicio()
        {
            char? opcao = '0';

            while (opcao != 'X' && opcao != 'x')
            {
                Console.Clear();
                Console.WriteLine("=================================================================");
                Console.WriteLine("===             Qual Collection usar? C#                      ===");
                Console.WriteLine("=== 1 - O primeiro que entra é o primeiro que sai?            ===");
                Console.WriteLine("=== 2 - O último que entra é o primeiro que sai?              ===");
                Console.WriteLine("=== 3 - É uma coleção flexível?                               ===");
                Console.WriteLine("=== 4 - É uma coleção de tamanho fixo ou baixo nível?         ===");
                Console.WriteLine("=== 5 - Inserção e remoção rápida de muitos dados?            ===");
                Console.WriteLine("=== 6 - As operações são como de conjuntos matemáticos?       ===");
                Console.WriteLine("=== 7 - Buscar valor através de uma chave-valor? JSON | NoSQL ===");
                Console.WriteLine("=== X - Sair do Sistema                                       ===");
                Console.WriteLine("=================================================================");
                Console.WriteLine();
                Console.Write("Digite a opção desejada: ");

                try
                {
                    opcao = Console.ReadLine()![0];

                    Console.WriteLine();

                    switch (opcao)
                    {
                        case '1':
                            PrimeiroEntraPrimeiroSai();
                            break;
                        case '2':
                            UltimoEntraPrimeiroSai();
                            break;
                        case '3':
                            ColecaoFlexivel();
                            break;
                        case '4':
                            TamanhoFixo();
                            break;
                        case '5':
                            InsercaoRemocaoRapida();
                            break;
                        case '6':
                            OperacoesConjuntos();
                            break;
                        case '7':
                            ChaveValor();
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

        #region PERGUNTAS

        /// <summary>
        /// PERGUNTA 1 - O primeiro que entra é o primeiro que sai? Fila! Queue<T>
        /// 
        /// Uma fila obedece à prioridade chamada de "FIFO", ou "First in - First out".
        /// </summary>
        private static void PrimeiroEntraPrimeiroSai()
        {
            Console.WriteLine("* O primeiro que entra é o primeiro que sai? ");
            Console.WriteLine("- Você verá uma coleção que você removerá SEMPRE o primeiro elemento que você colocou.");
            Console.WriteLine("- Um software de chamanda em uma FILA (Queue<T>) de banco ou consultório:");
            Console.WriteLine();

            Console.WriteLine("Entra o primeiro aluno na fila... sua matrícula será '1': ");
            Enfileirar(new("Ana Paula", 1));
            Suporte.EmpacaTela();

            Console.WriteLine("O segundo aluno entra na fila... a matrícula será '2': ");
            Enfileirar(new("Tatiana", 2));
            Suporte.EmpacaTela();

            Console.WriteLine("Rapidez e eficiência! O primeiro aluno saiu da fila! ");
            Desenfileirar();
            Suporte.EmpacaTela();

            Console.WriteLine("Aluno entrou... matrícula será '3': ");
            Enfileirar(new("Tatiane", 3));
            Suporte.EmpacaTela();

            Console.WriteLine("Mais um aluno entrou... matrícula é '4': ");
            Enfileirar(new("Daniela", 4));
            Suporte.EmpacaTela();

            Console.WriteLine("Outro aluno entrou... matrícula '5': ");
            Enfileirar(new("Cristiani", 5));
            Suporte.EmpacaTela();

            Console.WriteLine("O aluno 2 estava embassado, só saiu agora! ");
            Desenfileirar();
            Suporte.EmpacaTela();

            Console.WriteLine("O aluno 3 foi rapidinho... ");
            Desenfileirar();
            Suporte.EmpacaTela();

            Console.WriteLine("+ 1 aluno... matrícula '6': ");
            Enfileirar(new("Daniela", 6));
            Suporte.EmpacaTela();

            Console.WriteLine("O aluno 4 foi na média de tempo... ");
            Desenfileirar();
            Suporte.EmpacaTela();

            Console.WriteLine("Outro aluno... matrícula '7': ");
            Enfileirar(new("Alessandra", 7));
            Suporte.EmpacaTela();

            Console.WriteLine("Sairam os alunos 5 e 6... ");
            Desenfileirar();
            Desenfileirar();
            Suporte.EmpacaTela();

            Console.WriteLine("O último aluno entrou na fila - matrícula 8: ");
            Enfileirar(new("Patrícia", 8));
            Suporte.EmpacaTela();

            Console.WriteLine("Fim de expediente, sairam os dois últimos alunos. ");
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Suporte.EmpacaTela();

            Suporte.Finaliza();
        }

        /// <summary>
        /// PERGUNTA 2 - O último que entra é o primeiro que sai? Fila! Stack T
        /// 
        /// Uma pilha obedece à prioridade chamada de "LIFO", ou "Last in - First out".
        /// 
        /// Métodos:
        /// - Pop() - Retira e retorna o elemento do topo da pilha.
        /// - Peek() - Serve para "dar uma olhada" no próximo item que está 
        /// esperando para ser removido.
        /// - Push() - Serve para incluir itens numa pilha.
        /// </summary>
        private static void UltimoEntraPrimeiroSai()
        {
            Stack<int> chamadaPilha = new();

            Console.WriteLine("* O último que entra é o primeiro que sai? ");
            Console.WriteLine("- Você verá uma coleção que você removerá SEMPRE o último elemento que você colocou.");
            Console.WriteLine("- Um software de controle de CHAMADAS pode usar por PRIORIDADE uma PILHA (Stack<T>) para controle de atendimento:");
            Console.WriteLine();

            Console.WriteLine("Entra uma chamada na fila... seu código será '1': ");
            Empilha(1, chamadaPilha);
            Suporte.EmpacaTela();
            Console.WriteLine("Entrou uma carteirado do gerente! Tem Prioridade. Código '2': ");
            Empilha(2, chamadaPilha);
            Suporte.EmpacaTela();
            Console.WriteLine("Carteirada MASTER do dono da empresa! Prioridade máxima! Código '3': ");
            Empilha(3, chamadaPilha);
            Suporte.EmpacaTela();
            Console.WriteLine("A equipe correu como se estivesse o diabo no calcanhares... na verdade ele estava mesmo...");
            Console.WriteLine("O chamada de código '3' saiu da pilha.");
            Desempilha(chamadaPilha);
            Suporte.EmpacaTela();
            Console.WriteLine("Ufa! Mais uma carteirada resolvida, sufoco, viu? KKKKK!!!");
            Console.WriteLine("O chamada de código '2' saiu da pilha.");
            Desempilha(chamadaPilha);
            Suporte.EmpacaTela();
            Console.WriteLine("Caramba! Para resolver a chamada '1' é preciso resolver dois outros problema antes. Chamada: '4' e '5': ");
            Empilha(4, chamadaPilha);
            Empilha(5, chamadaPilha);
            Suporte.EmpacaTela();
            Console.WriteLine("Resolvidos! Chamada 4 e 5! ");
            Desempilha(chamadaPilha);
            Desempilha(chamadaPilha);
            Suporte.EmpacaTela();
            Console.WriteLine("Finalmente resolvemos a primeira chamada! Fim da pilha.");
            Desempilha(chamadaPilha);
            Desempilha(chamadaPilha);
            Desempilha(chamadaPilha);
            Desempilha(chamadaPilha);
            Suporte.EmpacaTela();

            Suporte.Finaliza();
        }

        /// <summary>
        /// PERGUNTA 3 - É uma coleção flexível? List T 
        /// 
        /// IList é uma sequência e aceita elementos duplicados. 
        /// ISet não aceita duplicados e não define ordem.
        /// 
        /// List é uma classe que implementa IList, logo pode ser 
        /// referenciada pela sua interface.
        /// 
        /// TIOBE Index for August 2023
        /// https://www.tiobe.com/tiobe-index/
        /// </summary>
        private static void ColecaoFlexivel()
        {
            //Fazendo a referência pela interface:
            IList<Aula> listaFlexivel = new List<Aula>() {
                new("Python", 1333),
                new("C", 1141),
                new("C++", 1063),
                new("Java", 1033),
                new("C#", 704),
                new("JavaScript", 329),
                new("Visual Basic", 262),
                new("SQL", 153),
                new("Assembly Language", 134),
                new("PHP", 127)
            };

            Console.WriteLine("* Uma coleção flexível? ");
            Console.WriteLine("- É a mais flexível de todas, você pode fazer várias operações. Exemplo: Inserir um elemento em qq posição da lista.");
            Console.WriteLine("- É uma implementação do .Net Framework, e é a melhor opção para quem precisa fazer tudo.");
            Console.WriteLine();

            Processa(listaFlexivel);

            Suporte.Finaliza();
        }

        /// <summary>
        /// PERGUNTA 4 - É uma coleção de tamanho fixo ou baixo nível?
        /// 
        /// Introdução prática a arrays com C#
        /// https://www.devmedia.com.br/introducao-pratica-a-arrays-com-csharp/26268
        /// </summary>
        private static void TamanhoFixo()
        {
            Aula[] tamanhoFixo = new Aula[] {
                new("Python", 1333),
                new("C", 1141),
                new("C++", 1063),
                new("Java", 1033),
                new("C#", 704),
                new("JavaScript", 329),
                new("Visual Basic", 262),
                new("SQL", 153),
                new("Assembly Language", 134),
                new("PHP", 127)
            };

            Console.WriteLine("* Uma coleção flexível? ");
            Console.WriteLine("- É a mais flexível de todas, você pode fazer várias operações. Exemplo: Inserir um elemento em qq posição da lista.");
            Console.WriteLine("- É uma implementação do .Net Framework, e é a melhor opção para quem precisa fazer tudo.");
            Console.WriteLine();

            Processa(tamanhoFixo);

            Suporte.Finaliza();
        }

        /// <summary>
        /// PERGUNTA 5 - Inserção e remoção rápida de muitos dados?
        /// </summary>
        private static void InsercaoRemocaoRapida()
        {
            Produto[] ArrProdutos = new Produto[] {
                new("Café", 19.99m),
                new("Açúcar", 5.50m),
                new("Carne", 45.50m),
                new("Queijo", 25.99m),
                new("Arroz", 26.90m),
                new("Feijão", 9.60m)
            };

            LinkedList<Produto> Produtos = new(ArrProdutos);

            Processa(Produtos);
            Suporte.Finaliza();
        }

        /// <summary>
        /// PERGUNTA 6 - As operações são como de conjuntos matemáticos?
        /// 
        /// São conjuntos mesmo. Os construtores, as propriedades,  
        /// os métodos, as interfaces e as extensões são bem voltados 
        /// para trabalhar com conjuntos matemáticos. Veja mais em:
        /// 
        /// HashSet<T> Classe
        /// https://learn.microsoft.com/pt-br/dotnet/api/system.collections.generic.hashset-1?view=net-7.0
        /// 
        /// Usando polimorfismo, pois HashSet é uma classe que implementa 
        /// a interface ICollection;
        /// </summary>
        private static void OperacoesConjuntos()
        {
            HashSet<int> evenNumbers = new();
            ICollection<int> oddNumbers = new HashSet<int>();

            for (int i = 0; i < 5; i++)
            {
                // Populate evenNumbers with just even numbers.
                // Preencher "evenNumbers" apenas com números pares.
                evenNumbers.Add(i * 2);

                // Populate oddNumbers with just odd numbers.
                // Preencher "oddNumbers" apenas com números ímpares.
                oddNumbers.Add((i * 2) + 1);
            }

            Processa(evenNumbers, oddNumbers);
            Suporte.Finaliza();
        }

        /// <summary>
        /// PERGUNTA 7 - Buscar valor através de uma chave-valor? JSON | NoSQL
        /// 
        /// A coleção Dictionary não suporta chaves repetidas, e permite que os 
        /// elementos sejam acessados pelo indexador.
        /// 
        /// * Minha opinião:
        /// Excelente para usar no NoSQL! 
        /// Uma chave e um valor que é uma string JSON (JavaScript Object Notation).
        /// 
        /// Saiba o que é JSON e como utilizar
        /// https://www.alura.com.br/artigos/o-que-e-json
        /// 
        /// Como serializar e desserializar JSON no .NET
        /// Artigo - 01/06/2023
        /// https://learn.microsoft.com/pt-br/dotnet/standard/serialization/system-text-json/how-to?pivots=dotnet-8-0
        /// </summary>
        private static void ChaveValor()
        {
            Dictionary<int, string> DictionaryAluno;

            List<Aluno> listaAlunos = new() {
                new("Ana Paula", 1),
                new("Tatiana", 2),
                new("Tatiane", 3),
                new("Cristiani", 4),
                new("Daniela", 5)
            };

            DictionaryAluno = Serializar(listaAlunos);

            Processa(DictionaryAluno);
            Suporte.Finaliza();
        }
        #endregion

        #region PERGUNTAS x SUPORTE

        #region PERGUNTA 1 - O primeiro que entra é o primeiro que sai? Fila! Queue<T>

        private static void Enfileirar(Aluno aluno)
        {
            Console.WriteLine($"O aluno {aluno} entrou na fila.");
            filaBancoConsultorio.Enqueue(aluno);
            Console.WriteLine("*** A FILA ESTÁ ASSIM: ");
            Imprimir(filaBancoConsultorio);
            Console.WriteLine("-------------------------");
        }

        private static void Desenfileirar()
        {
            if (filaBancoConsultorio.Any())
            {
                Aluno aluno1 = filaBancoConsultorio.Peek();

                // Aqui poderia ser um FLAG (boolean) requisitando a presença na gerência.
                if (aluno1.Nome == "Tatiana")
                    Console.WriteLine($"* ATENÇÃO: - Foi solicitada a presença do aluno \"{aluno1.Nome}\" - matrícula {aluno1.NumeroMatricula} na gerência.");

                Aluno aluno = filaBancoConsultorio.Dequeue();
                Console.WriteLine($"Saiu da fila: {aluno}");
                Console.WriteLine("*** A FILA ESTÁ ASSIM: ");
                Imprimir(filaBancoConsultorio);
                Console.WriteLine("-------------------------");
            }
        }

        #endregion

        #region PERGUNTA 2 - O último que entra é o primeiro que sai? Fila! Stack<T>
        private static void Empilha(int chamada, Stack<int> chamadaPilha)
        {
            chamadaPilha.Push(chamada);
            Console.WriteLine($"A chamada {chamada} entrou na pilha.");
            Console.WriteLine("*** A PILHA próximo ESTÁ ASSIM: ");
            Imprimir(chamadaPilha);
            Console.WriteLine("-------------------------");
        }

        private static void Desempilha(Stack<int> chamadaPilha)
        {
            int atual;

            if (chamadaPilha.Any())
            {
                atual = chamadaPilha.Pop();
                Console.WriteLine($"A chamada {atual} entrou na pilha.");
                Console.WriteLine("*** A PILHA anterior ESTÁ ASSIM: ");
                Imprimir(chamadaPilha);
                Console.WriteLine("-------------------------");
            }
        }
        #endregion

        #region PERGUNTA 3 - É uma coleção flexível? List<T>

        private static void Processa(IList<Aula> listaFlexivel)
        {
            int numero;

            Console.Write("Digite um número de 1 a 10: ");

            numero = int.Parse(Console.ReadLine() + string.Empty);

            if (numero >= 1 && numero <= 10)
                Console.WriteLine($"Você sabia que a linguagem {listaFlexivel[numero - 1].Titulo} é a {numero}º do mundo em Agosto de 2023?");
        }

        #endregion

        #region PERGUNTA 4 - É uma coleção de tamanho fixo ou baixo nível?

        private static void Processa(Aula[] tamanhoFixo)
        {
            int numero;

            Console.Write("Digite um número de 1 a 10: ");

            numero = int.Parse(Console.ReadLine() + string.Empty);

            if (numero >= 1 && numero <= 10)
                Console.WriteLine($"Você sabia que a linguagem {tamanhoFixo[numero - 1].Titulo} é a {numero}º do mundo em Agosto de 2023?");
        }

        #endregion

        #region PERGUNTA 5 - Inserção e remoção rápida de muitos dados?
        private static void Processa(LinkedList<Produto> insercaoRemocaoRapida)
        {
            Produto carne = new("Carne", 45.50m);
            Produto frango = new("Frango", 21.20m);
            LinkedListNode<Produto>? posicaoCarne = insercaoRemocaoRapida.Find(carne);

            Console.WriteLine("----- PRODUTOS: ");
            Imprimir(insercaoRemocaoRapida);
            Suporte.EmpacaTela();
            Console.WriteLine();

            Console.WriteLine("----- Colocar 'Sal' no inicio da lista: ");
            insercaoRemocaoRapida.AddFirst(new Produto("Sal", 2.49m));
            Imprimir(insercaoRemocaoRapida);
            Suporte.EmpacaTela();
            Console.WriteLine();

            Console.WriteLine("----- Colocar 'Ovos' no final da lista: ");
            insercaoRemocaoRapida.AddLast(new Produto("Ovos", 19.98m));
            Imprimir(insercaoRemocaoRapida);
            Suporte.EmpacaTela();
            Console.WriteLine();

            Console.WriteLine("----- Adicionar 'Cebola' no antes da 'Carne': ");

            if (posicaoCarne != null)
                insercaoRemocaoRapida.AddBefore(posicaoCarne, new Produto("Cebola", 33.80m));

            Imprimir(insercaoRemocaoRapida);
            Suporte.EmpacaTela();
            Console.WriteLine();

            Console.WriteLine("----- Adicionar 'Óleo' no depois da 'Carne': ");

            if (posicaoCarne != null)
                insercaoRemocaoRapida.AddAfter(posicaoCarne, new Produto("Óleo", 21.30m));

            Imprimir(insercaoRemocaoRapida);
            Suporte.EmpacaTela();
            Console.WriteLine();

            Console.WriteLine("----- Substituir a 'Carne' pelo 'Frango':");
            if (posicaoCarne != null)
                insercaoRemocaoRapida.AddBefore(posicaoCarne, frango);

            insercaoRemocaoRapida.Remove(carne);
            Imprimir(insercaoRemocaoRapida);
            Suporte.EmpacaTela();
            Console.WriteLine();

            Console.WriteLine("----- Pesquisar 'Queijo' e se tiver remover:");
            LinkedListNode<Produto>? posicaoQueijo = insercaoRemocaoRapida.FindLast(new("Queijo", 25.99m));

            if (posicaoQueijo != null)
                insercaoRemocaoRapida.Remove(posicaoQueijo);

            Imprimir(insercaoRemocaoRapida);
            Suporte.EmpacaTela();
            Console.WriteLine();

            Console.WriteLine("----- Pesquisar 'Vinagre' e se tiver remover:");
            LinkedListNode<Produto>? posicaoVinagre = insercaoRemocaoRapida.FindLast(new("Vinagre", 6.70m));

            if (posicaoVinagre != null)
                insercaoRemocaoRapida.Remove(posicaoVinagre);

            Imprimir(insercaoRemocaoRapida);
            Suporte.EmpacaTela();
            Console.WriteLine();

            Console.WriteLine("----- Retire o primeiro da lista e coloque 'Molho de Tomate':");
            insercaoRemocaoRapida.RemoveFirst();
            insercaoRemocaoRapida.AddFirst(new Produto("Molho de Tomate", 4.50m));
            Imprimir(insercaoRemocaoRapida);
            Suporte.EmpacaTela();
            Console.WriteLine();

            Console.WriteLine("----- Retire o último da lista e coloque 'Batata':");
            insercaoRemocaoRapida.RemoveLast();
            insercaoRemocaoRapida.AddLast(new Produto("Batata", 8.25m));
            Imprimir(insercaoRemocaoRapida);
            Suporte.EmpacaTela();
            Console.WriteLine();
        }
        #endregion

        #region PERGUNTA 6 - As operações são como de conjuntos matemáticos?

        private static void Processa(HashSet<int>? NumerosPares, ICollection<int>? NumerosImpares)
        {
            if (NumerosPares != null)
            {
                Console.Write("Numeros Pares contém {0} elementos: ", NumerosPares.Count);
                Imprimir(NumerosPares);
                Console.WriteLine();
            }

            if (NumerosImpares != null)
            {
                Console.Write("Número Ímpares contém {0} elementos: ", NumerosImpares.Count);
                Imprimir(NumerosImpares);
                Console.WriteLine();
            }

            // Create a new HashSet populated with even numbers.
            // Cria um novo HashSet preenchido com números pares.
            if (NumerosPares != null && NumerosImpares != null)
            {
                HashSet<int> numbers = new(NumerosPares);
                Console.WriteLine("numbers UnionWith oddNumbers...");
                numbers.UnionWith(NumerosImpares);

                Console.Write("numbers contains {0} elements: ", numbers.Count);
                DisplaySet(numbers);
            }
        }

        #endregion

        #region PERGUNTA 7 - Buscar valor através de uma chave-valor? JSON | NoSQL

        private static void Processa(Dictionary<int, string> StrJSON)
        {
            Aluno? deserializar;

            foreach (KeyValuePair<int, string> valor in StrJSON)
            {
                deserializar = JsonSerializer.Deserialize<Aluno>(valor.Value);

                if (deserializar != null)
                    Console.WriteLine($"Chave: {valor.Key} - Valor: {deserializar.Nome}");
            }

            Console.WriteLine();
            Imprimir(StrJSON);
        }

        private static Dictionary<int, string> Serializar(List<Aluno> alunos)
        {
            string StrJSON;
            Dictionary<int, string> parChaveValor = new();

            foreach (Aluno aluno in alunos)
            {
                StrJSON = JsonSerializer.Serialize(aluno);
                parChaveValor.Add(aluno.NumeroMatricula, StrJSON);
            };

            return parChaveValor;
        }

        #endregion

        #endregion

        #region SUPORTE
        /// <summary>
        /// Sobrecarga para Queue Aluno
        /// </summary>
        /// <param name="alunos">Um aluno comum...</param>
        private static void Imprimir(Queue<Aluno> alunos)
        {
            foreach (Aluno aluno in alunos)
                Console.WriteLine($"Aluno {aluno.Nome} - Matrícula {aluno.NumeroMatricula}");
        }

        /// <summary>
        /// Sobrecarga para Stack int
        /// </summary>
        /// <param name="chamadas"></param>
        private static void Imprimir(Stack<int> chamadas)
        {
            foreach (int chamada in chamadas)
                Console.WriteLine($"Chamada: {chamada}.");
        }

        /// <summary>
        /// Sobrecarga para LinkedList Produto
        /// </summary>
        /// <param name="produtos"></param>
        private static void Imprimir(LinkedList<Produto> produtos)
        {
            foreach (var produto in produtos.Select((x, i) => new { Value = x, Index = i }))
                Console.WriteLine($"Index: {produto.Index} - {produto.Value}.");
        }

        /// <summary>
        /// Sobrecarga para HashSet int
        /// </summary>
        /// <param name="numeros"></param>
        private static void Imprimir(HashSet<int> numeros)
        {
            foreach (int numero in numeros)
                Console.WriteLine($"Chamada: {numero}.");
        }

        /// <summary>
        /// Sobrecarga para ICollection int
        /// </summary>
        /// <param name="numeros"></param>
        private static void Imprimir(ICollection<int> numeros)
        {
            foreach (int numero in numeros)
                Console.WriteLine($"Chamada: {numero}.");
        }

        /// <summary>
        /// Sobrecarga para Dictionary int, string
        /// </summary>
        /// <param name="StrJSON"></param>
        private static void Imprimir(Dictionary<int, string> StrJSON)
        {
            foreach (KeyValuePair<int, string> ParChaveValor in StrJSON)
                Console.WriteLine($"Par Chave Valor: {ParChaveValor}.");
        }

        /// <summary>
        /// HashSet<T> Classe
        /// 
        /// https://learn.microsoft.com/pt-br/dotnet/api/system.collections.generic.hashset-1?view=net-7.0
        /// </summary>
        /// <param name="collection"></param>
        private static void DisplaySet(HashSet<int> collection)
        {
            Console.Write("{");

            foreach (int i in collection)
            {
                Console.Write(" {0}", i);
            }

            Console.WriteLine(" }");
        }
        #endregion
    }
}