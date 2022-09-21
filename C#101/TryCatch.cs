using System;

namespace MyConsoleProject
{
    internal class TryCatch
    {
        public static void Main(string [] args)
        {
            try
            {
                Console.WriteLine("Bir sayi giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girdiginiz sayi: " + sayi);
            }
            catch (Exception e)
            {
                Console.WriteLine("Hata: " + e.Message.ToString());
            }
            finally
            {
                Console.WriteLine("Islem tamamlandi.");
            }

            try
            {
                // int i = int.Parse(null);
                // int i = int.Parse("deneme");
                int i = int.Parse("-200000000000");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Bos deger girdiniz...");
                Console.WriteLine(e);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Veri tipi uygun degil...");
                Console.WriteLine(e);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Cok kucuk ya da cok buyuk bir deger girdiniz...");
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Islem basariyla tamamlandi.");
            }
        }
    }
}
