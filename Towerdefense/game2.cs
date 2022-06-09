using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Towerdefense
{
    public partial class game2 : Form
    {
        public game2()
        {
            InitializeComponent();
        }

        private void game2_Load(object sender, EventArgs e)
        {
            //all buttons get invisible
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

            pb_mageNoCoins.Visible = false;
            pb_archNoCoins.Visible = false;
            pb_bombNoCoins.Visible = false;
            pb_ninjaNoCoins.Visible = false;
            pb_gunNoCoins.Visible = false;
            waveController.start2(this);
            tower.startTower(this);

        }

        private void playtimer_Tick(object sender, EventArgs e)
        {
            lbl_coins.BringToFront();
            lbl_coins.Text = "Coins: " + movement.coins;

            //timer tick refreshes the health label
            //lbl_test.Text = enemy.looncounter.ToString();
            lbl_health.Text = "Health:" + movement.health;

            lbl_wave.Text = "Wave: " + waveController.waveCount;



            movement.moveenemys(this);//enemy movement
            movement.checkdirection(playtimer, enemyspawning, this);//check direction
            tower.checkCoinsAmount(this);
            //lbl_wave.Text = waveController.Cuurentwave;
        }

        private void enemyspawning_Tick(object sender, EventArgs e)
        {
            //spawnrate of the loons
            waveController.wavechecker(this);
        }

        private void bullet_speed_Tick(object sender, EventArgs e)
        {
            //checks where and what tower is placed
            movement.AutoAim(this);
        }

        private void bullet_spawning_Tick(object sender, EventArgs e)
        {
            tower.checkTowerPlacement(this);
            movement.coins = movement.coins + 5;
        }

        private void pb_corner2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        public async Task nextRound2()
        {
            enemyspawning.Stop();
            await Task.Delay(5000);
            enemyspawning.Start();
        }

        private void btn_PlaceTower7_Click(object sender, EventArgs e)
        {
            //buttons get invisible and the tower chosen gets played
            tower.ButtonDeactivateTowers(pb_tower7, btn_PlaceTower7, this);
        }

        private void btn_PlaceTower2_Click(object sender, EventArgs e)
        {
            //buttons get invisible and the tower chosen gets played
            tower.ButtonDeactivateTowers(pb_tower2, btn_PlaceTower2, this);
        }

        private void btn_PlaceTower3_Click(object sender, EventArgs e)
        {
            //buttons get invisible and the tower chosen gets played
            tower.ButtonDeactivateTowers(pb_tower3, btn_PlaceTower3, this);
        }

        private void btn_PlaceTower1_Click(object sender, EventArgs e)
        {
            //buttons get invisible and the tower chosen gets played
            tower.ButtonDeactivateTowers(pb_tower1, btn_PlaceTower1, this);
        }

        private void btn_PlaceTower8_Click(object sender, EventArgs e)
        {
            //buttons get invisible and the tower chosen gets played
            tower.ButtonDeactivateTowers(pb_tower8, btn_PlaceTower8, this);
        }

        private void btn_PlaceTower4_Click(object sender, EventArgs e)
        {
            //buttons get invisible and the tower chosen gets played
            tower.ButtonDeactivateTowers(pb_tower4, btn_PlaceTower4, this);
        }

        private void btn_PlaceTower10_Click(object sender, EventArgs e)
        {
            //buttons get invisible and the tower chosen gets played
            tower.ButtonDeactivateTowers(pb_tower10, btn_PlaceTower10, this);
        }

        private void btn_PlaceTower6_Click(object sender, EventArgs e)
        {
            //buttons get invisible and the tower chosen gets played
            tower.ButtonDeactivateTowers(pb_tower6, btn_PlaceTower6, this);
        }

        private void btn_PlaceTower5_Click(object sender, EventArgs e)
        {
            //buttons get invisible and the tower chosen gets played
            tower.ButtonDeactivateTowers(pb_tower5, btn_PlaceTower5, this);
        }

        private void pb_mageTower_Click(object sender, EventArgs e)
        {
            //buttons get visible again and checks what tower gets placed
            tower.ButtonActivateTowers(this);
            tower.TowerType = "mage";
        }

        private void pb_archerTower_Click(object sender, EventArgs e)
        {
            //buttons get visible again and checks what tower gets placed
            tower.ButtonActivateTowers(this);
            tower.TowerType = "archer";
        }

        private void pb_BombTower_Click(object sender, EventArgs e)
        {
            //buttons get visible again and checks what tower gets placed
            tower.ButtonActivateTowers(this);
            tower.TowerType = "bomb";
        }

        private void pb_maschingunTower_Click(object sender, EventArgs e)
        {
            //buttons get visible again and checks what tower gets placed
            tower.ButtonActivateTowers(this);
            tower.TowerType = "ninja";
        }

        private void pb_ninjaTower_Click(object sender, EventArgs e)
        {
            //buttons get visible again and checks what tower gets placed
            tower.ButtonActivateTowers(this);
            tower.TowerType = "machinegun";
        }
    }
}
