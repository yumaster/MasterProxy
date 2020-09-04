namespace MasterProxy.Data.DBEntites
{
    public class User
    {
        public string userId;
        public string userPwd;
        public string userName;
        public string regTime;
        public string isAdmin;
        public string isAnonymous; //1表示是 0表示否，匿名用户
    }
}
