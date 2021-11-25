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
    public partial class towerselect : Form 
    {
        public static int temp;
        public static int currentnumber = temp;
        public static int changeTowerNumber;
        public towerselect()
        {
            InitializeComponent();
        }

        private void towerselect_Load(object sender, EventArgs e)
        {
            lbl_test.Text = Convert.ToString(temp);
        }

        private void lbl_test_Click(object sender, EventArgs e)
        {
            
        }

        private void towerselect_Click(object sender, EventArgs e)
        {

        }

        private void pbtower_1_Click(object sender, EventArgs e)
        {
            changeTowerNumber = 1;
            this.Hide();

        }

        private void pbtower2_Click(object sender, EventArgs e)
        {
            changeTowerNumber = 2;
            this.Hide();
        }

        private void pbtower_3_Click(object sender, EventArgs e)
        {
            changeTowerNumber = 3;
            this.Hide();
        }

        private void pbtower4_Click(object sender, EventArgs e)
        {
            changeTowerNumber = 4;
            this.Hide();
        }

        private void pbtower_5_Click(object sender, EventArgs e)
        {
            changeTowerNumber = 5;
            this.Hide();
        }

        private void pbtower_6_Click(object sender, EventArgs e)
        {
            changeTowerNumber = 6;

            this.Hide();
        }

        private void pbtower_7_Click(object sender, EventArgs e)
        {
            changeTowerNumber = 7; 
            this.Hide();
        }

        private void pbtower_8_Click(object sender, EventArgs e)
        {
            changeTowerNumber = 8; 
            this.Hide();
        }

        private void pbtower_9_Click(object sender, EventArgs e)
        {
            changeTowerNumber = 9;
            this.Hide();
        }

        private void pbtower_10_Click(object sender, EventArgs e)
        {
            changeTowerNumber = 10;
            this.Hide();
        }
    }
}
