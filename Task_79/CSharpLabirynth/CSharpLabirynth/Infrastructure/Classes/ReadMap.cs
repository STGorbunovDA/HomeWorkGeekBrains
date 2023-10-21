namespace CSharpLabirynth.Infrastructure.Classes
{
    public class ReadMap : IReadMap
    {
        private readonly IGetMaxLengthOfLine _getMaxLengthOfLine;

        public ReadMap() { _getMaxLengthOfLine = new LengthOfLine(); }

        public char[,] GetMap(string path)
        {
            string[] file = File.ReadAllLines(path);

            char[,] map = new char[_getMaxLengthOfLine.GetMaxLengthOfLine(file), file.Length];
            for (int x = 0; x < map.GetLength(0); x++)
                for (int y = 0; y < map.GetLength(1); y++)
                    map[x, y] = file[y][x];

            return map;
        }
    }
}
