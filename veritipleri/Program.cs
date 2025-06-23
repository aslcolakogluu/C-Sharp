Console.Write("1.Sayı: ");
var sayi1 = Convert.ToInt32(Console.ReadLine()); //string to int

Console.Write("2.Sayı: ");
var sayi2 = Convert.ToInt32(Console.ReadLine()); //string to int

var sum = sayi1 + sayi2;

Console.WriteLine("Toplam: " + sum);
//*************************************************************//

int? maas = default;
bool? isActive = null;

Console.WriteLine(maas.HasValue);
Console.WriteLine(maas.GetValueOrDefault());
Console.WriteLine(isActive.GetValueOrDefault());
