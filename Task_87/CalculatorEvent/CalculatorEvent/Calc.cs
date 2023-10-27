namespace CalculatorEvent
{
    internal class Calc : ICalc
    {
        public double Result { get; set; } = 0D;
        public Stack<double> LastResult { get; set; } = new Stack<double>();

        public event EventHandler<EventArgs> MyEventHandler;

        private void PrintResult() { MyEventHandler?.Invoke(this, new EventArgs()); }

        public void Divide(int x)
        {
            if (Result != 0)
                Result /= x;
            PrintResult();
            LastResult.Push(Result);
        }

        public void Multy(int x)
        {
            Result *= x;
            PrintResult();
            LastResult.Push(Result);
        }

        public void Sub(int x)
        {
            Result -= x;
            PrintResult();
            LastResult.Push(Result);
        }

        public void Sum(int x)
        {
            Result += x;
            PrintResult();
            LastResult.Push(Result);
        }

        public void CancelLast()
        {
            if (LastResult.TryPop(out double res))
            {
                Result = res;
                Console.WriteLine("Последнее действие отменено. Результат равен: ");
                PrintResult();
            }
            else Console.WriteLine("Невозможно отменить последнее действие");

        }
    }
}
