namespace CSharpLabirynth.Infrastructure.Interfaces
{
    public interface IHandleInput
    {
        void Go(ConsoleKeyInfo pressedKey, ref int pacmanX, ref int pacmanY, char[,] map, ref int score);
    }
}
