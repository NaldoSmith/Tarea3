using System;
using System.Security.Cryptography.X509Certificates;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int fig;
            Console.WriteLine("Ingresar Numero:");
            num = int.Parse(Console.ReadLine());
            fig = num;
                if (num % 2 == 0)
                {
                    Console.WriteLine(fig + " Es un numero par");
                }
                else
                {
                    Console.WriteLine(fig + " Es un numero impar");
                }
            Console.ReadKey();
        }
    }
}
