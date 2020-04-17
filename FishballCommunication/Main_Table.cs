using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using ListViewItem = System.Windows.Forms.ListViewItem;

namespace FishballCommunication
{
    public partial class Main_Table : Form
    {
        Define_All define_all = new Define_All();
        private Point mPoint;
        public string message;
        //SqlConnection conn;
        public Main_Table()
        {
            InitializeComponent();
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            txt_Message_Table.AppendText("Me "+DateTime.Now+"\n"+ txt_Sent_Message_Table.Text+ "\n\n");
            message = RSACrypt.EncryptString(txt_Sent_Message_Table.Text, Method.PublicKey);
            Thread thread = new Thread(() =>
            {
                Method method = new Method();
                method.Method_SendMessage(message);
            });
            thread.Start();     
            txt_Sent_Message_Table.Text = "";
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            Application.OpenForms["Main_Table"].Hide();//隐藏指定窗体
        }

        private void Btn_Min_Size_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void panel_Top_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

        private void Btn_DouYiDou_Click(object sender, EventArgs e)
        {
            txt_Message_Table.AppendText("Me " + DateTime.Now + " 给Ta发了一个抖一抖" + "\n\n");
            Method method = new Method();
            method.Method_Send_Douyidou();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Method method = new Method();
            method.Method_Change_State("N");
            method.Method_Exit_Clean();
            method.Method_Exit_Clean_State();
            System.Environment.Exit(0);
        }

        private void 主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
        }
        
        private void Main_Table_Load(object sender, EventArgs e)
        {       
            this.fSC_LoginTableAdapter.Fill(this.fishball_Secure_CommunicationDataSet.FSC_Login);
            
            Thread thread = new Thread(() =>
            {
                while(true)
                {
                    Get_Message();
                }          
            });
            thread.Start();

            Thread thread_Dou = new Thread(() => 
            {
                while (true)
                {
                    Get_Douydou();
                }
            });
            thread_Dou.Start();

            Thread thread_Set_PrivateKey = new Thread(() =>
            {
                while(label_State.Equals("下线"))
                {
                    Method method = new Method();
                    method.Method_Set_PrivateKey();
                }
            });
        }

        private void Get_Douydou()
        {
            Method method = new Method();
            if (method.Method_Get_Douyidou().Equals("O"))
            {
                this.Show();
                notifyIcon1.Visible = false;
                Invoke(new MethodInvoker(delegate ()
                {           
                    Random ran = new Random((int)DateTime.Now.Ticks);
                    Point point = this.Location;
                    for (int i = 0; i < 40; i++)
                    {
                        this.Location = new Point(point.X + ran.Next(8) - 4, point.Y + ran.Next(8) - 4);
                        System.Threading.Thread.Sleep(5);
                        this.Location = point;
                        System.Threading.Thread.Sleep(5);
                    }
                    method.Method_Set_Douyidou();
                }));
            }   
        }

        private void Get_Message()
        {
            Method method = new Method();
            using (SqlConnection conn = new SqlConnection(define_all.DB_Sign_in))
            {
                conn.Open();
                string sql = "select * from FSC_Login where Account='" + Method.Account_You+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                string State = sdr.GetString(sdr.GetOrdinal("Order_Already_Read"));
                while (State.Equals("N"))
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        txt_Message_Table.AppendText("Ta " + DateTime.Now + "\n" + method.Method_Get_Message() + "\n\n");
                        method.Method_Set_Order_Already_Read();
                    }));
                    break;
                }
            }

        }

        private void Btn_Welcome_Min_Size_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Welcome_Close_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            Application.OpenForms["Main_Table"].Hide();//隐藏指定窗体
        }

        private void panel_Welcome_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void panel_Welcome_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

        private void panel_Center_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void panel_Center_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

        private void linkLabel_Aim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            richTextBox1.Visible = true;
            linkLabel_Aim.Visible = false;
            linkLabel_Aim_Close.Visible = true;
        }

        private void linkLabel_Aim_Close_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            richTextBox1.Visible = false;
            linkLabel_Aim.Visible = true;
            linkLabel_Aim_Close.Visible = false;
        }
        public void Check_Stute()
        {
            Method method = new Method();
            string Get_Stute = method.Method_Show_Account_State();
            if (Get_Stute.Equals("O"))
            {
                label_State.Text = "在线";
                Btn_Send.Enabled = true;
                Btn_DouYiDou.Enabled = true;
            }
            if (Get_Stute.Equals("N"))
            {
                label_State.Text = "下线";
                Btn_Send.Enabled = false;
                Btn_DouYiDou.Enabled = false;
            }
        }

        
        private void Btn_Commu_Click(object sender, EventArgs e)
        {
            Check_Stute();
            
            panel_Right.Visible = true;
            panel_Welcome.Visible = false;           
        }

        private void panel_Center_Click(object sender, EventArgs e)
        {
            Check_Stute();
        }

        private void panel_Top_Click(object sender, EventArgs e)
        {
            Check_Stute();
        }

        private void txt_Message_Table_Click(object sender, EventArgs e)
        {
            Check_Stute();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Check_Stute();
        }

        private void txt_Sent_Message_Table_Click(object sender, EventArgs e)
        {
            Check_Stute();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Check_Stute();
        }

        private void txt_Message_Table_MouseHover(object sender, EventArgs e)
        {
            Check_Stute();
        }

        private void txt_Message_Table_TextChanged(object sender, EventArgs e)
        {
            this.txt_Message_Table.SelectionStart = this.txt_Message_Table.Text.Length;
            this.txt_Message_Table.SelectionLength = 0;
            this.txt_Message_Table.ScrollToCaret();
        }

        private void Btn_Send_MouseHover(object sender, EventArgs e)
        {
            Btn_Send.ForeColor = Color.White;
            Btn_Send.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
        }

        private void Btn_Send_MouseDown(object sender, MouseEventArgs e)
        {
            Btn_Send.ForeColor = Color.White;
            Btn_Send.FlatAppearance.MouseDownBackColor = Color.CadetBlue;
        }

        private void Btn_Send_MouseLeave(object sender, EventArgs e)
        {
            Btn_Send.ForeColor = Color.Black;
            Btn_Send.BackColor = Color.Gainsboro;
        }

        private void Btn_DouYiDou_MouseHover(object sender, EventArgs e)
        {
            Btn_DouYiDou.ForeColor = Color.White;
            Btn_DouYiDou.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
        }

        private void Btn_DouYiDou_MouseDown(object sender, MouseEventArgs e)
        {
            Btn_DouYiDou.ForeColor = Color.White;
            Btn_DouYiDou.FlatAppearance.MouseDownBackColor = Color.CadetBlue;
        }

        private void Btn_DouYiDou_MouseLeave(object sender, EventArgs e)
        {
            Btn_DouYiDou.ForeColor = Color.Black;
            Btn_DouYiDou.BackColor = Color.Gainsboro;
        }

        private void Btn_Setting_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
        }

        private void Btn_Setting2_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
        }

        private void 赞助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Method method = new Method();
            method.Method_Open_Brower("https://zhongrongzhao.github.io/support.html");
        }
    }
}
