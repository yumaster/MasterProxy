using System;
using System.Diagnostics;

namespace MasterProxy.Interfaces
{
    public interface IMasterLogger
    {
        void Debug(object message);
       
        void Error(object message,Exception ex);

        void Info(object message);
    }
}