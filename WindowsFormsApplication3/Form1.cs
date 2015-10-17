using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Tutorial : Form
    {
        int pressed = 0;
        public Tutorial()
        {
            InitializeComponent();
        }

        public object Key { get; private set; }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pressed++;
            if (pressed == 1)
            {
                label1.Text = "I'll be your guide\nin this game!\nMuch excitement.";
            }
            if (pressed == 2)
            {
                label1.Text = "First select the\ndifficulty, choose\nwise!";
                groupBox1.Visible = true;
            }
            if (pressed == 3)
            {
                label1.Text = "Then you have to\nchoose your\nlucky number.";
                groupBox2.Visible = true;
            }
            if (pressed == 4)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                label1.Text = "Then i will choose\na random number.\nI hope its yours!";
            }
            if (pressed == 5)
            {
                label1.Text = "Well, you're\non your own now!\nMuch luck!";
                button1.Text = "Play";
            }
            if (pressed == 6)
            {
                Form2 frm = new Form2();
                frm.Show();
                Hide();
                Properties.Settings.Default.tut = 1;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();

            }
         }
    }
}
