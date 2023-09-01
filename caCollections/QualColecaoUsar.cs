using System.Diagnostics;
using System.Reflection.PortableExecutable;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                Console.WriteLine("=========================================================");
                Console.WriteLine("===             Qual Collection usar? C#              ===");
                Console.WriteLine("=== 1 - O primeiro que entra é o primeiro que sai?    ===");
                Console.WriteLine("=== 2 - O último que entra é o primeiro que sai?      ===");
                Console.WriteLine("=== 3 - É uma coleção flexível?                       ===");
                Console.WriteLine("=== 4 - É uma coleção de tamanho fixo ou baixo nível? ===");
                Console.WriteLine("=== 5 - Inserção e remoção rápida de muitos dados?    ===");
                Console.WriteLine("=== X - Sair do Sistema                               ===");
                Console.WriteLine("=========================================================");
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
        /// PERGUNTA 1 - O primeiro que entra é o primeiro que sai? Fila! Queue<T>
        /// </summary>
        private static void PrimeiroEntraPrimeiroSai()
        {
            Console.WriteLine("* O primeiro que entra é o primeiro que sai? ");
            Console.WriteLine("- Você verá uma coleção que você removerá SEMPRE o primeiro elemento que você colocou.");
            Console.WriteLine("- Um software de chamanda em uma FILA (Queue<T>) de banco ou consultório:");
            Console.WriteLine();

            Console.WriteLine("Entra o primeiro aluno na fila... sua matrícula será '1': ");
            Enfileirar(new("Ana Paula", 1));
            EmpacaTela();

            Console.WriteLine("O segundo aluno entra na fila... a matrícula será '2': ");
            Enfileirar(new("Tatiana", 2));
            EmpacaTela();

            Console.WriteLine("Rapidez e eficiência! O primeiro aluno saiu da fila! ");
            Desenfileirar();
            EmpacaTela();

            Console.WriteLine("Aluno entrou... matrícula será '3': ");
            Enfileirar(new("Tatiane", 3));
            EmpacaTela();

            Console.WriteLine("Mais um aluno entrou... matrícula é '4': ");
            Enfileirar(new("Daniela", 4));
            EmpacaTela();

            Console.WriteLine("Outro aluno entrou... matrícula '5': ");
            Enfileirar(new("Cristiani", 5));
            EmpacaTela();

            Console.WriteLine("O aluno 2 estava embassado, só saiu agora! ");
            Desenfileirar();
            EmpacaTela();

            Console.WriteLine("O aluno 3 foi rapidinho... ");
            Desenfileirar();
            EmpacaTela();

            Console.WriteLine("+ 1 aluno... matrícula '6': ");
            Enfileirar(new("Daniela", 6));
            EmpacaTela();

            Console.WriteLine("O aluno 4 foi na média de tempo... ");
            Desenfileirar();
            EmpacaTela();

            Console.WriteLine("Outro aluno... matrícula '7': ");
            Enfileirar(new("Alessandra", 7));
            EmpacaTela();

            Console.WriteLine("Sairam os alunos 5 e 6... ");
            Desenfileirar();
            Desenfileirar();
            EmpacaTela();

            Console.WriteLine("O último aluno entrou na fila - matrícula 8: ");
            Enfileirar(new("Patrícia", 8));
            EmpacaTela();

            Console.WriteLine("Fim de expediente, sairam os dois últimos alunos. ");
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            EmpacaTela();

            Finaliza();
        }

        /// <summary>
        /// PERGUNTA 2 - O último que entra é o primeiro que sai? Fila! Stack<T>
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
            EmpacaTela();
            Console.WriteLine("Entrou uma carteirado do gerente! Tem Prioridade. Código '2': ");
            Empilha(2, chamadaPilha);
            EmpacaTela();
            Console.WriteLine("Carteirada MASTER do dono da empresa! Prioridade máxima! Código '3': ");
            Empilha(3, chamadaPilha);
            EmpacaTela();
            Console.WriteLine("A equipe correu como se estivesse o diabo no calcanhares... na verdade ele estava mesmo...");
            Console.WriteLine("O chamada de código '3' saiu da pilha.");
            Desempilha(chamadaPilha);
            EmpacaTela();
            Console.WriteLine("Ufa! Mais uma carteirada resolvida, sufoco, viu? KKKKK!!!");
            Console.WriteLine("O chamada de código '2' saiu da pilha.");
            Desempilha(chamadaPilha);
            EmpacaTela();
            Console.WriteLine("Caramba! Para resolver a chamada '1' é preciso resolver dois outros problema antes. Chamada: '4' e '5': ");
            Empilha(4, chamadaPilha);
            Empilha(5, chamadaPilha);
            EmpacaTela();
            Console.WriteLine("Resolvidos! Chamada 4 e 5! ");
            Desempilha(chamadaPilha);
            Desempilha(chamadaPilha);
            EmpacaTela();
            Console.WriteLine("Finalmente resolvemos a primeira chamada! Fim da pilha.");
            Desempilha(chamadaPilha);
            Desempilha(chamadaPilha);
            Desempilha(chamadaPilha);
            Desempilha(chamadaPilha);
            EmpacaTela();

            Finaliza();
        }

        /// <summary>
        /// PERGUNTA 3 - É uma coleção flexível? List T 
        /// 
        /// TIOBE Index for August 2023
        /// https://www.tiobe.com/tiobe-index/
        /// </summary>
        private static void ColecaoFlexivel()
        {
            List<Aula> listaFlexivel = new() { 
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

            Finaliza();
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

            Finaliza();
        }

        /// <summary>
        /// PERGUNTA 5 - Inserção e remoção rápida de muitos dados?
        /// </summary>
        private static void InsercaoRemocaoRapida()
        {
            LinkedList<Aual>
        }

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

        private static void Processa(List<Aula> listaFlexivel)
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
        /// Somente para finalizar.
        /// </summary>
        private static void Finaliza()
        {
            Console.WriteLine();
            Console.WriteLine("Digite QQ Tecla.");
            Console.ReadKey();
        }

        /// <summary>
        /// Parar a tela para ler.
        /// </summary>
        private static void EmpacaTela()
        {
            Console.WriteLine("Pressione qq tecla para continuar...");
            Console.ReadKey();
        }
        #endregion
    }
}