using LR5;

Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;

void Task1()
{
    Exam exam = new Exam("Mathematics", 100, "2024-05-15");
    GraduationExam graduationExam = new GraduationExam("Physics", 100, "2024-06-15");
    Trial trial = new Trial("Chemistry", 50, "Practical");

    exam.ConductTest();
    graduationExam.ConductTest();
    trial.ConductTest();
}
void Task2()
{
    List<Test> tests = new List<Test>
    {
        new Exam("Mathematics", 100, "2024-05-15"),
        new GraduationExam("Physics", 100, "2024-06-15"),
        new Trial("Chemistry", 50, "Practical")
    };

    Console.WriteLine();

    foreach (var test in tests)
    {
        test.ConductTest();
    }
}

void Task3()
{
    Product[] products = new Product[]
        {
            new Toy("М'яч", 150.50, "ToyCorp", "Гума", 3),
            new Book("Програмування C#", 350.75, "Джон Доу", "TechBooks", 16),
            new SportsEquipment("Гантелі", 450.00, "SportMaster", 14),
            new Toy("Лялька", 250.25, "PlayFun", "Пластик", 4),
            new Book("Фізика", 280.00, "Джейн Сміт", "SciencePub", 12)
        };

    Console.WriteLine("Всі товари в базі:");
    Console.WriteLine();
    foreach (Product product in products)
    {
        product.DisplayInfo();
    }

    Console.WriteLine("\nПошук товарів за типом (toy, book, sports)");
    Console.Write("Введіть тип товару: ");
    string searchType = Console.ReadLine();

    Console.WriteLine($"\nЗнайдені товари типу '{searchType}':");
    Console.WriteLine();
    bool found = false;

    foreach (Product product in products)
    {
        if (product.IsType(searchType))
        {
            product.DisplayInfo();
            found = true;
        }
    }
    if (!found)
    {
        Console.WriteLine("Товарів цього типу не знайдено!");
    }

}

void Task4()
{
    Console.WriteLine("Структура.");
    Students.Struct();
    
    Console.WriteLine("\nКортеж.");
    Students.Tuple();
    
    Console.WriteLine("\nЗапис.");
    Students.Record();
}

Task4();