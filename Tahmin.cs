using System;
class Program
{
    static void Main()
    {

        Random sayi = new Random();
        int hedef_sayi = sayi.Next(1, 100);
        int tahmin = 0;

        Console.WriteLine("Aklınızdan 1 ile 100 arasından bir sayı tutunuz. Haydi tahmin edelim!!");
        
        while (hedef_sayi != tahmin)
        {
            Console.WriteLine("Tahmininiz:");
            tahmin = Convert.ToInt32(Console.ReadLine());


            if (tahmin < hedef_sayi)
            {
                Console.WriteLine("Daha büyük sayı giriniz!");

            }
            else if (tahmin > hedef_sayi)
            {
                Console.WriteLine("Daha küçük sayı giriniz!");

            }
            else
            {
                Console.WriteLine("Tebrikler doğru tahmin");
            }
        }
        
        Console.ReadLine();
    }

}

