namespace _31_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger;
            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();

            DatabaseLogger databaseLogger = new DatabaseLogger("test");
            databaseLogger.WriteLog();

            SmsLogger smsLogger = new();
            smsLogger.WriteLog();

            LogManager logManager = new LogManager(new DatabaseLogger("test"));
            logManager.WriteLog();

        }
    }
}