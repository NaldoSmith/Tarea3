using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double num3;

            Console.WriteLine("Ingresar Valor 1");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar Valor 2");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar Valor 3");
            num3 = Convert.ToDouble(Console.ReadLine());

            if(num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1 + " Es el mayor de los numeros");
            }
            else if(num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2 + " Es el mayor de los numeros");
            }
            else if(num3 > num1 && num3 > num2)
            {
                Console.WriteLine(num3 + " Es el mayor de los numeros");
            }
            Console.ReadKey();
        }
    }
}
