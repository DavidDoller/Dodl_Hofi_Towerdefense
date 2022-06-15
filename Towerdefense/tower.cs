using System.Drawing;
using System.Windows.Forms;

namespace Towerdefense
{
    internal class tower
    {
        public static string TowerType;
        public static Form game;

        #region Towermethodes

        public static void startTower(Form game_)
        {
            game = game_;
        }

        public static void magetowerShoot(int locationX, int locationY, Form form)
        {

            //bullet gets created
            Panel tempmage = new Panel
            {
                //tempmage.Name = "mage" + mageShootCounter;
                Name = "mage",
                Location = new Point(locationX, locationY),
                BackColor = Color.Red,
                Height = 7,
                Width = 7,
                Tag = "bullet"
            };
            tempmage.BringToFront();
            //panelmagetowershot.Add(tempmage);
            if (game1.ActiveForm == null)
            {
                return;
            }

            form.Controls.Add(tempmage);
        }

        public static void archertowerShoot(int locationX, int locationY,Form form)
        {
            //bullet gets created

            Panel temparcher = new Panel
            {
                Name = "arch",
                Location = new Point(locationX, locationY),
                BackColor = Color.Blue,
                Height = 7,
                Width = 7,
                Tag = "bullet"
            };
            //panelarchertowershot.Add(temparcher);
            form.Controls.Add(temparcher);
        }

        public static void bombTowerShoot(int locationX, int locationY, Form form)
        {
            //bullet gets created

            Panel tempBomb = new Panel
            {
                Name = "bomb",
                Location = new Point(locationX, locationY),
                BackColor = Color.Orange,
                Height = 7,
                Width = 7,
                Tag = "bullet"
            };
            //panelBombTowerShot.Add(tempBomb);
            form.Controls.Add(tempBomb);
        }

        public static void ninjaTowerShoot(int locationX, int locationY, Form form)
        {
            //bullet gets created
            Panel tempNinja = new Panel
            {
                Name = "ninj",
                Location = new Point(locationX, locationY),
                BackColor = Color.Green,
                Height = 7,
                Width = 7,
                Tag = "bullet"
            };
            //panelNinjaTowerShot.Add(tempNinja);
            form.Controls.Add(tempNinja);
        }

        public static void machinegunTowerShoot(int locationX, int locationY, Form form)
        {
            //bullet gets created

            Panel tempMachinegun = new Panel
            {
                Name = "gun",
                Location = new Point(locationX, locationY),
                BackColor = Color.Yellow,
                Height = 7,
                Width = 7,
                Tag = "bullet"
            };
            //panelMachineGunTowerShot.Add(tempMachinegun);
            form.Controls.Add(tempMachinegun);
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
                if (x is TextBox)
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
                if(x is TextBox)
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
                if (x.Tag == null)
                {
                    continue;
                }

                foreach (Control y in form.Controls)
                {
                    if (y.Tag == null)
                    {
                        continue;
                    }

                    if (y is PictureBox && y.Tag.ToString().Substring(0, 5) == "enemy")
                    {
                        //calc range
                        if ((y.Location.Y <= x.Location.Y + 150 && y.Location.Y >= x.Location.Y - 150) &&
                            (y.Location.X <= x.Location.X + 150 && y.Location.X >= x.Location.X - 150))
                        {
                            if (x is PictureBox && x.Tag == "mageTower")
                            {
                                magetowerShoot(x.Location.X, x.Location.Y, game);
                                break;
                            }
                            else if (x is PictureBox && x.Tag == "archerTower")
                            {
                                archertowerShoot(x.Location.X, x.Location.Y,game);
                                break;
                            }
                            else if (x is PictureBox && x.Tag == "bombTower")
                            {
                                bombTowerShoot(x.Location.X, x.Location.Y, game);
                                break;
                            }
                            else if (x is PictureBox && x.Tag == "ninjaTower")
                            {
                                ninjaTowerShoot(x.Location.X, x.Location.Y, game);
                                break;
                            }
                            else if (x is PictureBox && x.Tag == "machinegun")
                            {
                                machinegunTowerShoot(x.Location.X, x.Location.Y, game);
                                break;
                            }
                        }
                    }
                }
            }
        }

        public static void checkCoinsAmount(Form form)
        {
            //check if player has enough coins
            //when not a X will appear on he tower selection
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
