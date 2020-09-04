using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MasterProxy.Infrastructure.Interfaces
{
    public interface IWebController
    {
        void SetContext(HttpListenerContext context);
    }
}
