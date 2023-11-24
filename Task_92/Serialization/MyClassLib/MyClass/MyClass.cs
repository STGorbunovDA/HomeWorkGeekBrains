namespace MyClassLib.MyClass
{
    public class MyClass
    {
        private int _field = 10;
        private int _value = 20;

        public int Field = 30;
        public int Value = 50;

        public override string ToString()
        {
            return $"_field={_field}, " +
                   $"_value={_value}, " +
                   $"Field={Field}, " +
                   $"Value={Value}";
        }
    }
}
