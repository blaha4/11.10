using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._9
{
    internal class Zlomek
    {
        int citatel { get; set; }
        int jmenovatel { get; set; }

        private Zlomek(int cita, int jmen) {
            this.citatel = cita;
            this.jmenovatel = jmen;

            if (jmenovatel == 0) { throw new ArgumentException("Jmenovatel nesmi byt 0");
            }

        }

        public static Zlomek create(int cita, int jmen)
        {
            return new Zlomek(cita,jmen);
        }

        public static Zlomek scitani(Zlomek a, Zlomek b) {
            a.citatel = a.citatel * b.jmenovatel;
            b.citatel = b.citatel * a.jmenovatel;
            a.jmenovatel = a.jmenovatel * b.jmenovatel;
            a.citatel = a.citatel + b.citatel;
            return a;

        }

        public static Zlomek odecitani(Zlomek a, Zlomek b)
        {
            a.citatel = a.citatel * b.jmenovatel;
            b.citatel = b.citatel * a.jmenovatel;
            a.jmenovatel = a.jmenovatel * b.jmenovatel;
            a.citatel = a.citatel - b.citatel;
            return a;

        }

        public static Zlomek nasobeni(Zlomek a, Zlomek b)
        {
            a.citatel = a.citatel * b.citatel;
            a.jmenovatel = a.jmenovatel * b.jmenovatel;
            return a;


        }

        public static Zlomek deleni(Zlomek a, Zlomek b) 
        {
            a.citatel = a.citatel * b.jmenovatel;
            a.jmenovatel = a.jmenovatel * b.citatel;
            return a;
        }

        public static int DelitelBeta(Zlomek a) 
        {
            int d =a.citatel > a.jmenovatel ? a.jmenovatel : a.citatel;
            while (!(a.citatel % d == 0 && a.jmenovatel % d == 0)) 
            {
                d--;
            }
            return d;
        }


        public string ToString()
        {
            if (jmenovatel < 0 && citatel > 0) { 
                return citatel + "/" + jmenovatel*(-1); 
            }
            if (jmenovatel < 0 && citatel < 0) 
            { 
                return citatel * (-1) + "/" + jmenovatel * (-1); 
            }
            else 
                return citatel + "/" + jmenovatel;
        }



    }
}
