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
        public static int redloonhealth = 3;
        public static int redloonspeed = 5;

        public static int redLoonCounter;
        public static int blueLoonCounter;
        public static int pinkLoonCounter;
        public static int greenLoonCounter;

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
            redloonhealth = 2;
            pbred.BringToFront();
            enemyRedList.Add(pbred);
            waveController.enemyRedBallonList.Add(pbred);
            form.Controls.Add(pbred);
            redLoonCounter++;
            return pbred;
        }

        public static PictureBox CreateBlueLoon(int location1 , int location2, Form form)
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
            pbBlue.BringToFront();
            waveController.enemyBlueBallonList.Add(pbBlue);
            form.Controls.Add(pbBlue);
            blueLoonCounter++;
            return pbBlue;
        }

        public static PictureBox CreateGreenLoon(int location1, int location2,Form form) 
        {
            PictureBox pbGreen = new PictureBox();

            pbGreen.Size = new Size(32, 32);
            pbGreen.Location = new Point(location1, location2);
            pbGreen.BackgroundImage = Properties.Resources.bloonGreen;
            pbGreen.BackColor = Color.Transparent;
            pbGreen.BackgroundImageLayout = ImageLayout.Stretch;
            pbGreen.Tag = "enemy" + greenLoonCounter;
            pbGreen.Name = "Greenloon";
            pbGreen.BringToFront();
            waveController.enemyGreenBallonList.Add(pbGreen);
            form.Controls.Add(pbGreen);
            greenLoonCounter++;
            return pbGreen;
        }

        public static PictureBox CreatePinkLoon(int location1, int location2,Form form)
        {
            //creats the picturebox "pinkLoon"
            PictureBox pbPink = new PictureBox();

            pbPink.Size = new Size(32, 32);
            pbPink.Location = new Point(location1, location2);
            pbPink.BackgroundImage = Properties.Resources.bloonBlue;
            pbPink.BackColor = Color.Transparent;
            pbPink.BackgroundImageLayout = ImageLayout.Stretch;
            pbPink.Tag = "enemy"+ pinkLoonCounter;
            pbPink.Name = "Pinkloon";
            pbPink.BringToFront();
            waveController.enemyPinkBallonList.Add(pbPink);
            form.Controls.Add(pbPink);
            pinkLoonCounter++;
            return pbPink;
        }
    }


}

