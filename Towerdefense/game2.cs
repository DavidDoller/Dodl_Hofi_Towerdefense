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
            DoubleBuffered = true;

            pb_mageNoCoins.Visible = false;
            pb_archNoCoins.Visible = false;
            pb_bombNoCoins.Visible = false;
            pb_ninjaNoCoins.Visible = false;
            pb_gunNoCoins.Visible = false;
        }

    }
}
