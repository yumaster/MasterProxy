﻿using System.Collections.Generic;

namespace MasterProxy.Data
{
    public class ClientUserCacheItem
    {
        //public string ServerEndPoint { get; set; }
        public string UserName { get; set; }
        //public string UserPwd { get; set; }
        public string Token { get; set; }
    }


    /// <summary>
    /// key服务器名 value用户
    /// </summary>
    public class ClientUserCache : Dictionary<string, ClientUserCacheItem>
    {

    }
}
