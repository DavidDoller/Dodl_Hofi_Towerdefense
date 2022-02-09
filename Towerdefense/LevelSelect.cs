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
    public partial class LevelSelect : Form
    {
        public LevelSelect()
        {
            InitializeComponent();
        }

        private void LevelSelect_Load(object sender, EventArgs e)
        {
            pb_levelselect.BackgroundImage = Properties.Resources.lvl1Map;
            pb_levelselect.Tag = "lvl1";
            pb_levelselect.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeLevel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(pb_levelselect.Tag == "lvl1")
            {
                game1 game = new game1();
                game.Show();
                this.Hide();
            }
            if(pb_levelselect.Tag == "lvl2")
            {
                game2 game = new game2();
                game.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            changeLevel();
        }

        public void changeLevel()
        {
            if (pb_levelselect.Tag == "lvl1")
            {
                pb_levelselect.BackgroundImage = Properties.Resources.StoneMap;
                pb_levelselect.BackgroundImageLayout = ImageLayout.Stretch;
                pb_levelselect.Tag = "lvl2";
            }
            else if (pb_levelselect.Tag == "lvl2")
            {
                pb_levelselect.BackgroundImage = Properties.Resources.lvl1Map;
                pb_levelselect.BackgroundImageLayout = ImageLayout.Stretch;
                pb_levelselect.Tag = "lvl1";
            }
        }
    }
}
