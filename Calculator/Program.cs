using System;
using System.Threading;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem Vindo a Calculadora!");

            Console.WriteLine();

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Divisão");
            Console.WriteLine("3 - Subtração");
            Console.WriteLine("4 - Multiplcação");
            Console.WriteLine("5 - Resto da Divisão");
            Console.WriteLine("6 - Sair");
            Console.WriteLine();
            Console.WriteLine("----------VAMOS INICIAR----------");
            Console.WriteLine();
            Console.WriteLine("Selecione uma das opções:");

            int opcao = int.Parse(Console.ReadLine());
           
                switch (opcao)
                {
                    case 1: Soma(); break;
                    case 2: Dividir(); break;
                    case 3: Subtrair(); break;
                    case 4: Multiplicar(); break;
                    case 5: Resto(); break;
                    case 6: Sair(); break;
                    default: Menu(); break;
                }            
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Informe o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine();

            Console.WriteLine($"O resultado da soma é de : {resultado}");

            Console.ReadKey();
            Menu();
        }
        static void Dividir()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;

            Console.WriteLine();
            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Subtrair()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;

            Console.WriteLine();
            Console.WriteLine($"O resultado da subtração é : {resultado}");

            Console.ReadKey();
            Menu();


        }
        static void Multiplicar()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;

            Console.WriteLine();
            Console.WriteLine($"O resultado da Multiplicação é : {resultado}");

            Console.ReadKey();
            Menu();

        }
        static void Resto()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 % v2;

            Console.WriteLine();
            Console.WriteLine($"O resultado do Resto da Divisão é : {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Obrigado por utilizar a Calculadora!!");
            Thread.Sleep(2500);
            System.Environment.Exit(0);
        }
    }
}
