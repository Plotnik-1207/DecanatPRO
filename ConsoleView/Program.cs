using BusinessLogic;

Logic Logic = new Logic();

static int ReadUserChoice(int minValue, int maxValue)
{
    while (true)
    {
        var key = Console.ReadKey(true);
        if (key.Key >= ConsoleKey.D0 && key.Key <= ConsoleKey.D9)
        {
            int choice = key.Key - ConsoleKey.D0;
            if (choice >= minValue && choice <= maxValue)
                return choice;
        }
        else if (key.Key == ConsoleKey.Enter && minValue == 0)
        {
            return 0;
        }
    }
}

static (string name, string speciality, string group) ReadStudent()
{
    Console.WriteLine("Введите ФИО студента:");
    string name = Console.ReadLine() ?? "";

    Console.WriteLine("Введите специальность студента:");
    string speciality = Console.ReadLine() ?? "";

    Console.WriteLine("Введите группу студента:");
    string group = Console.ReadLine() ?? "";

    return (name, speciality, group);
}

void PrintStudents()
{
    var students = Logic.GetStudents();

    Console.WriteLine("┌────────────────────────────┬──────────────────┬────────────┐");
    Console.WriteLine("│ ФИО                        │ Специальность    │ Группа     │");
    Console.WriteLine("├────────────────────────────┼──────────────────┼────────────┤");

    foreach (var s in students)
    {
        Console.WriteLine($"│ {s.Name,-26} │ {s.Speciality,-16} │ {s.Group,-10} │");
    }

    Console.WriteLine("└────────────────────────────┴──────────────────┴────────────┘");
}

void PrintHistogram()
{
    var distribution = Logic.GetSpecialityDistribution();

    if (distribution.Count == 0)
    {
        Console.WriteLine("Нет данных для гистограммы.");
        return;
    }

    int maxCount = distribution.Values.Max();
    int maxNameLength = distribution.Keys.Max(s => s.Length);

    Console.WriteLine("Распределение студентов по специальностям:\n");

    foreach (var item in distribution)
    {
        string name = item.Key.PadRight(maxNameLength + 2);

        string count = item.Value.ToString().PadLeft(3);

        int barLength = (item.Value * 30) / maxCount;
        string bar = new string('█', barLength);

        Console.WriteLine($"{name} {count} │{bar}");
    }
}

while (true)
{
    Console.WriteLine("Информационная система DecanatPRO");
    Console.WriteLine("=================================");
    Console.WriteLine(
        "Выберите действие:" +
        "\n1.Добавить нового студента" +
        "\n2.Удалить студента" +
        "\n3.Вывести список студентов в таблицу" +
        "\n4.Вывести гистограмму: распределение студентов по специальностям" +
        "\n5.Выйти"
        );

    int mainChoice = ReadUserChoice(1, 5);
    Console.Clear();

    switch (mainChoice)
    {
        case 1:
            {
                var (name, speciality, group) = ReadStudent();
                Logic.AddStudent(name, speciality, group);
                break;
            }
        case 2:
            {
                var (name, speciality, group) = ReadStudent();
                Logic.DeleteStudent(name, speciality, group);
                break;
            }
        case 3:
            PrintStudents();
            break;
        case 4:
            PrintHistogram();
            break;
        case 5:
            return;
    }

    Console.Write("Чтобы продолжить нажмите Enter");
    while (true)
    {
        var key = System.Console.ReadKey(true);
        if (key.Key == ConsoleKey.Enter)
            break;
    }
    Console.Clear();
}