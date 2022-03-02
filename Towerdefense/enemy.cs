using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Towerdefense
{

    class enemy
    {
        public static int health;
        public static int redloonspeed = 5;

        public static int redLoonCounter;
        public static int blueLoonCounter;
        public static int greenLoonCounter;
        public static int yellowLoonCounter;
        public static int pinkLoonCounter;

        public static int blackLoonCounter;
        public static int LightBlueCounter;

        public static int zebraloonCounter;
        public static int rainbowloonCounter;

        public static int keramikLoonCounter;
        internal static int redloonhealth;

        public static PictureBox Createredloon(int location1, int location2, Form form)
        {
            //creats the picturebox "redLoon"

            PictureBox pbred = new PictureBox();

            pbred.Size = new Size(32, 32);
            pbred.Location = new Point(location1, location2);
            pbred.BackgroundImage = Properties.Resources.bloonRed;
            pbred.BackColor = Color.Transparent;
            pbred.BackgroundImageLayout = ImageLayout.Stretch;
            pbred.Tag = "enemy" + redLoonCounter;
            pbred.Name = "Redloon";
            health = 1;
            pbred.BringToFront();
            waveController.enemyRedBallonList.Add(pbred);
            form.Controls.Add(pbred);
            redLoonCounter++;
            return pbred;
        }

        public static PictureBox CreateBlueLoon(int location1, int location2, Form form)
        {
            //creats the picturebox "blueLoon"
            PictureBox pbBlue = new PictureBox();

            pbBlue.Size = new Size(32, 32);
            pbBlue.Location = new Point(location1, location2);
            pbBlue.BackgroundImage = Properties.Resources.bloonBlue;
            pbBlue.BackColor = Color.Transparent;
            pbBlue.BackgroundImageLayout = ImageLayout.Stretch;
            pbBlue.Tag = "enemy" + blueLoonCounter;
            pbBlue.Name = "Blueloon";
            health = 2;
            pbBlue.BringToFront();
            waveController.enemyBlueBallonList.Add(pbBlue);
            form.Controls.Add(pbBlue);
            blueLoonCounter++;
            return pbBlue;
        }

        public static PictureBox CreateGreenLoon(int location1, int location2, Form form)
        {
            PictureBox pbGreen = new PictureBox();

            pbGreen.Size = new Size(32, 32);
            pbGreen.Location = new Point(location1, location2);
            pbGreen.BackgroundImage = Properties.Resources.bloonGreen;
            pbGreen.BackColor = Color.Transparent;
            pbGreen.BackgroundImageLayout = ImageLayout.Stretch;
            pbGreen.Tag = "enemy" + greenLoonCounter;
            pbGreen.Name = "Greenloon";
            health = 3;
            pbGreen.BringToFront();
            waveController.enemyGreenBallonList.Add(pbGreen);
            form.Controls.Add(pbGreen);
            greenLoonCounter++;
            return pbGreen;
        }

        public static PictureBox CreateYellowEnemy(int location1, int location2, Form form)
        {
            PictureBox pbYellow = new PictureBox();

            pbYellow.Size = new Size(32, 32);
            pbYellow.Location = new Point(location1, location2);
            pbYellow.BackgroundImage = Properties.Resources.bloonYellow;
            pbYellow.BackColor = Color.Transparent;
            pbYellow.BackgroundImageLayout = ImageLayout.Stretch;
            pbYellow.Tag = "enemy" + yellowLoonCounter;
            pbYellow.Name = "Yellowloon";
            health = 4;
            pbYellow.BringToFront();
            waveController.enemyYellowBallonList.Add(pbYellow);
            form.Controls.Add(pbYellow);
            yellowLoonCounter++;
            return pbYellow;
        }


        public static PictureBox CreatePinkLoon(int location1, int location2, Form form)
        {
            //creats the picturebox "pinkLoon"
            PictureBox pbPink = new PictureBox();

            pbPink.Size = new Size(32, 32);
            pbPink.Location = new Point(location1, location2);
            pbPink.BackgroundImage = Properties.Resources.bloonPink;
            pbPink.BackColor = Color.Transparent;
            pbPink.BackgroundImageLayout = ImageLayout.Stretch;
            pbPink.Tag = "enemy" + pinkLoonCounter;
            pbPink.Name = "Pinkloon";
            health = 5;
            pbPink.BringToFront();
            waveController.enemyPinkBallonList.Add(pbPink);
            form.Controls.Add(pbPink);
            pinkLoonCounter++;
            return pbPink;
        }

        public static PictureBox CreateBlackLoon(int location1, int location2, Form form)
        {
            //creats the picturebox "pinkLoon"
            PictureBox pbBlack = new PictureBox();

            pbBlack.Size = new Size(32, 32);
            pbBlack.Location = new Point(location1, location2);
            pbBlack.BackgroundImage = Properties.Resources.bloonBlack;
            pbBlack.BackColor = Color.Transparent;
            pbBlack.BackgroundImageLayout = ImageLayout.Stretch;
            pbBlack.Tag = "enemy" + blackLoonCounter;
            pbBlack.Name = "Blackloon";
            health = 6;
            pbBlack.BringToFront();
            waveController.enemyBlackBallonList.Add(pbBlack);
            form.Controls.Add(pbBlack);
            blackLoonCounter++;
            return pbBlack;
        }

        public static PictureBox CreateLightBlueLoon(int location1, int location2, Form form)
        {
            //creats the picturebox "pinkLoon"
            PictureBox pbLightBlue = new PictureBox();

            pbLightBlue.Size = new Size(32, 32);
            pbLightBlue.Location = new Point(location1, location2);
            pbLightBlue.BackgroundImage = Properties.Resources.bloonLightBlue;
            pbLightBlue.BackColor = Color.Transparent;
            pbLightBlue.BackgroundImageLayout = ImageLayout.Stretch;
            pbLightBlue.Tag = "enemy" + LightBlueCounter;
            pbLightBlue.Name = "LightBlue";
            health = 6;
            pbLightBlue.BringToFront();
            waveController.enemyLightBlueBallonList.Add(pbLightBlue);
            form.Controls.Add(pbLightBlue);
            LightBlueCounter++;
            return pbLightBlue;
        }

        public static PictureBox CreateZebraLoon(int location1, int location2, Form form)
        {
            PictureBox pbZebra = new PictureBox();

            pbZebra.Size = new Size(32, 32);
            pbZebra.Location = new Point(location1, location2);
            pbZebra.BackgroundImage = Properties.Resources.bloonZebra;
            pbZebra.BackColor = Color.Transparent;
            pbZebra.BackgroundImageLayout = ImageLayout.Stretch;
            pbZebra.Tag = "enemy" + zebraloonCounter;
            pbZebra.Name = "Zebraloon";
            health = 7;
            pbZebra.BringToFront();
            waveController.enemyZebraBallonList.Add(pbZebra);
            form.Controls.Add(pbZebra);
            zebraloonCounter++;
            return pbZebra;
        }

        public static PictureBox CreaterainbowLoon(int location1, int location2, Form form)
        {
            PictureBox pbRainbow = new PictureBox();

            pbRainbow.Size = new Size(32, 32);
            pbRainbow.Location = new Point(location1, location2);
            pbRainbow.BackgroundImage = Properties.Resources.bloonRainbow;
            pbRainbow.BackColor = Color.Transparent;
            pbRainbow.BackgroundImageLayout = ImageLayout.Stretch;
            pbRainbow.Tag = "enemy" + rainbowloonCounter;
            pbRainbow.Name = "Rainbowloon";
            health = 8;
            pbRainbow.BringToFront();
            waveController.rainbowBallonList.Add(pbRainbow);
            form.Controls.Add(pbRainbow);
            rainbowloonCounter++;
            return pbRainbow;
        }


        public static PictureBox CreateKeramikLoon(int location1, int location2, Form form)
        {
            PictureBox pbKeramik = new PictureBox();

            pbKeramik.Size = new Size(32, 32);
            pbKeramik.Location = new Point(location1, location2);
            pbKeramik.BackgroundImage = Properties.Resources.bloonCeramicFull;
            pbKeramik.BackColor = Color.Transparent;
            pbKeramik.BackgroundImageLayout = ImageLayout.Stretch;
            pbKeramik.Tag = "enemy" + keramikLoonCounter;
            pbKeramik.Name = "Keramik";
            health = 13;
            pbKeramik.BringToFront();
            waveController.enemyKeramikBallonList.Add(pbKeramik);
            form.Controls.Add(pbKeramik);
            keramikLoonCounter++;
            return pbKeramik;
        }
    }
}


