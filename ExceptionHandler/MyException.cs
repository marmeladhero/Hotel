namespace ExceptionHandler
{
    using System;
    using System.IO;
    using System.Text;
    public class MyException : Exception
    {
        readonly object _syncObject = new object();
        public virtual string Path { set; get; }

        public MyException(string message) : base(message)
        {
            Log(message, base.StackTrace);
        }

        public MyException(string message, Exception innerException) : base(message, innerException)
        {
            Log(innerException.Message, innerException.StackTrace);
        }

        protected void Log(string exMessage, string stacktrace)
        {
            lock (_syncObject)
            {
                using (StreamWriter writer = new StreamWriter(Path ?? "log.txt", true, Encoding.Unicode))
                {
                    writer.Write(string.Format("[{0}]\r\n{1}\r\n{2}\r\n{3}\r\n",
                        DateTime.Now,
                        exMessage,
                        stacktrace,
                        new string('-', 80)));
                }
            }
        }
    }
}

