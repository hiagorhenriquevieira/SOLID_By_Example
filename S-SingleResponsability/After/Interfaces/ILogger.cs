namespace SOLID_By_Example.S_SingleResponsability.After.Interfaces
{
    public interface ILogger
    {
        void Log(string message);
        void Error(string message);
        void Warn(string message);
    }
}