namespace CSharpLabirynth.Infrastructure.Classes
{
    public class Direction : IGetDirection
    {
        public int[] GetDirection(ConsoleKeyInfo pressedKey)
        {

            int[] direction = { 0, 0 };

            if (pressedKey.Key == ConsoleKey.UpArrow)
                direction[1] -= 1;
            else if (pressedKey.Key == ConsoleKey.DownArrow)
                direction[1] += 1;
            else if (pressedKey.Key == ConsoleKey.LeftArrow)
                direction[0] -= 1;
            else if (pressedKey.Key == ConsoleKey.RightArrow)
                direction[0] += 1;

            return direction;
        }
    }
}
