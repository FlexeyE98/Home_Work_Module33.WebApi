namespace MyWebAPI
{
    public interface ILogger
    {
        void WriteEvent(string message);
        void WriteError(string message);
    }
}
