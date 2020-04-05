using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace waregame
{
    public partial class Form1 : Form
    {


        int Drofireball;
        bool Fireballdroping = false;
        Random rnd = new Random();
        int score = 0;
        int livee=0;

     
      
        int firedMissile;
        bool missilefired111 = false;
        bool missilefired11 = false;
        bool missilefired1 = false;
        bool missilefired2 = false;
        bool missilefired3 = false;
        public Form1()
        {
            InitializeComponent();



            bishforon.Visible = false;
        }

        private void live()
        {

            if (picmissile2.Bounds.IntersectsWith(player_Tank.Bounds))
            {

                livee-=1;
                live_text.Text = "Live" + livee.ToString();

            }

            if (picmissile3.Bounds.IntersectsWith(player_Tank.Bounds))
            {

                livee -= 1;
                live_text.Text = "Live" + livee.ToString();

            }
            if (picmissile3.Bounds.IntersectsWith(player_Tank.Bounds))
            {

                livee -= 1;
                live_text.Text = "Live" + livee.ToString();

            }



            if (picmissile3.Bounds.IntersectsWith(player_Tank.Bounds))
            {

                livee -= 1;
                live_text.Text = "Live" + livee.ToString();

            }
        }

        private void bouns()
        {
            if(picMissile1.Bounds.IntersectsWith(enemy_tank1.Bounds))
            {
     
                score++;
                score_point.Text = "Score " + score.ToString();
                bishforon.Left = enemy_tank1.Left + 15;
                bishforon.Top = enemy_tank1.Top + 30;
                bishforon.Visible = true;

            }
            if (picMissile1.Bounds.IntersectsWith(enemy_tank2.Bounds))
            {

                score++;
                score_point.Text = "Score " + score.ToString();
                bishforon.Top = enemy_tank2.Top + 2;
                bishforon.Visible = true;

            }
            if (picMissile11.Bounds.IntersectsWith(enemy_tank1.Bounds))
            {


                score++;
                score_point.Text = "Score " + score.ToString();
                bishforon.Top = enemy_tank1.Top + 2;
                bishforon.Visible = true;

            }
            if (picMissile11.Bounds.IntersectsWith(enemy_tank2.Bounds))
            {


                score++;
                score_point.Text = "Score " + score.ToString();
                bishforon.Top = enemy_tank2.Top + 2;
                bishforon.Visible = true;

            }
            if (picMissile111.Bounds.IntersectsWith(enemy_tank1.Bounds))
            {


                score++;
                score_point.Text = "Score " + score.ToString();
                bishforon.Top = enemy_tank1.Top + 30;
                bishforon.Visible = true;

            }

            if (picMissile111.Bounds.IntersectsWith(enemy_tank2.Bounds))
            {


                score++;
                score_point.Text = "Score " + score.ToString();
                bishforon.Top = enemy_tank2.Top + -2;
                bishforon.Visible = true;
                return;
            }
        }

        /// track//////////////////////////////////////////

        private void track_line(int speed)
        {

         

            if (player_live.Top > 200)
            {
               player_live.Top = 0;
               livee++;
                              
                if (livee> 5)
                {
                    livee -= 1;
                }

                   live_text.Text = "Live"+livee.ToString();
                


            }
            else
            {
                player_live.Top += 2;
            }





            timerMissile.Start();
            if (!missilefired2)
            {
                timerFireBall.Start();
                picmissile2.SendToBack();
                picmissile2.Show();
                picmissile2.Left = enemy_tank2.Left + 15;
                picmissile2.Top = enemy_tank2.Top + 18;
                missilefired2 = true;
            }


            if (!missilefired3)
            {
                timerFireBall.Start();
                timerMissile.Start();
                picmissile3.SendToBack();
                picmissile3.Show();
                picmissile3.Left = enemy_tank1.Left + 15;
                picmissile3.Top = enemy_tank1.Top + 18;
                missilefired3 = true;
            }




            if (enemy_tank2.Left > 600)
            {


                enemy_tank2.Left = 0;
            }

            else
            {
                enemy_tank2.Left += speed;
             



            }
            if (enemy_tank1.Left < 0)
            {


                enemy_tank1.Left = 600;
              
            }

            else
            {
                enemy_tank1.Left -= speed;
            


            }


            if (track_playercontrol.Left < 0)
            {
                track_playercontrol.Left = 300;


            }
            else
            {

                track_playercontrol.Left -= 10;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timerBludragon_Tick(object sender, EventArgs e)
        {

            track_line(1);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Down:
                         track_playercontrol.Left = 400;

                    if (track_playercontrol.Left > 0 && track_playercontrol.Left < 400)
                    {
                        player_Tank.Top += 5;
                    }

            

                    break;
                case Keys.Up:

                    track_playercontrol.Left = 400;

                    if (track_playercontrol.Left > 0 && track_playercontrol.Left < 400)
                    {
                        player_Tank.Top += 5;
                    }

                    if (player_Tank.Top > 0)
                    {
                        player_Tank.Top -= 30;
                    }
                    else
                    {
                        player_Tank.Top += 30;

                    }
                    break;

                case Keys.Left:

                    track_playercontrol.Left = 300;

                    if (player_Tank.Left > 0)
                    {
                        player_Tank.Left -= 10;

                    }
                    Triplefired();
                    break;

                case Keys.Right:

                    track_playercontrol.Left = 300;

                    if (player_Tank.Left < 700)
                    {

                        player_Tank.Left += 10;
                    }
                    Triplefired();
                    break;

                case Keys.Space:

                    track_playercontrol.Left = 400;
                    Triplefired();
                    break;
            }

        }

        private void Triplefired()
        {
            if (!missilefired1)
            {

                timerMissile.Start();
                picMissile1.SendToBack();
                picMissile1.Show();
                picMissile1.Left = player_Tank.Left + 15;

                picMissile1.Top = player_Tank.Top - 16;
                missilefired1 = true;
                //
            }

            if (!missilefired11)
            {

                timerMissile.Start();
                picMissile11.SendToBack();
                picMissile11.Show();
                picMissile11.Left = player_Tank.Left + 30;

                picMissile11.Top = player_Tank.Top - 16;
                missilefired11 = true;

            }


            if (!missilefired111)
            {

                timerMissile.Start();
                picMissile111.SendToBack();
                picMissile111.Show();
                picMissile111.Left = player_Tank.Left + 1;

                picMissile111.Top = player_Tank.Top - 16;
                missilefired111 = true;

            }
        }

        private void timerMissile_Tick(object sender, EventArgs e)
        {


            bouns();


            picMissile1.Top -= 40;
            picMissile11.Top -= 35;
            picMissile111.Top -= 35;
            if (picmissile3.Top > 500)
            {
                picmissile3.Hide();
                missilefired3 = false;
                timerMissile.Stop();
            }

            if (picmissile2.Top > 500)
            {
                picmissile2.Hide();
                missilefired2 = false;
                timerMissile.Stop();
            }


            if (picMissile111.Top < 0)
            {
                picMissile111.Hide();
                missilefired111 = false;
                timerMissile.Stop();
            }

            if (picMissile11.Top < 0)
            {
                picMissile11.Hide();
                missilefired11 = false;
                timerMissile.Stop();
            }


            if (picMissile1.Top < 0)
            {
                picMissile1.Hide();
                missilefired1 = false;
                timerMissile.Stop();
            }
        }

        private void timerFireBall_Tick(object sender, EventArgs e)
        {
            picmissile2.Top += 4;
            picmissile3.Top += 5;
            live();


  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (livee > 0)
            {

                livee -= 1;
                live_text.Text = "Live" + livee.ToString();
            }

        }

        private void enemy_tank2_Click(object sender, EventArgs e)
        {

        }

    }
}
