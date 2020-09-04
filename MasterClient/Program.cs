using MasterProxy.Shared;
using PeterKottas.DotNetCore.WindowsService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MasterProxy.ServerHost
{
    public class Program
    {
        static void Main()
        {
            //wait
            ServiceRunner<MasterProxyClient>.Run(config =>
            {
                var name = Global.MPClientServiceDisplayName;
                config.SetDisplayName(Global.MPClientServiceName);
                config.SetName(Global.MPClientServiceDisplayName);
                config.SetDescription(MPVersion.MasterProxyClientName);

                config.Service(serviceConfig =>
                {
                    serviceConfig.ServiceFactory((extraArguments, controller) =>
                    {
                        return new MasterProxyClient();
                    });

                    serviceConfig.OnStart((service, extraParams) =>
                    {
                        Console.WriteLine("Service {0} started", name);
                        Task.Run(() => service.Start(extraParams.ToArray()));
                    });

                    serviceConfig.OnStop(service =>
                    {
                        Console.WriteLine("Service {0} stopped", name);
                        Task.Run(() => service.Stop());
                    });

                    serviceConfig.OnError(e =>
                    {
                        Console.WriteLine("Service {0} errored with exception : {1}", name, e.Message);
                    });
                });


            });
        }
    }
}