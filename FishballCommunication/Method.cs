using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace FishballCommunication
{
    public class Method : Define_All
    {
        //Define_All define_All = new Define_All();
        Main_Table main_Table = new Main_Table();
        public int Show_Main_Table;

    public string Method_Get_TaAccount()
    {
            using (SqlConnection conn = new SqlConnection(DB_Sign_in))
            {
                conn.Open();
                string sql = "select * from FSC_Login where Account !='" + Account_Me + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                string TaAccount = sdr.GetString(sdr.GetOrdinal("Account"));
                return TaAccount;
            }
        }
        /// <summary>
        /// 登录界面
        /// 实现登录，并关闭登录界面，弹出主界面
        /// </summary>
        /// <param name="txt_Account"></param>
        /// <param name="txt_Password"></param>
        public void Method_Sign_in(string txt_Account, string txt_Password)
        {
            using (SqlConnection conn = new SqlConnection(DB_Sign_in))
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
                        //Get_Account();
                        Show_Main_Table = 1;
                        main_Table.Show();
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

        public void Method_Get_Login_Account_And_Account(string Account, string PassW)
        {
            Login_Account = Account;
            Login_PassW = PassW;
        }

        /// <summary>
        /// 任何界面
        /// 实现打开浏览器并打开指定网站
        /// </summary>
        /// <param name="URL"></param>
        public void Method_Open_Brower(string URL)
        {
            System.Diagnostics.Process.Start(URL);
        }

        /// <summary>
        /// 发信息
        /// </summary>
        /// <param name="message"></param>
        public void Method_SendMessage(string message)
        {
            SqlConnection conn;
            using (conn = new SqlConnection(DB_Sign_in))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "update FSC_Login set Chat = '" + message + "' , Order_Already_Read = 'N' where Account = '" + Account_Me + "'";
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

        public void Method_Change_State(string State)
        {
            SqlConnection conn;
            using (conn = new SqlConnection(DB_Sign_in))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    if (State.Equals("O"))
                    {
                        cmd.CommandText = "update FSC_Login set State = 'O' where Account = '" + Account_Me + "'";
                    }
                    if (State.Equals("N"))
                    {
                        cmd.CommandText = "update FSC_Login set State = 'N' where Account = '" + Account_Me + "'";
                    }
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

        public string Method_Show_Account_State()
        {
            using (SqlConnection conn = new SqlConnection(DB_Sign_in))
            {
                conn.Open();
                string sql = "select * from FSC_Login where Account='"+Account_You+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                string State = sdr.GetString(sdr.GetOrdinal("State"));
                return State;
            }
        }

        public string Method_Get_Message()
        {
            Method_Get_PrivateKey();
            using (SqlConnection conn = new SqlConnection(DB_Sign_in))
            {
                conn.Open();
                string sql = "select * from FSC_Login where Account='" + Account_You+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                string State = sdr.GetString(sdr.GetOrdinal("Chat"));
                string State2 = RSACrypt.DecryptString(State, You_PrivateKey);
                return State2;
            }
        }

        /// <summary>
        /// 发送私钥
        /// </summary>
        public void Method_Send_PrivateKey()
        {
            SqlConnection conn;
            using (conn = new SqlConnection(DB_Sign_in))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "update FSC_Login set PrivateKey = '"+ My_PrivateKey+"',PrivateKey_State='N' where Account ='" +Account_Me+"'";
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

        private void Method_Get_PrivateKey()
        {
            using (SqlConnection conn = new SqlConnection(DB_Sign_in))
            {
                conn.Open();
                string sql = "select * from FSC_Login where Account='" + Account_You + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                You_PrivateKey = sdr.GetString(sdr.GetOrdinal("PrivateKey"));
            }
        }

        public void Method_Set_PrivateKey()
        {
            using (SqlConnection conn = new SqlConnection(DB_Sign_in))
            {
                conn.Open();
                string sql = "update FSC_Login set PrivateKey = null,PrivateKey_State='O' where Account ='" + Account_You + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                You_PrivateKey = sdr.GetString(sdr.GetOrdinal("PrivateKey"));
            }
        }

        public void Method_Set_Order_Already_Read()
        {
            SqlConnection conn;
            using (conn = new SqlConnection(DB_Sign_in))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "update FSC_Login set Order_Already_Read = 'O' where Account = '" + Account_You + "'";
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

        public void Method_Exit_Clean()
        {
            SqlConnection conn;
            using (conn = new SqlConnection(DB_Sign_in))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "update FSC_Login set Chat = null, Order_Already_Read = 'O',Dou_Dou = 'N'";
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

        public void Method_Exit_Clean_State()
        {
            SqlConnection conn;
            using (conn = new SqlConnection(DB_Sign_in))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "update FSC_Login set State = 'N',PrivateKey = null,PrivateKey_State='N' where Account ='" + Account_Me+"'";
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
        public void Method_Send_Douyidou()
        {
            SqlConnection conn;
            using (conn = new SqlConnection(DB_Sign_in))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "update FSC_Login set Dou_Dou = 'O' where Account = '"+Account_You+"'";
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

        public string Method_Get_Douyidou()
        {
            using (SqlConnection conn = new SqlConnection(DB_Sign_in))
            {
                conn.Open();
                string sql = "select * from FSC_Login where Account='" + Account_Me + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                string Douyidou = sdr.GetString(sdr.GetOrdinal("Dou_Dou"));
                return Douyidou;
            }
        }

        public void Method_Set_Douyidou()
        {
            SqlConnection conn;
            using (conn = new SqlConnection(DB_Sign_in))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "update FSC_Login set Dou_Dou = 'N' where Account = '" + Account_Me + "'";
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

        public void Method_Create_Shortcut_On_Desktop()
        {
            //添加引用 (com->Windows Script Host Object Model)，using IWshRuntimeLibrary;
            String shortcutPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "鱼蛋安全通讯.lnk");
            if (!System.IO.File.Exists(shortcutPath))
            {
                // 获取当前应用程序目录地址
                String exePath = Process.GetCurrentProcess().MainModule.FileName;
                IWshShell shell = new WshShell();
                // 确定是否已经创建的快捷键被改名了
                foreach (var item in Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "*.lnk"))
                {
                    WshShortcut tempShortcut = (WshShortcut)shell.CreateShortcut(item);
                    if (tempShortcut.TargetPath == exePath)
                    {
                        return;
                    }
                }
                WshShortcut shortcut = (WshShortcut)shell.CreateShortcut(shortcutPath);
                shortcut.TargetPath = exePath;
                shortcut.Arguments = "";// 参数  
                shortcut.Description = "鱼蛋安全通讯v1.0";
                shortcut.WorkingDirectory = Environment.CurrentDirectory;//程序所在文件夹，在快捷方式图标点击右键可以看到此属性  
                shortcut.IconLocation = exePath;//图标，该图标是应用程序的资源文件  
                //shortcut.Hotkey = "CTRL+SHIFT+W";//热键，发现没作用，大概需要注册一下  
                shortcut.WindowStyle = 1;
                shortcut.Save();
            }
        }

        /// <summary>
        /// 开机自启
        /// 调用方式：Fun_AutoStart(true)
        /// </summary>
        //public static void Fun_AutoStart(bool isAutoRun = true)
        //{
        //    try
        //    {
        //        string path = Application.ExecutablePath;
        //        RegistryKey rk = Registry.LocalMachine;
        //        RegistryKey rk2 = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
        //        if (isAutoRun)
        //            rk2.SetValue("System Security", path); //rk2.DeleteValue("OIMSServer", false);
        //        else
        //            rk2.DeleteValue("System Security", false);
        //        rk2.Close();
        //        rk.Close();
        //    }
        //    catch
        //    {
        //        MessageBox.Show("开机自动启动服务注册被拒绝!请确认有系统管理员权限!");
        //    }
        //}
    }
}
