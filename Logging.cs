namespace CotLTemplateMod;

public static class Logging
{
    public static ManualLogSource Logger => Plugin.Log;
    
    public static void Log(LogLevel level, string message) => Logger.Log(level, message);
    public static void LogInfo(string message) => Logger.LogInfo(message);
    public static void LogDebug(string message) => Logger.LogDebug(message);
    public static void LogWarning(string message) => Logger.LogWarning(message);
    public static void LogError(string message) => Logger.LogError(message);
    public static void LogFatal(string message) => Logger.LogFatal(message);
}