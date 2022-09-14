using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                textBox1.Text = openFileDialog1.FileName;
            }
            player.URL = textBox1.Text;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
