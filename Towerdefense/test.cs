using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Towerdefense
{
    public partial class test : Form
    {
        public PictureBox temp;

        public test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temp = enemy.CreateLoon(Balloontypes.bloonRed,this);
            this.Controls.Add(temp);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            movement.movmentstraight(temp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temp = enemy.CreateLoon(Balloontypes.bloonBlue, this);
            this.Controls.Add(temp);
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temp = enemy.CreateLoon(Balloontypes.bloonGreen, this);
            this.Controls.Add(temp);
            timer1.Start();
        }
    }
}
