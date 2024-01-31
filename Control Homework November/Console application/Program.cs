namespace Console_application;
class Program
{
    /// <summary>
    /// Метод для считывания с консоли переменной типа int м проверки этой переменной на ограничения. Если ограничений нет, то происходит такая проверка: -бесконечность < введенное число < +бесконечность.
    /// </summary>
    /// <param name="name">Имя переменной, которую надо считать. По умолчанию имени нет.</param>
    /// <param name="lowerBound">Нижняя граница ограничения. По умолчанию равна -бесконечности.</param>
    /// <param name="upperBound">Верхняя граница ограничения. По умолчанию равна +бесконечности.</param>
    /// <param name="lowerSing">Строгость знака нижней границы ограничения. По умолчанию строгий знак ("<").</param>
    /// <param name="upperSing">Строгость знака верхней границы ограничения. По умолчанию строгий знак ("<").</param>
    /// <returns>Переменная типа int, которую ввёл пользователь.</returns>
    public static int InputInt(string name = "", double lowerBound = double.NegativeInfinity, double upperBound = double.PositiveInfinity, string lowerSing = "<", string upperSing = "<")
    {
        bool flag;
        // Временная переменная для проверки на корректность ввода данных.
        int result;
        // Возвращаемая переменная.
        do
        {
            Console.Write($"{lowerBound} {lowerSing} {name} {upperSing} {upperBound}. {name} = ");
            // Предупреждение пользователя об ограничениях на переменную, которую надо ввести.
            if (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Некорректный ввод, повторите попытку");
                flag = false;
                // Срабатывает, если пользователь ввел любой символ, не содержащий цифр.
            }
            else
            {
                bool flag1 = true;
                // Временная переменная создания проерки на ограничения. Проверяет нижнее ограничение.
                bool flag2 = true;
                // Временная переменная создания проерки на ограничения. Проверяет верхнее ограничение.
                switch (lowerSing)
                {
                    case "<":
                        flag1 = lowerBound < result;
                        break;
                    case "<=":
                        flag1 = lowerBound <= result;
                        break;
                }
                switch (upperSing)
                {
                    case "<":
                        flag2 = result < upperBound;
                        break;
                    case "<=":
                        flag2 = result <= upperBound;
                        break;
                }
                if (flag1 && flag2)
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine($"Введённые значения не подходят под ограничения. {lowerBound} {lowerSing} {name} {upperSing} {upperBound}");
                    flag = false;
                }
            }
        }
        while (!flag);
        // Цикл повторяется до тех пор, пока пользователь не введет корректные значения.
        return result;
    }
        ///<summary>
        ///Этот метод запрашивает у пользователя абсолютный путь к файлу с csv-данными и проверяет его корректность.
        ///</summary>
        ///<returns>
        ///Переменная типа string, содержащая абсолютный путь к файлу с csv-данными.
        ///</returns>
        public static string AbsolutePath()
    {
        // Временная переменная для корректной работы цикла.
        bool flag;
        string path; 
        do
        {
            Console.Write("Полный путь к файлу с csv-данными = ");
            path = Console.ReadLine();
            // Проверка на существование файла.
            if (!File.Exists(path))
            {
                flag = false;
                // Смена цвета консоли на красный.
                Console.ForegroundColor = ConsoleColor.Red;
                // Красная подсветка вывода ошибки.
                Console.WriteLine("Некорректный абсолютный путь, повторите попытку");
                // Сброс цвета консоли.
                Console.ResetColor();
            }
            else
            {   
                flag = true;
            }
        }
        while (!flag);
        // Цикл завершится, когда пользователь введёт корректный абсолютный путь.
        return path;
    }
    /// <summary>
    /// Этот метод считывает определенные данные с файла.
    /// </summary>
    /// <param name="path">
    /// Абсолютный путь файла.
    /// </param>
    public static void GettingData(string path)
    {
        int choice = InputInt("Ваш выбор", lowerBound: 0, upperBound: 7);

        Console.WriteLine("Укажите номер пункта меню для запуска действия:");
        Console.WriteLine("    1. Произвести выборку по значению Area");
        Console.WriteLine("    2. Произвести выборку по значению Name");
        Console.WriteLine("    3. Произвести выборку по значению Area и Name");
        Console.WriteLine("    4. Отсортировать таблицу по значению Year (прямой порядок)");
        Console.WriteLine("    5. Отсортировать таблицу по значению Name (прямой порядок)");
        Console.WriteLine("    6. Выйти из программы");
        switch (choice)
        {
            case 1:
                // реализация выборки по значению Area
                // ваш код
                break;
            case 2:
                // реализация выборки по значению Name
                // ваш код
                break;
            case 3:
                // реализация выборки по значению Area и Name
                // ваш код
                break;
            case 4:
                // реализация сортировки по значению Year
                // ваш код
                break;
            case 5:
                // реализация сортировки по значению Name
                // ваш код
                break;
            case 6:
                // выход из программы
                Console.WriteLine("До свидания!");
                break;
            default:
                Console.WriteLine("Некорректный выбор. Повторите попытку.");
                break;
        }
    }

static void Main(string[] args)
    {
        do
        {
            Console.Clear();
            Console.WriteLine("Укажите номер пункта меню для запуска действия:");
            Console.WriteLine("    1. Произвести выборку по значению Area");
            Console.WriteLine("    2. Произвести выборку по значению Name");
            Console.WriteLine("    3. Произвести выборку по значению Area и Name");
            Console.WriteLine("    4. Отсортировать таблицу по значению Year (прямой порядок)");
            Console.WriteLine("    5. Отсортировать таблицу по значению Name (прямой порядок)");
            Console.WriteLine("    6. Выйти из программы");
        }
        while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
}

