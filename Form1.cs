using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void posalji ()
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                textBox1.Text = "Odabrali ste: Dorucak, Rucak i Vecera";
            }
            else if (checkBox3.Checked == true && checkBox1.Checked == true)
            {
                textBox1.Text = "Odabrali ste: Dorucak i Rucak";
            }
            else if (checkBox3.Checked == true && checkBox2.Checked == true)
            {
                textBox1.Text = "Odabrali ste: Dorucak i Vecera";
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                textBox1.Text = "Odabrali ste: Rucak i Vecera";
            }
            else if (checkBox3.Checked == true)
            {
                textBox1.Text = "Odabrali ste: Dorucak";
            }
            else if (checkBox1.Checked == true)
            {
                textBox1.Text = "Odabrali ste: Rucak";
            }
            else if (checkBox2.Checked == true)
            {
                textBox1.Text = "Odabrali ste: Vecera";
            }
        }
        private void button1_Click(object sender, EventArgs e) => posalji();

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked )
            {
                textBox1.Visible = false;
            }
            else
            {
                textBox1.Visible=true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
