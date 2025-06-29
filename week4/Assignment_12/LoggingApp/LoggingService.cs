public class LoggingService
{
    private readonly ILogger<LoggingService> _logger;
    public LoggingService(ILogger<LoggingService> logger)
    {
        _logger = logger;
    }

    public void PrintLogs()
    {
        _logger.LogTrace("This is a trace log.");
        _logger.LogDebug("This is a debug log.");
        _logger.LogInformation("Logging from service");
        _logger.LogWarning("This is a warning.");
        _logger.LogError("This is an error.");
    }
}
