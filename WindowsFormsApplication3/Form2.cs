using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLib;

namespace WindowsFormsApplication3
{
    
    public partial class Form2 : Form
    {
        
        Random rannum = new Random();
        int num;
        int dogenum;
        int setting = 0;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown
                || e.CloseReason == CloseReason.ApplicationExitCall
                || e.CloseReason == CloseReason.TaskManagerClosing)
            {
                return;
            }
            e.Cancel = true;
            //assuming you want the close-button to only hide the form, 
            //and are overriding the form's OnFormClosing method:
            Application.Exit();
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if(progressBar1.Value == 1)
            {
                label1.Text = ".";
            }
            if(progressBar1.Value == 2)
            {
                label1.Text = "..";
            }
            if (progressBar1.Value == 3)
            {
                label1.Text = "...";
            }
            if (progressBar1.Value == 4)
            {
                dogenum = int.Parse(textBox1.Text);
                num = rannum.Next(0, setting);
                pictureBox3.Visible = true;
                
                //jawe//skfjdhfjkdshdf ewikd swdil jfsdfjeeeeeeeeeeeeeeeeeeeeeeee
                if (dogenum==num)
                {
                    if (dogenum < 10)
                    {
                        label1.Location = new System.Drawing.Point(262, 38);
                    }
                    if (dogenum > 9)
                    {
                        label1.Location = new System.Drawing.Point(242, 38);
                    }
                    label1.ForeColor = System.Drawing.Color.Green;
                    label1.Text = dogenum.ToString();
                    label7.Text = "Hey i chose\n" + dogenum + " too!\nYou won.";
                    timer1.Stop();
                }
                else
                {
                    if (dogenum < 10)
                    {
                        label1.Location = new System.Drawing.Point(262, 38);
                    }
                    if (dogenum > 9)
                    {
                        label1.Location = new System.Drawing.Point(242, 38);
                    }
                    label1.ForeColor = System.Drawing.Color.Red;
                    label1.Text = dogenum.ToString();
                    label7.Text = "Too bad, i\nchose " + num + "!\nTry again..";
                    timer1.Stop();
                }
                groupBox3.Visible = true;
            }
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 1 || setting == 0)
            {   
                MessageBox.Show("First choose a difficulty and choose a number!", "Error");
                return;
            }
            
            else
            {
                timer1.Start();
                button1.Enabled = false;
                textBox1.Enabled = false;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setting = 5;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            label8.Text = "0 - " + setting;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setting = 10;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            label8.Text = "0 - " + setting;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setting = 20;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            label8.Text = "0 - " + setting;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        public void resetGame()
        {
            Application.Restart();
            
            
        }
        public void Quit()
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }
    }
}
