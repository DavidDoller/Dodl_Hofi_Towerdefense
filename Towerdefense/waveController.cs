﻿using System;
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
        public static bool wave4 = false;
        public static bool wave5 = false;
        public static bool win = false;

        public static int RedcountEnemys;
        public static int BlueCountEnemys;

        public static int Wavesleep;

        public static List<PictureBox> enemyRedBallonList = new List<PictureBox>();
        public static List<PictureBox> enemyBlueBallonList = new List<PictureBox>();

        public static void wavechecker(int location1, int location2,Timer EnemySpawingCooldown)
        {

            RedcountEnemys = enemy.redLoonCounter;
            BlueCountEnemys = enemy.blueLoonCounter;


            if (wave1 == true)
            {
                game1.wavecounter = "Wave: 1";
                if (RedcountEnemys != 10)
                {
                    enemy.Createredloon(location1, location2);
                }
                if (BlueCountEnemys == 5)
                {
                    EnemySpawingCooldown.Start();
                    if (Wavesleep >= 5)
                    {
                        wave1 = false;
                        wave2 = true;
                    }
                    
                }
            }
            else if (wave2 == true)
            {
                EnemySpawingCooldown.Stop();
                Wavesleep = 0;
                game1.wavecounter = "Wave: 2";

                if (RedcountEnemys != 20)
                {
                    enemy.Createredloon(location1, location2);
                }
                if (BlueCountEnemys != 10 && RedcountEnemys == 20)
                {
                    enemy.CreateBlueLoon(location1, location2);

                }
                if (BlueCountEnemys == 20 && BlueCountEnemys == 10)
                {
                    EnemySpawingCooldown.Start();
                    if (Wavesleep >= 5)
                    {
                        wave2 = false;
                        wave3 = true;
                    }   
                    
                }
            }
            else if (wave3 == true)
            {
                EnemySpawingCooldown.Stop();
                game1.wavecounter = "Wave: 3";
            }
            else if (win == true)
            {
                MessageBox.Show("Geschafft", "Done", MessageBoxButtons.OK);

                if (DialogResult.OK.Equals(true))
                {
                    menu form = new menu();
                    form.Show();
                    if (game1.ActiveForm == null) return;
                    game1.ActiveForm.Hide();
                }
            }
        }
    }
}