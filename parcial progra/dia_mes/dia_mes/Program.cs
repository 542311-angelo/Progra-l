using System;

namespace dia_mes
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia = 0, m = 0, resultado;

            Console.WriteLine("Ingrese su dia de nacimiento");
            dia = Convert.ToInt32(Console.ReadLine());
            dia = ((dia * 20) + 73) * 5;
            Console.WriteLine("ingrese el numero de su mes de nacimiento: ");
            m = Convert.ToInt32(Console.ReadLine());
            resultado = dia + m - 365;
            int can1, can2, can3, can4;
            can1 = (resultado % 10000) / 1000;
            can2 = (resultado % 10000) % 1000 / 100;
            can3 = ((resultado % 10000) % 1000) % 100 / 10;
            can4 = (((resultado % 10000) % 1000) % 100) % 10;
            Console.WriteLine("Tunaciste el dia: " + can1 + can2 + " del mes:" + can3 + can4);
        }
    }
}
