using Microsoft.Extensions.Logging;

public interface ILogService
{
    void LogMessage(string message);
}
public class LogService : ILogService
{
    private ILogger<LogService> _log;
    public LogService(ILogger<LogService> log)
    {
        _log = log;
    }
    public void LogMessage(string message)
    {
        _log.LogInformation(message);
    }
}