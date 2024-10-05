using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.WriteLine("Merhaba Dünya");
            //Console.WriteLine("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String Değişkenler

            // string
            //Değişken_türü değişken_adı

            //string name;
            // name = "Ahmet";
            // Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail,city,district;

            //customerName = "Ahmet Yusuf";
            //customerSurname = "Tokgöz";
            //customerPhone = "+90 541 451 67 23";
            //district = "Alaca";
            //city = "Çorum";
            //customerEmail = "ahmetyusuftokgoz@gmail.com";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname );
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + city + "/" + district);
            //Console.WriteLine("----------------------------------------------");

            //Console.WriteLine();

            //customerName = "Ömer";
            //customerSurname = "Tokgöz";
            //customerPhone = "+90 536 737 02 30";
            //customerEmail = "omerfarukt@gmail.com";
            //district = "Osmangazi";
            //city = "Bursa";

            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + city + "/" + district);

            #endregion

            #region Int Degişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("-----Hambuger Fiyatı: " + hamburgerPrice + "TL");
            Console.WriteLine("-----Pizza Fiyatı: " + pizzaPrice + "TL");
            Console.WriteLine("-----Kola Fiyatı: " + cokePrice + "TL");
            Console.WriteLine("-----Limonata Fiyatı: " + lemonadePrice + "TL");
            Console.WriteLine("-----Kızartma Fiyatı: " + friesPrice + "TL");
            Console.WriteLine("-----Su Fiyatı: " + waterPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("***** Restoran Menü Fiyatı *****");

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int lemonadeCount;
            int friesCount;
            int pizzaCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemondaPrice;




            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalLemondaPrice = lemonadeCount * lemonadePrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemondaPrice + "TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + "TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "TL");

            Console.WriteLine("---------------------------------------------");


            int totalPrice = totalCokePrice + totalFriesPrice + totalHamburgerPrice + totalLemondaPrice + totalPizzaPrice + totalWaterPrice;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "TL");







            Console.Read();



            #endregion






           













        }
    }
}
