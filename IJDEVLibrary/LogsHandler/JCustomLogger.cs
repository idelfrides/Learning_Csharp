using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using IJDEVLibrary.DataTimeManager;


namespace IJDEVLibrary.LogsHandler
{
    public enum LogLevel
    {
        Critical = 1,
        Error = 2,
        Warning = 3,
        Info = 4,
        Debug = 5,
        Trace = 6
    }

    public interface IJCustomLogger
    {
        void Log(LogLevel level, string message, 
                    Dictionary<string, object>? properties = null,
                    Exception? exception = null,
                    [CallerMemberName] string memberName = "",
                    [CallerFilePath] string filePath = "",
                    [CallerLineNumber] int lineNumber = 0);

        void Trace(string message, Dictionary<string, object>? properties = null,
                    Exception? exception = null,
                    [CallerMemberName] string memberName = "",
                    [CallerFilePath] string filePath = "",
                    [CallerLineNumber] int lineNumber = 0);

        void Debug(string message, Dictionary<string, object>? properties = null,
                    Exception? exception = null,
                    [CallerMemberName] string memberName = "",
                    [CallerFilePath] string filePath = "",
                    [CallerLineNumber] int lineNumber = 0);

        void Info(string message, Dictionary<string, object>? properties = null,
                    Exception? exception = null,
                    [CallerMemberName] string memberName = "",
                    [CallerFilePath] string filePath = "",
                    [CallerLineNumber] int lineNumber = 0);

        void Warn(string message, Dictionary<string, object>? properties = null,
                    Exception? exception = null,
                    [CallerMemberName] string memberName = "",
                    [CallerFilePath] string filePath = "",
                    [CallerLineNumber] int lineNumber = 0);

        void Error(string message, Exception? exception = null,
                    Dictionary<string, object>? properties = null,
                    [CallerMemberName] string memberName = "",
                    [CallerFilePath] string filePath = "",
                    [CallerLineNumber] int lineNumber = 0);

        void Critical(string message, Exception? exception = null,
                        Dictionary<string, object>? properties = null,
                        [CallerMemberName] string memberName = "",
                        [CallerFilePath] string filePath = "",
                        [CallerLineNumber] int lineNumber = 0);
    }

    public class JCustomLogger : IJCustomLogger
    {
        private readonly string _loggerName;
        private readonly DateTimeConverter dtc = new();

        public JCustomLogger(string loggerName = "DefaultLogger")
        {
            _loggerName = loggerName;
        }

        public void Log(LogLevel level, string message, 
                        Dictionary<string, object>? properties = null,
                        Exception? exception = null,
                        string memberName = "", string filePath = "", int lineNumber = 0)
        {
         
            var brasiliaTime = dtc.ConvertUtcToTimeZone(DateTime.UtcNow, "E. South America Standard Time");
            var className = System.IO.Path.GetFileNameWithoutExtension(filePath);
            var structuredProps = properties != null
                ? string.Join(", ", properties.Select(p => $"{p.Key}={p.Value}"))
                : string.Empty;

            var logEntry = $"[{brasiliaTime}][{_loggerName}][{level}: " +
                            $"Class={className}, Method={memberName}, Line={lineNumber}]\n\n\t:::>> {message}" +
                            (string.IsNullOrWhiteSpace(structuredProps) ? "" : $" | {structuredProps}") +
                            (exception != null ? $" | Exception: {exception}" : "");
            
            Console.WriteLine($"\n{logEntry}");
        }

        public void Trace(string message, 
                         Dictionary<string, object>? properties = null,
                         Exception? exception = null,
                         [CallerMemberName] string memberName = "",
                         [CallerFilePath] string filePath = "",
                         [CallerLineNumber] int lineNumber = 0)
            => Log(LogLevel.Trace, message, properties, exception, memberName, filePath, lineNumber);

        public void Debug(string message, 
                         Dictionary<string, object>? properties = null,
                         Exception? exception = null,
                         [CallerMemberName] string memberName = "", 
                         [CallerFilePath] string filePath = "",
                         [CallerLineNumber] int lineNumber = 0)
            => Log(LogLevel.Debug, message, properties, exception, memberName, filePath, lineNumber);

        public void Info(string message, 
                        Dictionary<string, object>? properties = null,
                        Exception? exception = null,
                        [CallerMemberName] string memberName = "",
                        [CallerFilePath] string filePath = "",
                        [CallerLineNumber] int lineNumber = 0)
        {
            Log(LogLevel.Info, message, properties, exception, memberName, filePath, lineNumber);
        }

        public void Warn(string message, 
                        Dictionary<string, object>? properties = null,
                        Exception? exception = null,
                        [CallerMemberName] string memberName = "", 
                        [CallerFilePath] string filePath = "",
                        [CallerLineNumber] int lineNumber = 0)
            => Log(LogLevel.Warning, message, properties, exception, memberName, filePath, lineNumber);

        public void Error(string message, Exception? exception = null,
                            Dictionary<string, object>? properties = null,
                            [CallerMemberName] string memberName = "",
                            [CallerFilePath] string filePath = "",
                            [CallerLineNumber] int lineNumber = 0)
            => Log(LogLevel.Error, message, properties, exception, memberName, filePath, lineNumber);

        public void Critical(string message, Exception? exception = null,
                                Dictionary<string, object>? properties = null,
                                [CallerMemberName] string memberName = "",
                                [CallerFilePath] string filePath = "",
                                [CallerLineNumber] int lineNumber = 0)
            => Log(LogLevel.Critical, message, properties, exception, memberName, filePath, lineNumber);
    }
    
}
