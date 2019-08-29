using System.IO;

namespace Map.Library.Logger
{
    public class LogWriter : ILogWriter
    {
        public void WriteMessage(string message)
        {
            using (var stream = new StreamWriter("C:\\temp\\MapWebApplicationLog.txt",true))
            {
                stream.WriteLine(message);
            }
        }
    }
}