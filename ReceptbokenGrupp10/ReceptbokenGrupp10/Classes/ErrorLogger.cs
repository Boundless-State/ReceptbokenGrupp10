using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ReceptbokenGrupp10.Classes
{
  
    public class ErrorLog
    {
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public DateTime Timestamp { get; set; }

        public ErrorLog(string message, string stackTrace)
        {
            Message = message;
            StackTrace = stackTrace;
            Timestamp = DateTime.Now;
        }
    }

    public class ErrorLogger
    {
        private readonly string _logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Resources\ErrorLoger.json");


        public void LogCustomError(Exception ex)
        {
            var errorLog = new ErrorLog(ex.Message, ex.StackTrace);
            LogError(errorLog);
        }

        private void LogError(ErrorLog errorLog)
        {
            try
            {
                //deserialize the errorlog, if it dosent exist create a new errorlog
                var existingLogs = File.Exists(_logFilePath)
                      ? JsonSerializer.Deserialize<List<ErrorLog>>(File.ReadAllText(_logFilePath))
                      : new List<ErrorLog>();

                existingLogs.Add(errorLog);
                //new JsonSerializerOptions { WriteIndented = true })); To format the jsonfile, else it will be on the same line
                File.WriteAllText(_logFilePath, JsonSerializer.Serialize(existingLogs, new JsonSerializerOptions { WriteIndented = true }));

            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to log error: {e.Message}");
            }
        }
    }
}