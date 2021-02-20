using System;

namespace letra_mayus
{
    class Program
    {
        static void Main(string[] args)
        {
            int  num1, a;
            a = 0;

            Console.Writeline("introduce un numero");
            num1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num1; i++)
            {
                if (num1 % i == 0)
                    a++;
                        }
            if (a == 2)
            {
                Console.WriteLine("El numero es primo");
            }

            else
            {
                Console.WriteLine("El numero no es primo");
            }






        }
    }
}
