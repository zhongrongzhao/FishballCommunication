/*
 * 修复程序因bug强行退出后无法启动
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixBug
{
    public class Method_Fix
    {
        public static string Account_MD5;
        public void Method_Sign_in(string txt_Account, string txt_Password)
        {
            using (SqlConnection conn = new SqlConnection("Server = 服务器IP地址 ;database = 数据库名称; uid = 用户名;pwd =密码"))
            {
                try
                {
                    conn.Open();
                    string sql = "select * from FSC_Login where Account='" + txt_Account + "'and Passw='" + txt_Password + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        Method_Fix_Bug(txt_Account);
                        Form_Bug_Fix form_Bug_Fix = new Form_Bug_Fix();
                        MessageBox.Show("修复成功并提交Bug报告，请重启鱼蛋安全通讯", "您好");
                    }
                    else
                    {
                        MessageBox.Show("账户或密码有误！", "提示");
                    }
                    conn.Close();
                }
                catch (Exception a)
                {
                    Console.WriteLine("{0} Second exception caught.", a); //发生错误后，抛出出错原因
                    Console.ReadLine();
                }
            }
        }

        public static string Method_GetMd5(string plainStr)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes_md5_in = Encoding.UTF8.GetBytes(plainStr);
            byte[] bytes_md5_out = md5.ComputeHash(bytes_md5_in);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in bytes_md5_out)
            {
                sb.Append(b.ToString("x2").ToUpper());
            }
            return sb.ToString();
        }

        public static void Method_Fix_Bug(string Account)
        {
            SqlConnection conn;
            using (conn = new SqlConnection("Server = 服务器IP地址 ;database = 数据库名称; uid = 用户名;pwd =密码"))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "update FSC_Login set Chat = NULL,Order_Already_Read = 'O', State = 'N',Dou_Dou = 'N',PrivateKey = NULL, PrivateKey_State = 'N' where Account = '" + Account + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
