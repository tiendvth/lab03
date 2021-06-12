using System;
using System.Collections.Generic;

namespace Lab03
{
    public class Atom
    {
        public int Number { get; set; }
        public string Symbol { get; set; }
        public string FullName { get; set; }
        public float Weigth { get; set; }



        public bool Accept()
        {
            try
            {
                Console.WriteLine("Enter atomic number");
                this.Number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Symbol:");
                Console.ReadLine();
                Console.WriteLine("Enter FullName");
                Console.ReadLine();
                Console.WriteLine("Enter Atomatic weight:");
                this.Weigth = float.Parse(Console.ReadLine());

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return false;
        }

        public void Display()
        {
            Console.WriteLine($"{this.Number}{this.Symbol}{this.FullName}{this.Weigth}");
            
        }
    }
}