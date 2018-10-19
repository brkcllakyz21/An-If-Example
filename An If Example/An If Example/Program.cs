using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace An_If_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //36.	Ekrandan girilen bir sayı eğer 5-10 arasında ise girilen sayının karesini alıp gösteren, eğer 5'ten küçük ise faktöriyelini alan, 10'dan büyük ise sayıyı ikiye bölüp bir eksiğini yazan programın algoritmasını oluşturunuz.

            double sayı = 0, fakto = 1;
            Console.Write("Sayıyı Giriniz = ");
            sayı = Convert.ToInt32(Console.ReadLine());
            if (sayı < 5)
            {
                for (int i = 1; i < sayı + 1; i++)
                {
                    fakto *= i;
                }
                Console.WriteLine("Sayının Faktoriyeli = " + fakto);
            }
            if (sayı >= 5 && sayı <= 10)
            {
                Console.WriteLine("Sayının Karesi = " + Math.Pow(sayı, 2));
            }
            if (sayı > 10)
            {
                sayı /= 2;
                sayı -= 1;
                Console.WriteLine("Sayının yarısının 1 eksiği = " + sayı);
            }




        }
    }
}
