using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int mul = 4;
            int mul1 = 5;
            int cociente;
            int cociente1;
            int resul;
            int resul1;

            Console.WriteLine("Ingrese el Valor");
            num = int.Parse(Console.ReadLine());
            int num1 = num;
            cociente = (mul / num) * 2;
            resul = mul - cociente;

            cociente1 = (mul1 / num1) * 2;
            resul1 = mul1 - cociente1;
            if (resul == 0)
            {
                Console.WriteLine(num + " Es Multiplo de 4");
                Console.ReadKey();
            }
            if (resul1==0)
            {
                Console.WriteLine(num1 + " Es Multiplo de 5");
                Console.ReadKey();

            }
            if (resul != 0 && resul1 != 0)
            {
                Console.WriteLine("El numero ingresado no es multiplo de 4 o 5");
            }
            Console.ReadKey();
        }
    }
}
