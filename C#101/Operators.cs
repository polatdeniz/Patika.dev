using System;

namespace MyConsoleProject
{
    internal class Operators
    {
        public static void Main(string[] args)
        {
            int x = 3;
            int y = 3;
            y = y + 2;

            Console.WriteLine(y);
            y += 2;

            Console.WriteLine(y);
            y /= 2;

            Console.WriteLine(y);
            y += 2;

            Console.WriteLine(x);

            bool isSuccess = true;
            bool isCompleted = false;

            if(isCompleted && isSuccess)
                Console.WriteLine("Perfect!");
            if(isCompleted || isSuccess)
                Console.WriteLine("Great!");
            if(isCompleted && !isSuccess)
                Console.WriteLine("Fine!");

            int a = 3;
            int b = 4;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1*sayi2;
            Console.WriteLine (sonuc1);
            sonuc1 = sayi1+sayi2;
            Console.WriteLine (sonuc1);
            sayi1 += 1 ;
            sayi1++;
            Console.WriteLine (sayi1);
            int sonuc2 = 20%3 ;
            Console.WriteLine (sonuc2);
        }
    }
}
