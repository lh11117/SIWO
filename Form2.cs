using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XIWO
{
    public partial class Form2 : Form
    {
        private bool WantClose = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void ThanksMsg()
        {
            MessageBox.Show("太好啦！谢谢老师！", "来自同学们的祝福", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string msg = "老师，我们向您表示祝福，而您却想下次一定。\n要不您也感谢一下同学们？";
            string title = "让我们感恩吧！";
            if (MessageBox.Show(msg, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) {
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            ThanksMsg();
            WantClose = true;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThanksMsg();
            WantClose = true;
            Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WantClose)
            {
                e.Cancel = false;
            }
            else
            {
                MessageBox.Show("老师，请做出您的选择！","提示",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
            }
        }
    }
}
