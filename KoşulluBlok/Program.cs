
// if-else

// string username = "aslı";
// string password = "1234";

// if (username == "aslı")
// {
//     if (password == "1234")
//     {
//         Console.WriteLine("Giriş başarılı");
//     }
//     else
//     {
//         Console.WriteLine("Parola yanlış");
//     }

// }
// else
// {
//     Console.WriteLine("Kullanıcı adı yanlış");
// }

// elif

// int x = 20;
// int y = 20;

// if (x > y)
// {
//     Console.WriteLine("x, y'den büyüktür");
// }
// else if (x == y)
// {
//     Console.WriteLine("x, y'e eşittir");
// }
// else
// {
//     Console.WriteLine("x, y'den küçüktür");
// }

// Console.WriteLine("Toplama için: +");
// Console.WriteLine("Çıkarma için: -");
// Console.WriteLine("Çarpma için: *");
// Console.WriteLine("Bölme için: /");

// Console.Write("İşlemi seçiniz: ");

// var secim = Console.ReadLine();

// Console.Write("Birinci sayıyı giriniz: ");
// var sayi1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("İkinci sayıyı giriniz: ");
// var sayi2 = Convert.ToInt32(Console.ReadLine());

// double sonuc = 0;
// bool ok = true;

// if (secim == "+")
// {
//      sonuc = sayi1 + sayi2;

// }
// else if (secim == "-")
// {
//      sonuc = sayi1 - sayi2;

// }
// else if (secim == "*")
// {
//      sonuc = sayi1 * sayi2;

// }
// else if (secim == "/")
// {
//     if (sayi2 == 0)
//     {
//         ok = false;
//         Console.WriteLine("Bir sayıyı 0'a bölemezsiniz.");
//     }
//     else
//     {
//         sonuc = sayi1 / sayi2;

//     }

// }
// else
// {
//     Console.WriteLine("Geçersiz işlem");
// }

// Console.WriteLine(sonuc);

// Console.Write("1.Yazılı: ");
// int not1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("2.Yazılı: ");
// int not2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Sözlü: ");
// int sozlu = Convert.ToInt32(Console.ReadLine());

// var ortalama = (not1 + not2 + sozlu) / 3;
// int not = -1;

// if (ortalama >= 0 && ortalama < 25)
// {
//     not = 0;
// } else if (ortalama >= 25 && ortalama < 45)
// {
//     not = 1;
// } else if (ortalama >= 45 && ortalama < 55)
// {
//     not = 2;
// } else if (ortalama >= 55 && ortalama < 70)
// {
//     not = 3;
// } else if (ortalama >= 70 && ortalama < 85)
// {
//     not = 4;
// } else if (ortalama >= 85 && ortalama <= 100)
// {
//     not = 5;
// }else
// {
//     Console.WriteLine("Geçersiz not aralığı");

// }

// Console.WriteLine($"Ortalamanız: {ortalama}, Notunuz: {not}");

//*******************************************

// Console.Write("a: ");

// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("b: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.Write("c: ");
// int c = Convert.ToInt32(Console.ReadLine());

// int enBuyuk = a;

// if (a > b && a > c)
// {
//     enBuyuk = a;
// }
// else if (b > a && b > c)
// {
//     enBuyuk = b;
// }
// else if (c > a && c > b)
// {
//     enBuyuk = c;
// }
// else if (a == b && a > c)
// {
//     enBuyuk = a;
// }
// else if (b == c && b > a)
// {
//     enBuyuk = b;
// }
// else if (a == c && a > b)
// {
//     enBuyuk = a;
// }
// else
// {
//     Console.WriteLine("En büyük sayı bulunamadı.");
// }

// Console.WriteLine($"En büyük sayı: {enBuyuk}");

//*******************************************/

//switch-case

int ay = 12;

switch (ay)
{
    case 1:
        Console.WriteLine("Ocak");
        break;
    case 2:
        Console.WriteLine("Şubat");
        break;
    case 3:
        Console.WriteLine("Mart");
        break;
    case 4:
        Console.WriteLine("Nisan");
        break;
    case 5:
        Console.WriteLine("Mayıs");
        break;
    case 6:
        Console.WriteLine("Haziran");
        break;
    case 7:
        Console.WriteLine("Temmuz");
        break;
    case 8:
        Console.WriteLine("Ağustos");
        break;
    case 9:
        Console.WriteLine("Eylül");
        break;
    case 10:
        Console.WriteLine("Ekim");
        break;
    case 11:
        Console.WriteLine("Kasım");
        break;
    case 12:
        Console.WriteLine("Aralık");
        break;
    default:
        Console.WriteLine("Geçersiz ay numarası.");
        break;
}

//*********************************************************

// turnary

int sayi = -9;

var sonuc = (sayi % 2 == 0) ?
                   (sayi > 0) ? "Sayı Pozitif Çift" : "Sayı Negatif Çift" :
                   (sayi > 0) ? "Sayı Pozitif Tek" : "Sayı Negatif Tek";

Console.WriteLine(sonuc);

