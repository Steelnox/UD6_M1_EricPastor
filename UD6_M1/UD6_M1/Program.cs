using System;

namespace UD6_M1
{
    class Program
    {
        static void Main(string[] args)
        {
            Milestone1 m1 = new Milestone1();
            Milestone2 m2 = new Milestone2();

            string opcion = "";

            Console.WriteLine("Seleccione una milestone del 1 al 3");
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    m1.Principal();
                    break;
                case "2":
                    m2.Principal();
                    break;

                default:
                    break;
            }
        }
    }
}
