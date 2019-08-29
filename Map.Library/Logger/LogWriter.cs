using System.IO;

namespace Map.Library.Logger
{
    public class LogWriter : ILogWriter
    {
        public void WriteMessage(string message)
        {
            const string filePath = "C:\\temp\\MapWebApplicationLog.txt";
            var file = new FileInfo(filePath);
            file.Directory?.Create();

            using (var stream = new StreamWriter(filePath,true))
            {
                stream.WriteLine(message);
            }
        }
    }
}