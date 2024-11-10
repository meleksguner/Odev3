using System;

class Program
{
    static void Main()
    {
        int toplam = 0;
        string sayilar = ""; // Girilen sayıları saklamak için bir string

        while (true)
        {
            Console.Write("Pozitif bir tam sayı girin (Çıkmak için 0 girin): ");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi == 0)
            {
                break; // Giriş 0 ise döngüden çık
            }
            else if (sayi > 0)
            {
                toplam += sayi; // Sayıyı toplama ekle
                sayilar += sayi + " "; // Sayıyı string değişkene ekle
            }
            else
            {
                Console.WriteLine("Lütfen sadece pozitif tam sayılar girin.");
            }
        }

        Console.WriteLine("\nGirilen pozitif sayıların toplamı: " + toplam);
        Console.WriteLine("Girilen pozitif sayılar: " + sayilar);
    }
}

