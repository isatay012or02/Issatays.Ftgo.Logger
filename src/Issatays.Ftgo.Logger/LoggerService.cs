using Microsoft.Extensions.Logging;

namespace Issatays.Ftgo.Logger;

public class LoggerService(ILogger logger) : ILoggerService
{
    public void LogDebug(string action, string message, string customMessage, 
        object data, Dictionary<string, string> additionalFields)
    {
        Log(action, default, message, customMessage, data, additionalFields, LogLevel.Debug);
    }

    public void LogInfo(string action, string message, string customMessage,
        object data, Dictionary<string, string> additionalFields)
    {
        Log(action, default, message, customMessage, data, additionalFields, LogLevel.Information);
    }

    public void LogWarning(string action, string message, string customMessage,
        object data, Dictionary<string, string> additionalFields)
    {
        Log(action, default, message, customMessage, data, additionalFields, LogLevel.Warning);
    }

    public void LogError(string action, int code, string message, string customMessage,
        object data, Dictionary<string, string> additionalFields)
    {
        Log(action, code, message, customMessage, data, additionalFields, LogLevel.Error);
    }

    private void Log(string action, int code, string message, string customMessage, object data, 
        Dictionary<string, string> additionalFields, LogLevel logLevel)
    {
        switch (logLevel)
        {
            case LogLevel.Debug:
                logger.LogDebug("{Action} {Message} {CustomMessage} {Data} {AdditionalFields}",
                    action, message, customMessage, message, additionalFields);
                break;
            case LogLevel.Information:
                logger.LogInformation("{Action} {Message} {CustomMessage} {Data} {AdditionalFields}",
                    action, message, customMessage, data, additionalFields);
                break;
            case LogLevel.Warning:
                logger.LogWarning("{Action} {Message} {CustomMessage} {Data} {AdditionalFields}",
                    action, message, customMessage, data, additionalFields);
                break;
            case LogLevel.Error:
                logger.LogError("{Action} {Code} {Message} {CustomMessage} {Data} {AdditionalFields}",
                    action, code, message, customMessage, data, additionalFields);
                break;
        }
    }
}