public class Calculator
{
    public static void Main(string[] args)
    {
        if (args.Length != 3)
        {
            Console.WriteLine("Неверный формат команды.");
            Console.WriteLine("Пример вызова программы: program.exe 10 + 20");
            return;
        }

        double a, b;
        if (!double.TryParse(args[0], out a) || !double.TryParse(args[2], out b))
        {
            Console.WriteLine("Неверный формат чисел.");
            return;
        }

        double result = 0;
        bool isValidOperator = true;

        switch (args[1])
        {
            case "+":
                result = a + b;
                break;
            case "-":
                result = a - b;
                break;
            case "*":
                result = a * b;
                break;
            case "/":
                if (b != 0) result = a / b;
                else
                {
                    Console.WriteLine("Ошибка: деление на ноль.");
                    isValidOperator = false;
                }
                break;
            default:
                Console.WriteLine("Неверный оператор.");
                isValidOperator = false;
                break;
        }

        if (isValidOperator) Console.WriteLine($"{a} {args[1]} {b} = {result}");
        
    }
}