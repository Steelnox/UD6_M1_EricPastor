using System;

namespace UD6_M1
{
    class Program
    {
        static void Main(string[] args)
        {
            Milestone1 m1 = new Milestone1();
            Milestone2 m2 = new Milestone2();
            Milestone3 m3 = new Milestone3();

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
                case "3":
                    m3.Principal();
                    break;
                default:
                    Console.WriteLine("Opción incorrecta. Vuelve a intentarlo más tarde");
                    break;
            }
        }
    }
}
