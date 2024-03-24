using MYClassLibrary;
internal class Program
{
    private static void Main(string[] args)
    {
        // Створення файлового логера
        FileLoggerAdapter fileLogger = new FileLoggerAdapter("log.txt");

        // Використання логера
        fileLogger.Log("This is a log message.");
        fileLogger.Error("This is an error message.");
        fileLogger.Warn("This is a warning message.");
    }
}