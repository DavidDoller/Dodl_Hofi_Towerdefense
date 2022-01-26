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

        public static List<PictureBox> enemyRedList = new List<PictureBox>();
        public static List<PictureBox> enemyBlueList = new List<PictureBox>();
        public static List<PictureBox> enemyPinkList = new List<PictureBox>();

        public static PictureBox Createredloon(int location1, int location2)
        {
            //creats the picturebox "redLoon"

            PictureBox pbred = new PictureBox();

            pbred.Size = new Size(32, 32);
            pbred.Location = new Point(location1, location2);
            pbred.BackgroundImage = Properties.Resources.bloonRed;
            pbred.BackgroundImageLayout = ImageLayout.Stretch;
            pbred.Tag = "enemy" + redLoonCounter;
            pbred.Name = "Redloon";
            redloonhealth = 2;
            pbred.BringToFront();
            enemyRedList.Add(pbred);
            waveController.enemyRedBallonList.Add(pbred);
            game1.ActiveForm.Controls.Add(pbred);
            redLoonCounter++;
            return pbred;
        }

        public static PictureBox CreateBlueLoon(int location1 , int location2)
        {
            //creats the picturebox "blueLoon"
            PictureBox pbBlue = new PictureBox();

            pbBlue.Size = new Size(32, 32);
            pbBlue.Location = new Point(location1, location2);
            pbBlue.BackgroundImage = Properties.Resources.bloonBlue;
            pbBlue.BackgroundImageLayout = ImageLayout.Stretch;
            pbBlue.Tag = "enemy" + blueLoonCounter;
            pbBlue.Name = "Blueloon";
            pbBlue.BringToFront();
            enemyBlueList.Add(pbBlue);
            waveController.enemyBlueBallonList.Add(pbBlue);
            game1.ActiveForm.Controls.Add(pbBlue);
            blueLoonCounter++;
            return pbBlue;
        }

        public static PictureBox CreatePinkLoon(int location1, int location2)
        {
            //creats the picturebox "pinkLoon"
            PictureBox pbPink = new PictureBox();

            pbPink.Size = new Size(32, 32);
            pbPink.Location = new Point(location1, location2);
            pbPink.BackgroundImage = Properties.Resources.bloonBlue;
            pbPink.BackgroundImageLayout = ImageLayout.Stretch;
            pbPink.Tag = "enemy"+ pinkLoonCounter;
            pbPink.Name = "Pinkloon";
            pbPink.BringToFront();
            enemyPinkList.Add(pbPink);
            game1.ActiveForm.Controls.Add(pbPink);
            pinkLoonCounter++;
            return pbPink;
        }
    }


}

