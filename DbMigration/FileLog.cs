using System.IO;

namespace DbMigration
{
    public class FileLog : ILogger
    {
        private readonly string _path;

        public FileLog(string path)
        {
            _path = path;
        }
        public void LogInfo(string message)
        {
            Log("Info", message);
        }

        public void LogError(string message)
        {
            Log("Error", message);
        }

        private void Log(string message, string messageType)
        {
            // Stream writer uses a file resource.
            // File resource is not managed by the CLR.
            // So we need to dispose it when we're finished with it.
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": "+ message);
            }
        }
    }
}