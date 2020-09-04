using MasterProxy.Interfaces;
using System;

namespace MasterProxyWinform
{
    public class Log4netLogger : IMasterLogger
    {
        public delegate void BeforeWriteLogDelegate(object message);
        public BeforeWriteLogDelegate BeforeWriteLog;
        public void Debug(object message)
        {
            BeforeWriteLog(message);
            Program.Logger.Debug(message);
        }

        public void Error(object message, Exception ex)
        {
            BeforeWriteLog(message);
            Program.Logger.Error(message, ex);
        }

        public void Info(object message)
        {
            BeforeWriteLog(message);
            Program.Logger.Info(message);
        }
    }
}