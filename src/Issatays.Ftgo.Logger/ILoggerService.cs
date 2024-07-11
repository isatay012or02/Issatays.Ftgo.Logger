namespace Issatays.Ftgo.Logger;

public interface ILoggerService
{
    void LogDebug(string action, string message, string customMessage,
        object data, Dictionary<string, string> additionalFields);

    void LogInfo(string action, string message, string customMessage,
        object data, Dictionary<string, string> additionalFields);

    void LogWarning(string action, string message, string customMessage,
        object data, Dictionary<string, string> additionalFields);

    void LogError(string action, int code, string message, string customMessage,
        object data, Dictionary<string, string> additionalFields);
}