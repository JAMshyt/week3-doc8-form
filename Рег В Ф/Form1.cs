using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Рег_В_Ф
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            String s = textBox1.Text;
            Regex r = new Regex(@"(\d+,\d+|\d+)([eE](-|)\d+|)");
            foreach (Match it in r.Matches(s))
            {
                if (it.Success)
                {
                    sum += double.Parse(it.Value);
                }
            }
            textBox2.Text = sum.ToString();
        }
    }
}
