using System;

namespace PrinciplesDemo
{
    public static class Config
    {
        public const string ConnectionString = "Server=myServer;Database=myDb;User Id=myUser;Password=myPass;";
    }

    public class DryExamples
    {
        public class Logger
        {
            public void Log(string level, string message)
            {
                Console.WriteLine($"{level.ToUpper()}: {message}");
            }
        }

        public class DatabaseService
        {
            public void Connect()
            {
                Console.WriteLine($"Подключение к базе: {Config.ConnectionString}");
            }
        }

        public class LoggingService
        {
            public void Log(string message)
            {
                Console.WriteLine($"[{Config.ConnectionString}] Лог: {message}");
            }
        }
    }
}
