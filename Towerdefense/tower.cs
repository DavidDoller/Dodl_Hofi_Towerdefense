﻿using System;
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


        public static int mageShootCounter;
        public static int archerShootCounter;
        public static int bombShootCounter;
        public static int ninjaShootCounter;
        public static int machinegunShootCounter;


        #endregion

        //the price of each tower
        public static int mageTowerPrice = 200;
        public static int archerTowerPrice = 250;
        public static int bombTowerPrice = 300;
        public static int ninjaTowerPrice = 350;
        public static int machinegunTowerPrice = 400;


        public static void TowerShootsMovement(int bulletspeed) 
        {
            if (game1.ActiveForm == null) return;
            foreach (Control x in game1.ActiveForm.Controls)
            {
                if (game1.ActiveForm == null) return;
                foreach (Control y in game1.ActiveForm.Controls)
                {
                    if (x is Panel && x.Name.ToString().Substring(0, 4) == "mage" && y is PictureBox && y.Tag == "mageTower")
                    {
                        x.Left -= bulletspeed;

                        if (x.Left < y.Location.X - 100)
                        {
                            //panelmagetowershot.Remove((Panel)x);
                            x.Dispose();
                            x.Location = new Point(y.Location.X, y.Location.Y);
                        }
                    }
                    if(x is Panel && x.Name.ToString().Substring(0, 4) == "arch" && y is PictureBox && y.Tag == "archerTower")
                    {
                        x.Left -= bulletspeed;

                        if (x.Left < y.Location.X - 100)
                        {
                           // panelarchertowershot.Remove((Panel)x);
                            x.Dispose();
                            x.Location = new Point(y.Location.X, y.Location.Y);
                        }
                    }
                    if (x is Panel && x.Name.ToString().Substring(0, 4) == "bomb" && y is PictureBox && y.Tag == "bombTower")
                    {
                        x.Left -= bulletspeed;

                        if (x.Left < y.Location.X - 100)
                        {
                            //panelarchertowershot.Remove((Panel)x);
                            x.Dispose();
                            x.Location = new Point(y.Location.X, y.Location.Y);
                        }
                    }
                    if (x is Panel && x.Name.ToString().Substring(0, 4) == "ninj" && y is PictureBox && y.Tag == "ninjaTower")
                    {
                        x.Left -= bulletspeed;

                        if (x.Left < y.Location.X - 100)
                        {
                            //panelarchertowershot.Remove((Panel)x);
                            x.Dispose();
                            x.Location = new Point(y.Location.X, y.Location.Y);
                        }
                    }
                    if (x is Panel && x.Name.ToString().Substring(0, 3) == "gun" && y is PictureBox && y.Tag == "machinegun")
                    {
                        x.Left -= bulletspeed;

                        if (x.Left < y.Location.X - 100)
                        {
                            //panelarchertowershot.Remove((Panel)x);
                            x.Dispose();
                            x.Location = new Point(y.Location.X, y.Location.Y);
                        }
                    }
                }
                
            }
        }


        #region Towermethodes
        public static void magetowerShoot(int locationX, int locationY)
        {
            //bullet gets created
                Panel tempmage = new Panel();     
                tempmage.Name = "mage" + mageShootCounter;
                tempmage.Location = new Point(locationX, locationY);
                tempmage.BackColor = Color.Red;
                tempmage.Height = 3;
                tempmage.Width = 30;
                tempmage.Tag = "bullet";
            //panelmagetowershot.Add(tempmage);
            if (game1.ActiveForm == null) return;
            game1.ActiveForm.Controls.Add(tempmage);
                mageShootCounter++;
        }

        public static void archertowerShoot(int locationX, int locationY)
        {
            //bullet gets created

                Panel temparcher = new Panel();
                temparcher.Name = "arch" + archerShootCounter;
                temparcher.Location = new Point(locationX, locationY);
                temparcher.BackColor = Color.Blue;
                temparcher.Height = 3;
                temparcher.Width = 30;
                temparcher.Tag = "bullet";
                //panelarchertowershot.Add(temparcher);
                game1.ActiveForm.Controls.Add(temparcher);
                archerShootCounter++;
          

        }

        public static void bombTowerShoot(int locationX, int locationY)
        {
            //bullet gets created

                Panel tempBomb = new Panel();
                tempBomb.Name = "bomb" + bombShootCounter;
                tempBomb.Location = new Point(locationX, locationY);
                tempBomb.BackColor = Color.Orange;
                tempBomb.Height = 3;
                tempBomb.Width = 30;
                tempBomb.Tag = "bullet";
                //panelBombTowerShot.Add(tempBomb);
                game1.ActiveForm.Controls.Add(tempBomb);
                bombShootCounter++;
        }

        public static void ninjaTowerShoot(int locationX, int locationY)
        {
            //bullet gets created
                Panel tempNinja = new Panel();
                tempNinja.Name = "ninj" + ninjaShootCounter;
                tempNinja.Location = new Point(locationX, locationY);
                tempNinja.BackColor = Color.Green;
                tempNinja.Height = 3;
                tempNinja.Width = 30;
                tempNinja.Tag = "bullet";
                //panelNinjaTowerShot.Add(tempNinja);
                game1.ActiveForm.Controls.Add(tempNinja);
                ninjaShootCounter++;
        }

        public static void machinegunTowerShoot(int locationX, int locationY)
        {
            //bullet gets created

                Panel tempMachinegun = new Panel();
                tempMachinegun.Name = "gun" + machinegunShootCounter;
                tempMachinegun.Location = new Point(locationX, locationY);
                tempMachinegun.BackColor = Color.Yellow;
                tempMachinegun.Height = 3;
                tempMachinegun.Width = 30;
                tempMachinegun.Tag = "bullet";
                //panelMachineGunTowerShot.Add(tempMachinegun);
                game1.ActiveForm.Controls.Add(tempMachinegun);
                machinegunShootCounter++;
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
            if (game1.ActiveForm == null) return;
            foreach (Control x in game1.ActiveForm.Controls)
            {
                if(x is PictureBox && x.Tag == "mageTower")
                {
                        magetowerShoot(x.Location.X, x.Location.Y);
                        
                }
                else if(x is PictureBox && x.Tag == "archerTower")
                {
                        archertowerShoot(x.Location.X, x.Location.Y);
                        
                }
                else if (x is PictureBox && x.Tag == "bombTower")
                {
                        bombTowerShoot(x.Location.X, x.Location.Y);
                        
                }
                else if (x is PictureBox && x.Tag == "ninjaTower")
                {
                        ninjaTowerShoot(x.Location.X, x.Location.Y);
                        
                }
                else if (x is PictureBox && x.Tag == "machinegun")
                {
                        machinegunTowerShoot(x.Location.X, x.Location.Y);
                        
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
