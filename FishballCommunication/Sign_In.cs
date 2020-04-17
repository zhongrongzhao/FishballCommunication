using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishballCommunication
{
    public partial class Form_Sign_In : Form
    {
        Method method = new Method();
        Define_All define_All = new Define_All();
        private Point mPoint;

        public Form_Sign_In()
        {
            InitializeComponent();
        }

        private void Btn_Register_Exit_Click(object sender, EventArgs e)
        {
            method.Method_Change_State("N");
            this.Close();
        }

        private void Btn_Sign_In_Click(object sender, EventArgs e)
        {
            method.Method_Get_Login_Account_And_Account(txt_Account.Text, txt_Password.Text);
            method.Method_Sign_in(LoginCrypt.GetMd5(Method.Login_Account), LoginCrypt.GetMd5(Method.Login_PassW));         
            if (method.Show_Main_Table == 1)
            {
                Method.Account_Me = LoginCrypt.GetMd5(Method.Login_Account);
                Method.Account_You = method.Method_Get_TaAccount();
                string[] sKeys = RSACrypt.GenerateKeys();
                Method.My_PrivateKey = sKeys[0];
                Method.PublicKey = sKeys[1];
                method.Method_Send_PrivateKey();
                this.Hide();
            }
            method.Method_Change_State("O");
        }

        private void Btn_Find_Password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            method.Method_Open_Brower("http://zhongrongzhao.hknet3.iis800.com/");
        }

        private void Btn_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            method.Method_Open_Brower("http://zhongrongzhao.hknet3.iis800.com/");
        }

        #region 让panel代替窗体标签栏，使窗体能够挪动
        private void Form_Sign_In_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void Form_Sign_In_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }
        #endregion
    }
}
