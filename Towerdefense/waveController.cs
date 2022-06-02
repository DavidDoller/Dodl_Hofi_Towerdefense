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
        public static int result;

        public static Root Deserialize(string path)
        {
            return JsonConvert.DeserializeObject<Root>(path);
        }

       

        public static void start(game1 _game)
        {
            //start function
            string jsondata = File.ReadAllText("../../wavez.json");
            waves = Deserialize(jsondata).waves;
            Debug.WriteLine(waves[waveCount].bloons.red.ToString());
            spawned = new Bloons();
            game = _game;
            killed = 0;
            waveCount = 0;
        }

        public static void wavechecker(Form form)
        {
            //Debug.WriteLine("in Jason red:" + waves[waveCount].bloons.red.ToString() + "; spawned red:" + spawned.red.ToString() + ";\nin Jason blue: " + waves[waveCount].bloons.blue.ToString() + "; spawned blue: "+ spawned.blue.ToString() + "; \nKills" + killed+"; Result: " +result);
            //If to spawn the diffrent waves and diffrent Bloontypes
            if (spawned.red <= waves[waveCount].bloons.red)
            {           
                enemy.CreateLoon(Balloontypes.bloonRed, game);
                spawned.red++;
            }
            if (spawned.blue <= waves[waveCount].bloons.blue && spawned.red >= waves[waveCount].bloons.red)
            {
                enemy.CreateLoon(Balloontypes.bloonBlue, game);
                spawned.blue++;
            }
            if (spawned.green <= waves[waveCount].bloons.green &&  spawned.blue >= waves[waveCount].bloons.blue)
            {
                enemy.CreateLoon(Balloontypes.bloonGreen, game);
                spawned.green++;
            }
            if (spawned.yellow <= waves[waveCount].bloons.yellow && spawned.green >= waves[waveCount].bloons.green)
            {
                enemy.CreateLoon(Balloontypes.bloonYellow , game);
                spawned.yellow++;
            }
            if (spawned.pink <= waves[waveCount].bloons.pink && spawned.yellow >= waves[waveCount].bloons.yellow)
            {
                enemy.CreateLoon(Balloontypes.bloonPink, game);
                spawned.pink++;
            }
            if (spawned.black <= waves[waveCount].bloons.black && spawned.pink >= waves[waveCount].bloons.pink)
            {
                enemy.CreateLoon(Balloontypes.bloonBlack, game);
                spawned.black++;
            }
            if (spawned.lightBlue <= waves[waveCount].bloons.lightBlue && spawned.black  >= waves[waveCount].bloons.black)
            {
                enemy.CreateLoon(Balloontypes.bloonLightBlue, game);
                spawned.lightBlue++;
            }
            if (checkRoundWin())
            {
                //delete bullets after round end
                foreach(Control y in form.Controls)
                {
                    if (y.Tag == null) continue;
                    if(y is Panel && y.Tag.Equals("bullet"))
                    {
                        y.Dispose();
                    }
                }
                game.nextRound();
                Debug.WriteLine("WON");
                killed = 0;
                spawned.red = 0;
                spawned.blue = 0;
                spawned.green = 0;
                spawned.yellow = 0;
                spawned.pink = 0;
                spawned.black = 0;
                spawned.lightBlue = 0;
                waveCount++;

                

            }
        }

        public static bool checkRoundWin()
        {
            
            int red;
            int blue;
            int green;
            int yellow;
            int pink;
            int black;
            int lightblue;

            red = waves[waveCount].bloons.red;
            blue = waves[waveCount].bloons.blue;
            green = waves[waveCount].bloons.green;
            yellow = waves[waveCount].bloons.yellow;
            pink = waves[waveCount].bloons.pink;
            black = waves[waveCount].bloons.black;
            lightblue = waves[waveCount].bloons.lightBlue;

            //make a calc to see if the wave is over
            result = red + blue + green + yellow + pink + black + lightblue;

            if(killed >= result)
            {
                return true;
            }
            return false;
        }
    }
}
