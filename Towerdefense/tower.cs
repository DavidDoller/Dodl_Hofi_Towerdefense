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
using System.Diagnostics;

namespace Towerdefense
{
    class tower
    {
        #region var
        public static int MachineGunSpeed = 15;

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

        public static string TowerType;

        #region ShootController
        public static void TowerShootsController()
        {
            foreach (Control x in game1.ActiveForm.Controls)
            {
                foreach (Control y in game1.ActiveForm.Controls)
                {
                    //if (x is Panel && x.Name.ToString().Substring(0, 4) == "mage" && y is PictureBox && y.Tag == "mageTower")
                    if (x is Panel && x.Name.ToString().Substring(0, 4) == "mage" && y is PictureBox && y.Tag == "mageTower")
                    {
                        if (x.Name.Substring(4, 4) != y.Location.X.ToString("D4") && x.Name.Substring(8, 4) != y.Location.Y.ToString("D4")) continue;

                        if (x.Left < y.Location.X - 100)
                        {
                            x.Dispose();
                            x.Location = new Point(y.Location.X, y.Location.Y);
                        }
                        if (x.Top < y.Location.Y - 100)
                        {
                            x.Dispose();
                            x.Location = new Point(y.Location.X, y.Location.Y);
                        }
                        if (x.Left > y.Location.X + 100)
                        {
                            x.Dispose();
                            x.Location = new Point(y.Location.X, y.Location.Y);
                        }
                        if (x.Top > y.Location.Y + 100)
                        {
                            x.Dispose();
                            x.Location = new Point(y.Location.X, y.Location.Y);
                        }
                    }
                    if (x is Panel && x.Name.ToString().Substring(0, 4) == "arch" && y is PictureBox && y.Tag == "archerTower")
                    {
                        if (x.Left < y.Location.X - 100)
                        {
                            x.Dispose();
                            x.Location = new Point(y.Location.X, y.Location.Y);
                        }
                        if (x.Top < y.Location.Y - 100)
                        {
                            x.Dispose();
                            x.Location = new Point(y.Location.X, y.Location.Y);
                        }
                        if (x.Left > y.Location.X + 100)
                        {
                            x.Dispose();
                            x.Location = new Point(y.Location.X, y.Location.Y);
                        }
                        if (x.Top > y.Location.Y + 100)
                        {
                            x.Dispose();
                            x.Location = new Point(y.Location.X, y.Location.Y);
                        }
                    }
                    if (x is Panel && x.Name.ToString().Substring(0, 4) == "bomb" && y is PictureBox && y.Tag == "bombTower")
                    {
                        if (x.Left < y.Location.X - 100)
                        {
                            x.Dispose();
                            x.Location = new Point(y.Location.X, y.Location.Y);
                        }
                        if (x.Top < y.Location.Y - 100)
                        {
                            x.Dispose();
                            x.Location = new Point(y.Location.X, y.Location.Y);
                        }
                        if (x.Left > y.Location.X + 100)
                        {
                            x.Dispose();
                            x.Location = new Point(y.Location.X, y.Location.Y);
                        }
                        if (x.Top > y.Location.Y + 100)
                        {
                            x.Dispose();
                            x.Location = new Point(y.Location.X, y.Location.Y);
                        }
                    }
                    if (x is Panel && x.Name.ToString().Substring(0, 4) == "ninj" && y is PictureBox && y.Tag == "ninjaTower")
                    {
                        if (x.Left < y.Location.X - 100)
                        {
                            x.Dispose();
                            x.Location = new Point(y.Location.X, y.Location.Y);
                        }
                        if (x.Top < y.Location.Y - 100)
                        {
                            x.Dispose();
                            x.Location = new Point(y.Location.X, y.Location.Y);
                        }
                        if (x.Left > y.Location.X + 100)
                        {
                            x.Dispose();
                            x.Location = new Point(y.Location.X, y.Location.Y);
                        }
                        if (x.Top > y.Location.Y + 100)
                        {
                            x.Dispose();
                            x.Location = new Point(y.Location.X, y.Location.Y);
                        }
                    }
                    if (x is Panel && x.Name.ToString().Substring(0, 3) == "gun" && y is PictureBox && y.Tag == "machinegun")
                    {
                        if (x.Left < y.Location.X - 100)
                        {
                            x.Dispose();
                            x.Location = new Point(y.Location.X, y.Location.Y);
                        }
                        if (x.Top < y.Location.Y - 100)
                        {
                            x.Dispose();
                            x.Location = new Point(y.Location.X, y.Location.Y);
                        }
                        if (x.Left > y.Location.X + 100)
                        {
                            x.Dispose();
                            x.Location = new Point(y.Location.X, y.Location.Y);
                        }
                        if (x.Top > y.Location.Y + 100)
                        {
                            x.Dispose();
                            x.Location = new Point(y.Location.X, y.Location.Y);
                        }
                    }
                }

            }
        }
        #endregion

        #region Towermethodes
        public static void magetowerShoot(int locationX, int locationY)
        {          

            //bullet gets created
            Panel tempmage = new Panel();
            //tempmage.Name = "mage" + mageShootCounter;
            tempmage.Name = "mage" + locationX.ToString("D4") + locationY.ToString("D4") + mageShootCounter;
            tempmage.Location = new Point(locationX, locationY);
            tempmage.BackColor = Color.Red;
            tempmage.Height = 3;
            tempmage.Width = 30;
            tempmage.Tag = "bullet";
            tempmage.BringToFront();
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

        public static void UnvisibleButton(Form form)
        {
            //all buttons on the form game1 get invisible
            foreach (Control x in form.Controls)
            {
                if (x is Button)
                {
                    x.Visible = false;
                }
            }
        }
        public static void ButtonDeactivateTowers(PictureBox pbTower, Button towerButton, Form form)
        {
            //buttons get invisible
            UnvisibleButton(form);
            //the chosen tower gets placed at the chosen place
            if (TowerType == "mage")
            {
                pbTower.BackgroundImage = Properties.Resources.mageTower;
                pbTower.Tag = "mageTower";
                movement.coins = movement.coins - 200;
            }
            else if (TowerType == "archer")
            {
                pbTower.BackgroundImage = Properties.Resources.archerTowerrework;
                pbTower.Tag = "archerTower";
                movement.coins = movement.coins - 250;
            }
            else if (TowerType == "bomb")
            {
                pbTower.BackgroundImage = Properties.Resources.BombTowerrework;
                pbTower.Tag = "bombTower";
                movement.coins = movement.coins - 300;
            }
            else if (TowerType == "ninja")
            {
                pbTower.BackgroundImage = Properties.Resources.NinjaTower;
                pbTower.Tag = "ninjaTower";
                movement.coins = movement.coins - 350;
            }
            else if (TowerType == "machinegun")
            {
                pbTower.BackgroundImage = Properties.Resources.machineGunTower;
                pbTower.Tag = "machinegun";
                movement.coins = movement.coins - 400;
            }

            //when the tag of the tower is not empty you can't use the button anymore
            if (pbTower.Tag != "")
            {
                towerButton.BackColor = Color.Red;
                towerButton.Enabled = false;
            }
        }

        public static void ButtonActivateTowers(Form form)
        {
            //tower buttons get visible
            foreach (Control x in form.Controls)
            {
                if (x is Button)
                {
                    x.Visible = true;
                }
            }
        }


        public static void checkTowerPlacement(Form form)
        {
            //checks what and where the tower is placed, so the right bullet gets shot
            foreach (Control x in form.Controls)
            {
                if (x is PictureBox && x.Tag == "mageTower")
                {
                    magetowerShoot(x.Location.X, x.Location.Y);

                }
                else if (x is PictureBox && x.Tag == "archerTower")
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

        public static void checkCoinsAmount(Form form)
        {
            foreach (Control x in form.Controls)
            {
                if (x is PictureBox && x.Tag == "mageNoCoins")
                {
                    if (movement.coins >= 200)
                    {
                        x.Visible = false;
                    }
                    else if (movement.coins < 200)
                    {
                        x.Visible = true;
                    }
                }
                if (x is PictureBox && x.Tag == "archNoCoins")
                {
                    if (movement.coins >= 250)
                    {
                        x.Visible = false;
                    }
                    else if (movement.coins < 250)
                    {
                        x.Visible = true;
                    }
                }
                if (x is PictureBox && x.Tag == "bombNoCoins")
                {
                    if (movement.coins >= 300)
                    {
                        x.Visible = false;
                    }
                    else if (movement.coins < 300)
                    {
                        x.Visible = true;
                    }
                }
                if (x is PictureBox && x.Tag == "ninjaNoCoins")
                {
                    if (movement.coins >= 350)
                    {
                        x.Visible = false;
                    }
                    else if (movement.coins < 350)
                    {
                        x.Visible = true;
                    }
                }
                if (x is PictureBox && x.Tag == "gunNoCoins")
                {
                    if (movement.coins >= 400)
                    {
                        x.Visible = false;
                    }
                    else if (movement.coins < 400)
                    {
                        x.Visible = true;
                    }
                }
            }

        }


    }

}
