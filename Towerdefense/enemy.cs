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
        public static int health = 10;
        public static int speed = 5;
        

        public static int healpoints(int hp, Form form,PictureBox pb)
        {
            hp = health;

            if(hp < 1) 
            {
                form.Controls.Remove(pb);
                pb.Dispose();
            }

            return hp;
        }

        public static int movespeed(int speed1) 
        {
            speed1 = speed;

            return speed1;
        }

        public static PictureBox Createenemy()
        {
            
            PictureBox pb = new PictureBox();
            pb.Tag = "enemy";
            pb.Size = new Size(32, 32);
            pb.Location = new Point(30, 419);
            pb.BackColor = Color.Red;
            game.ActiveForm.Controls.Add(pb);
            return pb;
        }


    }
}
