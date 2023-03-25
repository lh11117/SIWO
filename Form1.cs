using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace XIWO
{
    public partial class Form1 : Form
    {
        private bool Thanksed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void T()
        {
            Text = "汐我白板";
        }

        private void Msg(int id)
        {
            T();
            switch (id) {
                case 0:
                    MessageBox.Show("老师，不要在黑板上写字，黑板会谢谢你的！", "汐我白板", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); break; 
                case 1:
                    MessageBox.Show("老师，不要清空黑板，黑板会谢谢你的！", "汐我白板", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); break;
                case 2:
                    MessageBox.Show("老师，您已经感谢过同学们了，请不要重复点击！", "汐我白板", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); break;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Msg(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Msg(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Msg(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            T();
            if (!Thanksed)
            {
                Thanksed = true;
                Form2 thanks = new Form2();
                thanks.ShowDialog();
            }
            else
            {
                Msg(2); 
            }
        }

        private void errMsg()
        {
            Form3 kill = new Form3();
            kill.ShowDialog();
        }

        private void KillWindows()
        {
            for (int i=1; i <= 50; i++)
            {
                Thread thread = new Thread(errMsg);
                //启动线程
                thread.Start();
                Thread.Sleep(20);
            }
        }

        private void OH()
        {
            T();
            if (MessageBox.Show("老师，您确定要退出吗？", "汐我白板", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Dispose();
                KillWindows();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            OH();
            e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OH();
        }
    }
}
