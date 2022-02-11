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
        //lists get created
        public static List<PictureBox> moveright = new List<PictureBox>();
        public static List<PictureBox> movestraight = new List<PictureBox>();
        public static List<PictureBox> movedown = new List<PictureBox>();
        public static List<PictureBox> moveLeftdir = new List<PictureBox>();
        public static int health = 100000;

        public static int mageTowerDamage = 1;
        public static int archerTowerDamage = 2;
        public static int bombTowerDamage = 3;
        public static int ninjaTowerDamage = 4;
        public static int machinegunTowerDamage = 5;

        public static int coins = 200;
        



        public static void movmentright(PictureBox temp)
        {
            //move right
            temp.Left += 5;
        }
        public static void movmentstraight(PictureBox temp)
        {
            //move straight
            temp.Top += -5;
        }

        public static void movementdown(PictureBox temp)
        {
            //move down
            temp.Top += 5;
        }

        public static void moveLeft(PictureBox temp)
        {
            temp.Left -= 5;
        }

        public static void checkdirection(Timer playtimer, Timer enemyspawning, Form form)
        {
            foreach (Control x in form.Controls)
            {
                foreach (Control y in form.Controls)
                {
                    //checks if the enemy collides with a corner picturebox, than checks what way it should turn
                    if (y.Tag == null || x.Tag == null) continue;
                    if (x is PictureBox && (string)x.Tag == "right" && y is PictureBox && (string)y.Tag.ToString().Substring(0,5) == "enemy")
                    {
                        if (y.Bounds.IntersectsWith(x.Bounds))
                        {
                            movestraight.Remove((PictureBox)y);
                            movedown.Remove((PictureBox)y);
                            moveLeftdir.Remove((PictureBox)y);
                            //enemy picturebox get added once to the list moveright
                            if (!moveright.Contains((PictureBox)y))
                            {
                                moveright.Add((PictureBox)y);
                            }
                        }
                    }
                    else if (x is PictureBox && (string)x.Tag == "straight" && y is PictureBox && (string)y.Tag.ToString().Substring(0, 5) == "enemy")
                    {
                        if (y.Bounds.IntersectsWith(x.Bounds))
                        {
                            moveright.Remove((PictureBox)y);
                            movedown.Remove((PictureBox)y);
                            moveLeftdir.Remove((PictureBox)y);
                            //enemy picturebox get added once to the list movestraight
                            if (!movestraight.Contains((PictureBox)y))
                            {
                                movestraight.Add((PictureBox)y);
                            }
                        }
                    }
                    else if (x is PictureBox && (string)x.Tag == "downdir" && y is PictureBox && (string)y.Tag.ToString().Substring(0, 5) == "enemy")
                    {
                        if (y.Bounds.IntersectsWith(x.Bounds))
                        {

                            moveright.Remove((PictureBox)y);
                            movestraight.Remove((PictureBox)y);
                            moveLeftdir.Remove((PictureBox)y);
                            //enemy picturebox get added once to the list movedown
                            if (!movedown.Contains((PictureBox)y))
                            {
                                movedown.Add((PictureBox)y);
                            }
                        }
                    }
                    else if (x is PictureBox && (string)x.Tag == "dirleft" && y is PictureBox && (string)y.Tag.ToString().Substring(0,5) == "enemy")
                    {
                        if (y.Bounds.IntersectsWith(x.Bounds))
                        {
                            moveright.Remove((PictureBox)y);
                            movestraight.Remove((PictureBox)y);
                            movedown.Remove((PictureBox)y);

                             if (!moveLeftdir.Contains((PictureBox)y))
                            {
                                moveLeftdir.Add((PictureBox)y);
                            }

                        }
                    }
                    //checks if enemy gets hit by a bullet 
                    else if (x is Panel && (string)x.Tag == "bullet" && y is PictureBox && (string)y.Tag.ToString().Substring(0, 5) == "enemy")
                    {
                        if (y.Bounds.IntersectsWith(x.Bounds))
                        {
                            //checks name of bullet panel
                            if (x.Name.ToString().Substring(0, 4) == "mage")
                            {
                                if (y.Name == "Redloon")
                                {
                                    //enemy health gets reduced by a certain amount dependent on the tower
                                    enemy.redloonhealth = enemy.redloonhealth - mageTowerDamage;

                                    //if the health of the enemy is zero, the enemy and bullet get removed from the form and the lists
                                    if (enemy.redloonhealth <= 0)
                                    {
                                        waveController.enemyRedBallonList.Remove((PictureBox)y);
                                        coins = coins + 10;
                                        x.Dispose();
                                        y.Dispose();
                                    }
                                }
                                if (y.Name == "Blueloon")
                                {
                                    y.Name = "Redloon";
                                    x.Dispose();
                                    waveController.enemyBlueBallonList.Remove((PictureBox)y);
                                    //enemy.enemyRedList.Add((PictureBox)y);
                                    y.BackgroundImage = Properties.Resources.bloonRed;
                                    coins = coins + 20;
                                }
                                if (y.Name == "Pinkloon")
                                {
                                    y.Name = "Blueloon";
                                    x.Dispose();
                                    waveController.enemyPinkBallonList.Remove((PictureBox)y);
                                    //enemy.enemyBlueList.Add((PictureBox)y);
                                    y.BackgroundImage = Properties.Resources.bloonBlue;
                                    coins = coins + 30;
                                }

                            }
                            else if (x.Name.ToString().Substring(0,4) == "arch")
                            {
                                if (y.Name == "Redloon")
                                {
                                    //enemy health gets reduced by a certain amount dependent on the tower
                                    enemy.redloonhealth = enemy.redloonhealth - archerTowerDamage;

                                    //if the health of the enemy is zero, the enemy and bullet get removed from the form and the lists
                                    if (enemy.redloonhealth <= 0)
                                    {
                                        waveController.enemyRedBallonList.Remove((PictureBox)y);
                                        coins = coins + 10;
                                        x.Dispose();
                                        y.Dispose();
                                    }
                                }
                                if (y.Name == "Blueloon")
                                {
                                    y.Name = "Redloon";
                                    x.Dispose();
                                    waveController.enemyBlueBallonList.Remove((PictureBox)y);
                                    //enemy.enemyRedList.Add((PictureBox)y);
                                    y.BackgroundImage = Properties.Resources.bloonRed;
                                    coins = coins + 20;
                                }
                                if (y.Name == "Pinkloon")
                                {
                                    y.Name = "Blueloon";
                                    x.Dispose();
                                    waveController.enemyPinkBallonList.Remove((PictureBox)y);
                                    //enemy.enemyBlueList.Add((PictureBox)y);
                                    y.BackgroundImage = Properties.Resources.bloonBlue;
                                    coins = coins + 30;
                                }
                            }
                            else if (x.Name.ToString().Substring(0,4) == "bomb")
                            {
                                if (y.Name == "Redloon")
                                {
                                    //enemy health gets reduced by a certain amount dependent on the tower
                                    enemy.redloonhealth = enemy.redloonhealth - bombTowerDamage;

                                    //if the health of the enemy is zero, the enemy and bullet get removed from the form and the lists
                                    if (enemy.redloonhealth <= 0)
                                    {
                                        waveController.enemyRedBallonList.Remove((PictureBox)y);

                                        coins = coins + 10;
                                        x.Dispose();
                                        y.Dispose();
                                    }
                                }
                                if (y.Name == "Blueloon")
                                {
                                    y.Name = "Redloon";
                                    x.Dispose();
                                    waveController.enemyBlueBallonList.Remove((PictureBox)y);
                                    //enemy.enemyRedList.Add((PictureBox)y);
                                    y.BackgroundImage = Properties.Resources.bloonRed;
                                    coins = coins + 20;
                                }
                                if (y.Name == "Pinkloon")
                                {
                                    y.Name = "Blueloon";
                                    x.Dispose();
                                    waveController.enemyPinkBallonList.Remove((PictureBox)y);
                                    //enemy.enemyBlueList.Add((PictureBox)y);
                                    y.BackgroundImage = Properties.Resources.bloonBlue;
                                    coins = coins + 30;
                                }
                            }
                            else if (x.Name.ToString().Substring(0,4) == "ninj")
                            {
                                if (y.Name == "Redloon")
                                {
                                    //enemy health gets reduced by a certain amount dependent on the tower
                                    enemy.redloonhealth = enemy.redloonhealth - ninjaTowerDamage;

                                    //if the health of the enemy is zero, the enemy and bullet get removed from the form and the lists
                                    if (enemy.redloonhealth <= 0)
                                    {
                                        waveController.enemyRedBallonList.Remove((PictureBox)y);

                                        coins = coins + 10;
                                        x.Dispose();
                                        y.Dispose();
                                    }
                                }
                                if (y.Name == "Blueloon")
                                {
                                    y.Name = "Redloon";
                                    x.Dispose();
                                    waveController.enemyBlueBallonList.Remove((PictureBox)y);
                                    //enemy.enemyRedList.Add((PictureBox)y);
                                    y.BackgroundImage = Properties.Resources.bloonRed;
                                    coins = coins + 20;
                                }
                                if (y.Name == "Pinkloon")
                                {
                                    y.Name = "Blueloon";
                                    x.Dispose();
                                    waveController.enemyPinkBallonList.Remove((PictureBox)y);
                                    //enemy.enemyBlueList.Add((PictureBox)y);
                                    y.BackgroundImage = Properties.Resources.bloonBlue;
                                    coins = coins + 30;
                                }
                            }
                            else if (x.Name.ToString().Substring(0,3) == "gun")
                            {
                                if (y.Name == "Redloon")
                                {
                                    //enemy health gets reduced by a certain amount dependent on the tower
                                    enemy.redloonhealth = enemy.redloonhealth - machinegunTowerDamage;

                                    //if the health of the enemy is zero, the enemy and bullet get removed from the form and the lists
                                    if (enemy.redloonhealth <= 0)
                                    {
                                        waveController.enemyRedBallonList.Remove((PictureBox)y);

                                        coins = coins + 10;
                                        x.Dispose();
                                        y.Dispose();
                                    }
                                }
                                if (y.Name == "Blueloon")
                                {
                                    y.Name = "Redloon";
                                    x.Dispose();
                                    waveController.enemyBlueBallonList.Remove((PictureBox)y);
                                    //enemy.enemyRedList.Add((PictureBox)y);
                                    y.BackgroundImage = Properties.Resources.bloonRed;
                                    coins = coins + 20;
                                }
                                if (y.Name == "Pinkloon")
                                {
                                    y.Name = "Blueloon";
                                    x.Dispose();
                                    waveController.enemyPinkBallonList.Remove((PictureBox)y);
                                    //enemy.enemyBlueList.Add((PictureBox)y);
                                    y.BackgroundImage = Properties.Resources.bloonBlue;
                                    coins = coins + 30;
                                }
                            }
                        }
                    }
                    //check if enemy collides with the core
                    else if (x is PictureBox && (string)x.Tag.ToString().Substring(0,4) == "core" && y is PictureBox && (string)y.Tag.ToString().Substring(0,5) == "enemy")
                    {
                        if (y.Bounds.IntersectsWith(x.Bounds))
                        {
                            //health of the core gets reduced by one, when an enemy collides with it
                            if (y.Name == "Redloon")
                            {
                                health--; 
                                y.Dispose();
                            }
                            if (y.Name == "Blueloon")
                            {
                                health = health - 2;
                                y.Dispose();
                            }
                            if(y.Name == "Pinkloon")
                            {
                                health = health - 3;
                                y.Dispose();
                            }
                            //when the health is zero, timer stops and the menu form opens
                            if (health == 0)
                            {
                                playtimer.Stop();
                                enemyspawning.Stop();
                                
                                menu menu = new menu();
                                menu.Show();
                                form.Hide();
                                MessageBox.Show("Dead!");
                            }

                        }
                    }
                }

            }

        }

        public static void moveenemys(Form form) 
        {
            foreach (Control x in form.Controls)
            {
                //check if picturebox has the tag "enemy"
                if (x.Tag == null) continue;
                if (x is PictureBox && (string)x.Tag.ToString().Substring(0,5) == "enemy")
                {
                    //when picturebox is in list movestraight the enemy moves straight
                    if (movestraight.Contains(x))
                    {
                        movmentstraight((PictureBox)x);
                    }
                    //when picturebox is in list moveright the enemy moves right
                    if (moveright.Contains(x))
                    {
                        movmentright((PictureBox)x);
                    }
                    //when picturebox is in list movedown the enemy moves down
                    if (movedown.Contains(x))
                    {
                        movementdown((PictureBox)x);
                    }
                    if (moveLeftdir.Contains(x))
                    {
                        moveLeft((PictureBox)x);
                    }
                }
            }
        }

        public static void AutoAim(Form form)
        {
            if (form.Controls == null) return;
            foreach (Control x in form.Controls)
            {
                foreach (Control y in form.Controls) 
                {
                    if (x.Tag == null || y.Tag == null) continue;
                    if(y is PictureBox && y.Tag.ToString().Substring(0, 5) == "enemy")
                    {
                        if(x is Panel && x.Tag == "bullet")
                        {
                            if(y.Left > x.Left)
                            {
                                x.Left += tower.bulletspeed;
                            }
                            if(y.Top > x.Top)
                            {
                                x.Top += tower.bulletspeed;
                            }
                            if(y.Left < x.Left)
                            {
                                x.Left -= tower.bulletspeed;
                            }
                            if(y.Top < x.Top)
                            {
                                x.Top -= tower.bulletspeed;
                            }
                        }
                    }

                }
            }
        }
    }
}
