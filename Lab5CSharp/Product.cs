using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    abstract class Product
    {
        protected string Name { get; set; }
        protected double Price { get; set; }
        protected int Age { get; set; }

        public Product(string name, double price, int age)
        {
            Name = name;
            Price = price;
            Age = age;
        }
        public abstract void DisplayInfo();
        public abstract bool IsType(string type);
    }

    class Toy : Product
    {
        private string Manufacturer { get; set; }
        private string Material { get; set; }

        public Toy(string name, double price, string manufacturer, string material, int age)
            : base(name, price, age)
        {
            Manufacturer = manufacturer;
            Material = material;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Іграшка: {Name}");
            Console.WriteLine($"Ціна: {Price} грн");
            Console.WriteLine($"Виробник: {Manufacturer}");
            Console.WriteLine($"Матеріал: {Material}");
            Console.WriteLine($"Вік: {Age}+");
            Console.WriteLine();
        }

        public override bool IsType(string type)
        {
            return type.ToLower() == "toy";
        }
    }

    class Book : Product
    {
        private string Author { get; set; }
        private string Publisher { get; set; }

        public Book(string name, double price, string author, string publisher, int age)
            : base(name, price, age)
        {
            Author = author;
            Publisher = publisher;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Книга: {Name}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Ціна: {Price} грн");
            Console.WriteLine($"Видавництво: {Publisher}");
            Console.WriteLine($"Вік: {Age}+");
            Console.WriteLine();
        }

        public override bool IsType(string type)
        {
            return type.ToLower() == "book";
        }
    }

    class SportsEquipment : Product
    {
        private string Manufacturer { get; set; }

        public SportsEquipment(string name, double price, string manufacturer, int age)
            : base(name, price, age)
        {
            Manufacturer = manufacturer;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Спортивний інвентар: {Name}");
            Console.WriteLine($"Ціна: {Price} грн");
            Console.WriteLine($"Виробник: {Manufacturer}");
            Console.WriteLine($"Вік: {Age}+");
            Console.WriteLine();
        }

        public override bool IsType(string type)
        {
            return type.ToLower() == "sports";
        }
    }
}
