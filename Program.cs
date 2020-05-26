using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int div;

            Console.WriteLine("Ingresar valor 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar valor 2");
            num2 = int.Parse(Console.ReadLine());
            
            if (num2 == 0)
            {
                Console.WriteLine("Error: no se puede dividir entre "+num2);
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                div = num1 / num2;
                Console.WriteLine(num1+"/"+num2+" = "+div);
            }
            
        }
    }
}
