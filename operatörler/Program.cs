using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatörler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // atama ve işlemli atama
            int x = 2;
            int y = 3;
            y = y + 2;
            y += 2;

            y /= 1;
            x *= 2;
            Console.WriteLine(x);
            Console.WriteLine(y);

            // mantıksal  operatörler
            // ' || &
            bool insuccess = true;
            bool incompleted = false;
            if (insuccess && incompleted)
            {
                Console.WriteLine("perfect");
            }if (insuccess || incompleted)
            {
                Console.WriteLine("great");
            }if (insuccess && !incompleted) { 
                Console.WriteLine("fine");
            }
            // ilişkisel operatörler
            // == <> >=
            int a = 4;
            int c = 9;
            bool sonuc=  a<c;

            Console.WriteLine(sonuc);
            sonuc = a == c;
            Console.WriteLine(sonuc);
            sonuc = a > c;
            Console.WriteLine(sonuc);

            // aritmetik operatörler
            //+-*/
            int h = 10;
            int b = 5;
            int sonuc1 = h / b;
            Console.WriteLine(sonuc1);
            sonuc1 = h * b;
            Console.WriteLine(sonuc1);
            sonuc1 = h - b;
            Console.WriteLine(sonuc1);


            // % mod satır kalan getirme
            int sonuc3 = 89 % 5;
            Console.WriteLine(sonuc3);











            Console.Read();
        }
    }
}
