using System.IO;

namespace FileLoggerDisposableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use FileLogger and dispose of it properly
            using (FileLogger fileLogger = new FileLogger("log.txt"))

            {
                fileLogger.Log("Log entry 1");
                fileLogger.Log("Log entry 2");
                fileLogger.Log("Log entry 3");
            }

        }
    }

    class FileLogger : IDisposable
    {
        private StreamWriter _writer;
        bool _disposed = false;

        public FileLogger(string filePath)
        {
            // Initialize StreamWriter instance
            _writer = new StreamWriter(filePath);   
        }
        ~FileLogger()
        {
Dispose(false);
        }
        private void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }
             if (disposing)
                {
                     // Dispose managed resources
                    if (_writer != null)
                    {
                        _writer?.Dispose();
                        _writer = null;
                    }
              }

            // Dispose unmanaged resources
           _disposed = true;
            
        }
        public void Dispose()
        {
            // Implement IDisposable pattern
            Dispose(true);
            GC.SuppressFinalize(this);

        }

        public void Log(string message)
        {
            // Write message to the file
            if (_disposed)
                throw new ObjectDisposedException("FileLogger");

            _writer.WriteLine($"{DateTime.Now}: {message}");
        }
    }
}