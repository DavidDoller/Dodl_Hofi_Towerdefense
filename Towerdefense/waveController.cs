using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Towerdefense
{
    
    class waveController
    {
        public static bool wave1 = true;
        public static bool wave2 = false;
        public static bool wave3 = false;
        public static int RedcountEnemys;
        public static int BlueCountEnemys;

        public static List<PictureBox> enemyRedBallonList = new List<PictureBox>();
        public static List<PictureBox> enemyBlueBallonList = new List<PictureBox>();

        public static void wavechecker(int location1, int location2)
        {
            foreach(Control x in game1.ActiveForm.Controls)
            {
                if (x.Tag == null) continue;
                if(x is PictureBox && x.Name == "Redloon")
                {
                    RedcountEnemys = x.Controls.Count;   
                }
                else if (x is PictureBox && x.Tag.ToString().Substring(0,5) == "enemy" && x.Name == "Blueloon")
                {
                    BlueCountEnemys = x.Controls.Count;
                }
            }

            if (RedcountEnemys == 0 && BlueCountEnemys == 0)
            {
                enemyRedBallonList.Clear();
                enemyBlueBallonList.Clear();
            }

            if (wave1 == true)
            {
                game1.wavecounter = "Wave: 1";
                if(enemyRedBallonList.Count() != 10)
                {
                    enemy.Createredloon(location1, location2);
                }
                if (enemyBlueBallonList.Count() != 5 && enemyRedBallonList.Count() == 10)
                {
                    enemy.CreateBlueLoon(location1, location2);
                    wave1 = false;
                    wave2 = true;
                }
            }
            else if (wave2 == true)
            {
                game1.wavecounter = "Wave: 2";
            }
            else if (wave3 == true)
            {
                game1.wavecounter = "Wave: 3";
            }
        }
    }
}
