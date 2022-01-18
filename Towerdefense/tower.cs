using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Resources;

namespace Towerdefense
{
    class tower
    {
        #region Lists and Panels for Towers
        public static List<Panel> panelmagetowershot = new List<Panel>();
        public static List<Panel> panelarchertowershot = new List<Panel>();
        public static List<Panel> panelBombTowerShot = new List<Panel>();
        public static List<Panel> panelNinjaTowerShot = new List<Panel>();
        public static List<Panel> panelMachineGunTowerShot = new List<Panel>();

        public static Panel tempmage = new Panel();
        public static Panel temparcher = new Panel();
        public static Panel tempBomb = new Panel();
        public static Panel tempNinja = new Panel();
        public static Panel tempMachinegun = new Panel();
        #endregion

        public static int bulletSpeedX = enemy.pb.Location.X;
        public static int bulletSpeedY = enemy.pb.Location.Y;

        public static int mageTowerPrice = 200;
        public static int archerTowerPrice = 250;
        public static int bombTowerPrice = 300;
        public static int ninjaTowerPrice = 350;
        public static int machinegunTowerPrice = 400;



        #region Towermethodes
        public static void magetowerShoot(int locationX, int locationY, int bulletspeed)
        {
            if (!panelmagetowershot.Contains(tempmage))
            {
                tempmage = new Panel();
                tempmage.Name = "mage";
                tempmage.Location = new Point(locationX, locationY);
                tempmage.BackColor = Color.Red;
                tempmage.Height = 3;
                tempmage.Width = 30;
                tempmage.Tag = "bullet";
                panelmagetowershot.Add(tempmage);
                game1.ActiveForm.Controls.Add(tempmage);
            }
            if (tempmage.Left < locationX - 100)
            {
                panelmagetowershot.Remove(tempmage);
                tempmage.Location = new Point(locationX, locationY);

            }
            tempmage.Left -= bulletspeed;
        }

        public static void archertowerShoot(int locationX, int locationY, int bulletspeed)
        {
            if (!panelarchertowershot.Contains(temparcher))
            {
                temparcher = new Panel();
                temparcher.Name = "archer";
                temparcher.Location = new Point(locationX, locationY);
                temparcher.BackColor = Color.Blue;
                temparcher.Height = 3;
                temparcher.Width = 30;
                temparcher.Tag = "bullet";
                panelarchertowershot.Add(temparcher);
                game1.ActiveForm.Controls.Add(temparcher);
            }
            if (temparcher.Left < locationX - 100)
            {
                panelarchertowershot.Remove(temparcher);
                temparcher.Location = new Point(locationX, locationY);

            }
            temparcher.Left -= bulletspeed;
            temparcher.Top -= bulletspeed;

        }

        public static void bombTowerShoot(int locationX, int locationY, int bulletspeed)
        {
            if (!panelBombTowerShot.Contains(tempBomb))
            {
                tempBomb = new Panel();
                tempBomb.Name = "bomb";
                tempBomb.Location = new Point(locationX, locationY);
                tempBomb.BackColor = Color.Orange;
                tempBomb.Height = 3;
                tempBomb.Width = 30;
                tempBomb.Tag = "bullet";
                panelBombTowerShot.Add(tempBomb);
                game1.ActiveForm.Controls.Add(tempBomb);
            }
            if (tempBomb.Left < locationX - 100)
            {
                panelBombTowerShot.Remove(tempBomb);
                tempBomb.Location = new Point(locationX, locationY);

            }
            tempBomb.Left -= bulletspeed;
        }

        public static void ninjaTowerShoot(int locationX, int locationY, int bulletspeed)
        {
            if (!panelNinjaTowerShot.Contains(tempNinja))
            {
                tempNinja = new Panel();
                tempNinja.Name = "ninja";
                tempNinja.Location = new Point(locationX, locationY);
                tempNinja.BackColor = Color.Green;
                tempNinja.Height = 3;
                tempNinja.Width = 30;
                tempNinja.Tag = "bullet";
                panelNinjaTowerShot.Add(tempNinja);
                game1.ActiveForm.Controls.Add(tempNinja);
            }
            if (tempNinja.Left < locationX - 100)
            {
                panelBombTowerShot.Remove(tempmage);
                tempNinja.Location = new Point(locationX, locationY);

            }
            tempNinja.Left -= bulletspeed;
        }

        public static void machinegunTowerShoot(int locationX, int locationY, int bulletspeed)
        {
            if (!panelMachineGunTowerShot.Contains(tempMachinegun))
            {
                tempMachinegun = new Panel();
                tempMachinegun.Name = "machinegun";
                tempMachinegun.Location = new Point(locationX, locationY);
                tempMachinegun.BackColor = Color.Yellow;
                tempMachinegun.Height = 3;
                tempMachinegun.Width = 30;
                tempMachinegun.Tag = "bullet";
                panelMachineGunTowerShot.Add(tempMachinegun);
                game1.ActiveForm.Controls.Add(tempMachinegun);
            }
            if (tempMachinegun.Left < locationX - 100)
            {
                panelMachineGunTowerShot.Remove(tempMachinegun);
                tempMachinegun.Location = new Point(locationX, locationY);

            }
            tempMachinegun.Left -= bulletspeed;
        }
        #endregion 

        public static void UnvisibleButton()
        {
            foreach (Control x in game1.ActiveForm.Controls)
            {
                if (x is Button)
                {
                    x.Visible = false;
                }
            }
        }
        public static void ButtonDeactivateTowers(PictureBox pbTower, Button towerButton ) 
        {
            UnvisibleButton();

                if (game1.TowerType == "mage")
                {
                    pbTower.BackgroundImage = Properties.Resources.mageTower;
                    pbTower.Tag = "mageTower";
                }
                else if(game1.TowerType == "archer")
                {
                    pbTower.BackgroundImage = Properties.Resources.archerTower;
                    pbTower.Tag = "archerTower";
                }
                else if (game1.TowerType == "bomb")
                {
                    pbTower.BackgroundImage = Properties.Resources.BombTower;
                    pbTower.Tag = "bombTower";
                }
                else if (game1.TowerType == "ninja")
                {
                    pbTower.BackgroundImage = Properties.Resources.NinjaTower;
                    pbTower.Tag = "ninjaTower";
                }
                else if (game1.TowerType == "machinegun")
                {
                    pbTower.BackgroundImage = Properties.Resources.maschiengun;
                    pbTower.Tag = "machinegun";
                }

            if(pbTower.Tag != "")
            {
                towerButton.BackColor = Color.Red;
                towerButton.Enabled = false;
            }
        }

        public static void ButtonActivateTowers()
        {
            foreach (Control x in game1.ActiveForm.Controls)
            {
                if (x is Button)
                {
                    x.Visible = true;
                }
            }
        }


        public static void checkTowerPlacement() 
        {
            foreach (Control x in game1.ActiveForm.Controls)
            {
                if(x is PictureBox && x.Tag == "mageTower")
                {
                    //if(game1.Coins >= mageTowerPrice)
                    //{
                        magetowerShoot(x.Location.X, x.Location.Y, 5);
                        //foreach(Button b in game1.ActiveForm.Controls)
                        //{
                        // if ()
                        //    {
                                game1.Coins = game1.Coins - mageTowerPrice;
                        //    }
                        //}     
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Sie haben zu wenig Coins um diesen Tower zu plazieren", "Zu Wenig Coins", MessageBoxButtons.OK);
                    //}
                }
                else if(x is PictureBox && x.Tag == "archerTower")
                {
                    //if(game1.Coins >= archerTowerPrice)
                    //{
                        archertowerShoot(x.Location.X, x.Location.Y, 5);
                        game1.Coins = game1.Coins - archerTowerPrice;
                    //}
                   // else
                    //{
                      //MessageBox.Show("Sie haben zu wenig Coins um diesen Tower zu plazieren", "Zu Wenig Coins", MessageBoxButtons.OK);
                    //}
                }
                else if (x is PictureBox && x.Tag == "bombTower")
                {
                    //if(game1.Coins >= bombTowerPrice)
                    //{
                        bombTowerShoot(x.Location.X, x.Location.Y, 5);
                        game1.Coins = game1.Coins - bombTowerPrice;
                    //}
                    //else
                    //{
                        MessageBox.Show("Sie haben zu wenig Coins um diesen Tower zu plazieren", "Zu Wenig Coins", MessageBoxButtons.OK);
                    //}
                }
                else if (x is PictureBox && x.Tag == "ninjaTower")
                {
                    //if(game1.Coins >= ninjaTowerPrice)
                    //{
                        ninjaTowerShoot(x.Location.X, x.Location.Y, 5);
                        game1.Coins = game1.Coins - ninjaTowerPrice;
                    //}
                    //else
                    //{
                        MessageBox.Show("Sie haben zu wenig Coins um diesen Tower zu plazieren", "Zu Wenig Coins", MessageBoxButtons.OK);
                    //}

                }
                else if (x is PictureBox && x.Tag == "machinegun")
                {
                    //if(game1.Coins >= machinegunTowerPrice)
                    //{
                        machinegunTowerShoot(x.Location.X, x.Location.Y, 20);
                        game1.Coins = game1.Coins - machinegunTowerPrice;
                   // }
                    //else
                    //{
                        MessageBox.Show("Sie haben zu wenig Coins um diesen Tower zu plazieren", "Zu Wenig Coins", MessageBoxButtons.OK);
                    //}
                }
            }
        }


    }

}
