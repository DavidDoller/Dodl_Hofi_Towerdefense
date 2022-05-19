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

        public game1()
        {
            InitializeComponent();
        }
      
        private void game_Load(object sender, EventArgs e)
        {
            //all buttons get invisible
            foreach (Control x in this.Controls)
            {
                if (x is Button)
                {
                    x.Visible = false;
                }
            }

            //direction check pictureboxes get invisible
            pb_corner1.Visible = false;
            pb_corner2.Visible = false;
            pb_corner3.Visible = false;
            pb_corner4.Visible = false;
            pb_corner5.Visible = false;
            DoubleBuffered = true;

            pb_mageNoCoins.Visible = false;
            pb_archNoCoins.Visible = false;
            pb_bombNoCoins.Visible = false;
            pb_ninjaNoCoins.Visible = false;
            pb_gunNoCoins.Visible = false;
        }

        private void playtimer_Tick(object sender, EventArgs e)
        {
            lbl_redlooncounter.Text = "Redloons in List: " + enemy.redLoonCounter;
            lbl_bluelooncounter.Text = "Blueloons in List: " + enemy.blackLoonCounter;
            lbl_waveCooldown.Text = "Time Elapsed: " + waveController.Wavesleep;

            //timer tick refreshes the coins label
            lbl_coins.BringToFront();
            lbl_coins.Text = "Coins: " + movement.coins;

            //timer tick refreshes the health label
            //lbl_test.Text = enemy.looncounter.ToString();
            lbl_health.Text = "Health:" + movement.health;

            lbl_curentwave.Text = "Wave: " + waveController.waveCount;
            
            movement.moveenemys(game1.ActiveForm);//enemy movement
            movement.checkdirection(playtimer, enemyspawning,game1.ActiveForm);//check direction
            tower.checkCoinsAmount(game1.ActiveForm);

            lbl_red.Text = "Red: "+waveController.red;
            lbl_blue.Text = "Blue: "+waveController.blue;
            lbl_green.Text = "Green: "+waveController.green;
        }

        private void enemyspawning_Tick(object sender, EventArgs e)
        {
            //spawnrate of the loons
            //enemy.Createredloon(30,419);
            //enemy.CreateBlueLoon(30, 419);

            waveController.wavechecker(pb_spawn.Location.X + 10, pb_spawn.Location.Y, WaveSleepTimer,game1.ActiveForm);
            
        }

        private void bullet_speed_Tick(object sender, EventArgs e)
        {
            //checks where and what tower is placed            
            tower.TowerShootsController();
            movement.AutoAim(game1.ActiveForm,bullet_spawning);
        }

        private void game1_KeyDown(object sender, KeyEventArgs e)
        {
            //Key E closes the application
            if(e.KeyCode == Keys.E) 
            {
                Application.Exit();
            }
        }

        private void pb_mageTower_Click(object sender, EventArgs e)
        {
            //buttons get visible again and checks what tower gets placed
            tower.ButtonActivateTowers(game1.ActiveForm);
            tower.TowerType = "mage";
        }

        private void pb_archerTower_Click(object sender, EventArgs e)
        {
            //buttons get visible again and checks what tower gets placed
            tower.ButtonActivateTowers(game1.ActiveForm);
            tower.TowerType = "archer";
        }
        private void pb_BombTower_Click(object sender, EventArgs e)
        {
            //buttons get visible again and checks what tower gets placed
            tower.ButtonActivateTowers(game1.ActiveForm);
            tower.TowerType = "bomb";
        }

        private void pb_ninjaTower_Click(object sender, EventArgs e)
        {
            //buttons get visible again and checks what tower gets placed
            tower.ButtonActivateTowers(game1.ActiveForm);
            tower.TowerType = "ninja";
        }

        private void pb_maschingunTower_Click(object sender, EventArgs e)
        {
            //buttons get visible again and checks what tower gets placed
            tower.ButtonActivateTowers(game1.ActiveForm);
            tower.TowerType = "machinegun";
        }



        private void btn_PlaceTower1_Click(object sender, EventArgs e)
        {
            //buttons get invisible and the tower chosen gets played
            tower.ButtonDeactivateTowers(pb_tower1,btn_PlaceTower1,game1.ActiveForm);
            //tower.reduceCoins(Coins);
        }

        private void btn_PlaceTower2_Click(object sender, EventArgs e)
        {
            //buttons get invisible and the tower chosen gets played
            tower.ButtonDeactivateTowers(pb_tower2, btn_PlaceTower2, game1.ActiveForm);
            //tower.reduceCoins();
        }

        private void btn_PlaceTower3_Click(object sender, EventArgs e)
        {
            //buttons get invisible and the tower chosen gets played
            tower.ButtonDeactivateTowers(pb_tower3,btn_PlaceTower3, game1.ActiveForm);
            //tower.reduceCoins();
        }

        private void btn_PlaceTower4_Click(object sender, EventArgs e)
        {
            //buttons get invisible and the tower chosen gets played
            tower.ButtonDeactivateTowers(pb_tower4,btn_PlaceTower4, game1.ActiveForm);
            //tower.reduceCoins();
        }

        private void btn_PlaceTower5_Click_1(object sender, EventArgs e)
        {
            //buttons get invisible and the tower chosen gets played
            tower.ButtonDeactivateTowers(pb_tower5,btn_PlaceTower5, game1.ActiveForm);
            //tower.reduceCoins();
        }

        private void btn_PlaceTower6_Click(object sender, EventArgs e)
        {
            //buttons get invisible and the tower chosen gets played
            tower.ButtonDeactivateTowers(pb_tower6, btn_PlaceTower6, game1.ActiveForm);
            //tower.reduceCoins();
        }

        private void btn_PlaceTower7_Click(object sender, EventArgs e)
        {
            //buttons get invisible and the tower chosen gets played
            tower.ButtonDeactivateTowers(pb_tower7,btn_PlaceTower7, game1.ActiveForm);
            //tower.reduceCoins();
        }

        private void btn_PlaceTower8_Click(object sender, EventArgs e)
        {
            //buttons get invisible and the tower chosen gets played
            tower.ButtonDeactivateTowers(pb_tower8,btn_PlaceTower8, game1.ActiveForm);
            //tower.reduceCoins();
        }

        private void btn_PlaceTower9_Click(object sender, EventArgs e)
        {
            //buttons get invisible and the tower chosen gets played
            tower.ButtonDeactivateTowers(pb_tower9,btn_PlaceTower9, game1.ActiveForm);
            //tower.reduceCoins();
        }

        private void btn_PlaceTower10_Click(object sender, EventArgs e)
        {
            //buttons get invisible and the tower chosen gets played
            tower.ButtonDeactivateTowers(pb_tower10,btn_PlaceTower10, game1.ActiveForm);
            //tower.reduceCoins();
        }

        private void pnl_start_Click(object sender, EventArgs e)
        {
            //timers get activated
            playtimer.Start();
            enemyspawning.Start();
            bullet_speed.Start();
        }

        private void pnl_pause_Click(object sender, EventArgs e)
        {
            //timers get deactivated
            playtimer.Stop();
            enemyspawning.Stop();
            bullet_speed.Stop();
        }

        private void bullet_spawning_Tick(object sender, EventArgs e)
        {
            tower.checkTowerPlacement(game1.ActiveForm);
            movement.coins = movement.coins + 5;
        }

        private void WaveSleepTimer_Tick(object sender, EventArgs e)
        {
            waveController.Wavesleep++;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnl_start_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_pause_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
