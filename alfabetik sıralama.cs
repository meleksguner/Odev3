using System;
using System.Collections;

class Program
{
    static void Main()
    {
        
        ArrayList isimler = new ArrayList();

        
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Bir isim girin: ");
            string isim = Console.ReadLine();
            isimler.Add(isim);
        }

        
        isimler.Sort();

        
        Console.WriteLine("\nAlfabetik sıralama:");
        foreach (string isim in isimler)
        {
            Console.WriteLine(isim);
        }
    }
}
