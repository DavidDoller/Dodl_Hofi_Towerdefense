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
        public static bool moveRightBool;
        public static bool moveStraightBool;
        public static bool moveDownBool;

        //lists get created
        public static List<PictureBox> moveright = new List<PictureBox>();
        public static List<PictureBox> movestraight = new List<PictureBox>();
        public static List<PictureBox> movedown = new List<PictureBox>();
        public static int health = 10;

        public static int mageTowerDamage = 1;
        public static int archerTowerDamage = 2;
        public static int bombTowerDamage = 3;
        public static int ninjaTowerDamage = 4;
        public static int machinegunTowerDamage = 5;

        



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

        public static void checkdirection(Timer playtimer, Timer enemyspawning)
        {           
            if (game1.ActiveForm == null) return;
            foreach (Control x in game1.ActiveForm.Controls)
            {
                foreach (Control y in game1.ActiveForm.Controls)
                {
                    //checks if the enemy collides with a corner picturebox, than checks what way it should turn
                    if (x is PictureBox && (string)x.Tag == "right" && y is PictureBox && (string)y.Tag == "enemy")
                    {
                        if (y.Bounds.IntersectsWith(x.Bounds))
                        {
                            movestraight.Remove((PictureBox)y);
                            movedown.Remove((PictureBox)y);
                            //enemy picturebox get added once to the list moveright
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
                            //enemy picturebox get added once to the list movestraight
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
                            //enemy picturebox get added once to the list movedown
                            if (!movedown.Contains((PictureBox)y))
                            {
                                movedown.Add((PictureBox)y);
                            }
                        }
                    }
                    //checks if enemy gets hit by a bullet 
                    else if (x is Panel && (string)x.Tag == "bullet" && y is PictureBox &&(string)y.Tag == "enemy") 
                    {
                        if (y.Bounds.IntersectsWith(x.Bounds))
                        {
                            //checks name of bullet panel
                            if(x.Name == "mage")
                            {
                                //enemy health gets reduced by a certain amount dependent on the tower
                                enemy.redloonhealth = enemy.redloonhealth - mageTowerDamage;

                                //if the health of the enemy is zero, the enemy and bullet get removed from the form and the lists
                                if (enemy.redloonhealth <= 0)
                                {
                                    tower.panelmagetowershot.Remove((Panel)x);
                                    enemy.enemyList.Remove((PictureBox)y);
                                    game1.Coins = game1.Coins + 10;
                                    x.Dispose();
                                    y.Dispose();
                                }
                            }
                            else if (x.Name == "archer")
                            {
                                //enemy health gets reduced by a certain amount dependent on the tower
                                enemy.redloonhealth = enemy.redloonhealth - archerTowerDamage;

                                //if the health of the enemy is zero, the enemy and bullet get removed from the form and the lists
                                if (enemy.redloonhealth <= 0)
                                {
                                    tower.panelarchertowershot.Remove((Panel)x);
                                    enemy.enemyList.Remove((PictureBox)y);
                                    game1.Coins = game1.Coins + 10;
                                    x.Dispose();
                                    y.Dispose();
                                }
                            }
                            else if (x.Name == "bomb")
                            {
                                //enemy health gets reduced by a certain amount dependent on the tower
                                enemy.redloonhealth = enemy.redloonhealth - bombTowerDamage;

                                //if the health of the enemy is zero, the enemy and bullet get removed from the form and the lists
                                if (enemy.redloonhealth <= 0)
                                {
                                    tower.panelBombTowerShot.Remove((Panel)x);
                                    enemy.enemyList.Remove((PictureBox)y);
                                    game1.Coins = game1.Coins + 10;
                                    x.Dispose();
                                    y.Dispose();
                                }
                            }
                            else if (x.Name == "ninja")
                            {
                                //enemy health gets reduced by a certain amount dependent on the tower
                                enemy.redloonhealth = enemy.redloonhealth - ninjaTowerDamage;

                                //if the health of the enemy is zero, the enemy and bullet get removed from the form and the lists
                                if (enemy.redloonhealth <= 0)
                                {
                                    tower.panelNinjaTowerShot.Remove((Panel)x);
                                    enemy.enemyList.Remove((PictureBox)y);
                                    game1.Coins = game1.Coins + 10;
                                    x.Dispose();
                                    y.Dispose();
                                }
                            }
                            else if (x.Name == "machinegun")
                            {
                                //enemy health gets reduced by a certain amount dependent on the tower
                                enemy.redloonhealth = enemy.redloonhealth - machinegunTowerDamage;

                                //if the health of the enemy is zero, the enemy and bullet get removed from the form and the lists
                                if (enemy.redloonhealth <= 0)
                                {
                                    tower.panelMachineGunTowerShot.Remove((Panel)x);
                                    enemy.enemyList.Remove((PictureBox)y);
                                    game1.Coins = game1.Coins + 10;
                                    x.Dispose();
                                    y.Dispose();
                                }
                            }
                        }
                    }
                    //check if enemy collides with the core
                    else if (x is PictureBox && (string)x.Tag == "core" && y is PictureBox && (string)y.Tag == "enemy")
                    {
                        if (y.Bounds.IntersectsWith(x.Bounds))
                        {
                            //health of the core gets reduced by one, when an enemy collides with it
                            health--;
                            y.Dispose();
                            //when the health is zero, timer stops and the menu form opens
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
            if (game1.ActiveForm == null) return;
            foreach (Control x in game1.ActiveForm.Controls)
            {
                //check if picturebox has the tag "enemy"
                if (x is PictureBox && (string)x.Tag == "enemy")
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
                }
            }
        }
    }
}
