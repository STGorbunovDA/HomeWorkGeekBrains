namespace CSharpLabirynth;
class Program
{
    static void Main()
    {
        IHandleInput handleInput = new HandleInput();
        IDrawMap drawMap = new DrawMap();

        char[,] map = Map();

        Console.ForegroundColor = ConsoleColor.Blue;
        drawMap.Draw(map);

        Task.Run(() =>
        {
            while (true) GlobalValue.PRESSEDKEY = Console.ReadKey();
        });

        while (true)
        {
            handleInput.Go(GlobalValue.PRESSEDKEY, ref GlobalValue.PACMAN_X, ref GlobalValue.PACMAN_Y, map, ref GlobalValue.SCOPE);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(GlobalValue.PACMAN_X, GlobalValue.PACMAN_Y);
            Console.Write("@");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(32, 0);
            Console.Write($"Score: {GlobalValue.SCOPE} ");

            Thread.Sleep(500);
        }
    }

    private static char[,] Map()
    {
        IReadMap readMap = new ReadMap();
        char[,] map = readMap.GetMap("map.txt");
        readMap = null;
        return map;
    }
}
