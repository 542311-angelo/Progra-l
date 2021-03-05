using System;

namespace adnum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado;

            Console.WriteLine("Piense en un numero, y no lo comente con nadie");
            Console.ReadKey();
            Console.WriteLine("Multiplicar por 2");
            Console.ReadKey();
            Console.WriteLine("Sumele 8");
            Console.ReadKey();
            Console.WriteLine("Multiplicalo por 5");
            Console.ReadKey();

            Console.Write("Ingrese el resultado: ");
            numero = Convert.ToInt32(Console.ReadLine());
            numero = numero / 10;
            resultado = numero - 4;

            Console.WriteLine("El numero que usted penso es: " + resultado);
            Console.WriteLine("gracias por jugar con nosiotros");

            Console.ReadKey();
        }
    }
}
