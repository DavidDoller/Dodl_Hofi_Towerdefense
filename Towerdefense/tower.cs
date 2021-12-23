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
        public static Panel tempmage = new Panel();
        public static Panel temparcher = new Panel();

        public static void magetower(int locationX,int locationY, int bulletspeed) 
        {
            

            if (!panelmagetowershot.Contains(tempmage)) 
            {
                tempmage.Location = new Point(locationX, locationY);
                tempmage.BackColor = Color.Red;
                tempmage.Height = 3;
                tempmage.Width = 30;
                tempmage.Tag = "bulletmage";
                panelmagetowershot.Add(tempmage);
                game1.ActiveForm.Controls.Add(tempmage);
            }
            if (tempmage.Left < 0) 
            {
                panelmagetowershot.Remove(tempmage);
                tempmage.Location = new Point(locationX, locationY);

            }
            tempmage.Left -= bulletspeed;
        }

        public static void archertower(int locationX, int locationY,int bulletspeed) 
        {

            if (!panelarchertowershot.Contains(temparcher))
            {
                temparcher.Location = new Point(locationX, locationY);
                temparcher.BackColor = Color.Blue;
                temparcher.Height = 3;
                temparcher.Width = 30;
                temparcher.Tag = "bulletarcher";
                panelarchertowershot.Add(temparcher);
                game1.ActiveForm.Controls.Add(temparcher);
            }
            if (temparcher.Left < 0)
            {
                panelarchertowershot.Remove(temparcher);
                temparcher.Location = new Point(locationX, locationY);

            }
            temparcher.Left -= bulletspeed;

        }



    }

}
