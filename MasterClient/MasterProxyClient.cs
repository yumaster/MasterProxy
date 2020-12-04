using log4net;
using Microsoft.Extensions.Configuration;
using MasterProxy.Client;
using MasterProxy.Data;
using MasterProxy.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net.Config;
using Exception = System.Exception;
using MasterProxy.Shared;
using Protocol = MasterProxy.Data.Protocol;
using MasterProxy.Infrastructure;

namespace MasterProxy
{
    class MasterProxyClient
    {
        #region logger
        public class Log4netLogger : IMasterLogger
        {
            public void Debug(object message)
            {
                //Logger.Debug(message);
                Logger.Debug(message);
            }

            public void Error(object message, Exception ex)
            {
                //Logger.Debug(message);
                Logger.Error(message, ex);
            }

            public void Info(object message)
            {
                Logger.Info(message);
            }
        }
        #endregion

        public static ILog Logger;
        public static IConfigurationRoot Configuration { get; set; }
        private static LoginInfo _currentLoginInfo;
        private static readonly string ConfigFilePath = ConfigHelper.AppSettingFullPath;
        public void Start(string[] args)
        {
            //appSettingFilePath = Directory.GetCurrentDirectory() + "/appsettings.json";
            //log
            var loggerRepository = LogManager.CreateRepository("MasterClientRouterRepository");
            XmlConfigurator.Configure(loggerRepository, new FileInfo("log4net.config"));
            MasterProxyClient.Logger = LogManager.GetLogger(loggerRepository.Name, "MasterServerClient");
            if (!loggerRepository.Configured) throw new Exception("log config failed.");
            Console.ForegroundColor = ConsoleColor.Yellow;

            //用户登录 e.g.: ./MasterProxyClient -u admin -p admin
            if (args.Length == 4)
            {
                _currentLoginInfo = new LoginInfo();
                _currentLoginInfo.UserName = args[1];
                _currentLoginInfo.UserPwd = args[3];
            }

            Logger.Info($"*** {MPVersion.MasterProxyClientName} ***");

            //start clientrouter.
            try
            {
                StartClient().Wait();
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
            }
            Console.Read();
            Logger.Info("客户端已终止，请按任意键继续。");

        }

        private static async Task StartClient()
        {

            Router clientRouter = new Router(new Log4netLogger());
            //read config from config file.
            clientRouter.SetConfiguration(ConfigHelper.ReadAllConfig<MPClientConfig>(ConfigFilePath));
            if (_currentLoginInfo != null)
            {
                clientRouter.SetLoginInfo(_currentLoginInfo);
            }

            Task tsk = clientRouter.Start(true);
            try
            {
                await tsk;
            }
            catch (Exception e)
            {
                Logger.Error(e);
                throw;
            }

        }

        public void Stop()
        {
            //
            Console.WriteLine(MPVersion.MasterProxyServerName + " STOPPED.");
            Environment.Exit(0);
        }
    }
}
