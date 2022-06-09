
namespace Towerdefense
{
    partial class game2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pb_gunNoCoins = new System.Windows.Forms.PictureBox();
            this.pb_ninjaNoCoins = new System.Windows.Forms.PictureBox();
            this.pb_bombNoCoins = new System.Windows.Forms.PictureBox();
            this.pb_archNoCoins = new System.Windows.Forms.PictureBox();
            this.pb_mageNoCoins = new System.Windows.Forms.PictureBox();
            this.lbl_maschineGunPrice = new System.Windows.Forms.Label();
            this.lbl_ninjaTowerPrice = new System.Windows.Forms.Label();
            this.lbl_bombTowerPrice = new System.Windows.Forms.Label();
            this.lbl_archerTowerPrice = new System.Windows.Forms.Label();
            this.lbl_mageTowerPrice = new System.Windows.Forms.Label();
            this.pb_ninjaTower = new System.Windows.Forms.PictureBox();
            this.pb_maschingunTower = new System.Windows.Forms.PictureBox();
            this.pb_BombTower = new System.Windows.Forms.PictureBox();
            this.pb_archerTower = new System.Windows.Forms.PictureBox();
            this.pb_mageTower = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playtimer = new System.Windows.Forms.Timer(this.components);
            this.enemyspawning = new System.Windows.Forms.Timer(this.components);
            this.bullet_speed = new System.Windows.Forms.Timer(this.components);
            this.bullet_spawning = new System.Windows.Forms.Timer(this.components);
            this.lbl_health = new System.Windows.Forms.Label();
            this.lbl_coins = new System.Windows.Forms.Label();
            this.pb_backgroundCoins = new System.Windows.Forms.PictureBox();
            this.lbl_wave = new System.Windows.Forms.Label();
            this.pb_corner1 = new System.Windows.Forms.PictureBox();
            this.pb_corner2 = new System.Windows.Forms.PictureBox();
            this.pb_corner3 = new System.Windows.Forms.PictureBox();
            this.pb_corner5 = new System.Windows.Forms.PictureBox();
            this.pb_corner4 = new System.Windows.Forms.PictureBox();
            this.btn_PlaceTower1 = new System.Windows.Forms.Button();
            this.pb_tower1 = new System.Windows.Forms.PictureBox();
            this.btn_PlaceTower5 = new System.Windows.Forms.Button();
            this.btn_PlaceTower10 = new System.Windows.Forms.Button();
            this.btn_PlaceTower8 = new System.Windows.Forms.Button();
            this.btn_PlaceTower7 = new System.Windows.Forms.Button();
            this.btn_PlaceTower6 = new System.Windows.Forms.Button();
            this.btn_PlaceTower4 = new System.Windows.Forms.Button();
            this.btn_PlaceTower3 = new System.Windows.Forms.Button();
            this.btn_PlaceTower2 = new System.Windows.Forms.Button();
            this.pb_tower10 = new System.Windows.Forms.PictureBox();
            this.pb_tower8 = new System.Windows.Forms.PictureBox();
            this.pb_tower7 = new System.Windows.Forms.PictureBox();
            this.pb_tower2 = new System.Windows.Forms.PictureBox();
            this.pb_tower3 = new System.Windows.Forms.PictureBox();
            this.pb_tower6 = new System.Windows.Forms.PictureBox();
            this.pb_tower5 = new System.Windows.Forms.PictureBox();
            this.pb_tower4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gunNoCoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ninjaNoCoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bombNoCoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_archNoCoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mageNoCoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ninjaTower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_maschingunTower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BombTower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_archerTower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mageTower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_backgroundCoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_corner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_corner2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_corner3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_corner5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_corner4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tower1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tower10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tower8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tower7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tower2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tower3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tower6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tower5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tower4)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_gunNoCoins
            // 
            this.pb_gunNoCoins.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pb_gunNoCoins.BackgroundImage = global::Towerdefense.Properties.Resources.notEnoughCoins;
            this.pb_gunNoCoins.Location = new System.Drawing.Point(885, 555);
            this.pb_gunNoCoins.Name = "pb_gunNoCoins";
            this.pb_gunNoCoins.Size = new System.Drawing.Size(53, 53);
            this.pb_gunNoCoins.TabIndex = 98;
            this.pb_gunNoCoins.TabStop = false;
            this.pb_gunNoCoins.Tag = "gunNoCoins";
            // 
            // pb_ninjaNoCoins
            // 
            this.pb_ninjaNoCoins.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pb_ninjaNoCoins.BackgroundImage = global::Towerdefense.Properties.Resources.notEnoughCoins;
            this.pb_ninjaNoCoins.Location = new System.Drawing.Point(686, 555);
            this.pb_ninjaNoCoins.Name = "pb_ninjaNoCoins";
            this.pb_ninjaNoCoins.Size = new System.Drawing.Size(53, 53);
            this.pb_ninjaNoCoins.TabIndex = 97;
            this.pb_ninjaNoCoins.TabStop = false;
            this.pb_ninjaNoCoins.Tag = "ninjaNoCoins";
            // 
            // pb_bombNoCoins
            // 
            this.pb_bombNoCoins.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pb_bombNoCoins.BackgroundImage = global::Towerdefense.Properties.Resources.notEnoughCoins;
            this.pb_bombNoCoins.Location = new System.Drawing.Point(490, 553);
            this.pb_bombNoCoins.Name = "pb_bombNoCoins";
            this.pb_bombNoCoins.Size = new System.Drawing.Size(53, 53);
            this.pb_bombNoCoins.TabIndex = 96;
            this.pb_bombNoCoins.TabStop = false;
            this.pb_bombNoCoins.Tag = "bombNoCoins";
            // 
            // pb_archNoCoins
            // 
            this.pb_archNoCoins.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pb_archNoCoins.BackgroundImage = global::Towerdefense.Properties.Resources.notEnoughCoins;
            this.pb_archNoCoins.Location = new System.Drawing.Point(257, 555);
            this.pb_archNoCoins.Name = "pb_archNoCoins";
            this.pb_archNoCoins.Size = new System.Drawing.Size(53, 53);
            this.pb_archNoCoins.TabIndex = 95;
            this.pb_archNoCoins.TabStop = false;
            this.pb_archNoCoins.Tag = "archNoCoins";
            // 
            // pb_mageNoCoins
            // 
            this.pb_mageNoCoins.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pb_mageNoCoins.BackgroundImage = global::Towerdefense.Properties.Resources.notEnoughCoins;
            this.pb_mageNoCoins.Location = new System.Drawing.Point(60, 553);
            this.pb_mageNoCoins.Name = "pb_mageNoCoins";
            this.pb_mageNoCoins.Size = new System.Drawing.Size(53, 53);
            this.pb_mageNoCoins.TabIndex = 94;
            this.pb_mageNoCoins.TabStop = false;
            this.pb_mageNoCoins.Tag = "mageNoCoins";
            // 
            // lbl_maschineGunPrice
            // 
            this.lbl_maschineGunPrice.AutoSize = true;
            this.lbl_maschineGunPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_maschineGunPrice.Location = new System.Drawing.Point(870, 609);
            this.lbl_maschineGunPrice.Name = "lbl_maschineGunPrice";
            this.lbl_maschineGunPrice.Size = new System.Drawing.Size(25, 13);
            this.lbl_maschineGunPrice.TabIndex = 93;
            this.lbl_maschineGunPrice.Text = "400";
            // 
            // lbl_ninjaTowerPrice
            // 
            this.lbl_ninjaTowerPrice.AutoSize = true;
            this.lbl_ninjaTowerPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_ninjaTowerPrice.Location = new System.Drawing.Point(666, 611);
            this.lbl_ninjaTowerPrice.Name = "lbl_ninjaTowerPrice";
            this.lbl_ninjaTowerPrice.Size = new System.Drawing.Size(25, 13);
            this.lbl_ninjaTowerPrice.TabIndex = 92;
            this.lbl_ninjaTowerPrice.Text = "350";
            // 
            // lbl_bombTowerPrice
            // 
            this.lbl_bombTowerPrice.AutoSize = true;
            this.lbl_bombTowerPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_bombTowerPrice.Location = new System.Drawing.Point(461, 609);
            this.lbl_bombTowerPrice.Name = "lbl_bombTowerPrice";
            this.lbl_bombTowerPrice.Size = new System.Drawing.Size(25, 13);
            this.lbl_bombTowerPrice.TabIndex = 91;
            this.lbl_bombTowerPrice.Text = "300";
            // 
            // lbl_archerTowerPrice
            // 
            this.lbl_archerTowerPrice.AutoSize = true;
            this.lbl_archerTowerPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_archerTowerPrice.Location = new System.Drawing.Point(243, 609);
            this.lbl_archerTowerPrice.Name = "lbl_archerTowerPrice";
            this.lbl_archerTowerPrice.Size = new System.Drawing.Size(25, 13);
            this.lbl_archerTowerPrice.TabIndex = 90;
            this.lbl_archerTowerPrice.Text = "250";
            // 
            // lbl_mageTowerPrice
            // 
            this.lbl_mageTowerPrice.AutoSize = true;
            this.lbl_mageTowerPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_mageTowerPrice.Location = new System.Drawing.Point(38, 609);
            this.lbl_mageTowerPrice.Name = "lbl_mageTowerPrice";
            this.lbl_mageTowerPrice.Size = new System.Drawing.Size(25, 13);
            this.lbl_mageTowerPrice.TabIndex = 89;
            this.lbl_mageTowerPrice.Text = "200";
            // 
            // pb_ninjaTower
            // 
            this.pb_ninjaTower.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pb_ninjaTower.BackgroundImage = global::Towerdefense.Properties.Resources.NinjaTower;
            this.pb_ninjaTower.Location = new System.Drawing.Point(652, 555);
            this.pb_ninjaTower.Name = "pb_ninjaTower";
            this.pb_ninjaTower.Size = new System.Drawing.Size(57, 53);
            this.pb_ninjaTower.TabIndex = 88;
            this.pb_ninjaTower.TabStop = false;
            this.pb_ninjaTower.Tag = "ninjaTowerselecter";
            this.pb_ninjaTower.Click += new System.EventHandler(this.pb_ninjaTower_Click);
            // 
            // pb_maschingunTower
            // 
            this.pb_maschingunTower.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pb_maschingunTower.BackgroundImage = global::Towerdefense.Properties.Resources.machineGunTower;
            this.pb_maschingunTower.Location = new System.Drawing.Point(859, 555);
            this.pb_maschingunTower.Name = "pb_maschingunTower";
            this.pb_maschingunTower.Size = new System.Drawing.Size(59, 53);
            this.pb_maschingunTower.TabIndex = 87;
            this.pb_maschingunTower.TabStop = false;
            this.pb_maschingunTower.Tag = "maschingunTowerselecter";
            this.pb_maschingunTower.Click += new System.EventHandler(this.pb_maschingunTower_Click);
            // 
            // pb_BombTower
            // 
            this.pb_BombTower.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pb_BombTower.BackgroundImage = global::Towerdefense.Properties.Resources.BombTowerrework;
            this.pb_BombTower.Location = new System.Drawing.Point(447, 555);
            this.pb_BombTower.Name = "pb_BombTower";
            this.pb_BombTower.Size = new System.Drawing.Size(57, 53);
            this.pb_BombTower.TabIndex = 86;
            this.pb_BombTower.TabStop = false;
            this.pb_BombTower.Tag = "BombTowerselecter";
            this.pb_BombTower.Click += new System.EventHandler(this.pb_BombTower_Click);
            // 
            // pb_archerTower
            // 
            this.pb_archerTower.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pb_archerTower.BackgroundImage = global::Towerdefense.Properties.Resources.archerTowerrework;
            this.pb_archerTower.Location = new System.Drawing.Point(231, 555);
            this.pb_archerTower.Name = "pb_archerTower";
            this.pb_archerTower.Size = new System.Drawing.Size(57, 53);
            this.pb_archerTower.TabIndex = 85;
            this.pb_archerTower.TabStop = false;
            this.pb_archerTower.Tag = "archerTowerselecter";
            this.pb_archerTower.Click += new System.EventHandler(this.pb_archerTower_Click);
            // 
            // pb_mageTower
            // 
            this.pb_mageTower.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pb_mageTower.BackgroundImage = global::Towerdefense.Properties.Resources.mageTower;
            this.pb_mageTower.Location = new System.Drawing.Point(25, 553);
            this.pb_mageTower.Name = "pb_mageTower";
            this.pb_mageTower.Size = new System.Drawing.Size(56, 53);
            this.pb_mageTower.TabIndex = 84;
            this.pb_mageTower.TabStop = false;
            this.pb_mageTower.Tag = "mageTowerselecter";
            this.pb_mageTower.Click += new System.EventHandler(this.pb_mageTower_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 553);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1008, 78);
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // playtimer
            // 
            this.playtimer.Enabled = true;
            this.playtimer.Interval = 50;
            this.playtimer.Tick += new System.EventHandler(this.playtimer_Tick);
            // 
            // enemyspawning
            // 
            this.enemyspawning.Enabled = true;
            this.enemyspawning.Interval = 500;
            this.enemyspawning.Tick += new System.EventHandler(this.enemyspawning_Tick);
            // 
            // bullet_speed
            // 
            this.bullet_speed.Enabled = true;
            this.bullet_speed.Interval = 30;
            this.bullet_speed.Tick += new System.EventHandler(this.bullet_speed_Tick);
            // 
            // bullet_spawning
            // 
            this.bullet_spawning.Enabled = true;
            this.bullet_spawning.Interval = 1000;
            this.bullet_spawning.Tick += new System.EventHandler(this.bullet_spawning_Tick);
            // 
            // lbl_health
            // 
            this.lbl_health.AutoSize = true;
            this.lbl_health.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_health.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_health.Location = new System.Drawing.Point(-3, 10);
            this.lbl_health.Name = "lbl_health";
            this.lbl_health.Size = new System.Drawing.Size(116, 31);
            this.lbl_health.TabIndex = 101;
            this.lbl_health.Text = "Health: ";
            // 
            // lbl_coins
            // 
            this.lbl_coins.AutoSize = true;
            this.lbl_coins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_coins.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coins.ForeColor = System.Drawing.Color.Black;
            this.lbl_coins.Location = new System.Drawing.Point(801, 10);
            this.lbl_coins.Name = "lbl_coins";
            this.lbl_coins.Size = new System.Drawing.Size(106, 31);
            this.lbl_coins.TabIndex = 100;
            this.lbl_coins.Text = "Coins: ";
            // 
            // pb_backgroundCoins
            // 
            this.pb_backgroundCoins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pb_backgroundCoins.Location = new System.Drawing.Point(-6, -2);
            this.pb_backgroundCoins.Name = "pb_backgroundCoins";
            this.pb_backgroundCoins.Size = new System.Drawing.Size(1000, 51);
            this.pb_backgroundCoins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_backgroundCoins.TabIndex = 99;
            this.pb_backgroundCoins.TabStop = false;
            // 
            // lbl_wave
            // 
            this.lbl_wave.AutoSize = true;
            this.lbl_wave.BackColor = System.Drawing.Color.Transparent;
            this.lbl_wave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wave.Location = new System.Drawing.Point(818, 472);
            this.lbl_wave.Name = "lbl_wave";
            this.lbl_wave.Size = new System.Drawing.Size(74, 24);
            this.lbl_wave.TabIndex = 102;
            this.lbl_wave.Text = "Wave: ";
            // 
            // pb_corner1
            // 
            this.pb_corner1.BackColor = System.Drawing.Color.Transparent;
            this.pb_corner1.Location = new System.Drawing.Point(329, 363);
            this.pb_corner1.Name = "pb_corner1";
            this.pb_corner1.Size = new System.Drawing.Size(28, 5);
            this.pb_corner1.TabIndex = 103;
            this.pb_corner1.TabStop = false;
            this.pb_corner1.Tag = "right";
            // 
            // pb_corner2
            // 
            this.pb_corner2.BackColor = System.Drawing.Color.White;
            this.pb_corner2.Location = new System.Drawing.Point(356, 510);
            this.pb_corner2.Name = "pb_corner2";
            this.pb_corner2.Size = new System.Drawing.Size(5, 27);
            this.pb_corner2.TabIndex = 104;
            this.pb_corner2.TabStop = false;
            this.pb_corner2.Tag = "straight";
            this.pb_corner2.Click += new System.EventHandler(this.pb_corner2_Click);
            // 
            // pb_corner3
            // 
            this.pb_corner3.BackColor = System.Drawing.Color.White;
            this.pb_corner3.Location = new System.Drawing.Point(626, 363);
            this.pb_corner3.Name = "pb_corner3";
            this.pb_corner3.Size = new System.Drawing.Size(5, 27);
            this.pb_corner3.TabIndex = 105;
            this.pb_corner3.TabStop = false;
            this.pb_corner3.Tag = "straight";
            // 
            // pb_corner5
            // 
            this.pb_corner5.BackColor = System.Drawing.Color.White;
            this.pb_corner5.Location = new System.Drawing.Point(464, 93);
            this.pb_corner5.Name = "pb_corner5";
            this.pb_corner5.Size = new System.Drawing.Size(5, 27);
            this.pb_corner5.TabIndex = 106;
            this.pb_corner5.TabStop = false;
            this.pb_corner5.Tag = "straight";
            // 
            // pb_corner4
            // 
            this.pb_corner4.BackColor = System.Drawing.Color.Transparent;
            this.pb_corner4.Location = new System.Drawing.Point(603, 92);
            this.pb_corner4.Name = "pb_corner4";
            this.pb_corner4.Size = new System.Drawing.Size(28, 5);
            this.pb_corner4.TabIndex = 107;
            this.pb_corner4.TabStop = false;
            this.pb_corner4.Tag = "dirleft";
            this.pb_corner4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btn_PlaceTower1
            // 
            this.btn_PlaceTower1.BackColor = System.Drawing.Color.Transparent;
            this.btn_PlaceTower1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlaceTower1.Location = new System.Drawing.Point(565, 459);
            this.btn_PlaceTower1.Name = "btn_PlaceTower1";
            this.btn_PlaceTower1.Size = new System.Drawing.Size(79, 30);
            this.btn_PlaceTower1.TabIndex = 125;
            this.btn_PlaceTower1.Text = "Place Here";
            this.btn_PlaceTower1.UseVisualStyleBackColor = false;
            this.btn_PlaceTower1.Click += new System.EventHandler(this.btn_PlaceTower1_Click);
            // 
            // pb_tower1
            // 
            this.pb_tower1.BackColor = System.Drawing.Color.Transparent;
            this.pb_tower1.Location = new System.Drawing.Point(574, 407);
            this.pb_tower1.Name = "pb_tower1";
            this.pb_tower1.Size = new System.Drawing.Size(57, 53);
            this.pb_tower1.TabIndex = 124;
            this.pb_tower1.TabStop = false;
            this.pb_tower1.Tag = "tower1";
            // 
            // btn_PlaceTower5
            // 
            this.btn_PlaceTower5.BackColor = System.Drawing.Color.Transparent;
            this.btn_PlaceTower5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlaceTower5.Location = new System.Drawing.Point(379, 90);
            this.btn_PlaceTower5.Name = "btn_PlaceTower5";
            this.btn_PlaceTower5.Size = new System.Drawing.Size(79, 30);
            this.btn_PlaceTower5.TabIndex = 123;
            this.btn_PlaceTower5.Text = "Place Here";
            this.btn_PlaceTower5.UseVisualStyleBackColor = false;
            this.btn_PlaceTower5.Click += new System.EventHandler(this.btn_PlaceTower5_Click);
            // 
            // btn_PlaceTower10
            // 
            this.btn_PlaceTower10.BackColor = System.Drawing.Color.Transparent;
            this.btn_PlaceTower10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlaceTower10.Location = new System.Drawing.Point(630, 196);
            this.btn_PlaceTower10.Name = "btn_PlaceTower10";
            this.btn_PlaceTower10.Size = new System.Drawing.Size(79, 30);
            this.btn_PlaceTower10.TabIndex = 122;
            this.btn_PlaceTower10.Text = "Place Here";
            this.btn_PlaceTower10.UseVisualStyleBackColor = false;
            this.btn_PlaceTower10.Click += new System.EventHandler(this.btn_PlaceTower10_Click);
            // 
            // btn_PlaceTower8
            // 
            this.btn_PlaceTower8.BackColor = System.Drawing.Color.Transparent;
            this.btn_PlaceTower8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlaceTower8.Location = new System.Drawing.Point(513, 272);
            this.btn_PlaceTower8.Name = "btn_PlaceTower8";
            this.btn_PlaceTower8.Size = new System.Drawing.Size(79, 30);
            this.btn_PlaceTower8.TabIndex = 121;
            this.btn_PlaceTower8.Text = "Place Here";
            this.btn_PlaceTower8.UseVisualStyleBackColor = false;
            this.btn_PlaceTower8.Click += new System.EventHandler(this.btn_PlaceTower8_Click);
            // 
            // btn_PlaceTower7
            // 
            this.btn_PlaceTower7.BackColor = System.Drawing.Color.Transparent;
            this.btn_PlaceTower7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlaceTower7.Location = new System.Drawing.Point(588, 44);
            this.btn_PlaceTower7.Name = "btn_PlaceTower7";
            this.btn_PlaceTower7.Size = new System.Drawing.Size(79, 30);
            this.btn_PlaceTower7.TabIndex = 120;
            this.btn_PlaceTower7.Text = "Place Here";
            this.btn_PlaceTower7.UseVisualStyleBackColor = false;
            this.btn_PlaceTower7.Click += new System.EventHandler(this.btn_PlaceTower7_Click);
            // 
            // btn_PlaceTower6
            // 
            this.btn_PlaceTower6.BackColor = System.Drawing.Color.Transparent;
            this.btn_PlaceTower6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlaceTower6.Location = new System.Drawing.Point(503, 186);
            this.btn_PlaceTower6.Name = "btn_PlaceTower6";
            this.btn_PlaceTower6.Size = new System.Drawing.Size(79, 30);
            this.btn_PlaceTower6.TabIndex = 119;
            this.btn_PlaceTower6.Text = "Place Here";
            this.btn_PlaceTower6.UseVisualStyleBackColor = false;
            this.btn_PlaceTower6.Click += new System.EventHandler(this.btn_PlaceTower6_Click);
            // 
            // btn_PlaceTower4
            // 
            this.btn_PlaceTower4.BackColor = System.Drawing.Color.Transparent;
            this.btn_PlaceTower4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlaceTower4.Location = new System.Drawing.Point(330, 272);
            this.btn_PlaceTower4.Name = "btn_PlaceTower4";
            this.btn_PlaceTower4.Size = new System.Drawing.Size(79, 30);
            this.btn_PlaceTower4.TabIndex = 118;
            this.btn_PlaceTower4.Text = "Place Here";
            this.btn_PlaceTower4.UseVisualStyleBackColor = false;
            this.btn_PlaceTower4.Click += new System.EventHandler(this.btn_PlaceTower4_Click);
            // 
            // btn_PlaceTower3
            // 
            this.btn_PlaceTower3.BackColor = System.Drawing.Color.Transparent;
            this.btn_PlaceTower3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlaceTower3.Location = new System.Drawing.Point(369, 459);
            this.btn_PlaceTower3.Name = "btn_PlaceTower3";
            this.btn_PlaceTower3.Size = new System.Drawing.Size(79, 30);
            this.btn_PlaceTower3.TabIndex = 117;
            this.btn_PlaceTower3.Text = "Place Here";
            this.btn_PlaceTower3.UseVisualStyleBackColor = false;
            this.btn_PlaceTower3.Click += new System.EventHandler(this.btn_PlaceTower3_Click);
            // 
            // btn_PlaceTower2
            // 
            this.btn_PlaceTower2.BackColor = System.Drawing.Color.Transparent;
            this.btn_PlaceTower2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlaceTower2.Location = new System.Drawing.Point(231, 420);
            this.btn_PlaceTower2.Name = "btn_PlaceTower2";
            this.btn_PlaceTower2.Size = new System.Drawing.Size(79, 30);
            this.btn_PlaceTower2.TabIndex = 116;
            this.btn_PlaceTower2.Text = "Place Here";
            this.btn_PlaceTower2.UseVisualStyleBackColor = false;
            this.btn_PlaceTower2.Click += new System.EventHandler(this.btn_PlaceTower2_Click);
            // 
            // pb_tower10
            // 
            this.pb_tower10.BackColor = System.Drawing.Color.Transparent;
            this.pb_tower10.Location = new System.Drawing.Point(640, 221);
            this.pb_tower10.Name = "pb_tower10";
            this.pb_tower10.Size = new System.Drawing.Size(57, 53);
            this.pb_tower10.TabIndex = 115;
            this.pb_tower10.TabStop = false;
            this.pb_tower10.Tag = "tower10";
            // 
            // pb_tower8
            // 
            this.pb_tower8.BackColor = System.Drawing.Color.Transparent;
            this.pb_tower8.Location = new System.Drawing.Point(515, 302);
            this.pb_tower8.Name = "pb_tower8";
            this.pb_tower8.Size = new System.Drawing.Size(57, 53);
            this.pb_tower8.TabIndex = 114;
            this.pb_tower8.TabStop = false;
            this.pb_tower8.Tag = "tower8";
            // 
            // pb_tower7
            // 
            this.pb_tower7.BackColor = System.Drawing.Color.Transparent;
            this.pb_tower7.Location = new System.Drawing.Point(535, 34);
            this.pb_tower7.Name = "pb_tower7";
            this.pb_tower7.Size = new System.Drawing.Size(57, 53);
            this.pb_tower7.TabIndex = 113;
            this.pb_tower7.TabStop = false;
            this.pb_tower7.Tag = "tower7";
            // 
            // pb_tower2
            // 
            this.pb_tower2.BackColor = System.Drawing.Color.Transparent;
            this.pb_tower2.Location = new System.Drawing.Point(240, 436);
            this.pb_tower2.Name = "pb_tower2";
            this.pb_tower2.Size = new System.Drawing.Size(57, 53);
            this.pb_tower2.TabIndex = 112;
            this.pb_tower2.TabStop = false;
            this.pb_tower2.Tag = "tower2";
            // 
            // pb_tower3
            // 
            this.pb_tower3.BackColor = System.Drawing.Color.Transparent;
            this.pb_tower3.Location = new System.Drawing.Point(379, 407);
            this.pb_tower3.Name = "pb_tower3";
            this.pb_tower3.Size = new System.Drawing.Size(57, 53);
            this.pb_tower3.TabIndex = 111;
            this.pb_tower3.TabStop = false;
            this.pb_tower3.Tag = "tower3";
            // 
            // pb_tower6
            // 
            this.pb_tower6.BackColor = System.Drawing.Color.Transparent;
            this.pb_tower6.Location = new System.Drawing.Point(513, 137);
            this.pb_tower6.Name = "pb_tower6";
            this.pb_tower6.Size = new System.Drawing.Size(57, 53);
            this.pb_tower6.TabIndex = 110;
            this.pb_tower6.TabStop = false;
            this.pb_tower6.Tag = "tower6";
            // 
            // pb_tower5
            // 
            this.pb_tower5.BackColor = System.Drawing.Color.Transparent;
            this.pb_tower5.Location = new System.Drawing.Point(391, 44);
            this.pb_tower5.Name = "pb_tower5";
            this.pb_tower5.Size = new System.Drawing.Size(57, 53);
            this.pb_tower5.TabIndex = 109;
            this.pb_tower5.TabStop = false;
            this.pb_tower5.Tag = "tower5";
            // 
            // pb_tower4
            // 
            this.pb_tower4.BackColor = System.Drawing.Color.Transparent;
            this.pb_tower4.Location = new System.Drawing.Point(352, 291);
            this.pb_tower4.Name = "pb_tower4";
            this.pb_tower4.Size = new System.Drawing.Size(57, 53);
            this.pb_tower4.TabIndex = 108;
            this.pb_tower4.TabStop = false;
            this.pb_tower4.Tag = "tower4";
            // 
            // game2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Towerdefense.Properties.Resources.Map2;
            this.ClientSize = new System.Drawing.Size(984, 627);
            this.Controls.Add(this.btn_PlaceTower1);
            this.Controls.Add(this.pb_tower1);
            this.Controls.Add(this.btn_PlaceTower5);
            this.Controls.Add(this.btn_PlaceTower10);
            this.Controls.Add(this.btn_PlaceTower8);
            this.Controls.Add(this.btn_PlaceTower7);
            this.Controls.Add(this.btn_PlaceTower6);
            this.Controls.Add(this.btn_PlaceTower4);
            this.Controls.Add(this.btn_PlaceTower3);
            this.Controls.Add(this.btn_PlaceTower2);
            this.Controls.Add(this.pb_tower10);
            this.Controls.Add(this.pb_tower8);
            this.Controls.Add(this.pb_tower7);
            this.Controls.Add(this.pb_tower2);
            this.Controls.Add(this.pb_tower3);
            this.Controls.Add(this.pb_tower6);
            this.Controls.Add(this.pb_tower5);
            this.Controls.Add(this.pb_tower4);
            this.Controls.Add(this.pb_corner4);
            this.Controls.Add(this.pb_corner5);
            this.Controls.Add(this.pb_corner3);
            this.Controls.Add(this.pb_corner2);
            this.Controls.Add(this.pb_corner1);
            this.Controls.Add(this.lbl_wave);
            this.Controls.Add(this.lbl_health);
            this.Controls.Add(this.lbl_coins);
            this.Controls.Add(this.pb_backgroundCoins);
            this.Controls.Add(this.pb_gunNoCoins);
            this.Controls.Add(this.pb_ninjaNoCoins);
            this.Controls.Add(this.pb_bombNoCoins);
            this.Controls.Add(this.pb_archNoCoins);
            this.Controls.Add(this.pb_mageNoCoins);
            this.Controls.Add(this.lbl_maschineGunPrice);
            this.Controls.Add(this.lbl_ninjaTowerPrice);
            this.Controls.Add(this.lbl_bombTowerPrice);
            this.Controls.Add(this.lbl_archerTowerPrice);
            this.Controls.Add(this.lbl_mageTowerPrice);
            this.Controls.Add(this.pb_ninjaTower);
            this.Controls.Add(this.pb_maschingunTower);
            this.Controls.Add(this.pb_BombTower);
            this.Controls.Add(this.pb_archerTower);
            this.Controls.Add(this.pb_mageTower);
            this.Controls.Add(this.pictureBox1);
            this.Name = "game2";
            this.Text = "game2";
            this.Load += new System.EventHandler(this.game2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_gunNoCoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ninjaNoCoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bombNoCoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_archNoCoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mageNoCoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ninjaTower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_maschingunTower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BombTower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_archerTower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mageTower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_backgroundCoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_corner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_corner2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_corner3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_corner5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_corner4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tower1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tower10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tower8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tower7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tower2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tower3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tower6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tower5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tower4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_gunNoCoins;
        private System.Windows.Forms.PictureBox pb_ninjaNoCoins;
        private System.Windows.Forms.PictureBox pb_bombNoCoins;
        private System.Windows.Forms.PictureBox pb_archNoCoins;
        private System.Windows.Forms.PictureBox pb_mageNoCoins;
        private System.Windows.Forms.Label lbl_maschineGunPrice;
        private System.Windows.Forms.Label lbl_ninjaTowerPrice;
        private System.Windows.Forms.Label lbl_bombTowerPrice;
        private System.Windows.Forms.Label lbl_archerTowerPrice;
        private System.Windows.Forms.Label lbl_mageTowerPrice;
        private System.Windows.Forms.PictureBox pb_ninjaTower;
        private System.Windows.Forms.PictureBox pb_maschingunTower;
        private System.Windows.Forms.PictureBox pb_BombTower;
        private System.Windows.Forms.PictureBox pb_archerTower;
        private System.Windows.Forms.PictureBox pb_mageTower;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer playtimer;
        private System.Windows.Forms.Timer enemyspawning;
        private System.Windows.Forms.Timer bullet_speed;
        private System.Windows.Forms.Timer bullet_spawning;
        private System.Windows.Forms.Label lbl_health;
        private System.Windows.Forms.Label lbl_coins;
        private System.Windows.Forms.PictureBox pb_backgroundCoins;
        private System.Windows.Forms.Label lbl_wave;
        private System.Windows.Forms.PictureBox pb_corner1;
        private System.Windows.Forms.PictureBox pb_corner2;
        private System.Windows.Forms.PictureBox pb_corner3;
        private System.Windows.Forms.PictureBox pb_corner5;
        private System.Windows.Forms.PictureBox pb_corner4;
        private System.Windows.Forms.Button btn_PlaceTower1;
        private System.Windows.Forms.PictureBox pb_tower1;
        private System.Windows.Forms.Button btn_PlaceTower5;
        private System.Windows.Forms.Button btn_PlaceTower10;
        private System.Windows.Forms.Button btn_PlaceTower8;
        private System.Windows.Forms.Button btn_PlaceTower7;
        private System.Windows.Forms.Button btn_PlaceTower6;
        private System.Windows.Forms.Button btn_PlaceTower4;
        private System.Windows.Forms.Button btn_PlaceTower3;
        private System.Windows.Forms.Button btn_PlaceTower2;
        private System.Windows.Forms.PictureBox pb_tower10;
        private System.Windows.Forms.PictureBox pb_tower8;
        private System.Windows.Forms.PictureBox pb_tower7;
        private System.Windows.Forms.PictureBox pb_tower2;
        private System.Windows.Forms.PictureBox pb_tower3;
        private System.Windows.Forms.PictureBox pb_tower6;
        private System.Windows.Forms.PictureBox pb_tower5;
        private System.Windows.Forms.PictureBox pb_tower4;
    }
}