using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int cociente;
            int resul;

            Console.WriteLine("Ingresar Numero 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar Numero 2");
            num2 = int.Parse(Console.ReadLine());

            cociente = (num2 / num1) * 2;
            resul = num2 - cociente;
            if(resul == 0)
            {
                Console.WriteLine(num1+" Es multiplo de "+num2);
            }
            else
            {
                Console.WriteLine("No hay multiplo");
            }
        }
    }
}
