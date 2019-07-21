using System.IO;

namespace TestingInterfaces
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string message)
        {
            Log(message, MessageType.Error);
        }

        public void LogInfo(string message)
        {
            Log(message, MessageType.Info);
        }

        public void Log(string message, MessageType type)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(type + ": "+ message);
            }
        }
    }
}