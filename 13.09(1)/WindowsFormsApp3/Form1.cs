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

        private void Form1_Load(object sender, EventArgs e)
        {
            string first = "First";string second = "Second";string name = "Name: Dauren";string age = "Age: 17";string grade = "Grade: 11";
            MessageBox.Show(name,first);
            MessageBox.Show(age,second);
            double sr = (name.Length + age.Length + grade.Length) / 3;
            MessageBox.Show(grade,sr.ToString());

        }
    }
}
