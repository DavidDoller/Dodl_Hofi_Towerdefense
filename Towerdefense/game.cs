using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Towerdefense
{
    public partial class game : Form
    {

        
        public static int currentnumber;

        public static bool boolmovementright = false;
        public static bool boolmovmentstraight = false;
        public static bool boolmovementdown = false;
        public static string check;

        public game()
        {
            InitializeComponent();
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void game_Load(object sender, EventArgs e)
        {
            
            boolmovementright = false;
            boolmovmentstraight = false;
            boolmovementdown = false;

            DoubleBuffered = true;
        }


        private void pb_tower1_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(1);
            currentnumber = 1;

            towerselect form = new towerselect();
            form.Show();

        }

        private void pb_tower2_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(2);
            currentnumber = 2;

            towerselect form = new towerselect();
            form.Show();
        }

        private void pb_tower3_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(3);
            currentnumber = 3;
            towerselect form = new towerselect();
            form.Show();
        }

        private void pb_tower4_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(4);
            currentnumber = 4;
            towerselect form = new towerselect();
            form.Show();
        }

        private void pb_tower5_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(5);
            currentnumber = 5;
            towerselect form = new towerselect();
            form.Show();
        }

        private void pb_tower6_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(6);
            currentnumber = 6;
            towerselect form = new towerselect();
            form.Show();
        }

        private void pb_tower7_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(7);
            currentnumber = 7;
            towerselect form = new towerselect();
            form.Show();
        }

        private void pb_tower8_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(8);
            currentnumber = 8;
            towerselect form = new towerselect();
            form.Show();
        }

        private void pb_tower9_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(9);
            currentnumber = 9;
            towerselect form = new towerselect();
            form.Show();
        }

        private void pb_tower10_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(10);
            currentnumber = 10;
            towerselect form = new towerselect();
            form.Show();
        }

        private void towerselectint_Click(object sender, EventArgs e)
        {

        }

        private void playtimer_Tick(object sender, EventArgs e)
        {
            lbl_direction.Text = "directeion: " + check;

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "enemy") 
                {
                    if (boolmovmentstraight == true)
                    {
                        movmentstraight((PictureBox)x);
                    }
                    else if (boolmovementright == true)
                    {
                        movmentright((PictureBox)x);
                    }
                    else if (boolmovementdown == true)
                    {
                        movementdown((PictureBox)x);
                    }
                }
            }
            

            foreach (Control x in this.Controls)
            {
                foreach (Control y in this.Controls)
                {
                    if (x is PictureBox && (string)x.Tag == "right" && y is PictureBox && (string)y.Tag == "enemy")
                    {
                        if (y.Bounds.IntersectsWith(x.Bounds))
                        {
                            boolmovementdown = false;
                            boolmovmentstraight = false;
                            boolmovementright = true;
                            check = "right";

                        }
                    }
                    else if (x is PictureBox && (string)x.Tag == "straight" && y is PictureBox && (string)y.Tag == "enemy")
                    {
                        if (y.Bounds.IntersectsWith(x.Bounds))
                        {
                            boolmovementdown = false;
                            boolmovementright = false;
                            boolmovmentstraight = true;
                            check = "straight";
                        }
                    }
                   else if (x is PictureBox && (string)x.Tag == "down" && y is PictureBox && (string)y.Tag == "enemy")
                    {
                        if (y.Bounds.IntersectsWith(x.Bounds))
                        {
                            boolmovementdown = true;
                            boolmovmentstraight = false;
                            boolmovementright = false;
                            check = "down";
                        }
                    }
                    else if (x is PictureBox && (string)x.Tag == "core" && y is PictureBox && (string)y.Tag == "enemy")
                    {
                        if (y.Bounds.IntersectsWith(x.Bounds))
                        {
                            playtimer.Stop();
                            menu form = new menu();
                            form.Show();
                            this.Hide();
                            MessageBox.Show("Dead!");
                        }
                    }
                }
            }

            #region iftest
            if (towerselect.changeTowerNumber == 1)
            {
                if (currentnumber == 1)
                {
                    pb_tower1.BackColor = Color.Green;
                }
                else if (currentnumber == 2)
                {
                    pb_tower2.BackColor = Color.Green;
                }
                else if (currentnumber == 3)
                {
                    pb_tower3.BackColor = Color.Green;
                }
                else if (currentnumber == 4)
                {
                    pb_tower4.BackColor = Color.Green;
                }
                else if (currentnumber == 5)
                {
                    pb_tower5.BackColor = Color.Green;
                }
                else if (currentnumber == 6)
                {
                    pb_tower6.BackColor = Color.Green;
                }
                else if (currentnumber == 7)
                {
                    pb_tower7.BackColor = Color.Green;
                }
                else if (currentnumber == 8)
                {
                    pb_tower8.BackColor = Color.Green;
                }
                else if (currentnumber == 9)
                {
                    pb_tower9.BackColor = Color.Green;
                }
                else if (currentnumber == 10)
                {
                    pb_tower10.BackColor = Color.Green;
                }
            }
            if (towerselect.changeTowerNumber == 2)
            {
                if (currentnumber == 1)
                {
                    pb_tower1.BackColor = Color.Blue;
                }
                else if (currentnumber == 2)
                {
                    pb_tower2.BackColor = Color.Blue;
                }
                else if (currentnumber == 3)
                {
                    pb_tower3.BackColor = Color.Blue;
                }
                else if (currentnumber == 4)
                {
                    pb_tower4.BackColor = Color.Blue;
                }
                else if (currentnumber == 5)
                {
                    pb_tower5.BackColor = Color.Blue;
                }
                else if (currentnumber == 6)
                {
                    pb_tower6.BackColor = Color.Blue;
                }
                else if (currentnumber == 7)
                {
                    pb_tower7.BackColor = Color.Blue;
                }
                else if (currentnumber == 8)
                {
                    pb_tower8.BackColor = Color.Blue;
                }
                else if (currentnumber == 9)
                {
                    pb_tower9.BackColor = Color.Blue;
                }
                else if (currentnumber == 10)
                {
                    pb_tower10.BackColor = Color.Blue;
                }
            }
            if (towerselect.changeTowerNumber == 3)
            {
                if (currentnumber == 1)
                {
                    pb_tower1.BackColor = Color.Red;
                }
                else if (currentnumber == 2)
                {
                    pb_tower2.BackColor = Color.Red;
                }
                else if (currentnumber == 3)
                {
                    pb_tower3.BackColor = Color.Red;
                }
                else if (currentnumber == 4)
                {
                    pb_tower4.BackColor = Color.Red;
                }
                else if (currentnumber == 5)
                {
                    pb_tower5.BackColor = Color.Red;
                }
                else if (currentnumber == 6)
                {
                    pb_tower6.BackColor = Color.Red;
                }
                else if (currentnumber == 7)
                {
                    pb_tower7.BackColor = Color.Red;
                }
                else if (currentnumber == 8)
                {
                    pb_tower8.BackColor = Color.Red;
                }
                else if (currentnumber == 9)
                {
                    pb_tower9.BackColor = Color.Red;
                }
                else if (currentnumber == 10)
                {
                    pb_tower10.BackColor = Color.Red;
                }

            }
            if (towerselect.changeTowerNumber == 4)
            {
                if (currentnumber == 1)
                {
                    pb_tower1.BackColor = Color.Yellow;
                }
                else if (currentnumber == 2)
                {
                    pb_tower2.BackColor = Color.Yellow;
                }
                else if (currentnumber == 3)
                {
                    pb_tower3.BackColor = Color.Yellow;
                }
                else if (currentnumber == 4)
                {
                    pb_tower4.BackColor = Color.Yellow;
                }
                else if (currentnumber == 5)
                {
                    pb_tower5.BackColor = Color.Yellow;
                }
                else if (currentnumber == 6)
                {
                    pb_tower6.BackColor = Color.Yellow;
                }
                else if (currentnumber == 7)
                {
                    pb_tower7.BackColor = Color.Yellow;
                }
                else if (currentnumber == 8)
                {
                    pb_tower8.BackColor = Color.Yellow;
                }
                else if (currentnumber == 9)
                {
                    pb_tower9.BackColor = Color.Yellow;
                }
                else if (currentnumber == 10)
                {
                    pb_tower10.BackColor = Color.Yellow;
                }
            }
            if (towerselect.changeTowerNumber == 5)
            {
                if (currentnumber == 1)
                {
                    pb_tower1.BackColor = Color.Orange;
                }
                else if (currentnumber == 2)
                {
                    pb_tower2.BackColor = Color.Orange;
                }
                else if (currentnumber == 3)
                {
                    pb_tower3.BackColor = Color.Orange;
                }
                else if (currentnumber == 4)
                {
                    pb_tower4.BackColor = Color.Orange;
                }
                else if (currentnumber == 5)
                {
                    pb_tower5.BackColor = Color.Orange;
                }
                else if (currentnumber == 6)
                {
                    pb_tower6.BackColor = Color.Orange;
                }
                else if (currentnumber == 7)
                {
                    pb_tower7.BackColor = Color.Orange;
                }
                else if (currentnumber == 8)
                {
                    pb_tower8.BackColor = Color.Orange;
                }
                else if (currentnumber == 9)
                {
                    pb_tower9.BackColor = Color.Orange;
                }
                else if (currentnumber == 10)
                {
                    pb_tower10.BackColor = Color.Orange;
                }
            }

            #endregion

        }

        
   

        private void enemy_test_Click(object sender, EventArgs e)
        {
            
        }

        public static void movmentright(PictureBox temp)
        {
            temp.Left += 5;
        }
        public static void movmentstraight(PictureBox temp) 
        {
            temp.Top += -5;
        }

        public static void movementdown(PictureBox temp)
        {
            temp.Top += 5;
        }

        private void pb_corner1_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            playtimer.Start();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            playtimer.Stop();
        }

        private void lbl_direction_Click(object sender, EventArgs e)
        {
            
        }

        private void enemyspawning_Tick(object sender, EventArgs e)
        {
            PictureBox temp = enemy.Createenemy();          
        }
    }
}
