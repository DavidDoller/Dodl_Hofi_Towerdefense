using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Towerdefense
{

    class waveController
    {
        public static int waveCount = 0;

        public static int Wavesleep;

        public static List<PictureBox> enemyRedBallonList = new List<PictureBox>();
        public static List<PictureBox> enemyBlueBallonList = new List<PictureBox>();
        public static List<PictureBox> enemyGreenBallonList = new List<PictureBox>();
        public static List<PictureBox> enemyYellowBallonList = new List<PictureBox>();
        public static List<PictureBox> enemyPinkBallonList = new List<PictureBox>();
        public static List<PictureBox> enemyBlackBallonList = new List<PictureBox>();
        public static List<PictureBox> enemyLightBlueBallonList = new List<PictureBox>();
        public static List<PictureBox> enemyZebraBallonList = new List<PictureBox>();
        public static List<PictureBox> rainbowBallonList = new List<PictureBox>();
        public static List<PictureBox> enemyKeramikBallonList = new List<PictureBox>();

        public static string red;
        public static string blue;
        public static string green;

        public static Root Deserialize(string path)
        {
            return JsonConvert.DeserializeObject<Root>(path);
        }

        public static void wavechecker(int location1, int location2, Timer EnemySpawingCooldown, Form form)
        {           
            string jsondata = File.ReadAllText("../../waves.json");
            List<WaveStructure> waves = Deserialize(jsondata).waves;

            red = waves[waveCount].bloons.red.ToString();
            blue = waves[waveCount].bloons.blue.ToString();
            green = waves[waveCount].bloons.green.ToString();


            if (enemy.redLoonCounter <= waves[waveCount].bloons.red)
            {
                enemy.Createredloon(location1, location2, form);
            }
            if (enemy.blueLoonCounter <= waves[waveCount].bloons.blue && enemy.redLoonCounter >= waves[waveCount].bloons.red)
            {
                enemy.CreateBlueLoon(location1, location2, form);
            }
            if(enemy.redLoonCounter >= waves[waveCount].bloons.red && enemy.blueLoonCounter >= waves[waveCount].bloons.blue)
            {
                EnemySpawingCooldown.Start();
                if (Wavesleep >= 5)
                {
                    EnemySpawingCooldown.Stop();
                    waveCount++;
                    Wavesleep = 0;

                }
            }  
        }
    }
}
