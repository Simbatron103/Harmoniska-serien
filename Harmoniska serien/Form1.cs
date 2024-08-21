using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harmoniska_serien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double NUMMMER = 0;
        double NUMMER = 0;
        double NUMER = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            NUMER = double.Parse(textBox1.Text);
            while (NUMMMER < NUMER)
            {

                NUMMER++;
                NUMMMER = NUMMMER + 1 / NUMMER;
            }
            if (NUMMMER  > NUMER) 
            {
                MessageBox.Show("DU använde " + NUMMER + " termer");
                NUMMER = 0;
            }
        }
    }
}
