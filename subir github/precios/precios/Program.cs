using System;

namespace precios
{
    class Program
    {
        static void Main(string[] args)
        {
            int precio, descuento, total;

            Console.Write("cantidad gastada:");
            precio = Convert.ToInt32(Console.ReadLine());
            descuento = precio * 20 / 100;

            if (precio > 300)
            {
                total = precio - descuento;
                Console.WriteLine("El total con descuento es de: " + total);
            }
            else
            {
                total = precio;
                Console.WriteLine("El total sin descuento es de: " + total);
            }

            Console.ReadKey();
        }
    }
}
