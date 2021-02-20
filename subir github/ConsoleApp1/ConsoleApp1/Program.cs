using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int horast, horase, horaso, total;
            Console.Write("Horas trabajadas:");
            horast = Convert.ToInt32(Console.ReadLine());



            if (horast > 40)
            {
                horase = horast - 40;
                horaso = horast - horase;

                horaso = horaso * 16;
                horase = horase * 20;

                total = horaso + horase;

            }
            else
            {
                horast = horast * 16;
                total = horast;

            }

            Console.WriteLine("El total es: " + total);

            Console.ReadKey();
        }
    }
}
