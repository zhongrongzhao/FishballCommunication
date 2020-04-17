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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Btn_Enter_Click(object sender, EventArgs e)
        {
            if (checkBox_Create_Shortcut_On_Desktop.Checked)
            {
                Method method = new Method();
                method.Method_Create_Shortcut_On_Desktop();
            }
            this.Close();
        }

        private void Btn_Cansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
