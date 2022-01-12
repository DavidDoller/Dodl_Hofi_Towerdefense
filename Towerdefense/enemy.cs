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
        public static int looncounter = 1;
        public static int smallestEnemy = 0;
        public static PictureBox pb = new PictureBox();
        public static List<PictureBox> enemyList = new List<PictureBox>();





        public static PictureBox Createredloon(int location1, int location2)
        {
            pb = new PictureBox();
                    
            pb.Size = new Size(32, 32);
            pb.Location = new Point(location1, location2);
            pb.BackgroundImage = Properties.Resources.bloonRed;
            pb.BackgroundImageLayout = ImageLayout.Stretch;
            pb.Tag = "enemy";
            pb.Name = "Redloon"+ looncounter;
            looncounter++;
            redloonhealth = 2;
            pb.BringToFront();
            enemyList.Add(pb);
            game1.ActiveForm.Controls.Add(pb);
            return pb;


        }       
    }


}

