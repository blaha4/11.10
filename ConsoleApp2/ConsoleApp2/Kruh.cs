using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Kruh
    {
        private double polomer;

        public double Polomer
        {
            get { return polomer; } 
            set {
                if (value <= 0)
                    throw new ArgumentException("blabala");
                polomer = value;
            }
            
        }

        public Kruh(double polomer)
        {
            Polomer = polomer;
        }



    }
}
