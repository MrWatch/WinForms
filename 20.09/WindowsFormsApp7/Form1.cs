using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        int priceOfHD = 120;
        int priceOfCf = 100;
        int priceOfTea = 80;
        int priceOfBurger = 130;
        double priceOfOil;
        int price;
        int pr;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                textBox5.Text = "145";
            }
            if (comboBox1.SelectedIndex == 0)
            {
                textBox5.Text = "150";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                textBox5.Text = "155";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Visible = true;
                numericUpDown1.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
                numericUpDown1.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Visible = true;
                numericUpDown2.Visible = true;
            }
            else 
            {
                textBox2.Visible = false;
                numericUpDown2.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox3.Visible = true;
                numericUpDown3.Visible = true;
            }
            else
            {
                textBox3.Visible = false;
                numericUpDown3.Visible = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox4.Visible = true;
                numericUpDown4.Visible = true;
            }
            else
            {
                textBox4.Visible = false;
                numericUpDown4.Visible = false;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pofh; int poc; int pot; int pob;
            pofh = priceOfHD * Convert.ToInt32(numericUpDown1.Value.ToString());
            poc = priceOfCf * Convert.ToInt32(numericUpDown2.Value.ToString());
            pot = priceOfTea * Convert.ToInt32(numericUpDown3.Value.ToString());
            pob = priceOfBurger * Convert.ToInt32(numericUpDown4.Value.ToString());
            price = poc + pob + pofh + pot;
            textBox9.Text = price.ToString();
            textBox8.Text = priceOfOil.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) {
                textBox6.Visible = true;
                label4.Visible = true;
            }
            else
            {
                textBox6.Visible = false;
                label4.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox7.Visible = true;
                label5.Visible = true;
            }
            else
            {
                textBox7.Visible = false;
                label5.Visible = false;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            int poo = Convert.ToInt32(textBox6.Text);
            priceOfOil = Convert.ToInt32(textBox5.Text) * poo;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox10.Text = (priceOfOil + price).ToString();
            }
            if (radioButton2.Checked == true)
            {
                textBox10.Text = (pr + price).ToString();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            pr = Convert.ToInt32(textBox7.Text);
            priceOfOil = pr / Convert.ToInt32(textBox5.Text);
        }
    }
}
