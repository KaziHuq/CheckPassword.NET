using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordCheckingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = true;
            lbl2.Visible = true;
            textBox2.Visible = true;
            textBox2.Focus();
            btnCheck.Visible = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == textBox2.Text)
            {
                lblMessage.Text = "Password Matched!";
            }
            else
            {
                lblMessage.Text = "Password Does Not Match";
                btnRst.Visible = true;
            }
        }

        private void btnRst_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            lblMessage.Text = " ";
            lbl2.Visible = false;
            textBox2.Visible = false;
            btnCheck.Visible = false;
            btnRst.Visible = false;

        }
    }
}
