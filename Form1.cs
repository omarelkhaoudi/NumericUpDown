using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericUpDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Value = 50;
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown1.ThousandsSeparator = true;
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(numericUpDown2.Value.ToString());
        }
    }
}
