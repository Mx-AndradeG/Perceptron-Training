using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entrenamientoDePerceptrones
{

    public partial class Form1 : Form
    {

        public static double w0 = 0;
        public static double w1 = 0;
        public static double w2 = 0;
        public static double fa = 0;
        public static string compuerta = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            w0 = System.Convert.ToSingle(tbW0.Text);
            w1 = System.Convert.ToSingle(tbW1.Text);
            w2 = System.Convert.ToSingle(tbW2.Text);
            fa = System.Convert.ToSingle(tbFa.Text);
            compuerta = upCompuerta.Text;
            Form2 trigger = new Form2();
            trigger.Show();
        }

        private void upCompuerta_SelectedItemChanged(object sender, EventArgs e)
        {
            if (upCompuerta.Text == "NOT")
            {
                labelx.Visible = false;
                tbW2.Visible = false;
            }
            else {
                labelx.Visible = true;
                tbW2.Visible = true;
            }
       
        }
    }
}
