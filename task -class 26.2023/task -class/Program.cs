using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Text.RegularExpressions;

namespace task__class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region AcademyTask1
            //Human human1 = new Human()
            //{
            //    Name = "Jack",
            //    Surname = "Sparrow",
            //    Age = 30
            //};
            //human1.Age = 45;
            //Console.WriteLine(human1.GetInfo());
            #endregion

            #region AcademyTask2
            //Student student1 = new Student()
            //{
            //    Fullname = "Jack Sparrow",
            //    GroupNo = "P233",
            //    Point = 40
            //};

            //Student student2 = new Student
            //{
            //    Fullname = "Sherlock Holmes",
            //    GroupNo = "El201",
            //    Point = 100
            //};
            //Console.WriteLine(student1.IsGraduated());
            //Console.WriteLine(student2.IsGraduated());
            //Console.WriteLine(student2.GetInfo());
            #endregion

            #region AcademyTask3
            //Product pr1 = new Product("Atena", 2.5);
            #endregion

            #region HomeworkTask1
            //Notebook notebook1 = new Notebook("Apple", "Air1")
            //{
            //    Brand = "Asus",
            //    Model = "Vivabook 2022",
            //    Price = 1999
            //};
            //Console.WriteLine(notebook1.ShowInfo());
            #endregion

            #region Consoldan cagiraraq arraydeki productlarin ortalama tapmaq yolu
            //Notebook[] notebooks = new Notebook[3];
            //int sum = 0;
            //int avr = 0;
            //for (int i = 0; i < notebooks.Length; i++)
            //{
            //    Console.WriteLine("Brand daxil edin:");
            //    string brand = Console.ReadLine();
            //    Console.WriteLine("Model daxil edin:");
            //    string model = Console.ReadLine();
            //    Console.WriteLine("Price daxil edin:");
            //    string Pricestr = Console.ReadLine();
            //    int price = Convert.ToInt32(Pricestr);

            //    Notebook notebook2 = new Notebook(brand, model, price);
            //    notebooks[i] = notebook2;

            //}
            //for (int i = 0; i < notebooks.Length; i++)
            //{
            //    sum += notebooks[i].Price;
            //    avr = sum / notebooks.Length;
            //}
            //Console.WriteLine(avr);
            #endregion

            #region Obyekt yaradaraq avrage tapma yolu
            //Notebook nt1 = new Notebook("Asus","Viva",2000)
            //{
            //    Brand = "Asus",
            //    Model = "Vivabook 2022",
            //    Price = 2000
            //};

            //Notebook nt2 = new Notebook("Asus", "Air", 2200)
            //{
            //    Brand = "Apple",
            //    Model = "Pro",
            //    Price =2300
            //};
            //Notebook nt3 = new Notebook("Hp", "ProArt", 2000)
            //{
            //    Brand = "Lenova",
            //    Model = "ProArt",
            //    Price = 2500
            //};
            //Notebook[] notes = { nt1, nt2, nt3 };
            //int sum = 0;
            //int avr = 0;
            //for (int i = 0; i < notes.Length; i++)
            //{
            //    sum += notes[i].Price;
            //    avr = sum / notes.Length;
            //}
            //Console.WriteLine(avr);
            #endregion

        }
    }
}
