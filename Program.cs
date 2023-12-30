using System;
namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Soma()

        {
            Console.Clear();
            Console.WriteLine("Soma");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Escreva o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 + v2;

            Console.WriteLine("");

            Console.WriteLine($"A soma dos dois números é: {result}."); 
            
            Console.ReadKey();
            Menu();

        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Subtração");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Escreva o primeiro número: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o segundo número: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 - v2;

            Console.WriteLine($"A subtração dos dois números é: {result}.");

            Console.ReadKey();
            Menu();

        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Multiplicação.");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Escreva o segundo número: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escrava o segundo número: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 * v2;

            Console.Write("");

            Console.WriteLine($"A multiplicação dos dois números é: {result}.");

            Console.ReadKey();
            Menu();

        }  
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Divisão");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Escreva o primeiro número: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float result =  v1 / v2;

            Console.WriteLine($"A divisão dos dois números é: {result}.");

            Console.ReadKey();
            Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Menu de operações:");

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Escolha uma operação:");
            short menu = short.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5:
                 {
                    Console.WriteLine("Obrigado por usar a calculadora");
                    System.Environment.Exit(0);
                 }; break;
                 default: Menu(); break;
            }

        }      
    }
}