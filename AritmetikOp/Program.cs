/*int a = 10;
int b = 5;
int c = 20;
var total = (c - a) * b;
Console.WriteLine(total);
*/
//*******************************************
/*
int? a = null;
int b = 20;

var total = (a ?? 0) + b;
Console.WriteLine(total);
*/
//*******************************************
/*
int a = 10;
int b = 20;

a = b--;

Console.WriteLine(a);
Console.WriteLine(b);
*/
//*******************************************

/*Console.Write("Sayı:");
int sayi = int.Parse(Console.ReadLine() ?? "0");
var total = sayi % 2;

Console.WriteLine(total);
*/
//*******************************************

/*double sonuc;

sonuc = Math.Pow(2, 3); // 2 üssü 3
sonuc = Math.Sqrt(16); // 16'nın karekökü
sonuc = Math.Abs(-10); // -10'un mutlak değeri
sonuc = Math.Round(4.5); // 4.5'in yuvarlanması
sonuc = Math.Round(4.6); // 4.6'nın yuvarlanması
sonuc = Math.Round(4.4); // 4.4'ün yuvarlanması
sonuc = Math.Ceiling(4.4); // 4.4'ün yukarı yuvarlanması
sonuc = Math.Floor(4.6); // 4.6'nın aşağı yuvarlanması
sonuc = Math.Max(10, 20); // 10 ve 20'nin maksimumu
sonuc = Math.Min(10, 20); // 10 ve 20'nin minimumu

Console.WriteLine(sonuc);
*/
//*******************************************
/*
int a = 5, b = 5, c = 10, d = 3;
string username = "aslıclkgl";
string password = "1234";

var sonuc = (a == b);
sonuc = (c == d);
sonuc = (username == "aslıclkgl");
sonuc = (password == "1234");

sonuc = (a != b);
sonuc = (a > c);
sonuc = (a < c);
sonuc = (a >= b);

var sonuc2 = (a > b) ? "a büyük" : (a == b) ? "a b eşit" : "b büyük";

Console.WriteLine(sonuc2);
*/
//*******************************************

// Console.Write("Yaşınızı giriniz: ");
// var yas = Convert.ToInt32(Console.ReadLine());

// var sonuc = (yas >= 18) ? "Ehliyet alabilirsiniz." : "Ehliyet alamazsınız.";
// Console.WriteLine(sonuc);

//*******************************************

// Console.Write("Bir sayı giriniz: ");

// var num = Convert.ToInt32(Console.ReadLine());

// var sonuc = (num > 0) ? "Sayı pozitif" : "Sayı negatif";

// Console.WriteLine(sonuc);

//*******************************************

// Console.Write("Bir sayı giriniz: ");

// var num = Convert.ToInt32(Console.ReadLine());

// var sonuc = (num % 2 == 0) ? "Sayı çift" : "Sayı tek";

// Console.WriteLine(sonuc);

//*******************************************

// var a = true;
// var b = false;
// var c = true;
// var d = false;

// var sonuc = (a && c);
// sonuc = (a && c);
// sonuc = (b && d);

// sonuc = (a || b);
// sonuc = (b || d);
// sonuc = (c || d);

// sonuc = !c;

// Console.WriteLine(sonuc);

//*******************************************

// int age = 17;
// bool permission = true;

// bool age_perm = (age >= 18);
// bool parentperm = (permission);

// var total = (age_perm || parentperm) ? "Çalışabilir" : "Çalışamaz";

// Console.WriteLine(total);

//*******************************************

// int not = 50;

// bool kosul1 = (not >= 50);
// bool kosul2 = (not <= 100);

// var sonuc = (kosul1 && kosul2) ? "Geçti" : "Kaldı";

// Console.WriteLine(sonuc);

//*******************************************

// int ortalama = 70;
// int zayif = 1;

// var sonuc = (ortalama >= 70 && zayif == 0) ? "Teşekkür alabilir" : "Teşekkür alamaz ";

// Console.WriteLine(sonuc);

//*******************************************

// string education = "Lisans";

// bool cigarette = true;

// var sonuc = ((education == "Lisans" || education == "Önlisans") && (!cigarette)) ? "İşe girebilir" : "İşe giremez";

// Console.WriteLine(sonuc);

//*******************************************

// string email = "aslı@gmail.com";
// string username = "aslıclkgl";
// string password = "1234";

// var sonuc = ((email == "aslı@gmail.com" || username == "aslıclkgl") && (password == "1234")) ? "Giriş Başarılı" : "Giriş Başarısız";

// Console.WriteLine(sonuc);

//*******************************************

// string [] takimlar = { "Galatasaray", "Fenerbahçe", "Beşiktaş", "Trabzonspor" };
// var rnd = new Random();

// int num = rnd.Next(3); 

// Console.WriteLine(takimlar[num]);

//*******************************************

