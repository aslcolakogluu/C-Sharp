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
string[] sehirler = { "Ankara,İstanbul,İzmir" };
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

