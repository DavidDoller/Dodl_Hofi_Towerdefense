using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Towerdefense
{
    public partial class game1 : Form
    {
        public static int Coins = 200;

        public static string TowerType;

        public static int currentnumber;

        public static string check;


        public game1()
        {
            InitializeComponent();
        }

        
        private void game_Load(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is Button)
                {
                    x.Visible = false;
                }
            }



            pb_corner1.Visible = false;
            pb_corner2.Visible = false;
            pb_corner3.Visible = false;
            pb_corner4.Visible = false;
            pb_corner5.Visible = false;
            DoubleBuffered = true;

        }




        private void playtimer_Tick(object sender, EventArgs e)
        {
            lbl_coins.BringToFront();
            lbl_coins.Text = "Coins: " + Coins;


            lbl_test.Text = enemy.looncounter.ToString();
            lbl_health.Text = "Health:" + movement.health;


            
            movement.moveenemys();
            movement.checkdirection(playtimer, enemyspawning);
        }

        private void enemyspawning_Tick(object sender, EventArgs e)
        {
            enemy.Createredloon(30,419);
            
        }

        private void bullet_speed_Tick(object sender, EventArgs e)
        {
            tower.checkTowerPlacement();
            //tower.autoAim();
            //tower.magetowerShoot(83, 335, 5);
            //tower.archertowerShoot(359, 334, 5);


        }

        private void game1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.E) 
            {
                Application.Exit();
            }
        }

        private void pb_mageTower_Click(object sender, EventArgs e)
        {
            tower.ButtonActivateTowers();
            TowerType = "mage";
        }

        private void pb_archerTower_Click(object sender, EventArgs e)
        {
            tower.ButtonActivateTowers();
            TowerType = "archer";
        }
        private void pb_BombTower_Click(object sender, EventArgs e)
        {
            tower.ButtonActivateTowers();
            TowerType = "bomb";
        }

        private void pb_ninjaTower_Click(object sender, EventArgs e)
        {
            tower.ButtonActivateTowers();
            TowerType = "ninja";
        }

        private void pb_maschingunTower_Click(object sender, EventArgs e)
        {
            tower.ButtonActivateTowers();
            TowerType = "machinegun";
        }



        private void btn_PlaceTower1_Click(object sender, EventArgs e)
        {
            tower.ButtonDeactivateTowers(pb_tower1,btn_PlaceTower1);

            //tower.reduceCoins();
        }

        private void btn_PlaceTower2_Click(object sender, EventArgs e)
        {
            tower.ButtonDeactivateTowers(pb_tower2, btn_PlaceTower2);
            //tower.reduceCoins();
        }

        private void btn_PlaceTower3_Click(object sender, EventArgs e)
        {
            tower.ButtonDeactivateTowers(pb_tower3,btn_PlaceTower3);
            //tower.reduceCoins();
        }

        private void btn_PlaceTower4_Click(object sender, EventArgs e)
        {
            tower.ButtonDeactivateTowers(pb_tower4,btn_PlaceTower4);
            //tower.reduceCoins();
        }

        private void btn_PlaceTower5_Click_1(object sender, EventArgs e)
        {
            tower.ButtonDeactivateTowers(pb_tower5,btn_PlaceTower5);
            //tower.reduceCoins();
        }

        private void btn_PlaceTower6_Click(object sender, EventArgs e)
        {
            tower.ButtonDeactivateTowers(pb_tower6, btn_PlaceTower6);
            //tower.reduceCoins();
        }

        private void btn_PlaceTower7_Click(object sender, EventArgs e)
        {
            tower.ButtonDeactivateTowers(pb_tower7,btn_PlaceTower7);
            //tower.reduceCoins();
        }

        private void btn_PlaceTower8_Click(object sender, EventArgs e)
        {
            tower.ButtonDeactivateTowers(pb_tower8,btn_PlaceTower8);
            //tower.reduceCoins();
        }

        private void btn_PlaceTower9_Click(object sender, EventArgs e)
        {
            tower.ButtonDeactivateTowers(pb_tower9,btn_PlaceTower9);
            //tower.reduceCoins();
        }

        private void btn_PlaceTower10_Click(object sender, EventArgs e)
        {
            tower.ButtonDeactivateTowers(pb_tower10,btn_PlaceTower10);
            //tower.reduceCoins();
        }

        private void pnl_start_Click(object sender, EventArgs e)
        {
            playtimer.Start();
            enemyspawning.Start();
            bullet_speed.Start();
        }

        private void pnl_pause_Click(object sender, EventArgs e)
        {
            playtimer.Stop();
            enemyspawning.Stop();
            bullet_speed.Stop();
        }

        private void lbl_coins_Click(object sender, EventArgs e)
        {

        }

        private void pb_tower5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_coins_Click_1(object sender, EventArgs e)
        {

        }
    }
}
