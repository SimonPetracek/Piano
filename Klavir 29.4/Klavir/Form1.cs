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
using System.IO;
using System.Timers;

namespace Klavir
{
    public partial class Form1 : Form
    {
        public klavesy klavesy { get; set; }
        public noty noty { get; set; }
        private int counter;

        bool TogMove;        
        int MValX;
        int MValY;

        public Form1()
        {
            InitializeComponent();
            counter = 10;
            this.klavesy = new klavesy();
            this.noty = new noty();
            this.klavesy.White = 24;
            this.klavesy.Black = this.klavesy.White;
            this.klavesy.FormWhiteSelector = -1;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            for (int i = 0; i < this.klavesy.White; i++)
            {
                if (e.KeyCode.ToString() == this.klavesy.charWhite[i].ToString())
                {
                    this.klavesy.FormWhiteSelector = i;
                    CheckFormSelector();
                    this.pictureBox_Klavesy.Refresh();
                }
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            this.klavesy.FormWhiteSelector = -1;
            this.pictureBox_Klavesy.Refresh();
        }
        private void pictureBox_Noty_Paint(object sender, PaintEventArgs e)
        {
            this.pictureBox_Noty.Refresh();
            Graphics g = e.Graphics;
            this.noty.Draw(e.Graphics);
        }


        private void pictureBox_Klavesy_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (this.klavesy.FormWhiteSelector == -1)
            {
                this.klavesy.Draw(e.Graphics);
            }
            else
            {
                this.klavesy.SelectedWhiteKey(e.Graphics);
            }            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            this.TogMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            this.TogMove = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == true)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void pictureBox_Klavesy_MouseDown(object sender, MouseEventArgs e)
        {
            MValX = e.X;
            MValY = e.Y;
            for (int i = 0; i < this.klavesy.White; i++)
            {
                if (MValX > i * 40 && MValX < 40 + i * 40 && MValY > 130)
                {
                    this.klavesy.FormWhiteSelector = i;
                    this.pictureBox_Klavesy.Refresh();
                }
            }
            CheckFormSelector();
        }

        private void pictureBox_Klavesy_MouseUp(object sender, MouseEventArgs e)
        {
            this.klavesy.FormWhiteSelector = -1;
            this.pictureBox_Klavesy.Refresh();
            SoundPlayer splayer = new SoundPlayer(Klavir.Properties.Resources.a48);
            splayer.Stop();
        }
        private void CheckFormSelector()
        {
            if (this.klavesy.FormWhiteSelector == 0)
            {
                SoundPlayer splayer = new SoundPlayer(Klavir.Properties.Resources.a48);
                splayer.Play();
            }
            else if (this.klavesy.FormWhiteSelector == 1)
            {
                SoundPlayer splayer = new SoundPlayer(Klavir.Properties.Resources.a49);
                splayer.Play();
            }
            else if (this.klavesy.FormWhiteSelector == 2)
            {
                SoundPlayer splayer = new SoundPlayer(Klavir.Properties.Resources.a50);
                splayer.Play();
            }
            else if (this.klavesy.FormWhiteSelector == 3)
            {
                SoundPlayer splayer = new SoundPlayer(Klavir.Properties.Resources.a51);
                splayer.Play();
            }
            else if (this.klavesy.FormWhiteSelector == 4)
            {
                SoundPlayer splayer = new SoundPlayer(Klavir.Properties.Resources.a52);
                splayer.Play();
            }
            else if (this.klavesy.FormWhiteSelector == 5)
            {
                SoundPlayer splayer = new SoundPlayer(Klavir.Properties.Resources.a53);
                splayer.Play();
            }
            else if (this.klavesy.FormWhiteSelector == 6)
            {
                SoundPlayer splayer = new SoundPlayer(Klavir.Properties.Resources.a54);
                splayer.Play();
            }
            else if (this.klavesy.FormWhiteSelector == 7)
            {
                SoundPlayer splayer = new SoundPlayer(Klavir.Properties.Resources.a55);
                splayer.Play();
            }
            else if (this.klavesy.FormWhiteSelector == 8)
            {
                SoundPlayer splayer = new SoundPlayer(Klavir.Properties.Resources.a56);
                splayer.Play();
            }
            else if (this.klavesy.FormWhiteSelector == 9)
            {
                SoundPlayer splayer = new SoundPlayer(Klavir.Properties.Resources.a57);
                splayer.Play();
            }
            else if (this.klavesy.FormWhiteSelector == 10)
            {
                SoundPlayer splayer = new SoundPlayer(Klavir.Properties.Resources.a65);
                splayer.Play();
            }
            else if (this.klavesy.FormWhiteSelector == 11)
            {
                SoundPlayer splayer = new SoundPlayer(Klavir.Properties.Resources.a65);
                splayer.Play();
            }
            else if (this.klavesy.FormWhiteSelector == 12)
            {
                SoundPlayer splayer = new SoundPlayer(Klavir.Properties.Resources.a67);
                splayer.Play();
            }
            else if (this.klavesy.FormWhiteSelector == 13)
            {
                SoundPlayer splayer = new SoundPlayer(Klavir.Properties.Resources.a68);
                splayer.Play();
            }
            else if (this.klavesy.FormWhiteSelector == 14)
            {
                SoundPlayer splayer = new SoundPlayer(Klavir.Properties.Resources.a69);
                splayer.Play();
            }
            else if (this.klavesy.FormWhiteSelector == 15)
            {
                SoundPlayer splayer = new SoundPlayer(Klavir.Properties.Resources.a70);
                splayer.Play();
            }
            else if (this.klavesy.FormWhiteSelector == 16)
            {
                SoundPlayer splayer = new SoundPlayer(Klavir.Properties.Resources.a71);
                splayer.Play();
            }
            else if (this.klavesy.FormWhiteSelector == 17)
            {
                SoundPlayer splayer = new SoundPlayer(Klavir.Properties.Resources.a72);
                splayer.Play();
            }
            else if (this.klavesy.FormWhiteSelector == 18)
            {
                SoundPlayer splayer = new SoundPlayer(Klavir.Properties.Resources.a73);
                splayer.Play();
            }
            else if (this.klavesy.FormWhiteSelector == 19)
            {
                SoundPlayer splayer = new SoundPlayer(Klavir.Properties.Resources.a74);
                splayer.Play();
            }
            else if (this.klavesy.FormWhiteSelector == 20)
            {
                SoundPlayer splayer = new SoundPlayer(Klavir.Properties.Resources.a75);
                splayer.Play();
            }
            else if (this.klavesy.FormWhiteSelector == 21)
            {
                SoundPlayer splayer = new SoundPlayer(Klavir.Properties.Resources.a76);
                splayer.Play();
            }
            else if (this.klavesy.FormWhiteSelector == 22)
            {
                SoundPlayer splayer = new SoundPlayer(Klavir.Properties.Resources.a77);
                splayer.Play();
            }
            else if (this.klavesy.FormWhiteSelector == 23)
            {
                SoundPlayer splayer = new SoundPlayer(Klavir.Properties.Resources.a78);
                splayer.Play();
            }
        }
    }
}

