// Defines a contract for logging — this is the dependency to be injected
public interface ILogger
{
    void Log(string message);
}