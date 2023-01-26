using System;
using System.Collections.Generic;
using System.Text;

namespace task__class
{
    internal class Human
    {
        public string Name;
        public string Surname;
        public int Age;
        public string GetInfo()
        {
            string info = Name + " " + Surname + " " + Age + " ";
            return info;
        }
    }

  internal class Student
  {
        public string Fullname;
        public string GroupNo;
        public int Point;

        public bool IsGraduated()
        {
            if (Point>66)
            {
                return true;
            }
            return false;
        }
        public string GetInfo()
        {
            return $"Fullname: {Fullname}-GroupNo:{GroupNo}-Point:{Point}-Graduated:{IsGraduated()}";
        }
  }

    internal class Product
    {
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name;
        public double Price;
        public double DiscountPercent;

        
    }
    
    internal class Notebook
    {
        public Notebook (string brand, string model)
        {
            this.Brand = brand;
            this.Model = model;
            
        }
        public Notebook(string brand, string model, int price = 0)
        {
            this.Brand = brand;
            this.Model = model;
            this.Price = price;
        }

        public string Brand;
        public string Model;
        public int Price;

        public string ShowInfo()
        {
            return $"Brand:{Brand}-Model:{Model}-Price{Price}";
        }
       
    }

}
