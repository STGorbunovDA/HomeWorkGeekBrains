namespace CSharpLabirynth.Infrastructure.Classes
{
    public class HandleInput : IHandleInput
    {

        private readonly IGetDirection _getDirection;

        public HandleInput() { _getDirection = new Direction(); }

        public void Go(ConsoleKeyInfo pressedKey, ref int pacmanX, ref int pacmanY, char[,] map, ref int score)
        {
            int[] direction = _getDirection.GetDirection(pressedKey);

            int nextPacmanPositionX = pacmanX + direction[0];
            int nextPacmanPositionY = pacmanY + direction[1];

            char nextCell = map[nextPacmanPositionX, nextPacmanPositionY];

            if (nextCell == ' ' || nextCell == '.')
            {
                map[pacmanX, pacmanY] = ' ';

                Console.SetCursorPosition(pacmanX, pacmanY);
                Console.Write(' ');

                pacmanX = nextPacmanPositionX;
                pacmanY = nextPacmanPositionY;

                if (nextCell == '.')
                {
                    score++;
                    map[nextPacmanPositionX, nextPacmanPositionY] = ' ';
                }
            }
        }
    }
}
