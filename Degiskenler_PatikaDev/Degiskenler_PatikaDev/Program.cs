using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler_PatikaDev
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* --- İlk program :
             
            Console.WriteLine("Elektrik");
            Console.WriteLine("Enter your Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Surname :");
            string surname = Console.ReadLine();

            Console.ReadLine(); */

            //---- Değişkenler 

            // örnek 1-
             int deger;
              deger = 2024;

              Console.WriteLine(deger);
              Console.ReadLine(); 

            // örnek 2-
              byte b = 5;


               char c= '2';    // 2 byte yer kaplar.


               bool b1 = true;

               DateTime dt = DateTime.Now;
               Console.WriteLine(dt);


               // obje değerleri :

               object a1 = "x";
               object a2 = 'y';
               object a3 = 4;
               Console.WriteLine(a1); Console.WriteLine(a2); Console.WriteLine(a3);

               Console.ReadLine(); 

             // örnek 3 - string ifadeler

               string str = null;
               string str1 = string.Empty;  // değerini boş yapar.
               str1 = "esmanur";
               string ad = "esma";
               string soyad = "bingol"; 

              // int tanımlama şekilleri

               int int1 = 24;
               int int2 = 23;
               int int3 = int2 * int1;

               // boolean

               bool b1 = 10 < 2; 

               // değişken dönüşümleri:


               string str10 = "2025";
               int int10 = 20;

               string yeniDeger = str10 + int10.ToString();
               int yeniDeger2 = int10 + Convert.ToInt32(str10);

               Console.WriteLine(yeniDeger);
               Console.WriteLine(yeniDeger);
               Console.ReadLine();

               int int22 = int10 + int.Parse(str10); // çıktısı 2045 olacak
               Console.WriteLine(int22); Console.ReadLine(); */

            // dateTime:

            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);  


            string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTime2); 

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
            Console.ReadLine();

            string t1est; 
        }
    }
}
