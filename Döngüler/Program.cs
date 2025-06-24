//For döngüsü

// var sum = 0;

// for (var i = 1; i <= 100;i++) {

//     sum += i;
//     Console.WriteLine(sum);
//
//****************************************

// Console.WriteLine("Başlangıç: ");
// var start = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Bitiş: ");
// var end = Convert.ToInt32(Console.ReadLine());

// var sum = 0;

// for (var i = start; i < end; i++)
// {
//     sum += i;

// }

// Console.WriteLine("Toplam: " + sum);

//****************************************

// string[] isimler = { "Ali", "Ayşe", "Fatma", "Mehmet", "Hasan" };

// for (var i = 0; i < 5; i++)
// {
//     Console.WriteLine(isimler[i]);
// }

//****************************************

// int[] numbers = { 1, 3, 4, 33, 41, 56, 89 };

// for (var i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] % 3 == 0)
//     {
//         Console.WriteLine(numbers[i]);
//     }
// }

//****************************************

//while döngüsü


// var rnd = new Random();
// int hold = rnd.Next(1, 100);
// int guess = 3;

// while (guess > 0)
// {
//     Console.WriteLine(hold);

//     Console.Write("Sayı: ");
//     int num = Convert.ToInt32(Console.ReadLine());

//     guess--;

//     if (num == hold)
//     {
//         Console.WriteLine("Tebrikler Bildiniz!");
//         break;

//     }
//     else
//     {
//         if (guess == 0)
//         {
//             Console.WriteLine("Hakkınız Bitti!");
//             break;
//         }
//         if (hold > num)
//         {
//             Console.WriteLine("Yukarı");
//         }
//         else
//         {
//             Console.WriteLine("Aşağı");
//         }
//     }
// }

// do while döngüsü

// Console.Write("Adet:");
// int adet = Convert.ToInt32(Console.ReadLine());

// string[] urunler = new string[adet];

// int i = 0;

// do
// {
//     Console.Write("Ürün Adı:");
//     urunler[i] = Console.ReadLine() ?? "";

//     i++;
// }
// while (adet != 1);

// Console.WriteLine("Ürünler Listeleniyor...");

// for (var a = 0; a < urunler.Length; a++)
// {
//     Console.WriteLine(urunler[a]);
// }

// foreach döngüsü

// string ad = "Aslı";

// foreach (var harf in ad)
// {
//     Console.WriteLine(harf);
// }

// int[] sayilar = { 10, 20, 40, 45, 50 };

// foreach (var sayi in sayilar)
// {
//     if (sayi == 20)
//     {
//         break; // Döngüyü kırar
//     Console.WriteLine(sayi);
//     }

// }