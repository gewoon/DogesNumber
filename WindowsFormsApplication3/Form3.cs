using DBLib;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            DBSession sess = new DBSession(textBox1.Text, textBox2.Text);
            await sess.LoginAsync();
            if (sess.Status == DBStatus.LoggedIn)
            {
                await sess.SendShoutAsync("Doge's Number created by Rebug is awesome!\nI just played a game, you should too!");
                MessageBox.Show("Logged in and Shared!", "Succes!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Something bad happened!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Know that all your passwords are 100% secure!\nNo information is leaked towards me, or anyone else!\n\nThis was made by DBLib (created by Mika)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
