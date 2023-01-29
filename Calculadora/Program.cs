using System;
using System.Runtime.Serialization;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double resultado;
            string operacaoEscolha = null;

            IniciarMenuFinal();

            string menuFinal = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite o primeiro número: ");
            double primeiroNumero = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double segundoNumero = double.Parse(Console.ReadLine());

            resultado = ImprimirCaluculos(primeiroNumero, segundoNumero, menuFinal );

            if (menuFinal == "SM")
                operacaoEscolha = ("SOMA");
            else if (menuFinal == "DV")
                operacaoEscolha = ("DIVISÃ");
            else if (menuFinal == "MT")
                operacaoEscolha = ("MULTIPLICAÇÃO");
            else if (menuFinal == "SU")
                operacaoEscolha = ("SUBTRAÇÃO");

            Console.WriteLine("A operação escolhida foi: " + operacaoEscolha +", "+ "O resultado é: " + resultado);

            Console.ReadKey();
        }

        static void IniciarMenuFinal()
        {
            Console.WriteLine("######################### MENU ############################");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("## [SM] SOMA [DV] DIVISÃO [MT] MULTIPLICAÇÃO [SU] SUBTRAÇÃO");
            Console.ResetColor();
            Console.WriteLine("###########################################################");
        }

        static double ImprimirCaluculos(double primeiroNumero, double segundoNumero, string opcaoMenu)
        {

            double resultado = 0;

            if (opcaoMenu == "SM")
                resultado = Somar(primeiroNumero, segundoNumero);
            else if (opcaoMenu == "MT")
                resultado = Multiplicar(primeiroNumero, segundoNumero);
            else if (opcaoMenu == "DV")
                resultado = Dividir(primeiroNumero, segundoNumero);
            else if (opcaoMenu == "SU")
                resultado = Subtrair(primeiroNumero, segundoNumero);
            else
                Console.WriteLine("OPCAO INVÁLIDA");
            return resultado;
        }

        static double Somar(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero + segundoNumero;
        }

        static double Multiplicar(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero * segundoNumero;
        }

        static double Dividir(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero / segundoNumero;
        }

        static double Subtrair(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero - segundoNumero;
        }
    }   
}
