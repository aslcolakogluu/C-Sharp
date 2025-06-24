// StreamReader sr = File.OpenText("deneme.txt");

// Console.WriteLine(sr.ReadLine());
// Console.WriteLine(sr.ReadLine());


// var s = "";

// while((s = sr.ReadLine()) != null)
// {
//     Console.WriteLine(s);
// }

////////////////////////////////////////7

// string sonuc = File.ReadAllText("deneme.txt");
// Console.WriteLine(sonuc);

//Dosya okuma işlemi

// using (StreamWriter sw = File.CreateText("deneme.txt"))
// {
//     sw.WriteLine("Merhaba Dünya");
//     sw.WriteLine("Merhaba C#");
//     sw.WriteLine("Merhaba Programlama Dilleri");
// }

// using (StreamWriter sw = File.AppendText("deneme.txt"))
// {
//     sw.WriteLine("Merhaba C# 10");
//     sw.WriteLine("Merhaba C# 11");
// }

// using(StreamReader sr = File.OpenText("deneme.txt"))
// {
//     var s = "";
//     while((s = sr.ReadLine()) != null)
//     {
//         Console.WriteLine(s);
//     }
// }

//Klasörle Çalışma

// Directory.CreateDirectory("denemeKlasoru");
// Directory.CreateDirectory("denemeKlasoru/altKlasor");

// Directory.Move("denemeKlasoru/altKlasor", "denemeKlasoru/yeniAltKlasor");

// string path = @"C:\Users\YourUsername\Desktop\denemeKlasoru";

// string path = Directory.GetCurrentDirectory() + "/denemeKlasoru";

// Console.WriteLine(path);
