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
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void game_Load(object sender, EventArgs e)
        {
        }

        private void pb_tower1_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(1);

        }

        private void pb_tower2_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(2);
        }

        private void pb_tower3_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(3);
        }

        private void pb_tower4_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(4);

            towerselect form = new towerselect();
            form.Show();
            this.Hide();
        }

        private void pb_tower5_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(5);
        }

        private void pb_tower6_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(6);
        }

        private void pb_tower7_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(7);
        }

        private void pb_tower8_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(8);
        }

        private void pb_tower9_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(9);
        }

        private void pb_tower10_Click(object sender, EventArgs e)
        {
            sqlcon.selecttowerplace(10);
        }
    }
}
