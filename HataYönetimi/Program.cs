// using System;
// using System.Collections.Generic;

// namespace HataYönetimi
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Exception
//             //System.FormatException
//             //Sytem.DivideByZeroException
//             //System.NullReferenceException

//             try
//             {
//                 Console.Write("1.Sayı:");
//                 int sayi1 = Convert.ToInt32(Console.ReadLine());

//                 Console.Write("2.Sayı:");
//                 int sayi2 = Convert.ToInt32(Console.ReadLine());

//                 var sonuc = sayi1 / sayi2;

//                 Console.WriteLine(sonuc);

//             }
//             catch (FormatException)
//             {
//                 Console.WriteLine("Sayısal Bilgiler Yanlış");
//             }
//             catch (DivideByZeroException)
//             {
//                 Console.WriteLine("2.Sayı sıfır olmamalıdır");

//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine("Bir Hata Oluştu");
//                 Console.WriteLine(ex.Message);
//             }
//         }
//     }
//

using System;
using System.Collections.Generic;


namespace HataYönetimi{
    class Program{

        static void parola_kontrol(string password){

            if(password.Length < 6 || password.Length > 10){

                throw new Exception("Parola 6-10 karakter araalığında olmalıdır.");
            }

            if(!password.Any(char.IsDigit)){
                throw new Exception("Parola en az bir rakam içermelidir.");
            }
            
            if(!password.Any(char.IsLetter)){
                throw new Exception("Parola en az bir harf içermelidir");
            }
        }

        static void Main(string[] args){

            Console.Write("Parola:");
            string parola = Console.ReadLine();

            try{
                parola_kontrol(parola);
                Console.WriteLine("Parola Geçerli");
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
