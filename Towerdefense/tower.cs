using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Towerdefense
{
    class tower
    {
        public static Panel temp;
        public static List<Panel> panellist = new List<Panel>();


        public static void drawshooting() 
        {
            

            if (!panellist.Contains(temp)) 
            {
                temp = new Panel();
                temp.Location = new Point(90, 325);
                temp.BackColor = Color.Red;
                temp.Height = 20;
                temp.Width = 30;
                panellist.Add(temp);
                game1.ActiveForm.Controls.Add(temp);
            }         
            temp.Tag = "bullet";
            

            temp.Left -= 1;
        }



    }

}
