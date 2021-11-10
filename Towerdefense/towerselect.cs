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
    }
}
