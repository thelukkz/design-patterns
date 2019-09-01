using System;
using System.IO;

namespace SingletonPattern
{
    class Logger
    {
        private static Logger _instance = null;
        private Stream logStream = null;
        private StreamWriter streamWriter = null;
        private static object _handle = new object();

        protected Logger()
        {
            logStream = File.Open("logfile.log", FileMode.Create);
            streamWriter = new StreamWriter(logStream);
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
            streamWriter.Write(message);
            streamWriter.Write(Environment.NewLine);
        }

        ~Logger()
        {
            try
            {
                streamWriter.Close();
                streamWriter.Dispose();
            }
            catch (Exception)
            {
            }
        }

        public static Logger Instance
        {
            get
            {
                lock (_handle)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                }

                return _instance;
            }
        }
    }
}
