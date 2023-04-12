using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace game1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = (@"..\\..\\y2mate.com - Kids Game  Childrens Music Instrumental Music For Kids.wav");
            player.PlayLooping();

        }



        private void button_WOC1_Click(object sender, EventArgs e)
        {
            var frm = new Form2();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"..\\..\\y2mate.com - Kids Game  Childrens Music Instrumental Music For Kids.wav");


            splayer.PlayLooping();

        }
        private void rjButton2_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"..\\..\\y2mate.com - Kids Game  Childrens Music Instrumental Music For Kids.wav");


            splayer.Stop();

        }
        private void button_WOC2_Click(object sender, EventArgs e)
        {
            var frm = new Wordbank();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
        private void button_WOC3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
