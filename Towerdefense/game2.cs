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


            //direction check pictureboxes get invisible
            pb_corner1.Visible = false;
            pb_corner2.Visible = false;
            pb_corner3.Visible = false;
            pb_corner4.Visible = false;
            pb_corner5.Visible = false;
            pb_corner7.Visible = false;
            pb_corner10.Visible = false;
            pb_corner9.Visible = false;
            DoubleBuffered = true;

            pb_mageNoCoins.Visible = false;
            pb_archNoCoins.Visible = false;
            pb_bombNoCoins.Visible = false;
            pb_ninjaNoCoins.Visible = false;
            pb_gunNoCoins.Visible = false;
        }

        private void btn_PlaceTower4_Click(object sender, EventArgs e)
        {
            tower.ButtonDeactivateTowers(pb_tower4, btn_PlaceTower4, game2.ActiveForm);
        }

        private void btn_PlaceTower10_Click(object sender, EventArgs e)
        {
            tower.ButtonDeactivateTowers(pb_tower10, btn_PlaceTower10, game2.ActiveForm);
        }

        private void btn_PlaceTower3_Click(object sender, EventArgs e)
        {
            tower.ButtonDeactivateTowers(pb_tower2, btn_PlaceTower2, game2.ActiveForm);
        }

        private void btn_PlaceTower2_Click(object sender, EventArgs e)
        {
            tower.ButtonDeactivateTowers(pb_tower2, btn_PlaceTower2, game2.ActiveForm);
        }

        private void btn_PlaceTower8_Click(object sender, EventArgs e)
        {
            tower.ButtonDeactivateTowers(pb_tower8, btn_PlaceTower8, game2.ActiveForm);
        }

        private void btn_PlaceTower9_Click(object sender, EventArgs e)
        {
            tower.ButtonDeactivateTowers(pb_tower9, btn_PlaceTower9 , game2.ActiveForm);
        }

        private void btn_PlaceTower7_Click(object sender, EventArgs e)
        {
            tower.ButtonDeactivateTowers(pb_tower7, btn_PlaceTower7, game2.ActiveForm);
        }

        private void btn_PlaceTower6_Click(object sender, EventArgs e)
        {
            tower.ButtonDeactivateTowers(pb_tower6, btn_PlaceTower6, game2.ActiveForm);
        }

        private void pb_mageTower_Click(object sender, EventArgs e)
        {
            //buttons get visible again and checks what tower gets placed
            tower.ButtonActivateTowers(game2.ActiveForm);
            tower.TowerType = "mage";
        }

        private void pb_ninjaTower_Click(object sender, EventArgs e)
        {
            //buttons get visible again and checks what tower gets placed
            tower.ButtonActivateTowers(game2.ActiveForm);
            tower.TowerType = "ninja";
        }

        private void pb_BombTower_Click(object sender, EventArgs e)
        {
            //buttons get visible again and checks what tower gets placed
            tower.ButtonActivateTowers(game2.ActiveForm);
            tower.TowerType = "bomb";
        }

        private void pb_archerTower_Click(object sender, EventArgs e)
        {
            tower.ButtonActivateTowers(game2.ActiveForm);
            tower.TowerType = "archer";
        }

        private void pb_maschingunTower_Click(object sender, EventArgs e)
        {
            tower.ButtonActivateTowers(game2.ActiveForm);
            tower.TowerType = "machinegun";
        }

        private void bullet_speed_Tick(object sender, EventArgs e)
        {
            tower.TowerShootsController();
            movement.AutoAim(game2.ActiveForm);
        }

        private void bullet_spawning_Tick(object sender, EventArgs e)
        {
            tower.checkTowerPlacement(game2.ActiveForm);
            movement.coins = movement.coins + 5;
        }

        private void enemyspawning_Tick(object sender, EventArgs e)
        {
            waveController.wavechecker(pbspawn.Location.X + 10, pbspawn.Location.Y, waveSleepTimer, game2.ActiveForm);
        }

        private void playtimer_Tick_1(object sender, EventArgs e)
        {
            //timer tick refreshes the coins label
            lbl_coins.BringToFront();
            lblcoins.Text = "Coins: " + movement.coins;

            //timer tick refreshes the health label
            //lbl_test.Text = enemy.looncounter.ToString();
            lblhealth.Text = "Health:" + movement.health;

            lbl_redlooncounter.Text = "Redloons in List: " + waveController.RedcountEnemys;

            movement.moveenemys(game2.ActiveForm);//enemy movement
            movement.checkdirection(playtimer, enemyspawning, game2.ActiveForm);//check direction
            tower.checkCoinsAmount(game2.ActiveForm);
            lbl_wave.Text = waveController.Cuurentwave;
            lbl_waveCooldown.Text = "Time Elapsed: " + waveController.Wavesleep;
        }
    }
}
