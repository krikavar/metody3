using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metody3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        int pctsmall = 0;
        int pctbig = 0;
        int diff = 0;
        
        void JeAlfanum(string pole, ref int pctsmall, ref int pctbig, ref int diff, ref int cisla)
        {
            foreach (char x in pole)
            {
                if (x <= 'z' && x >= 'a') { pctsmall++; }
                else if (x <= 'Z' && x >= 'A') { pctbig++; }
                else if (x >= '0' && x <= '9'){ cisla++;}
                else { diff++; }
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int pctsmall = 0; int pctbig = 0; int diff = 0; int cisla = 0;
            JeAlfanum(textBox1.Text, ref pctsmall, ref pctbig, ref diff, ref cisla);
            if (diff == 0) { MessageBox.Show("Řetězec je alfanumerický"); }
            else { MessageBox.Show("Retezec neni alfanumericky"); }
            label6.Text = pctsmall.ToString();
            label5.Text = pctbig.ToString();
            label4.Text = diff.ToString();
            label7.Text = cisla.ToString();
        }
    }
}
