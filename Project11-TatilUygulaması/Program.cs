//ilk olarak tatil paketlerini yazdır
Console.WriteLine("Hadi Tatil Planı Yapalım");
Console.WriteLine("Bodrum paket başlangıç fiyatı= 4000 TL");
Console.WriteLine("Marmaris paket başlangıç fiyatı= 3000 TL");
Console.WriteLine("Çeşme paket başlangıç fiyatı= 5000 TL");

int bodrum = 4000;
int marmaris = 3000;
int cesme = 5000;

Console.WriteLine("Hangi lokasyona gitmek istersiniz? (Bodrum-Marmaris-Çeşme)");


#region lokasyon seçimi
//kullanıcıya gitmek istediği yeri sor
string lokasyon = Console.ReadLine().ToLower();
int tatilfiyat = 0;
switch (lokasyon)
{
    case "bodrum":
        tatilfiyat = 4000;
        Console.WriteLine("Bodrum lokasyonu ile devam ediyoruz.");
        break;

    case "marmaris":
        tatilfiyat = 3000;
        Console.WriteLine("Marmaris lokasyonu ile devam ediyoruz.");
        break;

    case "çeşme":
        tatilfiyat = 5000;
        Console.WriteLine("Çeşme lokasyonu ile devam ediyoruz.");
        break;

    default:
        Console.WriteLine("Geçerli bir lokasyon girmediniz! Lütfen geçerli bir lokasyon adı giriniz (Bodrum-Marmaris-Çeşme)");
        break;
}

#endregion

#region Kişi Sayısı Seçimi
//Kullanıcıya kişi sayısını soruyoruz

int kullanıcı = 0;
do
{
    Console.Write("Kaç kişi için bir tatil planlıyoruz?: ");
    int.TryParse(Console.ReadLine(), out kullanıcı);
}
while (!(kullanıcı > 0));

Console.WriteLine($"{kullanıcı} kişi için tatil planlıyoruz.");
Console.WriteLine($"{lokasyon} tercihinizde kahvaltı ve akşam yemeği fiyatlarımıza dahildir.İyi tatiller. İyi eğlenceler.");

#endregion

#region Ulaşım seçimi
//Kullanıcıya ulaşım seçimini soruyoruz
Console.WriteLine($"{lokasyon} tercihinize nasıl gitmek istersiniz?  ");
Console.WriteLine("1 - Kara yolu (Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL)");
Console.WriteLine("2 - Hava yolu (Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
Console.WriteLine("Lütfen ulaşım seçiminizi '1' yada '2' şeklinde yapınız.");

byte tercih; //"1" ve "2" girişine izin vereceğimiz için byte kullanıyoruz
int Fiyat = 0;

while (true)
{
    tercih = byte.Parse(Console.ReadLine());

    if (tercih == 1 || tercih == 2)
    {
        Console.WriteLine($"{tercih} seçimi ile başarılı bir seçim yaptınız. iyi yolculuklar");
        Fiyat = (tercih == 1) ? 1500 : 4000; // tercihe göre fiyat belirleniyor.
        break;
    }
    else
    {
        Console.WriteLine("Geçersiz bir değer girdiniz, Lütfen ulaşım tercihinizi '1' yada '2' şeklinde yapınız.");
    }

}
#endregion

#region Sonuc
//Tercih edilen tatil; kişi sayısı ile çarpılarak toplam fiyat belirlenir
int toplamFiyat = kullanıcı * (Fiyat + tatilfiyat);
Console.WriteLine($"Planladığınız tatilin toplam tutarı: {toplamFiyat} TL'dir. \r\nİyi tatiller dileriz.");

#endregion

#region tekrar tatil planı
//Yeni bir tatil planı istiyor mu sorulur.
//Ve eğer istemiyorsa döngü sonlandırılır.
Console.WriteLine("Yeni bir tatil planlamak istiyoranız lütfen 'evet' yazın.");
string cevap = Console.ReadLine();

if (cevap.ToLower() == "hayır")
{
    Console.WriteLine("Tatil planlama işlemi sonlandırıldı.");
}
else if (cevap.ToLower() == "evet")
{
    Console.WriteLine("Tatil planlama işlemi başlatılıyor...");
}
else
{
    Console.WriteLine("Lütfen 'evet' veya 'hayır' olarak cevap verin.");
}

#endregion

Console.ReadKey();
