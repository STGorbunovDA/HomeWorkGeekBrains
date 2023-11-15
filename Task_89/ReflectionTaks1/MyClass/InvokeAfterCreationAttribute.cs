namespace MyClassLib
{
    [AttributeUsage(AttributeTargets.Method)]
    public class InvokeAfterCreationAttribute : Attribute
    {
        public string X;

        public InvokeAfterCreationAttribute(string x) => X = x;
    }
}
