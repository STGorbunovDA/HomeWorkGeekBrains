namespace CSharpLabirynth.Infrastructure.Classes
{
    public class LengthOfLine : IGetMaxLengthOfLine
    {
        public int GetMaxLengthOfLine(string[] lines)
        {
            int maxLength = lines[0].Length;

            foreach (var line in lines)
                if (line.Length > maxLength)
                    maxLength = line.Length;

            return maxLength;
        }
    }
}
