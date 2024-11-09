using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Bir cümle giriniz: ");
        string cumle = Console.ReadLine();


        string[] kelimeler = cumle.Split(' ');

        
        int kelimeSayisi = kelimeler.Length;

        
        Console.WriteLine("Cümledeki kelime sayısı: " + kelimeSayisi);
    }
}

