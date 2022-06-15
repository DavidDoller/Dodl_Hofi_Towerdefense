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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            //change form to game1
            LevelSelect form = new LevelSelect();
            form.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //button click closes the application
            Application.Exit();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
