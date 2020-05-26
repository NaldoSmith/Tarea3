using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num = 4;
            int cociente;
            int resul;


            Console.WriteLine("Ingresar valor");
            num1 = int.Parse(Console.ReadLine());
            cociente = (num / num1) * 2;
            resul = num - cociente;
            if (resul == 0)
            {
                Console.WriteLine(num1 + " Es Multiplo de 10");
                Console.WriteLine();
                Console.WriteLine("Ingresar 2do. valor");
                num2 = int.Parse(Console.ReadLine());
                cociente = (num / num2) * 2;
                resul = num - cociente;
                if (resul == 0)
                {
                    Console.WriteLine(num2 + " Es Multiplo de 10");
                }
                else
                {
                    Console.WriteLine(num2 + " No es Multiplo de 10");
                }
            }
            else
            {
                Console.WriteLine(num1 + " No es Multiplo de 10");
            }
            Console.ReadKey();
        }
    }
}
