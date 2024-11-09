using System;
using System.Collections;

class Program
{
    static void Main()
    {
        
        ArrayList sayilar = new ArrayList { 10, 20, 30, 40, 50 };

        int toplam = 0;

       
        foreach (int sayi in sayilar)
        {
            Console.WriteLine("Sayı: " + sayi);
            toplam += sayi;
        }

       
        Console.WriteLine("Sayıların Toplamı: " + toplam);
    }
}

