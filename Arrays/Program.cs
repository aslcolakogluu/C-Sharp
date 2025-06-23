/*var kursAdi = ".net 7 ile C# programlama dersleri".Split(' ');


string[] isimler = new string[5];

isimler[0] = "Ali";
isimler[1] = "Ayşe";
isimler[2] = "Mehmet";
isimler[3] = "Fatma";
isimler[4] = "Zeynep";

int[] numaralar = new int[5];

numaralar[0] = 10;
numaralar[1] = 20;
numaralar[2] = 30;
numaralar[3] = 40;
numaralar[4] = 50;

Console.WriteLine($"{numaralar[0]} numaralı öğrencinin adı {isimler[0]}");

*/
/*string[] sehirler = { "Ankara,İstanbul,İzmir" };
int[] plakalar = { 67, 53, 41 };


//sehirler[0] = "Sakarya";
//sehirler.SetValue("Sakarya", 1);

Console.WriteLine(sehirler.GetValue(1));
Console.WriteLine(sehirler.Length);
Console.WriteLine(Array.IndexOf(sehirler, "Ankara"));

Array.Sort(sehirler);
Array.Sort(plakalar);

Array.Reverse(plakalar);

Array.Clear(sehirler);
Array.Clear(plakalar,0,1);

Console.WriteLine(plakalar.GetValue(0));
Console.WriteLine(plakalar.GetValue(1));
Console.WriteLine(plakalar.GetValue(2));   
*/
/***************************************************************************************/
/*var ogrenciler = new string[3];
var notlar = new int[3];

Console.Write("1. Öğrencinin adını giriniz: ");
ogrenciler[0] = Console.ReadLine() ?? "";

Console.Write("1. Öğrencinin notunu giriniz: ");
notlar[0] = Convert.ToInt32(Console.ReadLine());

Console.Write("2. Öğrencinin adını giriniz: ");
ogrenciler[1] = Console.ReadLine() ?? "";

Console.Write("2. Öğrencinin notunu giriniz: ");
notlar[1] = Convert.ToInt32(Console.ReadLine());

Console.Write("3. Öğrencinin adını giriniz: ");
ogrenciler[2] = Console.ReadLine() ?? "";

Console.Write("3. Öğrencinin notunu giriniz: ");
notlar[2] = Convert.ToInt32(Console.ReadLine());

foreach (var ogrenci in ogrenciler)
{
    Console.WriteLine(ogrenci);
}

foreach (var not in notlar)
{
    Console.WriteLine(not);
}

Console.WriteLine("Öğrenciler dizisinin eleman sayısı: " + ogrenciler.Length);

var not1 = notlar[0];
var not2 = notlar[1];
var not3 = notlar[2];

var ortalama = (not1 + not2 + not3) / 3;

Console.WriteLine($"Öğrencilerin not ortalaması: " + ortalama);
*/

string[] ogrenciler = { "Ali", "Ayşe", "Mehmet" };
int[,] notlar = new int[3, 3];

//ali
notlar[0, 0] = 85; // Matematik
notlar[0, 1] = 90; // Fizik
notlar[0, 2] = 78; // Kimya

//ayşe
notlar[1, 0] = 88; // Matematik
notlar[1, 1] = 92; // Fizik 
notlar[1, 2] = 80; // Kimya

//mehmet
notlar[2, 0] = 75; // Matematik
notlar[2, 1] = 85; // Fizik
notlar[2, 2] = 82; // Kimya

var ortalama_1 = (notlar[0, 0] + notlar[0, 1] + notlar[0, 2]) / 3;
var ortalama_2 = (notlar[1, 0] + notlar[1, 1] + notlar[1, 2]) / 3;
var ortalama_3 = (notlar[2, 0] + notlar[2, 1] + notlar[2, 2]) / 3;

Console.WriteLine($"{ogrenciler[0]} öğrencisinin not ortalaması: {ortalama_1}");
Console.WriteLine($"{ogrenciler[1]} öğrencisinin not ortalaması: {ortalama_2}");
Console.WriteLine($"{ogrenciler[2]} öğrencisinin not ortalaması: {ortalama_3}");