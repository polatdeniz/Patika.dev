using System;

namespace MyConsoleProject
{
    internal class TypeConversions
    {
        public static void Main(string [] args)
        {
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c;
            Console.WriteLine("d: " + d);

            long h = d ;
            Console.WriteLine("h: " + h);

            float i = h ;
            Console.WriteLine("i: " + 1);

            string e = "Deniz";
            char f = 'P';
            object g = e+f+d;
            Console.WriteLine("g: " + g);


            int x = 4;
            byte y = (byte) x;
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte) z;
            Console.WriteLine("t: " + t);

            float w = 10.3f;
            byte v = (byte) w;
            Console.WriteLine("v: " + v);
            
            
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);

            string zz = 12.51.ToString();
            Console.WriteLine("zz: " + zz);
            

            string s1 = "10", s2 = "20";
            int i1, i2;
            int Toplam;

            i1 = Convert.ToInt32(s1);
            i2 = Convert.ToInt32(s2);

            Toplam = i1 + i2;
            Console.WriteLine("Toplam:" + Toplam);

            ParseMethod();
        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;
            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            Console.WriteLine("rakam1: " + rakam1);
            Console.WriteLine("doublel: " + double1);
        }
    }
}
