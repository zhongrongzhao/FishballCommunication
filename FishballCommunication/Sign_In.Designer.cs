namespace FishballCommunication
{
    partial class Form_Sign_In
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Sign_In));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_Sign_In_Account = new System.Windows.Forms.PictureBox();
            this.pic_Sign_In_Password = new System.Windows.Forms.PictureBox();
            this.txt_Account = new System.Windows.Forms.TextBox();
            this.Bar1 = new System.Windows.Forms.Panel();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.Bar2 = new System.Windows.Forms.Panel();
            this.Btn_Sign_In = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Find_Password = new System.Windows.Forms.LinkLabel();
            this.Btn_Register = new System.Windows.Forms.LinkLabel();
            this.Btn_Register_Exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sign_In_Account)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sign_In_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Register_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 450);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pic_Sign_In_Account
            // 
            this.pic_Sign_In_Account.Image = ((System.Drawing.Image)(resources.GetObject("pic_Sign_In_Account.Image")));
            this.pic_Sign_In_Account.Location = new System.Drawing.Point(356, 126);
            this.pic_Sign_In_Account.Name = "pic_Sign_In_Account";
            this.pic_Sign_In_Account.Size = new System.Drawing.Size(31, 31);
            this.pic_Sign_In_Account.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Sign_In_Account.TabIndex = 1;
            this.pic_Sign_In_Account.TabStop = false;
            // 
            // pic_Sign_In_Password
            // 
            this.pic_Sign_In_Password.Image = ((System.Drawing.Image)(resources.GetObject("pic_Sign_In_Password.Image")));
            this.pic_Sign_In_Password.Location = new System.Drawing.Point(354, 189);
            this.pic_Sign_In_Password.Name = "pic_Sign_In_Password";
            this.pic_Sign_In_Password.Size = new System.Drawing.Size(27, 28);
            this.pic_Sign_In_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Sign_In_Password.TabIndex = 2;
            this.pic_Sign_In_Password.TabStop = false;
            // 
            // txt_Account
            // 
            this.txt_Account.BackColor = System.Drawing.Color.White;
            this.txt_Account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Account.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Account.Location = new System.Drawing.Point(387, 128);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.Size = new System.Drawing.Size(254, 28);
            this.txt_Account.TabIndex = 3;
            // 
            // Bar1
            // 
            this.Bar1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Bar1.Location = new System.Drawing.Point(356, 160);
            this.Bar1.Name = "Bar1";
            this.Bar1.Size = new System.Drawing.Size(285, 2);
            this.Bar1.TabIndex = 4;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.White;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Password.Location = new System.Drawing.Point(387, 189);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(254, 28);
            this.txt_Password.TabIndex = 5;
            // 
            // Bar2
            // 
            this.Bar2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Bar2.Location = new System.Drawing.Point(356, 221);
            this.Bar2.Name = "Bar2";
            this.Bar2.Size = new System.Drawing.Size(285, 2);
            this.Bar2.TabIndex = 5;
            // 
            // Btn_Sign_In
            // 
            this.Btn_Sign_In.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sign_In.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Sign_In.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Sign_In.Location = new System.Drawing.Point(403, 259);
            this.Btn_Sign_In.Name = "Btn_Sign_In";
            this.Btn_Sign_In.Size = new System.Drawing.Size(176, 47);
            this.Btn_Sign_In.TabIndex = 6;
            this.Btn_Sign_In.Text = "登录";
            this.Btn_Sign_In.UseVisualStyleBackColor = true;
            this.Btn_Sign_In.Click += new System.EventHandler(this.Btn_Sign_In_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fishball Secure Communication was Desigined in 2020";
            // 
            // Btn_Find_Password
            // 
            this.Btn_Find_Password.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Find_Password.AutoSize = true;
            this.Btn_Find_Password.LinkColor = System.Drawing.Color.Gray;
            this.Btn_Find_Password.Location = new System.Drawing.Point(584, 235);
            this.Btn_Find_Password.Name = "Btn_Find_Password";
            this.Btn_Find_Password.Size = new System.Drawing.Size(53, 12);
            this.Btn_Find_Password.TabIndex = 8;
            this.Btn_Find_Password.TabStop = true;
            this.Btn_Find_Password.Text = "找回密码";
            this.Btn_Find_Password.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Btn_Find_Password_LinkClicked);
            // 
            // Btn_Register
            // 
            this.Btn_Register.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Register.AutoSize = true;
            this.Btn_Register.LinkColor = System.Drawing.Color.Gray;
            this.Btn_Register.Location = new System.Drawing.Point(474, 321);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(29, 12);
            this.Btn_Register.TabIndex = 9;
            this.Btn_Register.TabStop = true;
            this.Btn_Register.Text = "注册";
            this.Btn_Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Btn_Register_LinkClicked);
            // 
            // Btn_Register_Exit
            // 
            this.Btn_Register_Exit.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Register_Exit.Image")));
            this.Btn_Register_Exit.Location = new System.Drawing.Point(701, 0);
            this.Btn_Register_Exit.Name = "Btn_Register_Exit";
            this.Btn_Register_Exit.Size = new System.Drawing.Size(24, 28);
            this.Btn_Register_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Register_Exit.TabIndex = 10;
            this.Btn_Register_Exit.TabStop = false;
            this.Btn_Register_Exit.Click += new System.EventHandler(this.Btn_Register_Exit_Click);
            // 
            // Form_Sign_In
            // 
            this.AcceptButton = this.Btn_Sign_In;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.Btn_Register_Exit);
            this.Controls.Add(this.Btn_Register);
            this.Controls.Add(this.Btn_Find_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Sign_In);
            this.Controls.Add(this.Bar2);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.Bar1);
            this.Controls.Add(this.txt_Account);
            this.Controls.Add(this.pic_Sign_In_Password);
            this.Controls.Add(this.pic_Sign_In_Account);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Sign_In";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Sign_In_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Sign_In_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sign_In_Account)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sign_In_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Register_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_Sign_In_Account;
        private System.Windows.Forms.PictureBox pic_Sign_In_Password;
        private System.Windows.Forms.Panel Bar1;
        private System.Windows.Forms.Panel Bar2;
        private System.Windows.Forms.Button Btn_Sign_In;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Btn_Find_Password;
        private System.Windows.Forms.LinkLabel Btn_Register;
        private System.Windows.Forms.PictureBox Btn_Register_Exit;
        public System.Windows.Forms.TextBox txt_Account;
        public System.Windows.Forms.TextBox txt_Password;
    }
}

