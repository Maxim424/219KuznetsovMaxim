using System;

namespace Task01
{

    class MyComplex
    {
        private double im;
        private double re;

        public double Re { get => re; set => re = value; }
        public double Im { get => im; set => im = value; }

        public MyComplex(double xre = 0, double xim = 0)
        {
            re = xre;
            im = xim;
        }

        public static MyComplex operator ++(MyComplex mc)
        {
            return new MyComplex(mc.Re + 1, mc.Im + 1);
        }

        public static MyComplex operator --(MyComplex mc)
        {
            return new MyComplex(mc.re - 1, mc.im - 1);
        }

        public double Mod()
        {
            return Math.Abs(re * re + im * im);
        }

        static public bool operator true(MyComplex f)
        {
            if (f.Mod() > 1.0)
                return true;
            return false;
        }
        static public bool operator false(MyComplex f)
        {
            if (f.Mod() <= 1.0) return true;
            return false;
        }

        static public MyComplex operator +(MyComplex mc1, MyComplex mc2)
        {
            return new MyComplex(mc1.Re + mc2.Re, mc1.Im + mc2.Im);
        }

        static public MyComplex operator -(MyComplex mc1, MyComplex mc2)
        {
            return new MyComplex(mc1.Re - mc2.Re, mc1.Im - mc2.Im);
        }

        static public MyComplex operator *(MyComplex mc1, MyComplex mc2)
        {
            return new MyComplex(mc1.Re*mc2.Re - mc1.Im*mc2.Im, mc1.Im*mc2.Re +mc1.Re*mc2.Im);
        }

        static public MyComplex operator /(MyComplex mc1, MyComplex mc2)
        {
            return new MyComplex((mc1.Re*mc2.Re + mc1.Im*mc2.Im)/(mc2.Re* mc2.Re + mc2.Im * mc2.Im), (mc1.Im*mc2.Re - mc1.Re*mc2.Im)/(mc2.Re * mc2.Re + mc2.Im * mc2.Im));
        }

        public override string ToString()
        {
            return Re + " " + Im;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
