//Collections

// using System;
// using System.Collections;
// using System.Diagnostics.CodeAnalysis;

// namespace Collections
// {

//     class Program
//     {

//         static void Main(string[] args)
//         {
//             //ArrayList

//             ArrayList list = new ArrayList();

//             list.Add(10);
//             list.Add("10");
//             list.Add("ali");
//             list.Add(null);
//             list.Add(true);

//             var list2 = new ArrayList()
//             {
//                 5,
//                 "ahmet",
//                 false,
//                 4.5,
//                 null
//             };

//             int[] numbers = { 10, 20, 30 };

//             list.AddRange(numbers);

//             var eleman = (int)list[0];
//             var name = list[2].ToString();

//             //insert
//             list.Insert(1, "aslı");
//             list.InsertRange(2, list2);

//             //remove
//             list.Remove(10);
//             list.RemoveAt(2);
//             list.RemoveRange(2, 3);

//             //contains indexof
//             Console.WriteLine(list.Contains(100));
//             Console.WriteLine(list.IndexOf(10));

//             foreach (var item in list) {
//                 Console.WriteLine(item);
//             }

//         }
//     }
// }

//Generic List

// using System;
// using System.Collections.Generic;


// namespace Collections
// {

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Generic List

//             List<int> numbers = new List<int>();

//             numbers.Add(10);
//             numbers.Add(20);

//             List<string> names = new List<string>() { "ali", "ahmet", "ayşe" };

//             List<Product> products = new List<Product>();

//             products.Add(new Product() { ID = 1, Title = "Iphone 14", Price = 40000 });
//             products.Add(new Product() { ID = 2, Title = "IPhone 15", Price = 50000 });
//             products.Add(new Product() { ID = 3, Title = "IPhone 16", Price = 60000 });

//             products.Insert(products.Count, new Product() { ID = 4, Title"IPhone 17", Price = 70000 });

//             products.RemoveAt(2);
//             products.Remove(products[0]);

//             foreach (var product in products)
//             {
//                 Console.WriteLine(product.Title + " " + product.Price);
//             }


//         }
//     }

//     class Product {

//         public int ID { get; set; }
//         public int Title { get; set; }
//         public int Price { get; set; }
//     }
// }

//Dictionary

using System;
using System.Collections.Generic;

namespace Collections
{
    class Program{
        static void Main(string[] args)
        {
            //Dictionary
            Dictionary<int, string> plakalar = new Dictionary<int, string>();

            plakalar.Add(41, "Kocaeli");
            plakalar.Add(34, "İstanbul");
            plakalar.Add(53, "Rize");

            Dictionary<int, string> numbers = new Dictionary<int, string>()
            {
                { 1, "Bir" },
                { 2, "İki" },
                { 3, "Üç" }
            };

            Console.WriteLine(plakalar[41]);

            if (plakalar.ContainsKey(34))
            {
                Console.WriteLine(plakalar[34]);
            }
            foreach (KeyValuePair<int, string> plaka in plakalar)
            {
                Console.WriteLine(plaka.Key + " " + plaka.Value);
            }

            //update
            numbers[1] = "one";

            Console.WriteLine(numbers[1]);

        }
    }
    
}