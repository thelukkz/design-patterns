using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.Instance;

            logger.Log(string.Format("Logging started at {0}", DateTime.Now));
            logger.Log("Hello World!");
            logger.Log(string.Format("Logging ended at {0}", DateTime.Now));
        }
    }
}
