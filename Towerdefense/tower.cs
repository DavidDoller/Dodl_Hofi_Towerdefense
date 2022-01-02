using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Towerdefense
{
    class tower
    { 
        public static List<Panel> panelmagetowershot = new List<Panel>();
        public static List<Panel> panelarchertowershot = new List<Panel>();
        public static Panel tempmage = new Panel();
        public static Panel temparcher = new Panel();

        public static int bulletSpeedX = enemy.pb.Location.X;
        public static int bulletSpeedY = enemy.pb.Location.Y;

        public static bool activemageTower = false;
        public static bool activeArcherTower = false;









        public static void magetower(int locationX,int locationY, int bulletspeed) 
        {
            if (!panelmagetowershot.Contains(tempmage)) 
            {
                tempmage.Location = new Point(locationX, locationY);
                tempmage.BackColor = Color.Red;
                tempmage.Height = 3;
                tempmage.Width = 30;
                tempmage.Tag = "bulletmage";
                panelmagetowershot.Add(tempmage);
                game1.ActiveForm.Controls.Add(tempmage);
            }
            if (tempmage.Left < 0) 
            {
                panelmagetowershot.Remove(tempmage);
                tempmage.Location = new Point(locationX, locationY);

            }
            tempmage.Left -= bulletspeed;
        }

        public static void archertower(int locationX, int locationY,int bulletspeed) 
        {

            if (!panelarchertowershot.Contains(temparcher))
            {
                temparcher.Location = new Point(locationX, locationY);
                temparcher.BackColor = Color.Blue;
                temparcher.Height = 3;
                temparcher.Width = 30;
                temparcher.Tag = "bulletarcher";
                panelarchertowershot.Add(temparcher);
                game1.ActiveForm.Controls.Add(temparcher);
            }
            if (temparcher.Left < 350)
            {
                panelarchertowershot.Remove(temparcher);
                temparcher.Location = new Point(locationX, locationY);

            }
            temparcher.Left -= bulletspeed;
            temparcher.Top -= bulletspeed;

        }

        public static void ButtonDeactivateTowers(PictureBox pbTower ) 
        {
            foreach (Control x in game1.ActiveForm.Controls)
            {
                if (x is Button)
                {
                    x.Visible = false;
                }
            }

                if(game1.TowerType == "mage")
                {
                    pbTower.BackgroundImage = Properties.Resources.mageTower1;
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
                    pbTower.Tag = "maschiengun";
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

    }

}
