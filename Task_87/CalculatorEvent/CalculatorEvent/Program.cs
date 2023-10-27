/*
    * 1. Спроектируйте интерфейс калькулятора, поддерживающего простые арифметические действия, 
         хранящего результат и также способного выводить информацию о результате при помощи события.

    * 2. Арифметические методы должны выполняться как обычно а метод CancelLast должен отменять последнее действие. 
         При этом метод может отменить последовательно все действия вплоть до самого последнего.

    * 3. Доработайте программу калькулятор реализовав выбор действий и вывод результатов на экран 
         в цикле так чтобы калькулятор мог работать до тех пор пока пользователь не нажмет отмена 
         или введёт пустую строку.
*/

namespace CalculatorEvent;

class Program
{

    static void Main(string[] args)
    {
        var calc = new Calc();
        calc.MyEventHandler += Calc_MyEventHandler;

        // Выводим приветствие и инструкцию пользователю
        Console.WriteLine("Добро пожаловать в калькулятор! Введите число и действие (+, -, *, /),\nлибо введите 'отмена' или пустую строку для выхода.");

        string input;
        do
        {
            Console.Write("Введите число и действие: ");
            input = Console.ReadLine();

            if (input.ToLower() == "отмена" || string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Работа калькулятора завершена.");
                break;
            }

            // Парсим введенную строку
            var parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 2)
            {
                Console.WriteLine("Неверный формат ввода. Попробуйте снова.");
                continue;
            }

            if (!int.TryParse(parts[0], out int number))
            {
                Console.WriteLine("Неверный формат числа. Попробуйте снова.");
                continue;
            }

            // Выполняем действие в зависимости от оператора
            switch (parts[1])
            {
                case "+":
                    calc.Sum(number);
                    break;
                case "-":
                    calc.Sub(number);
                    break;
                case "*":
                    calc.Multy(number);
                    break;
                case "/":
                    calc.Divide(number);
                    break;
                default:
                    Console.WriteLine("Неверный оператор. Попробуйте снова.");
                    break;
            }

        } while (true);
    }

    private static void Calc_MyEventHandler(object? sender, EventArgs e)
    {
        if (sender is Calc calc)
            Console.WriteLine(calc.Result);
    }
}