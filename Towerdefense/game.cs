using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Towerdefense
{
    public partial class game : Form
    {

        public static int currentnumber;
        public static int templocation;

        public static bool boolmovementright = false;
        public static bool boolmovmentstraight = false;
        public static bool boolmovementdown = false;
        public game()
        {
            InitializeComponent();
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void game_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            enemy_test.BringToFront();
            
            
            towerselectint.Text = Convert.ToString(towerselect.temp);
            changetowerint.Text = Convert.ToString(towerselect.changetowernumber);
            lbl_currentnumber.Text = Convert.ToString(towerselect.currentnumber);

            //testpush
            #region iftest

            
                if (towerselect.changetowernumber == 1)
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
                        pb_tower1.BackColor = Color.Green;
                    }
                    else if (currentnumber == 4)
                    {
                        pb_tower2.BackColor = Color.Green;
                    }
                    else if (currentnumber == 5)
                    {
                        pb_tower2.BackColor = Color.Green;
                    }
                }
                if (towerselect.changetowernumber == 2)
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
                }
                if (towerselect.changetowernumber == 3)
                {
                    pb_tower1.BackColor = Color.Red;
                }
                if (towerselect.changetowernumber == 4)
                {
                    pb_tower1.BackColor = Color.Yellow;
                }
                if (towerselect.changetowernumber == 5)
                {
                    pb_tower1.BackColor = Color.Orange;
                }
                if (towerselect.changetowernumber == 6)
                {
                    pb_tower1.BackColor = Color.Purple;
                }
                if (towerselect.changetowernumber == 7)
                {
                    pb_tower1.BackColor = Color.Pink;
                }
                if (towerselect.changetowernumber == 8)
                {
                    pb_tower1.BackColor = Color.LightGray;
                }
                if (towerselect.changetowernumber == 9)
                {
                    pb_tower1.BackColor = Color.Magenta;
                }
                if (towerselect.changetowernumber == 10)
                {
                    pb_tower1.BackColor = Color.Gold;
                }
            
            
           
            #endregion



        }

        private void pb_tower1_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(1);
            currentnumber = 1;

            towerselect form = new towerselect();
            form.Show();
            this.Hide();

            

        }

        private void pb_tower2_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(2);
            currentnumber = 2;

            towerselect form = new towerselect();
            form.Show();
            this.Hide();
        }

        private void pb_tower3_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(3);

            towerselect form = new towerselect();
            form.Show();
            this.Hide();
        }

        private void pb_tower4_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(4);

            towerselect form = new towerselect();
            form.Show();
            this.Hide();
        }

        private void pb_tower5_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(5);

            towerselect form = new towerselect();
            form.Show();
            this.Hide();
        }

        private void pb_tower6_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(6);

            towerselect form = new towerselect();
            form.Show();
            this.Hide();
        }

        private void pb_tower7_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(7);

            towerselect form = new towerselect();
            form.Show();
            this.Hide();
        }

        private void pb_tower8_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(8);

            towerselect form = new towerselect();
            form.Show();
            this.Hide();
        }

        private void pb_tower9_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(9);

            towerselect form = new towerselect();
            form.Show();
            this.Hide();
        }

        private void pb_tower10_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(10);

            towerselect form = new towerselect();
            form.Show();
            this.Hide();
        }

        private void towerselectint_Click(object sender, EventArgs e)
        {
            
        }

        private void playtimer_Tick(object sender, EventArgs e)
        {
            enemy_test.BringToFront();


            if (boolmovmentstraight == true) 
            {
                movmentstraight(enemy_test);
            }
            else if (boolmovementright == true) 
            {
                movmentright(enemy_test);
            }
            else if (boolmovementdown == true)
            {
                movementdown(enemy_test);
            }



            if (enemy_test.Bounds.IntersectsWith(pl_spawn.Bounds)|| enemy_test.Bounds.IntersectsWith(pb_corner2.Bounds)) 
            {
                boolmovementdown = false;
                boolmovementright = false;
                boolmovmentstraight = true;
            }
            else if (enemy_test.Bounds.IntersectsWith(pb_corner1.Bounds)|| enemy_test.Bounds.IntersectsWith(pb_corner3.Bounds) || enemy_test.Bounds.IntersectsWith(pb_corner5.Bounds)) 
            {
                boolmovementdown = false;
                boolmovmentstraight = false;
                boolmovementright = true; 
            }
            else if (enemy_test.Bounds.IntersectsWith(pb_corner4.Bounds)) 
            {
                boolmovementdown = true;
                boolmovmentstraight = false;
                boolmovementright = false;
            }

            if (enemy_test.Bounds.IntersectsWith(pl_core.Bounds)) 
            {
                playtimer.Stop();
                menu form = new menu();
                form.Show();
                this.Hide();
                MessageBox.Show("Dead!");
                
            }
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
    }
}
