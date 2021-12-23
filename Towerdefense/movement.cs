using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Towerdefense
{
    class movement
    {
        public static List<PictureBox> moveright = new List<PictureBox>();
        public static List<PictureBox> movestraight = new List<PictureBox>();
        public static List<PictureBox> movedown = new List<PictureBox>();
        public static int health = 10;

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

        public static void checkdirection(Timer playtimer, Timer enemyspawning)
        {

            foreach (Control x in game1.ActiveForm.Controls)
            {
                foreach (Control y in game1.ActiveForm.Controls)
                {
                    if (x is PictureBox && (string)x.Tag == "right" && y is PictureBox && (string)y.Tag == "enemy")
                    {
                        if (y.Bounds.IntersectsWith(x.Bounds))
                        {
                            movestraight.Remove((PictureBox)y);
                            movedown.Remove((PictureBox)y);
                            if (!moveright.Contains((PictureBox)y))
                            {
                                moveright.Add((PictureBox)y);
                            }
                        }
                    }
                    else if (x is PictureBox && (string)x.Tag == "straight" && y is PictureBox && (string)y.Tag == "enemy")
                    {
                        if (y.Bounds.IntersectsWith(x.Bounds))
                        {
                            moveright.Remove((PictureBox)y);
                            movedown.Remove((PictureBox)y);
                            if (!movestraight.Contains((PictureBox)y))
                            {
                                movestraight.Add((PictureBox)y);
                            }
                        }
                    }
                    else if (x is PictureBox && (string)x.Tag == "down" && y is PictureBox && (string)y.Tag == "enemy")
                    {
                        if (y.Bounds.IntersectsWith(x.Bounds))
                        {

                            moveright.Remove((PictureBox)y);
                            movestraight.Remove((PictureBox)y);
                            if (!movedown.Contains((PictureBox)y))
                            {
                                movedown.Add((PictureBox)y);
                            }
                        }
                    }
                    else if (x is Panel && (string)x.Tag == "bulletmage" && y is PictureBox &&(string)y.Tag == "enemy" && y is PictureBox &&(string)y.Name == "Redloon") 
                    {
                        if (y.Bounds.IntersectsWith(x.Bounds)) 
                        {
                            //enemy.redloonhealth--;
                            tower.panelmagetowershot.Remove((Panel)x);
                            x.Location = new System.Drawing.Point(90,325);
                            y.Dispose();
                            //if (enemy.redloonhealth == 0) 
                            //{
                            //    tower.panelmagetowershot.Remove((Panel)x);
                            //    x.Dispose();
                            //    y.Dispose();
                            //}
                            
                        }
                        
                    }
                    else if (x is PictureBox && (string)x.Tag == "core" && y is PictureBox && (string)y.Tag == "enemy")
                    {
                        if (y.Bounds.IntersectsWith(x.Bounds))
                        {
                            health--;
                            y.Dispose();
                            if (health == 0) 
                            {
                                playtimer.Stop();
                                enemyspawning.Stop();
                                menu form = new menu();
                                form.Show();
                                game1.ActiveForm.Hide();
                                MessageBox.Show("Dead!");
                            }
                            
                        }
                    }
                }

            }

        }

        public static void moveenemys() 
        {
            foreach (Control x in game1.ActiveForm.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "enemy")
                {
                    if (movestraight.Contains(x))
                    {
                        movmentstraight((PictureBox)x);
                    }
                    if (moveright.Contains(x))
                    {
                        movmentright((PictureBox)x);
                    }
                    if (movedown.Contains(x))
                    {
                        movementdown((PictureBox)x);
                    }
                }
            }
        }
    }
}
