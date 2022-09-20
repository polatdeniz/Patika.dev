using System;

namespace MyConsoleProject
{
    class VariablesAndDataTypes
    {
        public static void Main(string [] args)
        {
            Console.WriteLine("");

            byte b = 5;
            sbyte sb = 5;

            short s = 5;
            ushort us = 5;

            int i = 5;
            uint ui = 5;
            Int16 i16 = 5;
            Int32 i32 = 5;
            Int64 i64 = 5;

            long l = 5;
            ulong ul = 5;

            float f = 5;
            double d = 5;
            decimal de = 5;

            char c = '5';
            String str = "Deniz";

            bool b1 = false;
            bool b2 = true;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = 'a';
            object o2 = "aaaa";
            object o3 = 1;
            object o4 = 1.1;

            String str1 = string.Empty;
            str1 = "Deniz POLAT";
            string ad = "Deniz";
            string soyad = "POLAT";
            string tamIsim = ad + " " + soyad;

            int i1 = 5;
            int i2 = 5;
            int i3 = i1 * i2;

            bool bl = 10 > 5;

            string str20 = "20";
            int i20 = 20;

            string yeniDeger = str20 + i20; // sonuc 2020
            int yeniInt = i20 + Convert.ToInt16(str20); // sonuc 40
            int yeniInt2 = i20 + Int16.Parse(str20); // sonuc 40

            string dateTime = DateTime.Now.ToString();
            Console.WriteLine(dateTime);

            string dateTime2 = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
