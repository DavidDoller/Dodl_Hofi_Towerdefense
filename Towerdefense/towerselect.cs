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
        public static int changetowernumber;
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
            changetowernumber = 1;

            game form = new game();
            form.Show();
            this.Hide();

        }

        private void pbtower2_Click(object sender, EventArgs e)
        {
            changetowernumber = 2;

            game form = new game();
            form.Show();
            this.Hide();
        }

        private void pbtower_3_Click(object sender, EventArgs e)
        {
            changetowernumber = 3;

            game form = new game();
            form.Show();
            this.Hide();
        }

        private void pbtower4_Click(object sender, EventArgs e)
        {
            changetowernumber = 4;

            game form = new game();
            form.Show();
            this.Hide();
        }

        private void pbtower_5_Click(object sender, EventArgs e)
        {
            changetowernumber = 5;

            game form = new game();
            form.Show();
            this.Hide();
        }

        private void pbtower_6_Click(object sender, EventArgs e)
        {
            changetowernumber = 6;

            game form = new game();
            form.Show();
            this.Hide();
        }

        private void pbtower_7_Click(object sender, EventArgs e)
        {
            changetowernumber = 7;

            game form = new game();
            form.Show();
            this.Hide();
        }

        private void pbtower_8_Click(object sender, EventArgs e)
        {
            changetowernumber = 8;

            game form = new game();
            form.Show();
            this.Hide();
        }

        private void pbtower_9_Click(object sender, EventArgs e)
        {
            changetowernumber = 9;

            game form = new game();
            form.Show();
            this.Hide();
        }

        private void pbtower_10_Click(object sender, EventArgs e)
        {
            changetowernumber = 10;

            game form = new game();
            form.Show();
            this.Hide();
        }
    }
}
