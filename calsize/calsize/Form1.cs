using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calsize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        progress prog = new progress();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                string operation = textBox3.Text.ToString();

                double result = prog.operationprog(num1, num2, operation);
                label1.Text = "" + result;

                int resulta = Convert.ToInt32(label1.Text);
                prog.total(resulta);

                MessageBox.Show("" + resulta);

            }
            catch (FormatException)
            {

                MessageBox.Show("please input format");
            }
            catch (ArgumentException ex) 
            {
                MessageBox.Show(ex.Message);
            }

            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
