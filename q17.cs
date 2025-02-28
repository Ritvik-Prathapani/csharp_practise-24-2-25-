using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_exam
{
    interface ILogger
    {
        void Log(string message);
    }

    class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[FileLogger] {message}");
        }
    }
    abstract class LoggerDecorator : ILogger
    {
        protected ILogger logger;

        public LoggerDecorator(ILogger logger)
        {
            this.logger = logger;
        }

        public virtual void Log(string message)
        {
            logger.Log(message); 
        }
    }

    class TimestampLogger : LoggerDecorator
    {
        public TimestampLogger(ILogger logger) : base(logger) { }

        public override void Log(string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            base.Log($"[{timestamp}] {message}");
        }
    }

    class ErrorLogger : LoggerDecorator
    {
        public ErrorLogger(ILogger logger) : base(logger) { }

        public override void Log(string message)
        {
            base.Log($"[ERROR] {message}");
        }
    }
}
