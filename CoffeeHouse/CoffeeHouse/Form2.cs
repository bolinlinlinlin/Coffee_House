using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoffeeHouse
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            List<string> xData = new List<string>() { "墊材", "零食", "主糧", "配糧" };
            List<int> yData = new List<int>() { 17, 13, 22, 48 };
            chart1.Series[0].Points.DataBindXY(xData, yData);

            List<string> xData2 = new List<string>() { "墊材", "零食", "主糧", "配糧" };
            List<int> yData2 = new List<int>() { 15, 17, 30, 38 };
            chart2.Series[0].Points.DataBindXY(xData, yData);
        }
    }
}
