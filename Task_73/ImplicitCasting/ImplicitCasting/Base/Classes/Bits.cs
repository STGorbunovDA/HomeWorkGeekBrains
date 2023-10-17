using ImplicitCasting.Base.Infrastructure;
using ImplicitCasting.Base.Interfaces;

namespace ImplicitCasting.Base.Classes
{
    public class Bits<T> : IBits<T> where T : struct
    {
        public Bits(T b)
        {
            Value = b;
            MaxBitsCount = SizeOf.DataTypeInBytes(b.GetType().Name) * 8;
        }

        public T Value { get; set; } = default;
        private int MaxBitsCount { get; set; }

        public bool GetBit(int index)
        {
            if (index > MaxBitsCount || index < 0)
            {
                Console.WriteLine($"Выход за пределы от 0 до {MaxBitsCount}");
                return false;
            }

            dynamic val = Value;
            return (val >> index & 1) == 1;
        }

        public void SetBit(bool bit, int index)
        {
            if (index > MaxBitsCount || index < 0)
            {
                Console.WriteLine($"Выход за пределы от 0 до {MaxBitsCount}");
                return;
            }

            dynamic val = Value;
            if (bit)
                val |= 1 << index;
            else
                val &= ~(1 << index);

            Value = val;
        }

        public static implicit operator Bits<T>(T value)
        {
            return new Bits<T>(value);
        }
    }
}
