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
        public static int redloonhealth = 2;
        public static int redloonspeed = 5;
        

        public static PictureBox Createredloon(int location1, int location2)
        {
            
            PictureBox pb = new PictureBox();         
            pb.Size = new Size(32, 32);
            pb.Location = new Point(location1, location2);
            pb.BackgroundImage = Properties.Resources.bloonRed;
            pb.BackgroundImageLayout = ImageLayout.Stretch;
            pb.Tag = "enemy";
            pb.Name = "Redloon";
            redloonhealth = 2;
            pb.BringToFront();
            game1.ActiveForm.Controls.Add(pb);
            return pb;
        }


    }


}

