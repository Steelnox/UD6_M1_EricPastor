using System;
using System.Collections.Generic;
using System.Text;

namespace UD6_M1
{
    public class Milestone2
    {
        public void Principal()
        {
            double double_var = 4.5678;
            int int_var = (int)double_var;
            float float_var = (float)double_var;
            string string_var = double_var.ToString();

            Console.WriteLine("La variable double es " + double_var);
            Console.WriteLine("La variable int es " + int_var);
            Console.WriteLine("La variable float es " + float_var);
            Console.WriteLine("La variable string es " + string_var);
        }
    }
}
