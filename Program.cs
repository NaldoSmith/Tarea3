using System;

namespace _8
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
            if (num1 > 0 && num2 > 0)
            {
                Console.WriteLine("Ambos numeros son positivo");

            }
            else if(num1 < 0 && num2 < 0)
            {
                Console.WriteLine("Ambos numeros son negativos");
            }
            else if(num1 > 0 && num2 < 0)
            {
                Console.WriteLine(num1 + " Es positivo y " + num2 + " Es negativo");
            }
            else if(num1<0 && num2 > 0)
            {
                Console.WriteLine(num1 + " Es negativo y " + num2 + " Es positivo");
            }
        }
    }
}
