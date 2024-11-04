using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    public class Program
    {
        static void Main(string[] args)
        {
            MenuInicial();
            ExibirMenu();
        }

        public static void MenuInicial()
        {
            Console.WriteLine("Autor: Cauã Canale");
            Console.WriteLine("\n");

            //FALTA AS OUTRAS INFORMAÇÕES

        }

        public static void ExibirMenu()
        {
            Console.WriteLine("Digite 0 para Sair");
            Console.WriteLine("Digite 1 para o Exercicio 1");
            Console.WriteLine("Digite 2 para o Exercicio 2");
            Console.WriteLine("Digite 3 para o Exercicio 3");
            Console.WriteLine("Digite 4 para o Exercicio 4");
            Console.WriteLine("Digite 5 para o Exercicio 5");
            Console.WriteLine("Digite 6 para o Exercicio 6");
            Console.WriteLine("\nDigite a opção escolhida:");
            int opcaoEscolhidaNumero = int.Parse(Console.ReadLine());


            switch (opcaoEscolhidaNumero)
            {
                case 1:

                    atv1();
                    break;

                case 2:
                    atv2();
                    break;


                case 3:

                    atv3();
                    break;

                case 4:

                    atv4();
                    break;


                case 5:

                    atv5();
                    break;


                case 6:

                    atv6();
                    break;


                case 0:
                    Console.Clear();
                    Console.WriteLine(@"
░██████╗░█████╗░██╗███╗░░██╗██████╗░░█████╗░░░░░░░░░░
██╔════╝██╔══██╗██║████╗░██║██╔══██╗██╔══██╗░░░░░░░░░
╚█████╗░███████║██║██╔██╗██║██║░░██║██║░░██║░░░░░░░░░
░╚═══██╗██╔══██║██║██║╚████║██║░░██║██║░░██║░░░░░░░░░
██████╔╝██║░░██║██║██║░╚███║██████╔╝╚█████╔╝██╗██╗██╗
╚═════╝░╚═╝░░╚═╝╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░╚═╝╚═╝╚═╝");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
            }
        }




        private static void atv3()
        {
            Console.WriteLine("\nVocê escolheu o Exercicio 3");
            Console.Clear();
            Console.WriteLine("3. Crie um programa que leia a idade de uma pessoa e informe se ela é maior de idade (18 anos ou mais) ou menor de idade.");
            Console.WriteLine();

            // Solicita ao usuário que insira a idade
            Console.Write("Digite a idade da pessoa: ");
            string input = Console.ReadLine(); // Lê a entrada do usuário
            int idade; // Declara uma variável para armazenar a idade

            // Tenta converter a entrada para um número inteiro
            if (int.TryParse(input, out idade))
            {
                // Verifica se a idade é maior ou igual a 18
                if (idade >= 18)
                {
                    Console.WriteLine("A pessoa é maior de idade."); // Imprime que é maior de idade
                }
                else
                {
                    Console.WriteLine("A pessoa é menor de idade."); // Imprime que é menor de idade
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira uma idade válida."); // Mensagem de erro para entrada inválida
            }
        }




        private static void atv1()
        {

            Console.WriteLine("\nVocê escolheu o Exercicio 1");
            Console.Clear();
            Console.WriteLine("1. Escreva um programa que verifique se um número fornecido pelo usuário é positivo, negativo ou zero.");
            Console.WriteLine();

            // Solicita ao usuário que insira um número
            Console.Write("Digite um número: ");
            string input = Console.ReadLine(); // Lê a entrada do usuário
            double numero; // Declara a variável para armazenar o número

            // Tenta converter a entrada para um número
            if (double.TryParse(input, out numero))
            {
                Console.WriteLine();
                // Verifica se o número é positivo
                if (numero > 0)
                {
                    Console.WriteLine("O número é positivo."); // Imprime que é positivo
                }
                // Verifica se o número é negativo
                else if (numero < 0)
                {
                    Console.WriteLine("O número é negativo."); // Imprime que é negativo
                }
                // Se não for nem positivo nem negativo, é zero
                else
                {
                    Console.WriteLine("O número é zero."); // Imprime que é zero
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido."); // Mensagem de erro para entrada inválida
            }
        }




        private static void atv2()
        {
            Console.WriteLine("\nVocê escolheu o Exercicio 2");
            Console.WriteLine("2. Escreva um programa que leia uma senha e permita até três tentativas para acertar. Caso contrário, bloqueie o acesso.");

            // Solicita ao usuário que insira um número
            Console.Write("Digite um número: ");
            string input = Console.ReadLine(); // Lê a entrada do usuário
            int numero; // Declara uma variável para armazenar o número

            // Tenta converter a entrada para um número inteiro
            if (int.TryParse(input, out numero))
            {
                // Verifica se o número é par
                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número é par."); // Imprime que o número é par
                }
                else
                {
                    Console.WriteLine("O número é ímpar."); // Imprime que o número é ímpar
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido."); // Mensagem de erro para entrada inválida
            }
        }




        private static void atv4()
        {
            Console.WriteLine("\nVocê escolheu o Exercicio 4");
            Console.WriteLine("11. Escreva um programa que leia um mês do ano e informe quantos dias ele tem.");

            // Solicita ao usuário que insira um mês do ano
            Console.Write("Digite um mês (1-12): ");
            string input = Console.ReadLine(); // Lê a entrada do usuário
            int mes; // Declara uma variável para armazenar o mês

            // Tenta converter a entrada para um número inteiro
            if (int.TryParse(input, out mes) && mes >= 1 && mes <= 12)
            {
                int dias; // Declara uma variável para armazenar o número de dias

                // Verifica quantos dias o mês tem
                switch (mes)
                {
                    case 1: // Janeiro
                    case 3: // Março
                    case 5: // Maio
                    case 7: // Julho
                    case 8: // Agosto
                    case 10: // Outubro
                    case 12: // Dezembro
                        dias = 31; // Meses com 31 dias
                        break;
                    case 4: // Abril
                    case 6: // Junho
                    case 9: // Setembro
                    case 11: // Novembro
                        dias = 30; // Meses com 30 dias
                        break;
                    case 2: // Fevereiro
                        dias = 28; // Fevereiro normalmente tem 28 dias (não considerando anos bissextos)
                        break;
                    default:
                        dias = 0; // Não deve acontecer devido à verificação anterior
                        break;
                }

                // Imprime o resultado
                Console.WriteLine($"O mês {mes} tem {dias} dias.");
            }
            else
            {
                Console.WriteLine("Por favor, insira um mês válido (1-12)."); // Mensagem de erro para entrada inválida
            }
        }

        private static void atv5() // Método principal
        {
            Console.WriteLine("\nVocê escolheu o Exercicio 5");
            Console.WriteLine("15. Escreva um programa que leia uma data (dia, mês, ano) e verifique se é uma data válida.");

            // Solicita ao usuário que insira uma data
            Console.Write("Digite uma data (dd/mm/aaaa): ");
            string input = Console.ReadLine(); // Lê a entrada do usuário

            // Tenta converter a entrada em uma data válida
            if (DateTime.TryParse(input, out DateTime data))
            {
                // Imprime que a data é válida
                Console.WriteLine($"A data {data:dd/MM/yyyy} é válida.");
            }
            else
            {
                // Imprime que a data é inválida
                Console.WriteLine("A data fornecida não é válida.");
            }
        }



        private static void atv6() // Definição da função Atv6
        {
            Console.WriteLine("\nVocê escolheu o Exercicio 6");
            Console.WriteLine("6. Faça um programa que leia a nota de um aluno e informe se ele está aprovado (nota maior ou igual a 7), em recuperação (nota entre 5 e 7) ou reprovado (nota menor que 5).");

            // Solicita ao usuário que insira a nota do aluno
            Console.Write("Digite a nota do aluno: ");
            string input = Console.ReadLine(); // Lê a entrada do usuário
            double nota; // Declara uma variável para armazenar a nota

            // Tenta converter a entrada para um número
            if (double.TryParse(input, out nota))
            {
                // Verifica a situação do aluno com base na nota
                if (nota >= 7)
                {
                    Console.WriteLine("O aluno está aprovado."); // Imprime que o aluno está aprovado
                }
                else if (nota >= 5)
                {
                    Console.WriteLine("O aluno está em recuperação."); // Imprime que o aluno está em recuperação
                }
                else
                {
                    Console.WriteLine("O aluno está reprovado."); // Imprime que o aluno está reprovado
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira uma nota válida."); // Mensagem de erro para entrada inválida
            }
        }
    }
}