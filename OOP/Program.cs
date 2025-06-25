//Class

/*using System;
using System.IO;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Class!");

            Student std1 = new Student();

            std1.studentID = "123";
            std1.studentName = "John Doe";
            std1.branch = "Computer Science";

            Student std2 = new Student();
            std2.studentID = "456";
            std2.studentName = "Jane Smith";
            std2.branch = "Electrical Engineering";

            Student std3 = new Student();
            std3.studentID = "789";
            std3.studentName = "Alice Johnson";
            std3.branch = "Mechanical Engineering";

            Console.WriteLine($"{std1.studentID} - {std1.studentName} - {std1.branch}");
            Console.WriteLine($"{std2.studentID} - {std2.studentName} - {std2.branch}");
            Console.WriteLine($"{std3.studentID} - {std3.studentName} - {std3.branch}");


        }
    }

    class Student
    {

        public string studentID { get; set; }

        public string studentName { get; set; }

        public string branch { get; set; }



    }
}
*/

//Methodlar

// using System;
// using System.IO;

// namespace OOP
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Student std1 = new Student() { StudentId = "123", StudentName = "John Doe", Branch = "Computer Science" };
//             Student std2 = new Student() { StudentId = "456", StudentName = "Jane Smith", Branch = "Electrical Engineering" };
//             Student std3 = new Student() { StudentId = "789", StudentName = "Alice Johnson", Branch = "Mechanical Engineering" };

//             Student[] students = new Student[3] { std1, std2, std3 };

//             foreach (var student in students)
//             {
//                 string total = student.Showinfo();
//                 Console.WriteLine(total);

//             }
//         }
//     }

//     class Student
//     {

//         public string StudentId { get; set; }

//         public string StudentName { get; set; }

//         public string Branch { get; set; }

//         //methods

//         public string Showinfo()
//         {
//             return $"{this.StudentId} numaralı öğrencinin adı {this.StudentName} ve branşı {this.Branch}";
//         }
//     }
// }

////////////////////////////////////////////////////////////////7

// using System;

// namespace OOP
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var question1 = new Question()
//             {
//                 QuestionText = "Hangisi programlama dili değildir?",
//                 Options = new string[4] { "Python", "C#", "Java", "Html" },
//                 Answer = "Html"
//             };

//             var question2 = new Question()
//             {
//                 QuestionText = "Hangisi en pöpüler programlama dilidir?",
//                 Options = new string[4] { "Python", "C#", "Java", "Html" },
//                 Answer = "C#"
//             };

//             var question3 = new Question()
//             {
//                 QuestionText = "Hangisi en popüler web programlama platformudur?",
//                 Options = new string[4] { "Django", "Asp.Net", "Spring", "Python" },
//                 Answer = "Django"
//             };

//             // var questions = new Question[] { question1, question2, question3 };

//             // foreach (var question in questions)
//             // {
//             //     Console.WriteLine(question.QuestionText);
//             //     foreach (var Options in question.Options)
//             //     {
//             //         Console.WriteLine(Options);
//             //     }

//             //     Console.Write("Cevabınız:");
//             //     var answer = Console.ReadLine();

//             //     if (question.answercontrol(answer))
//             //     {
//             //         Console.WriteLine("Doğru Cevap");
//             //     }
//             //     else
//             //     {
//             //         Console.WriteLine("Yanlış Cevap");
//             //     }
//             // }
//         }
//     }
// }


// class Question
// {
//     public Question()
//     {
//         Console.WriteLine("Soru nesnesi oluşturuldu.");
//     }
//     public int QuestionId { get; set; }


//     public string QuestionText { get; set; }

//     public string[] Options { get; set; }

//     public string Answer { get; set; }

//     public bool answercontrol(string answer)
//     {
//         return this.Answer.ToLower() == answer.ToLower();
//     }
// }

///////////////////////////////////////////
// constructers

// using System;

// namespace OOP
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var question1 = new Question(1, "Hangisi programlama dili değildir?", new string[4] { "Python", "C#", "Java", "Html" }, "Html");
//             var question2 = new Question(2, "Hangisi en pöpüler programlama dilidir?", new string[4] { "Python", "C#", "Java", "Html" }, "C#");
//             var question3 = new Question(3, "Hangisi en popüler web programlama platformudur?", new string[4] { "Django", "Asp.Net", "Spring", "Python" }, "Django");

//             Console.WriteLine(question1.WriteQuestion);
//             Console.WriteLine(question1.answercontrol("Html"));

//             Console.WriteLine(question2.WriteQuestion);
//             Console.WriteLine(question2.answercontrol("C#"));

//             Console.WriteLine(question3.WriteQuestion);
//             Console.WriteLine(question3.answercontrol("Django"));



//         }
//     }
//     class Question
//     {
//         public Question()
//         {
//             Console.WriteLine("constructor 1");
//             this.QuestionId = (new Random()).Next(11111, 99999);

//         }

//         public Question(int questionId)
//         {
//             Console.WriteLine("constructor 2");
//             this.QuestionId = questionId;
//         }

//         public Question(int questionId, string questionText, string[] options, string answer)
//         {
//             this.QuestionId = questionId;
//             this.QuestionText = questionText;
//             this.Options = options;
//             this.Answer = answer;
//         }

//         private int QuestionId { get; set; } //erişilmesini istemediğimiz


//         public string QuestionText { get; set; }

//         public string[] Options { get; set; }

//         public string Answer { get; set; }

//         public string WriteQuestion()
//         {
//             string question = "";
//             question += this.QuestionText + "/n";

//             foreach (var options in this.Options)
//             {
//                 question += options + "/n";
//             }

//             return question;
//         }

//         public bool answercontrol(string answer)
//         {
//             return this.Answer.ToLower() == answer.ToLower();
//         }
//     }

// }

//Static Methods

using System;
using System.Runtime.CompilerServices;

namespace OOP
{

    class Program
    {
        static void Main(string[] args)
        {
            var total = HelperMethods.FixChar("Ölçme ve Değerlendirme");
            Console.WriteLine(total);
        }
    }

    class HelperMethods
    {
        public static string FixChar(string str)
        {
            return
                str.Replace("ö", "o")
                .Replace("ü", "u")
                .Replace("ı", "i")
                .Replace("ğ", "g")
                .Replace("ç", "c")
                .Replace(" ", "-");

        }
    }
}