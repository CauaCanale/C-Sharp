using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aula2
{
    public class Program
    {
        static void Main(string[] args)
        {
            ExibirCabecalho();
            ExibirMenu();

        }
        public static void ExibirMenu()
        {
            Console.WriteLine("Digite 1 para registrar informações");
            Console.WriteLine("Digite 2 para listar informações");
            Console.WriteLine("Digite 3 para apagar informações");
            Console.WriteLine("\nDigite a opção escolhida:");
            int opcaoEscolhidaNumero = int.Parse(Console.ReadLine());
            //int opcaoEscolhidaNumero = int.Parse(opcaoEscolhida);
            /*if (opcaoEscolhidaNumero == 1) 
            {
                Console.WriteLine("\nVocê escolheu a opção 1");
            }
            if (opcaoEscolhidaNumero == 2) ;
            {
                Console.WriteLine("\nVocê escolheu a opção 1");
            }*/

            switch (opcaoEscolhidaNumero)
            {
                case 1:
                    CadInfo();                               
                    break;

                case 2:
                    Console.WriteLine("\nVocê escolheu a opção 2");
                    Thread.Sleep(3000);
                    Console.Clear();
                    ExibirCabecalho();
                    ExibirMenu();
                    break;

                case 3:
                    Console.WriteLine("\nVocê escolheu a opção 3");
                    Thread.Sleep(3000);
                    Console.Clear();
                    ExibirCabecalho();
                    ExibirMenu();
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
                    break;

                default:
                    Console.WriteLine("\nVocê digitou a opção inválida");
                    Thread.Sleep(3000);
                    Console.Clear();
                    ExibirCabecalho();
                    ExibirMenu();
                    break;
            }
        }

        private static void CadInfo()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Cliente");
            Console.WriteLine("Digite seu lindo Nome:");
            string NomeDousuario = Console.ReadLine();
            Console.WriteLine($"\nNome cadastro com Sucesso!!!!");
            Thread.Sleep(3000);
            ExibirCabecalho();
            ExibirMenu();
        }





        public static void ExibirCabecalho()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("hello World");
            Console.WriteLine("════════════════");
            Console.WriteLine(@"
░█████╗░░█████╗░██╗░░░██╗░█████╗░
██╔══██╗██╔══██╗██║░░░██║██╔══██╗
██║░░╚═╝███████║██║░░░██║███████║
██║░░██╗██╔══██║██║░░░██║██╔══██║
╚█████╔╝██║░░██║╚██████╔╝██║░░██║
░╚════╝░╚═╝░░╚═╝░╚═════╝░╚═╝░░╚═╝");
            Console.ResetColor();
        }






    }
}