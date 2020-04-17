namespace FishballCommunication
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox_Create_Shortcut_On_Desktop = new System.Windows.Forms.CheckBox();
            this.Btn_Enter = new System.Windows.Forms.Button();
            this.Btn_Cansel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 325);
            this.panel1.TabIndex = 0;
            // 
            // checkBox_Create_Shortcut_On_Desktop
            // 
            this.checkBox_Create_Shortcut_On_Desktop.AutoSize = true;
            this.checkBox_Create_Shortcut_On_Desktop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_Create_Shortcut_On_Desktop.Location = new System.Drawing.Point(181, 58);
            this.checkBox_Create_Shortcut_On_Desktop.Name = "checkBox_Create_Shortcut_On_Desktop";
            this.checkBox_Create_Shortcut_On_Desktop.Size = new System.Drawing.Size(123, 21);
            this.checkBox_Create_Shortcut_On_Desktop.TabIndex = 5;
            this.checkBox_Create_Shortcut_On_Desktop.Text = "创建桌面快捷方式";
            this.checkBox_Create_Shortcut_On_Desktop.UseVisualStyleBackColor = true;
            // 
            // Btn_Enter
            // 
            this.Btn_Enter.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Enter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Enter.FlatAppearance.BorderSize = 0;
            this.Btn_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Enter.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Enter.Location = new System.Drawing.Point(246, 281);
            this.Btn_Enter.Name = "Btn_Enter";
            this.Btn_Enter.Size = new System.Drawing.Size(75, 23);
            this.Btn_Enter.TabIndex = 7;
            this.Btn_Enter.Text = "确定";
            this.Btn_Enter.UseVisualStyleBackColor = false;
            this.Btn_Enter.Click += new System.EventHandler(this.Btn_Enter_Click);
            // 
            // Btn_Cansel
            // 
            this.Btn_Cansel.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Cansel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Cansel.FlatAppearance.BorderSize = 0;
            this.Btn_Cansel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cansel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cansel.Location = new System.Drawing.Point(342, 281);
            this.Btn_Cansel.Name = "Btn_Cansel";
            this.Btn_Cansel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cansel.TabIndex = 6;
            this.Btn_Cansel.Text = "取消";
            this.Btn_Cansel.UseVisualStyleBackColor = false;
            this.Btn_Cansel.Click += new System.EventHandler(this.Btn_Cansel_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(493, 325);
            this.Controls.Add(this.Btn_Enter);
            this.Controls.Add(this.Btn_Cansel);
            this.Controls.Add(this.checkBox_Create_Shortcut_On_Desktop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password_Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox_Create_Shortcut_On_Desktop;
        private System.Windows.Forms.Button Btn_Enter;
        private System.Windows.Forms.Button Btn_Cansel;
    }
}