using System;
using System.ComponentModel.Design;
class Prograam
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hesaplamak istediğiniz işlemi giriniz!");
        Console.WriteLine("İlk sayıyı giriniz:");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("İşlem operatörünü giriniz:");
        string op = Console.ReadLine();

        Console.WriteLine("İkinci sayıyı giriniz:");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (op)
        {
            case "+":
                result = sayi1 + sayi2;
                break;

            case "-":
                result = sayi1 - sayi2;
                break;

            case "*":
                result = sayi1 * sayi2;
                break;

            case "/":

                if (sayi2 != 0)
                    result = sayi1 / sayi2;

                else
                    Console.WriteLine("İkinci sayı değeri 0 olamaz.");

                break;
            default:
                Console.WriteLine("Sadece +,-,*,/ işlemlerini yapınız.");
                break;
        }

        if (op == "+" || op == "-" || op == "*" || op == "/" && sayi2 != 0)
            Console.WriteLine("Result:" + result);
        Console.ReadKey();
    }



}