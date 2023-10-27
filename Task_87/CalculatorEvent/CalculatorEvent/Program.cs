/*
    * 1. Спроектируйте интерфейс калькулятора, поддерживающего простые арифметические действия, 
         хранящего результат и также способного выводить информацию о результате при помощи события.

    * 2. Арифметические методы должны выполняться как обычно а метод CancelLast должен отменять последнее действие. 
         При этом метод может отменить последовательно все действия вплоть до самого последнего.

    * 3. 
*/

namespace CalculatorEvent;

class Program
{

    static void Main(string[] args)
    {
        var calc = new Calc();
        calc.MyEventHandler += Calc_MyEventHandler;
        calc.Sum(10);
        calc.Sub(5);
        calc.Multy(5);
        calc.Divide(5);
        calc.CancelLast();
        calc.CancelLast();
        calc.CancelLast();
        calc.CancelLast();
        calc.CancelLast();
    }

    private static void Calc_MyEventHandler(object? sender, EventArgs e)
    {
        if (sender is Calc calc)
            Console.WriteLine(calc.Result);
    }
}