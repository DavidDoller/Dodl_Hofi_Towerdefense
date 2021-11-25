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
            boolmovementright = false;
            boolmovmentstraight = false;
            boolmovementdown = false;
            


            DoubleBuffered = true;
            enemy_test.BringToFront();
            
            
            changetowerint.Text = Convert.ToString(towerselect.changeTowerNumber);
            lbl_currentnumber.Text = Convert.ToString(towerselect.currentnumber);

            //testpush
           



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
            }
            if (towerselect.changeTowerNumber == 3)
            {

            }
            if (towerselect.changeTowerNumber == 4)
            {

            }
            if (towerselect.changeTowerNumber == 5)
            {

            }
            if (towerselect.changeTowerNumber == 6)
            {

            }
            if (towerselect.changeTowerNumber == 7)
            {

            }
            if (towerselect.changeTowerNumber == 8)
            {

            }
            if (towerselect.changeTowerNumber == 9)
            {

            }
            if (towerselect.changeTowerNumber == 10)
            {

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
    }
}
