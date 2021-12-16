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
        public static List<Panel> panelmagetowershot = new List<Panel>();
        public static List<Panel> panelarchertowershot = new List<Panel>();

        public static void magetower(int locationX,int locationY) 
        {
            Panel temp = new Panel();

            if (!panelmagetowershot.Contains(temp)) 
            {
                
                temp.Location = new Point(locationX, locationY);
                temp.BackColor = Color.Red;
                temp.Height = 3;
                temp.Width = 30;
                temp.Tag = "bulletmage";
                panelmagetowershot.Add(temp);
                game1.ActiveForm.Controls.Add(temp);
               
            }
            if (temp.Left < 0) 
            {
                panelmagetowershot.Remove(temp);
                temp.Dispose();

            }
            temp.Left -= 75;
        }

        public static void archertower(int locationX, int locationY) 
        {
            Panel temp = new Panel();

            if (!panelarchertowershot.Contains(temp))
            {
                temp.Location = new Point(locationX, locationY);
                temp.BackColor = Color.Blue;
                temp.Height = 3;
                temp.Width = 30;
                temp.Tag = "bulletarcher";
                panelarchertowershot.Add(temp);
                game1.ActiveForm.Controls.Add(temp);
            }
            if (temp.Left < 0)
            {
                panelarchertowershot.Remove(temp);
                temp.Dispose();

            }
            temp.Left -= 1;

        }



    }

}
