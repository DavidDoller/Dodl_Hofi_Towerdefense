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
        //a list gets created for every shot from each tower
        public static List<Panel> panelmagetowershot = new List<Panel>();
        public static List<Panel> panelarchertowershot = new List<Panel>();
        public static List<Panel> panelBombTowerShot = new List<Panel>();
        public static List<Panel> panelNinjaTowerShot = new List<Panel>();
        public static List<Panel> panelMachineGunTowerShot = new List<Panel>();

        //the bullet of eacht tower gets created
        public static Panel tempmage = new Panel();
        public static Panel temparcher = new Panel();
        public static Panel tempBomb = new Panel();
        public static Panel tempNinja = new Panel();
        public static Panel tempMachinegun = new Panel();
        #endregion        

        //the price of each tower
        public static int mageTowerPrice = 200;
        public static int archerTowerPrice = 250;
        public static int bombTowerPrice = 300;
        public static int ninjaTowerPrice = 350;
        public static int machinegunTowerPrice = 400;


        #region Towermethodes
        public static void magetowerShoot(int locationX, int locationY, int bulletspeed)
        {
            //if the bullet is not in the list, bullet gets created
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
            //when the bullet moves to far away from the tower, bullet starts at the tower again
            if (tempmage.Left < locationX - 100)
            {
                panelmagetowershot.Remove(tempmage);
                tempmage.Location = new Point(locationX, locationY);

            }
            tempmage.Left -= bulletspeed;
        }

        public static void archertowerShoot(int locationX, int locationY, int bulletspeed)
        {
            //if the bullet is not in the list, bullet gets created
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
            //when the bullet moves to far away from the tower, bullet starts at the tower again
            if (temparcher.Left < locationX - 100)
            {
                panelarchertowershot.Remove(temparcher);
                temparcher.Location = new Point(locationX, locationY);

            }
            temparcher.Left -= bulletspeed;

        }

        public static void bombTowerShoot(int locationX, int locationY, int bulletspeed)
        {
            //if the bullet is not in the list, bullet gets created
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
            //when the bullet moves to far away from the tower, bullet starts at the tower again
            if (tempBomb.Left < locationX - 100)
            {
                panelBombTowerShot.Remove(tempBomb);
                tempBomb.Location = new Point(locationX, locationY);

            }
            tempBomb.Left -= bulletspeed;
        }

        public static void ninjaTowerShoot(int locationX, int locationY, int bulletspeed)
        {
            //if the bullet is not in the list, bullet gets created
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
            //when the bullet moves to far away from the tower, bullet starts at the tower again
            if (tempNinja.Left < locationX - 100)
            {
                panelBombTowerShot.Remove(tempmage);
                tempNinja.Location = new Point(locationX, locationY);

            }
            tempNinja.Left -= bulletspeed;
        }

        public static void machinegunTowerShoot(int locationX, int locationY, int bulletspeed)
        {
            //if the bullet is not in the list, bullet gets created
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
            //when the bullet moves to far away from the tower, bullet starts at the tower again
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
            //all buttons on the form game1 get invisible
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
            //buttons get invisible
            UnvisibleButton();
                //the chosen tower gets placed at the chosen place
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
                    pbTower.BackgroundImage = Properties.Resources.machineGunTower;
                    pbTower.Tag = "machinegun";
                }

            //when the tag of the tower is not empty you can't use the button anymore
            if(pbTower.Tag != "")
            {
                towerButton.BackColor = Color.Red;
                towerButton.Enabled = false;
            }
        }

        public static void ButtonActivateTowers()
        {
            //tower buttons get visible
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
            //checks what and where the tower is placed, so the right bullet gets shot
            foreach (Control x in game1.ActiveForm.Controls)
            {
                if(x is PictureBox && x.Tag == "mageTower")
                {
                        magetowerShoot(x.Location.X, x.Location.Y,5);
                        
                }
                else if(x is PictureBox && x.Tag == "archerTower")
                {
                        archertowerShoot(x.Location.X, x.Location.Y, 5);
                        
                }
                else if (x is PictureBox && x.Tag == "bombTower")
                {
                        bombTowerShoot(x.Location.X, x.Location.Y, 5);
                        
                }
                else if (x is PictureBox && x.Tag == "ninjaTower")
                {
                        ninjaTowerShoot(x.Location.X, x.Location.Y, 5);
                        
                }
                else if (x is PictureBox && x.Tag == "machinegun")
                {
                        machinegunTowerShoot(x.Location.X, x.Location.Y, 20);
                        
                }
            }
        }

        //public static void reduceCoins()
        //{
        //    if (game1.TowerType == "mage")
        //    {
        //        game1.Coins = game1.Coins - 200;
        //    }
        //    if(game1.TowerType == "archer")
        //    {
        //        game1.Coins = game1.Coins - 250;
        //    }
        //    if (game1.TowerType == "bomb")
        //    {
        //        game1.Coins = game1.Coins - 250;
        //    }
        //    if (game1.TowerType == "ninja")
        //    {
        //        game1.Coins = game1.Coins - 250;
        //    }
        //    if (game1.TowerType == "machinegun")
        //    {
        //        game1.Coins = game1.Coins - 250;
        //    }
        //}


    }

}
