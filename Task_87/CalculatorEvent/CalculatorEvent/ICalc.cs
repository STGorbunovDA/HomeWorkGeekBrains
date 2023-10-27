namespace CalculatorEvent
{
    public interface ICalc
    {
        double Result { get; set; }
        public Stack<double> LastResult { get; set; }

        public event EventHandler<EventArgs> MyEventHandler;

        void Divide(int x);
        void Multy(int x);
        void Sum(int x);
        void Sub(int x);
        void CancelLast();

    }
}
