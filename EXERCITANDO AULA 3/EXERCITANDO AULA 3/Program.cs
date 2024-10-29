using System;
using System.Collections.Generic;
using System.Linq;
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
                    Console.WriteLine("\nVocê escolheu o Exercicio 1");
                    Console.WriteLine("1. Escreva um programa que verifique se um número fornecido pelo usuário é positivo, negativo ou zero.");
                    break;


                case 2:
                    Console.WriteLine("\nVocê escolheu o Exercicio 2");
                    Console.WriteLine("2. Escreva um programa que leia uma senha e permita até três tentativas para acertar. Caso contrário, bloqueie o acesso.");                                       
                    break;


                case 3:
                    Console.WriteLine("\nVocê escolheu o Exercicio 3");
                    Console.WriteLine("3. Crie um programa que leia a idade de uma pessoa e informe se ela é maior de idade (18 anos ou mais) ou menor de idade.");
                    break;


                case 4:
                    Console.WriteLine("\nVocê escolheu o Exercicio 4");
                    Console.WriteLine("4. Escreva um programa que verifique se um número fornecido pelo usuário é par ou ímpar.");
                    break;


                case 5:
                    Console.WriteLine("\nVocê escolheu o Exercicio 5");
                    Console.WriteLine("11. Escreva um programa que leia um mês do ano e informe quantos dias ele tem.");
                    break;


                case 6:
                    Console.WriteLine("\nVocê escolheu o Exercicio 6");
                    Console.WriteLine("6.s Faça um programa que leia a nota de um aluno e informe se ele está aprovado (nota maior ou igual a 7), em recuperação (nota entre 5 e 7) ou reprovado (nota menor que 5).");                
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


                default:
                    Console.Clear();
                    Console.WriteLine(@"

░█████╗░██████╗░░█████╗░░█████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗
██║░░██║██████╔╝██║░░╚═╝███████║██║░░██║
██║░░██║██╔═══╝░██║░░██╗██╔══██║██║░░██║
╚█████╔╝██║░░░░░╚█████╔╝██║░░██║╚█████╔╝
░╚════╝░╚═╝░░░░░░╚════╝░╚═╝░░╚═╝░╚════╝░

██╗███╗░░██╗██╗░░░██╗░█████╗░██╗░░░░░██╗██████╗░░█████╗░░░░░░░░░░
██║████╗░██║██║░░░██║██╔══██╗██║░░░░░██║██╔══██╗██╔══██╗░░░░░░░░░
██║██╔██╗██║╚██╗░██╔╝███████║██║░░░░░██║██║░░██║███████║░░░░░░░░░
██║██║╚████║░╚████╔╝░██╔══██║██║░░░░░██║██║░░██║██╔══██║░░░░░░░░░
██║██║░╚███║░░╚██╔╝░░██║░░██║███████╗██║██████╔╝██║░░██║██╗██╗██╗
╚═╝╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝╚══════╝╚═╝╚═════╝░╚═╝░░╚═╝╚═╝╚═╝╚═╝");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
            }
        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
