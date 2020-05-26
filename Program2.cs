using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("Ingresar Valor 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar Valor 2");
            num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Ambos numeros son iguales");
                Console.ReadKey();
                Environment.Exit(1);
            }
            if (num1 > num2)
            {
                Console.WriteLine(num1 + " Es el mayor de ambos numeros");
            }
            else
            {
                Console.WriteLine(num2 + " Es el mayor de ambos numeros");
            }
           
            Console.ReadKey();
        }
    }
}
