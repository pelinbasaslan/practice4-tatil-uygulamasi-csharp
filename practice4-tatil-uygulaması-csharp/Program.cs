
bool programDevam = true;
while (programDevam)
{
    Console.WriteLine("Tatilinizi kaçırmayın!");
    Console.WriteLine("3 adet lokasyonumuz var. Bu lokasyonlar Bodrum, Marmaris, Çeşme.");
    Console.WriteLine("Hangi lokasyona gitmek istiyorsunuz?");
    string lokasyon = Console.ReadLine().ToLower();
    while (lokasyon != "çeşme" && lokasyon != "marmaris" && lokasyon != "bodrum")
    {
        Console.WriteLine("Girdiğiniz veride bir lokasyon yok. Lokasyonlar Bodrum, Marmaris ve Çeşme'dir.");
        Console.WriteLine("Lütfen tekrardan veri giriniz:");
        lokasyon = Console.ReadLine().ToLower();
    }
    Console.WriteLine("Kaç kişi için plan yapmayı düşünüyorsun?");
    int numPeople = Convert.ToInt32(Console.ReadLine());
    int lokasyonPrice = 0;

    switch (lokasyon)
    {
        case "bodrum":
            Console.WriteLine($"Gitmek istediğiniz lokasyonunuz {lokasyon}");
            lokasyonPrice = 4000;
            Console.WriteLine($"Paket başlangıç fiyatı {lokasyonPrice} TL");
            Console.WriteLine("Bodrum, muhteşem plajları ve tarihi dokusuyla her yaz tatilcilerin vazgeçilmez adresi olmuştur.");
            break;
        case "marmaris":
            Console.WriteLine($"Gitmek istediğiniz lokasyonunuz {lokasyon}");
            lokasyonPrice = 3000;
            Console.WriteLine($"Paket başlangıç fiyatı {lokasyonPrice} TL");
            Console.WriteLine("Marmaris, eşsiz doğası, turkuaz rengi denizi ve hareketli gece hayatıyla tatilcilerin gözdesi haline gelmiştir.");
            break;
        case "çeşme":
            Console.WriteLine($"Gitmek istediğiniz lokasyonunuz {lokasyon}");
            lokasyonPrice = 5000;
            Console.WriteLine($"Paket başlangıç fiyatı {lokasyonPrice} TL");
            Console.WriteLine("Çeşme, berrak denizi, ünlü Alaçatı sokakları ve termal su kaynaklarıyla huzurlu bir tatil arayanların tercih ettiği bir cennet köşesidir.");
            break;
    }
    int priceKaraYolu = 1500;
    int priceHavaYolu = 4000;
    string gidisKaraYaDahava;
    do
    {
        Console.WriteLine("Tatile ne şekilde gitmek istiyorsunuz?");
        Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");
        Console.WriteLine("2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
        Console.WriteLine("Lütfen yukarıdaki seçeneklerden bir tanesini seçiniz(1,2).");
        gidisKaraYaDahava = Console.ReadLine();
    } while (gidisKaraYaDahava != "1" && gidisKaraYaDahava != "2");

    switch (gidisKaraYaDahava)
    {
        case "1":
            Console.WriteLine($"Gidilecek lokasyon: {lokasyon}, kişi sayısı: {numPeople}, kara yolu ile kişi başı tutar {priceKaraYolu} liradan; {(lokasyonPrice + priceKaraYolu) * numPeople}");
            break;
        case "2":
            Console.WriteLine($"Gidilecek lokasyon: {lokasyon}, kişi sayısı: {numPeople}, hava yolu ile kişi başı tutar {priceHavaYolu} liradan; {(lokasyonPrice + priceHavaYolu) * numPeople}");
            break;
    }

    string tatilDevam = "";

    do
    {
        Console.WriteLine("Başka bir tatil planı yapmak istiyor musunuz?");
        tatilDevam = Console.ReadLine().ToLower();
        if (tatilDevam == "evet")
        {
            programDevam = true;
        }
        else if (tatilDevam == "hayır")
        {
            programDevam = false;
            Console.WriteLine("Bizi tercih ettiğiniz için teşekkürler. İyi Günler.");
        }
        else
        {
            Console.WriteLine("Yanlış girdi.");
        }
    } while (tatilDevam != "evet" && tatilDevam != "hayır");

}









/*using System;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tatilinizi kaçırmayın!");
        Console.WriteLine("3 adet lokasyonumuz var. Bu lokasyonlar Bodrum, Marmaris, Çeşme.");
        Console.WriteLine("Hangi lokasyona gitmek istiyorsunuz?");
        string lokasyon = Console.ReadLine().ToLower();
        while (lokasyon != "çeşme" && lokasyon != "marmaris" && lokasyon != "bodrum")
        {
            Console.WriteLine("Girdiğiniz veride bir lokasyon yok. Lokasyonlar Bodrum, Marmaris ve Çeşme'dir.");
            Console.WriteLine("Lütfen tekrardan veri giriniz:");
            lokasyon = Console.ReadLine().ToLower();
        }
        Console.WriteLine("Kaç kişi için plan yapmayı düşünüyorsun?");
        int numPeople = Convert.ToInt32(Console.ReadLine());
        int lokasyonPrice = 0;

        switch (lokasyon)
        {
            case "bodrum":
                Console.WriteLine($"Gitmek istediğiniz lokasyonunuz {lokasyon}");
                lokasyonPrice = 4000;
                Console.WriteLine($"Paket başlangıç fiyatı {lokasyonPrice} TL");
                Console.WriteLine("Bodrum, muhteşem plajları ve tarihi dokusuyla her yaz tatilcilerin vazgeçilmez adresi olmuştur.");
                break;
            case "marmaris":
                Console.WriteLine($"Gitmek istediğiniz lokasyonunuz {lokasyon}");
                lokasyonPrice = 3000;
                Console.WriteLine($"Paket başlangıç fiyatı {lokasyonPrice} TL");
                Console.WriteLine("Marmaris, eşsiz doğası, turkuaz rengi denizi ve hareketli gece hayatıyla tatilcilerin gözdesi haline gelmiştir.");
                break;
            case "çeşme":
                Console.WriteLine($"Gitmek istediğiniz lokasyonunuz {lokasyon}");
                lokasyonPrice = 5000;
                Console.WriteLine($"Paket başlangıç fiyatı {lokasyonPrice} TL");
                Console.WriteLine("Çeşme, berrak denizi, ünlü Alaçatı sokakları ve termal su kaynaklarıyla huzurlu bir tatil arayanların tercih ettiği bir cennet köşesidir.");
                break;
        }

        int priceKaraYolu = 1500;
        int priceHavaYolu = 4000;
        string gidisKaraYaDahava;
        do
        {
            Console.WriteLine("Tatile ne şekilde gitmek istiyorsunuz?");
            Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");
            Console.WriteLine("2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
            Console.WriteLine("Lütfen yukarıdaki seçeneklerden bir tanesini seçiniz(1,2).");
            gidisKaraYaDahava = Console.ReadLine();
        } while (gidisKaraYaDahava != "1" && gidisKaraYaDahava != "2");

        switch (gidisKaraYaDahava)
        {
            case "1":
                Console.WriteLine($"Gidilecek lokasyon: {lokasyon}, kişi sayısı: {numPeople}, kara yolu ile kişi başı tutar {priceKaraYolu} liradan; {(lokasyonPrice + priceKaraYolu) * numPeople}");
                break;
            case "2":
                Console.WriteLine($"Gidilecek lokasyon: {lokasyon}, kişi sayısı: {numPeople}, hava yolu ile kişi başı tutar {priceHavaYolu} liradan; {(lokasyonPrice + priceHavaYolu) * numPeople}");
                break;
        }

        string tatilDevam;

        do
        {
            Console.WriteLine("Başka bir tatil planı yapmak istiyor musunuz?");
            tatilDevam = Console.ReadLine().ToLower();
            if (tatilDevam == "evet")
            {
                Console.WriteLine("Tatilinizi kaçırmayın!");
                Console.WriteLine("3 adet lokasyonumuz var. Bu lokasyonlar Bodrum, Marmaris, Çeşme.");
                Console.WriteLine("Hangi lokasyona gitmek istiyorsunuz?");
                string lokasyon2 = Console.ReadLine().ToLower();
                while (lokasyon2 != "çeşme" && lokasyon2 != "marmaris" && lokasyon2 != "bodrum")
                {
                    Console.WriteLine("Girdiğiniz veride bir lokasyon yok. Lokasyonlar Bodrum, Marmaris ve Çeşme'dir.");
                    Console.WriteLine("Lütfen tekrardan veri giriniz:");
                    lokasyon2 = Console.ReadLine().ToLower();
                }
                Console.WriteLine("Kaç kişi için plan yapmayı düşünüyorsun?");
                int numPeople2 = Convert.ToInt32(Console.ReadLine());
                int lokasyonPrice2 = 0;

                switch (lokasyon2)
                {
                    case "bodrum":
                        Console.WriteLine($"Gitmek istediğiniz lokasyonunuz {lokasyon2}");
                        lokasyonPrice2 = 4000;
                        Console.WriteLine($"Paket başlangıç fiyatı {lokasyonPrice2} TL");
                        Console.WriteLine("Bodrum, muhteşem plajları ve tarihi dokusuyla her yaz tatilcilerin vazgeçilmez adresi olmuştur.");
                        break;
                    case "marmaris":
                        Console.WriteLine($"Gitmek istediğiniz lokasyonunuz {lokasyon2}");
                        lokasyonPrice2 = 3000;
                        Console.WriteLine($"Paket başlangıç fiyatı {lokasyonPrice2} TL");
                        Console.WriteLine("Marmaris, eşsiz doğası, turkuaz rengi denizi ve hareketli gece hayatıyla tatilcilerin gözdesi haline gelmiştir.");
                        break;
                    case "çeşme":
                        Console.WriteLine($"Gitmek istediğiniz lokasyonunuz {lokasyon2}");
                        lokasyonPrice2 = 5000;
                        Console.WriteLine($"Paket başlangıç fiyatı {lokasyonPrice2} TL");
                        Console.WriteLine("Çeşme, berrak denizi, ünlü Alaçatı sokakları ve termal su kaynaklarıyla huzurlu bir tatil arayanların tercih ettiği bir cennet köşesidir.");
                        break;
                }

                int priceKaraYolu2 = 1500;
                int priceHavaYolu2 = 4000;
                string gidisKaraYaDahava2;
                do
                {
                    Console.WriteLine("Tatile ne şekilde gitmek istiyorsunuz?");
                    Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");
                    Console.WriteLine("2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
                    Console.WriteLine("Lütfen yukarıdaki seçeneklerden bir tanesini seçiniz(1,2).");
                    gidisKaraYaDahava2 = Console.ReadLine();
                } while (gidisKaraYaDahava2 != "1" && gidisKaraYaDahava2 != "2");

                switch (gidisKaraYaDahava2)
                {
                    case "1":
                        Console.WriteLine($"Gidilecek lokasyon: {lokasyon2}, kişi sayısı: {numPeople2}, kara yolu ile kişi başı tutar {priceKaraYolu2} liradan; {(lokasyonPrice2 + priceKaraYolu2) * numPeople2}");
                        break;
                    case "2":
                        Console.WriteLine($"Gidilecek lokasyon: {lokasyon2}, kişi sayısı: {numPeople2}, hava yolu ile kişi başı tutar {priceHavaYolu2} liradan; {(lokasyonPrice2 + priceHavaYolu2) * numPeople2}");
                        break;
                }
            }
            else if (tatilDevam == "hayır")
            {
                Console.WriteLine("İyi Günler!");
            }
            else
            {
                Console.WriteLine("Geçersiz bir veri girdiniz.");
            }

        } while (tatilDevam != "evet" && tatilDevam != "hayır");



    }
}

*/
