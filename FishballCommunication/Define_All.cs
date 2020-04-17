using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishballCommunication
{
    public class Define_All 
    {
        public string DataBase = "Fishball_Secure_Communication";
        public string DB_Sign_in = "data source=服务器IP地址,端口;User ID=用户名;pwd=密码;Initial Catalog=数据库名称 ";
        public string DB_Select_All = "select * from FSC_Login";
        public static string Account_Me;
        public static string Account_You;
        public static string My_PrivateKey, You_PrivateKey, PublicKey;
        public static string Login_Account, Login_PassW;
    }
}
