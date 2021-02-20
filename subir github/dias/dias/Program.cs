using System;

namespace dias
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia = 1;

            Console.WriteLine("Elija uno de los dias de la semana sabiendo que lunes seria #1 martes #2 etc");
            

            dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.Write("usted escogio Lunes y si es un dia laboral");
                    break;

                case 2:
                    Console.Write("usted escogio Martes y si es un dia laboral");
                    break;

                case 3:
                    Console.Write("usted escogio Miercoles y si es un dia laboral");
                    break;

                case 4:
                    Console.Write("usted escogio Jueves y si es un dia laboral");
                    break;

                case 5:
                    Console.Write("usted escogio Viernes y si es un dia laboral");
                    break;

                case 6:
                    Console.Write("usted escogio sabado y no es un dia laboral");
                    break;

                case 7:
                    Console.Write("usted escogio Domingo y no es un dia laboral");
                    break;

                case 8:

                    break;
            }
    }
}
}
