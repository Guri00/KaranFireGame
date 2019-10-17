using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaranFireGame
{
    public partial class Form1 : Form
    {
        public details obj = new details();
        public Random rd = new Random();

        int trigger = 0;
        int fire = 0;
        int chance = 0;

        public Form1()
        {
            

            InitializeComponent();

            //loading the sound generated button 
            fire = rd.Next(1, 6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // starting the game of the fire with giving the instruction 
            MessageBox.Show("You have only 2 bullet to fire ");
            //display the frst image which is empty
            pbArea.Image = Properties.Resources.k1;
            // enable the rest button to fire 
            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String img = obj.load();
            pbArea.Image = Properties.Resources.k2;
            // enable the rest button to fire 
            button3.Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String img = obj.spin();
            pbArea.Image = Properties.Resources.k3;
            // enable the rest button to fire 
            button4.Enabled = true;
            button3.Enabled = false;

        }


        

        private void button4_Click(object sender, EventArgs e)
        {
            String img = obj.shoot();
            pbArea.Image = Properties.Resources.k4;
            // enable the rest button to fire 
            



            // code to fire  
            trigger++;
            if (trigger == fire)
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer("sound.wav");
                player.Play();
                chance++;
                trigger = 0;
                fire = rd.Next(1, 6);
                //chances to play the game
                if (obj.chances(chance) == 1) {
                    MessageBox.Show("You have used your first bullet");

                } else if (obj.chances(chance) == 2) {
                    MessageBox.Show("Your bullets are finished now you can play if you want ");
                    button4.Enabled = false;
                    button5.Enabled = true;
                }

            }
            else {
                // empty sound 
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("blank.wav");
                player.Play();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //code to reload the game 
            button5.Enabled = false;
            button1.Enabled =true;

            pbArea.Image = Properties.Resources.k1;

            fire = rd.Next(1, 6);
            chance = 0;
            trigger = 0;

        }
    }
}
