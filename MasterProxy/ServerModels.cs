using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using MasterProxy.Infrastructure;

namespace MasterProxy
{
    public struct ClientIDAppID
    {
        public int ClientID;
        public int AppID;
    }

    /// <summary>
    /// mpclient集合 clientid->MPClient
    /// </summary>
    public class MPClientCollection:IEnumerable<MPClient>
    {
        private ConcurrentDictionary<int, MPClient> ClientMap;

        public MPClient this[int index]
        {
            get => ClientMap[index];
            set => ClientMap[index] = value;
        }
        public MPClientCollection()
        {
            ClientMap = new ConcurrentDictionary<int, MPClient>();
        }

        public bool ContainsKey(int key)
        {
            return ClientMap.ContainsKey(key);
        }

        public void RegisterNewClient(int key)
        {
            
                ClientMap.TryAdd(key,new MPClient()
                {
                    ClientID = key,
                    LastUpdateTime = DateTime.Now
                });
        }

        public void UnRegisterClient(int key)
        {
            //关闭所有连接
            //int closedClients = ClientMap[key].Close();
            this.ClientMap.TryRemove(key,out _);
            //停止端口侦听
            //return closedClients;
        }

        public IEnumerator<MPClient> GetEnumerator()
        {
            return ClientMap.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


    public class AppChangedEventArgs : EventArgs
    {
        public MPApp App;
    }

}