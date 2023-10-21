namespace CSharpLabirynth.Infrastructure.Interfaces
{
    public interface IReadMap
    {
        char[,] GetMap(string path);
    }
}
