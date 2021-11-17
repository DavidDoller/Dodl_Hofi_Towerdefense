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
        public game()
        {
            InitializeComponent();
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void game_Load(object sender, EventArgs e)
        {
            towerselectint.Text = Convert.ToString(towerselect.temp);
            changetowerint.Text = Convert.ToString(towerselect.changetowernumber);
            lbl_currentnumber.Text = Convert.ToString(towerselect.currentnumber);


            #region iftest

            if (towerselect.temp == currentnumber)
            {
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
    }
}
