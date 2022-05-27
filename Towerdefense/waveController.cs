using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Towerdefense
{

    static class waveController
    {
        public static game1 game;

        public static int waveCount = 0;

        public static List<PictureBox> enemies = new List<PictureBox>();
        public static List<WaveStructure> waves;
        public static Bloons spawned;

        public static int killed;

        public static Root Deserialize(string path)
        {
            return JsonConvert.DeserializeObject<Root>(path);
        }

       

        public static void start(game1 _game)
        {
            string jsondata = File.ReadAllText("../../wavez.json");
            waves = Deserialize(jsondata).waves;
            Debug.WriteLine(waves[waveCount].bloons.red.ToString());
            spawned = new Bloons();
            game = _game;
            killed = 0;
            waveCount = 0;
        }

        public static void wavechecker()
        {
            if (spawned.red <= waves[waveCount].bloons.red)
            {
                Debug.WriteLine(waves[waveCount].bloons.red.ToString() + ";" +spawned.red.ToString());
                PictureBox temp = new PictureBox();
                enemy.CreateLoon(Balloontypes.bloonRed, game);
                spawned.red++;
            }
            if (spawned.blue <= waves[waveCount].bloons.blue && spawned.red == waves[waveCount].bloons.red)
            {
                PictureBox temp = new PictureBox();
                enemy.CreateLoon(Balloontypes.bloonBlue, game);           
            }
            if (spawned.green <= waves[waveCount].bloons.green && spawned.red == waves[waveCount].bloons.red && spawned.blue == waves[waveCount].bloons.blue)
            {
                PictureBox temp = new PictureBox();
                enemy.CreateLoon(Balloontypes.bloonGreen, game);
            }
            if (checkRoundWin())
            {
                game.nextRound();
                Debug.WriteLine("WON");
                killed = 0;
                spawned.red = 0;
                waveCount++;
            }
        }

        public static bool checkRoundWin()
        {
            int enemCount = 0;

            foreach(var property in waves[waveCount].bloons.GetType().GetProperties())
            {
                enemCount += (int)property.GetValue(waves[waveCount].bloons, null);
            }

            if(killed == enemCount)
            {
                return true;
            }
            return false;
        }
    }
}
