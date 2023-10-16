class Program
{

    class Fibonacci
    {
        public int Value { get; private set; } = 1;

        private int valuePrev = 0;

        public static Fibonacci operator ++(Fibonacci f)
        {
            var temp = f.Value;
            f.Value += f.valuePrev;
            f.valuePrev = temp;
            return f;
        }

        public static Fibonacci operator +(Fibonacci f, int count)
        {
            for (int i = 0; i < count; i++) f++;
            return f;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
    static void Main()
    {
        var fibNumber = new Fibonacci() + 0;

        for (int i = 0; i <= 8; i++)
        {
            Console.Write($"{fibNumber} ");
            fibNumber++;
        }

        //Console.WriteLine(fibNumber);
    }
}