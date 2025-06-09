using System;
using System.Collections.Generic;
using static System.Console;

public class Students
{
    struct Student
    {
        public string Surname;
        public string Name;
        public string Patronymic;
        public string Address;
        public string Group;
        public double Rating;

        public Student(string surname, string name, string patronymic, string address, string group, double rating)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Address = address;
            Group = group;
            Rating = rating;
        }

        public void Print() =>
            WriteLine($"{Surname} {Name} {Patronymic}, Адреса: {Address}, Група: {Group}, Рейтинг: {Rating}");
    }

    public static void Struct()
    {
        List<Student> students = new List<Student>
        {
            new Student("Іваненко", "Іван", "Іванович", "вул. Шевченка, 1", "КІ-101", 85.5),
            new Student("Петренко", "Петро", "Петрович", "вул. Франка, 2", "КІ-102", 78.0),
            new Student("Сидоренко", "Сидір", "Сидорович", "вул. Лесі Українки, 3", "КІ-101", 92.5)
        };
        Student newStudent = new Student("Новаченко", "Ніна", "Михайлівна", "вул. Грушевського, 4", "КІ-103", 88.0);

        students.Add(newStudent);

        Write("Введіть рейтинг для вилучення: ");
        if (!double.TryParse(ReadLine(), out double minRating))
        {
            WriteLine("Некоректний рейтинг.");
            return;
        }

        students.RemoveAll(s => s.Rating < minRating);

        WriteLine("\nРезультат:");
        foreach (var s in students)
            s.Print();
    }

    public static void Tuple()
    {
        var students = new List<(string Surname, string Name, string Patronymic, string Address, string Group, double Rating)>
        {
            ("Іваненко", "Іван", "Іванович", "вул. Шевченка, 1", "КІ-101", 85.5),
            ("Петренко", "Петро", "Петрович", "вул. Франка, 2", "КІ-102", 78.0),
            ("Сидоренко", "Сидір", "Сидорович", "вул. Лесі Українки, 3", "КІ-101", 92.5)
        };
        var newStudent = ("Новаченко", "Ніна", "Михайлівна", "вул. Грушевського, 4", "КІ-103", 88.0);

        students.Add(newStudent);
        
        Write("Введіть рейтинг для вилучення: ");
        if (!double.TryParse(ReadLine(), out double minRating))
        {
            WriteLine("Некоректний рейтинг.");
            return;
        }

        students.RemoveAll(s => s.Rating < minRating);

        WriteLine("\nРезультат:");
        foreach (var s in students)
        {
            WriteLine($"{s.Surname} {s.Name} {s.Patronymic}, Адреса: {s.Address}, Група: {s.Group}, Рейтинг: {s.Rating}");
        }
    }

    public record StudentRecord(string Surname, string Name, string Patronymic, string Address, string Group, double Rating);

    public static void Record()
    {
        List<StudentRecord> students = new List<StudentRecord>
        {
            new StudentRecord("Іваненко", "Іван", "Іванович", "вул. Шевченка, 1", "КІ-101", 85.5),
            new StudentRecord("Петренко", "Петро", "Петрович", "вул. Франка, 2", "КІ-102", 78.0),
            new StudentRecord("Сидоренко", "Сидір", "Сидорович", "вул. Лесі Українки, 3", "КІ-101", 92.5)
        };
        StudentRecord newStudent = new StudentRecord("Новаченко", "Ніна", "Михайлівна", "вул. Грушевського, 4", "КІ-103", 88.0);

        students.Add(newStudent);

        Write("Введіть рейтинг для вилучення: ");
        if (!double.TryParse(ReadLine(), out double minRating))
        {
            WriteLine("Некоректний рейтинг.");
            return;
        }

        students.RemoveAll(s => s.Rating < minRating);

        WriteLine("\nРезультат:");
        foreach (var s in students)
        {
            WriteLine($"{s.Surname} {s.Name} {s.Patronymic}, Адреса: {s.Address}, Група: {s.Group}, Рейтинг: {s.Rating}");
        }
    }
}