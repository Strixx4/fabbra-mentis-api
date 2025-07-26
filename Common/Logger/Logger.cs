namespace Common.Logger;

public static class Logger
{
    public static void LogStartProject(string projectName)
    {
        LogTimeStampAndType(LogLevel.Info);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Starting: ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(projectName + "\n \n");
    }

    public static void LogEndProject(string projectName)
    {
        LogTimeStampAndType(LogLevel.Info);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Ending: ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(projectName);
        Console.Write(projectName + "\n \n");
    }

    public static void LogStartOperation(string operationName)
    {
        LogTimeStampAndType(LogLevel.Info);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Start: ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"{operationName} \n");
    }

    public static void LogEndOperation(string operationName)
    {
        LogTimeStampAndType(LogLevel.Info);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("End: ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(operationName + "\n \n");
    }

    public static void ErrorLog(
        string message,
        Exception exception)
    {
        LogTimeStampAndType(LogLevel.Error);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Error: {message}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(exception.Message);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Stack Trace");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(exception.StackTrace + "\n");
    }

    public static void Log(string message)
    {
        LogTimeStampAndType(LogLevel.Info);
        Console.WriteLine(message);
    }

    public static void LogWarn(string message)
    {
        LogTimeStampAndType(LogLevel.Warning);
        Console.Write(message);
    }

    private static void LogTimeStampAndType(LogLevel logLevel)
    {
        Console.Write($"{DateTime.Now:HH:mm:ss} [");
        Console.ForegroundColor = logLevel switch
        {
            LogLevel.Info => ConsoleColor.Blue,
            LogLevel.Warning => ConsoleColor.Yellow,
            LogLevel.Error => ConsoleColor.Red,
            _ => ConsoleColor.White
        };
        Console.Write(logLevel.ToString());
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("] ");
    }
}

internal enum LogLevel
{
    Info,
    Warning,
    Error
}
