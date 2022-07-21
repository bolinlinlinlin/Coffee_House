using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeHouse
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            Form2 form = new Form2 { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.panel2.Controls.Add(form);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            Form3 form = new Form3 { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.panel2.Controls.Add(form);
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            Form4 form = new Form4 { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.panel2.Controls.Add(form);
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            Form5 form = new Form5 { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.panel2.Controls.Add(form);
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            Form6 form = new Form6 { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.panel2.Controls.Add(form);
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            Form7 form = new Form7 { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.panel2.Controls.Add(form);
            form.Show();
        }
    }
}
