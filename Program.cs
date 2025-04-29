// See https://aka.ms/new-console-template for more information


// TODO: İLK HAFTA ÖDEV ---------------------------------------
// TODO: 1. ODEV

// Console.WriteLine("Adınız ve Soyadınız? ");
// string ad = Console.ReadLine();
// Console.WriteLine("teşekkürler " +ad);
//
//
//
//
// Console.WriteLine("lütfen yaşınızı belirtin");
// int yas = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("yanıtınız için teşekküler");
//
//
//
//
//
// string programTuru = "";
// if (yas < 24)
// {
//     programTuru = "genç";
// }
//
// else
// {
//     programTuru= "yetişkin";
// }
//
//
//
//
// Console.WriteLine("Hangi semmte ikamet ediyorsunuz");
// string semt = Console.ReadLine();
//
//
//
// Console.WriteLine("kayıt olmak istdiğiniz aktiviteleri seçiniz");
// Console.WriteLine("judo için 1");
// Console.WriteLine("tekvando için 2");
// Console.WriteLine("karate için 3");
//
//
// int aktiviteler = Convert.ToInt32(Console.ReadLine());
// string aktiviteAdi = "";
//
// if (aktiviteler == 1)
// {
//     aktiviteAdi = "judo";
// }
//
// if (aktiviteler == 2)
// {
//     aktiviteAdi = "tekvando";
// }
//
// if (aktiviteler == 3)
// {
//     aktiviteAdi = "karate";
// }
// Console.Clear();
//
// Console.WriteLine($"Sayın: {ad}, {semt} semtinde, {aktiviteAdi} {programTuru}ler programı için kaydınız alınmıştır." );

// todo 2. ödev --------------------------------------------------

// using System.ComponentModel.Design;
// using System.Globalization;
// using System.Threading.Channels;

// string takipNo = "";
// var takipNo2 = false;
// while (true)
// {
//     Console.WriteLine("Takip Numarası Girin");
//     takipNo = Console.ReadLine();
//
//     if (takipNo.Length > 20)
//     {
//         Console.WriteLine("Takip Numarası Uzunluğu En Fazla 20 Karakter Olabilir, Lütfen Tekrar Deneyiniz");
//     }
//     else
//     {
//         break;
//     }
//
// }
//
//
//
// Console.WriteLine("alıcı ismi soy ismi girin");
// string alici = Console.ReadLine();
//
// Console.WriteLine("gönderici ismi soy ismi girin");
// string gonderici = Console.ReadLine();
//
//
// Console.WriteLine("açıklama girin");
// String aciklama = Console.ReadLine();
//
// Console.Clear();
//
// Console.WriteLine($"kargo takip numarası: {takipNo}");
// Console.WriteLine($"gönderici: {gonderici}");
// Console.WriteLine($"alıcı: {alici}");
// Console.WriteLine($"aciklama: {aciklama}");
//
//
// Console.Clear();
//
// if (aciklama.ToLower().Contains("kırılabilir"))
//     
//
// {
//     Console.WriteLine("kargonuz hassas gönderi olarak kayıt edilmiştir");
// }
//
// else
// {
//     Console.WriteLine("sipariş kaydınız alınmıştır en kısa sürede dağıtıma çıkacaktır");
// }




// TODO: 2. HAFTA ÖDEV 29.04.2025 -------------------------------------------------------------------------
// TODO: 1. ÖDEV

// Console.Write("ders adıı girin: ");
// string dersAdi = Console.ReadLine();
//
// NotGiris: 
//
// Console.Write("Vize notunu girin (0-100): ");
// bool vizeOk = int.TryParse(Console.ReadLine(), out int vize);
//
// Console.Write("Final notunu girin (0-100): ");
// bool finalOk = int.TryParse(Console.ReadLine(), out int final);
//
// if (!vizeOk || !finalOk || vize < 0 || vize > 100 || final < 0 || final > 100)
// {
//     Console.WriteLine("Hatalı not girişi yaptınız. Lütfen 0-100 arasında değerler girin.");
//     goto NotGiris;
// }
//
// double ortalama = vize * 0.4 + final * 0.6;
//
// string harfNotu;
//
// if (ortalama < 50)
//     harfNotu = "D";
// else if (ortalama < 60)
//     harfNotu = "C2";
// else if (ortalama < 65)
//     harfNotu = "C1";
// else if (ortalama < 70)
//     harfNotu = "B2";
// else if (ortalama < 75)
//     harfNotu = "B1";
// else if (ortalama < 85)
//     harfNotu = "A2";
// else
//     harfNotu = "A1";
//
// Console.WriteLine($"{dersAdi} dersi dönem sonu puanınız: {harfNotu}");
//
// string sonuc = (ortalama >= 50) ? "Geçtiniz" : "Kaldınız";
// Console.WriteLine(sonuc);


// TODO: 2. ÖDEV ------------------------------------------------------------------------------

// double aySonuBakiyesi = 0; 
//
//         Console.Write("Hangi ay için işlem yapmak istiyorsunuz? (1-12 arasında sayı girin): ");
//         int ayNumarasi = int.Parse(Console.ReadLine());
//
//         string[] aylar = { "", "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", 
//                                "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
//
//         if (ayNumarasi < 1 || ayNumarasi > 12)
//         {
//             Console.WriteLine("Geçersiz ay numarası. Program sonlandırılıyor.");
//             return;
//         }
//
//         Console.WriteLine($"{aylar[ayNumarasi]} ayı için işlemlere başlayabilirsiniz.");
//
//     Islemler: 
//
//         Console.WriteLine("İşlem Seçin:");
//         Console.WriteLine("1- Gelir Girişi");
//         Console.WriteLine("2- Gider Girişi");
//         Console.WriteLine("3- Bakiyeyi Görüntüle");
//
//         Console.Write("Seçiminiz: ");
//         string secim = Console.ReadLine();
//
//         switch (secim)
//         {
//             case "1":
//                 Console.Write("Gelir tutarını giriniz: ");
//                 if (double.TryParse(Console.ReadLine(), out double gelir))
//                 {
//                     aySonuBakiyesi += gelir;
//                     Console.WriteLine($"Gelir eklendi. Güncel bakiye: {aySonuBakiyesi} TL");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Geçersiz tutar girdiniz!");
//                 }
//                 goto Islemler;
//
//             case "2":
//                 Console.Write("Gider tutarını giriniz: ");
//                 if (double.TryParse(Console.ReadLine(), out double gider))
//                 {
//                     aySonuBakiyesi -= gider;
//                     Console.WriteLine($"Gider çıkarıldı. Güncel bakiye: {aySonuBakiyesi} TL");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Geçersiz tutar girdiniz!");
//                 }
//                 goto Islemler;
//
//             case "3":
//                 Console.WriteLine($"{aylar[ayNumarasi]} ayı sonu bakiyeniz: {aySonuBakiyesi} TL");
//
//                 string borcDurumu = (aySonuBakiyesi < 0) 
//                     ? "Bu ay ödemeniz gereken borçlarınız var!" 
//                     : "Mali durumunuz iyi görünüyor!";
//                 
//                 Console.WriteLine(borcDurumu);
//                 break;
//
//             default:
//                 Console.WriteLine("Geçersiz seçim yaptınız!");
//                 goto Islemler;
//         }
//
//         Console.WriteLine("Program sona erdi.");



// TODO: 3. ÖDEV -------------------------------------------------------------------------


// double acilisUcreti = 150; // Açılış ücreti
// double kmUcreti = 25;      // Kilometre başına ücret
//
// Console.WriteLine("Taksimetre Uygulamasına Hoşgeldiniz!");
//
//
// Console.Write("Gidilen mesafeyi (km) giriniz: ");
// double mesafe = double.Parse(Console.ReadLine());
//
//
// if (mesafe < 0)
// {
//     Console.WriteLine("Mesafe negatif olamaz. Lütfen geçerli bir mesafe giriniz.");
//     return;
// }
//
//
// double toplamUcret = acilisUcreti + (mesafe * kmUcreti);
//
//
// Console.Write("Gece tarifesi uygulanacak mı? (Evet/Hayır): ");
// string geceTarife = Console.ReadLine().ToLower();
//
//
// if (geceTarife == "evet")
// {
//     toplamUcret *= 1.20; // %20 artış
// }
//
//
// Console.WriteLine($"Toplam ücret: {toplamUcret} TL");


// TODO: 4. ÖDEV --------------------------------------------

// Console.WriteLine("Ehliyet Uygunluğu Kontrolü");
//
//
// Console.Write("Yaşınızı giriniz: ");
// int yas = int.Parse(Console.ReadLine());
//
// Console.Write("Sağlık durumunuzu (evet/hayır) giriniz: ");
// string saglikDurumu = Console.ReadLine().ToLower();
//
// Console.Write("Sabıka kaydınız var mı? (evet/hayır) giriniz: ");
// string sabikaDurumu = Console.ReadLine().ToLower();
//
//
// if (yas >= 18 && saglikDurumu == "evet" && sabikaDurumu == "hayır")
// {
//     Console.WriteLine("Ehliyet alabilirsiniz.");
// }
// else
// {
//     Console.WriteLine("Ehliyet alamazsınız.");
// }




// TODO: 5. ÖDEV -------------------------------------------------------

// string kullaniciAdi = "admin";
// string sifre = "123456";
// string kullaniciAdiInput, sifreInput;
//
//
// girisKontrol: 
//
// Console.WriteLine("Kullanıcı adı: ");
// kullaniciAdiInput = Console.ReadLine();
//
// Console.WriteLine("Şifre: ");
// sifreInput = Console.ReadLine();
//
// Console.Clear();
// if (kullaniciAdiInput == kullaniciAdi && sifreInput == sifre)
// {
//     Console.WriteLine("Giriş başarılı.");
// }
// else
// {
//     Console.WriteLine("Lütfen bilgileriniz kontrol ediniz.");
//     
//     goto girisKontrol;
// }



// todo: 6. ödev -----------------------------


// Console.WriteLine("Üyelik durumunu giriniz (evet/hayır): ");
// string uyeDurumu = Console.ReadLine().ToLower();
//
// Console.WriteLine("Alışveriş tutarını giriniz: ");
// int alisverisTutari = int.Parse(Console.ReadLine());
//
// Console.WriteLine("İlk defa alışveriş yapıyor musunuz? (evet/hayır): ");
// string ilkDefaAlisveris = Console.ReadLine().ToLower();
//
//
// if ((uyeDurumu == "evet" && alisverisTutari > 1000) || ilkDefaAlisveris == "evet")
// {
//     
//     double indirimliTutar = alisverisTutari * 0.85;
//     Console.WriteLine($"Kampanya kazandınız! %15 indirim uygulandı. Ödemeniz gereken tutar: {indirimliTutar} TL");
// }
// else
// {
//     Console.WriteLine($"Kampanyadan yararlanamıyorsunuz. Ödemeniz gereken tutar: {alisverisTutari} TL");
// }