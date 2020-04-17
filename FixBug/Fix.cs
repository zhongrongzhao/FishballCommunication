using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixBug
{
    public partial class Form_Bug_Fix : Form
    {
        public Form_Bug_Fix()
        {
            InitializeComponent();
        }

        private void Btn_Fix_Click(object sender, EventArgs e)
        {
            Method_Fix method_Fix = new Method_Fix();
            method_Fix.Method_Sign_in(Method_Fix.Method_GetMd5(txt_Account.Text), Method_Fix.Method_GetMd5(txt_Password.Text));

        }
    }
}
