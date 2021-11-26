using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Towerdefense
{
    class movement
    {
        public static bool boolmovementright = false;
        public static bool boolmovmentstraight = false;
        public static bool boolmovementdown = false;

        public static void movmentright(PictureBox temp)
        {
            temp.Left += 5;
        }
        public static void movmentstraight(PictureBox temp)
        {
            temp.Top += -5;
        }

        public static void movementdown(PictureBox temp)
        {
            temp.Top += 5;
        }

        public static void checkdirection() 
        {
        }

    }
}
