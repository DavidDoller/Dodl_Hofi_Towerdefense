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
        public static int PinkCountEnemys;

        public static int Wavesleep;

        public static List<PictureBox> enemyRedBallonList = new List<PictureBox>();
        public static List<PictureBox> enemyBlueBallonList = new List<PictureBox>();
        public static List<PictureBox> enemyGreenBallonList = new List<PictureBox>();
        public static List<PictureBox> enemyPinkBallonList = new List<PictureBox>();

        public static string Cuurentwave;

        public static void wavechecker(int location1, int location2,Timer EnemySpawingCooldown, Form form)
        {

            RedcountEnemys = enemy.redLoonCounter;
            BlueCountEnemys = enemy.blueLoonCounter;
            PinkCountEnemys = enemy.pinkLoonCounter;


            if (wave1 == true)
            {
                Cuurentwave = "Wave: 1";
                if (RedcountEnemys != 10)
                {
                    enemy.Createredloon(location1, location2, form);
                    

                }
                if (RedcountEnemys >= 10)
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
                Cuurentwave = "Wave: 2";

                if (BlueCountEnemys != 5)
                {
                    enemy.CreateBlueLoon(location1, location2, form);
                }
                if (RedcountEnemys != 20 && BlueCountEnemys >= 5)
                {
                    enemy.Createredloon(location1, location2, form);
                }
                if (RedcountEnemys >= 20 && BlueCountEnemys >= 5)
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
                Wavesleep = 0;
                Cuurentwave = "Wave: 3";

                if(BlueCountEnemys != 25)
                {
                    enemy.Createredloon(location1, location2,form);
                }
                if(BlueCountEnemys >= 25)
                {
                    EnemySpawingCooldown.Start();
                    if (Wavesleep >= 5)
                    {
                        wave3 = false;
                        wave4 = true;
                    }
                } 
            }
            else if (wave4 == true)
            {
                EnemySpawingCooldown.Stop();
                Wavesleep = 0;
                Cuurentwave = "Wave: 4";

                if(BlueCountEnemys != 35)
                {
                    enemy.CreateBlueLoon(location1, location2,form);
                }
                if(BlueCountEnemys >= 35 && PinkCountEnemys != 5)
                {
                    enemy.CreatePinkLoon(location1, location2,form);
                }
                if (PinkCountEnemys >= 5 && BlueCountEnemys >= 35)
                {
                    EnemySpawingCooldown.Start();
                    if (Wavesleep >= 5)
                    {
                        wave4 = false;
                        win = true;
                    }
                }
            }
            else if (wave5 == true)
            {

            }
            else if (win == true)
            {
                MessageBox.Show("Geschafft", "Done", MessageBoxButtons.OK);

                if (DialogResult.OK.Equals(true))
                {
                    menu menu = new menu();
                    menu.Show();
                    form.Hide();
                }
            }
        }
    }
}
