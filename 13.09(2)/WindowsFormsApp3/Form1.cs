using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Угадайте число от 1 до 2000", "Game");
            Random rand = new Random();
            string random;
            Form1 form = new Form1();
            form.Hide();
            for (int i = 0; i < 2000; ++i)
            {
                random = Convert.ToString(rand.Next(1, 2000));
                if (MessageBox.Show(random, Convert.ToString(i++), MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.OK) {
                    MessageBox.Show("Количество попыток: " + Convert.ToString(i), "Game is end");
                    break;
                }
                else { continue; }
            }
            if(MessageBox.Show("Хотите сыграть снова?", "Game", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
            {
                Form1 newform=new Form1();
                newform.Show();
            }
        }
        
    }
}
