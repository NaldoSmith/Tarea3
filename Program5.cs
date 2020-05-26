using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int resul;
            Console.WriteLine("Ingresar Valor 1");
            num1 = int.Parse(Console.ReadLine());
            if (num1 == 0)
            {
                Console.WriteLine("El producto de 0 por cualquier numero es 0");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Ingresar Valor 2");
                num2 = int.Parse(Console.ReadLine());
                resul=num1* num2;
                Console.WriteLine("El producto de " + num1 + " y " + num2 + " es " + resul);
            }
        }
    }
}
