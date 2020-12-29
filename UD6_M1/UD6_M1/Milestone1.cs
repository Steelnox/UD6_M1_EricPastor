using System;
using System.Collections.Generic;
using System.Text;

namespace UD6_M1
{
    public class Milestone1
    {
        public void Principal()
        {
            string nom = "Eric ";
            string cognom1 = "Pastor ";
            string cognom2 = "Castillejo ";

            int dia = 10;
            int mes = 12;
            int any = 1993;

            int cantidad_bis = 0;

            bool isAñoBis = true;

            string string_bis = "es bisiesto";
            string string_nobis = "no es bisiesto";

            const int año_bisiesto = 1948;

            string nombre_junto = nom + cognom1 + cognom2;
            string año_nacimiento = dia + "/" + mes + "/" + any;

            Console.WriteLine("FASE 1--------------");
            Console.WriteLine(cognom1 + cognom2 + nom);
            Console.WriteLine(dia + "/" + mes + "/" + any);

            Console.WriteLine("FASE 2--------------");
            cantidad_bis = (any - año_bisiesto) / 4;
            Console.WriteLine("Hay {0} años bisiestos entre el año {1} y el año {2}", cantidad_bis, año_bisiesto, any);

            Console.WriteLine("FASE 3--------------");
            for (int i = año_bisiesto; i <= any; i++)
            {
                if(i % 4 != 0)
                {
                    isAñoBis = false;
                }
                else
                {
                    isAñoBis = true;
                }

                Console.Write(i + " ");
                if(isAñoBis)
                {
                    Console.WriteLine(string_bis);
                }
                else
                {
                    Console.WriteLine(string_nobis);
                }
            }
            Console.WriteLine("FASE 4--------------");
            Console.WriteLine("El meu nom és " + nombre_junto);
            Console.WriteLine("Vaig néixer el " + año_nacimiento);
            if (any % 4 == 0) Console.WriteLine("El meu any de naixement és de traspàs");
            else Console.WriteLine("El meu any de naixement no és de traspàs");
        }
    }
}
