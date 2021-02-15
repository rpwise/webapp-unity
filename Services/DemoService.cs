public class DemoService: IDemoService
{
    private ILogService _logService;

    public DemoService(ILogService logService)
    {
        _logService = logService;
    }

    public void Log()
    {
        _logService.LogMessage("Logging Message from Demo Service using LogService");
    }
}

public interface IDemoService
{
    void Log();
}