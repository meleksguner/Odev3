using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bir sayı giriniz.");
        
        int n= Convert.ToInt32(Console.ReadLine());

        int a = 0;
        int b = 1;
        int c;

        Console.WriteLine(a + "\n" + b);
        for (int i=2; i<n; i++)
        {
            c = a + b;
            Console.WriteLine(c);
            a = b;
            b=c;

        }
        Console.ReadLine();



    }
}