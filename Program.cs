namespace CSharp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            Console.WriteLine("Hello, World!");  //Line ile imleç bi alt satıra indi.
            Console.Write("Selam");

            Console.WriteLine("***** Yemek Kategorileri *****");
            Console.WriteLine();
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yenmekler");
            Console.WriteLine("3-Soğuk Başlangıçlar");
            Console.WriteLine("4-Salatalar");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("6-İçecekler");
            Console.WriteLine();
            Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region String Değişkenler
            string
          // Değişken_türü değişken_adı

            string name;
            name = "zeynep";
            Console.Write(name);
            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            customerName = "Erdem";
            customerSurname = "Çınar";
            customerPhone = "+90 100 200 3040";
            customerEmail = "deneme@gmail.com";
            district = "Kadıköy";
            city = "İstanbul";

            Console.WriteLine("***** Rezervasyon Kartı *****");
            Console.WriteLine();
            Console.WriteLine("********************************************");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("********************************************");
            Console.WriteLine();

            customerName = "Zeynep";
            customerSurname = "Kaya";
            customerPhone = "+90 900 800 7060";
            customerEmail = "test@gmail.com";
            district = "Beşiktaş";
            city = "İstanbul";

            Console.WriteLine("********************************************");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("********************************************");


            #endregion

            #region Int Değişkenler
            //int
            int number = 12;
            Console.WriteLine("Sayı: " + number);

            int hamburgerPrice = 300;
            int cokePrice = 50;
            int waterPrice = 10;
            int friesPrice = 100;
            int pizzaPrice = 250;
            int lemonedePrice = 35;

            Console.WriteLine("***** Menü *****");
            Console.WriteLine();
            Console.WriteLine("1-Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("2-pizza: " + pizzaPrice + " TL");
            Console.WriteLine("3-Kızartma: " + friesPrice + " TL");
            Console.WriteLine("4-Kola: " + cokePrice + " TL");
            Console.WriteLine("5-Limonata: " + lemonedePrice + " TL");
            Console.WriteLine("6-Su: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("***** Menü *****");
            Console.WriteLine();

            int hamburgerCount = 3;
            int cokeCount = 4;
            int waterCount = 2;
            int friesCount = 1;
            int pizzaCount = 1;
            int lemonedeCount = 0;
            int totalPrice = (hamburgerPrice * hamburgerCount) + (cokePrice * cokeCount) + (waterPrice * waterCount) + (friesPrice * friesCount) + (pizzaPrice * pizzaCount) + (lemonedePrice * lemonedeCount);

            Console.WriteLine("***** Sipariş Özeti *****");
            Console.WriteLine();
            Console.WriteLine("Hamburger: " + hamburgerCount + " Adet = " + hamburgerPrice * hamburgerCount + " TL");
            Console.WriteLine("Pizza: " + pizzaCount + "Adet = " + pizzaPrice * pizzaCount + " TL");
            Console.WriteLine("Kızartma: " + friesCount + " Adet = " + friesPrice * friesCount + " TL");
            Console.WriteLine("Kola: " + cokeCount + " Adet = " + cokePrice * cokeCount + " TL");
            Console.WriteLine("Limonata: " + lemonedeCount + " Adet = " + lemonedePrice * lemonedeCount + " TL");
            Console.WriteLine("Su: " + waterCount + " Adet = " + waterPrice * waterCount + " TL");
            Console.WriteLine();
            Console.WriteLine("Toplam Tutar: " + totalPrice + " TL");
            Console.WriteLine("***** Sipariş Özeti *****");

            #endregion
            Console.Read();
        }
    }
}
