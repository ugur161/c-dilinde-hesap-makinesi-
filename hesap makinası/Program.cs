using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesap_makinası
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hesap makinesi");
            Console.WriteLine("1. sayıyı giriniz lütfen");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" 2. sayıyı giriniz lütfen");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("yapmak istediğniz işlemi seçiniz efedim tolama=+ çıkarma=- çarpma=* bölme=/");
            string islem = Console.ReadLine();
            switch (islem)
            {
                case "+":
                    int sonuctoplam = sayi1 + sayi2;
                       Console.WriteLine($"{sayi1}+{sayi2} = "+sonuctoplam);break;
                case "-":
                  int  sonuccıkarma = sayi1 - sayi2;
                    Console.WriteLine($"{sayi1}-{sayi2} = "+sonuccıkarma); break;
                case "*":
                    int sonuccarpma = sayi1 * sayi2;
                    Console.WriteLine($"{sayi1}*{sayi2} = "+sonuccarpma); break;
                case "/":
                    int sonucbolme=sayi1 / sayi2;   
                    Console.WriteLine($"{sayi1}/{sayi2} = "+sonucbolme); break;

                default:
                    Console.WriteLine("geçersiz giriş");
                    break;
            }
            Console.ReadKey();


        }
    } 
}
