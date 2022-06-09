using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Towerdefense
{
    class enemy
    {
        public static int looncounter = 0;

        public static PictureBox CreateLoon(Balloon ballon, Form form)
        {
            //Create Basic Balloon
            PictureBox pbenemy = new PictureBox();

            pbenemy.Size = ballon.size;
            pbenemy.Location = ballon.point;
            pbenemy.BackgroundImage = ballon.image;
            pbenemy.BackColor = ballon.color;
            pbenemy.BackgroundImageLayout = ImageLayout.Stretch;
            pbenemy.Tag = "enemy" + looncounter.ToString();
            pbenemy.Name = ballon.name;
            pbenemy.BringToFront();
            form.Controls.Add(pbenemy);
            looncounter++;
            return pbenemy;
        }    
    }
}


public class Balloon
{
    //Basic Properties of any balloon
    public Size size;
    public Point point;
    public Bitmap image;
    public Color color;
    public string tag;
    public string name;
    public int looncounter;

    public Balloon()
    {
        size = new Size(32, 32);
        point = new Point(91, 553);
        color = Color.Transparent;
    }
}

public static class Balloontypes
{
    //Create every Balloon Type
    private static Balloon temp = new Balloon();
    public static Balloon bloonRed
    {
        get
        {
            string resourceName = "bloonRed";
            Bitmap bmp = (Bitmap)Towerdefense.Properties.Resources.ResourceManager.GetObject(resourceName);
            temp.image = bmp;
            temp.name = "Redloon";
            return temp;
        }
    }
    public static Balloon bloonBlue
    {
        get
        {
            string resourceName = "bloonBlue";
            Bitmap bmp = (Bitmap)Towerdefense.Properties.Resources.ResourceManager.GetObject(resourceName);
            temp.image = bmp;
            temp.name = "Blueloon";
            return temp;
        }
    }
    public static Balloon bloonGreen
    {
        get
        {
            string resourceName = "bloonGreen";
            Bitmap bmp = (Bitmap)Towerdefense.Properties.Resources.ResourceManager.GetObject(resourceName);
            temp.image = bmp;
            temp.name = "Greenloon";
            return temp;
        }      
    }

    public static Balloon bloonYellow
    {
        get
        {
            string resourceName = "bloonYellow";
            Bitmap bmp = (Bitmap)Towerdefense.Properties.Resources.ResourceManager.GetObject(resourceName);
            temp.image = bmp;
            temp.name = "Yellowloon";
            return temp;
        }
    }

    public static Balloon bloonPink
    {
        get
        {
            string resourceName = "bloonPink";
            Bitmap bmp = (Bitmap)Towerdefense.Properties.Resources.ResourceManager.GetObject(resourceName);
            temp.image = bmp;
            temp.name = "Pinkloon";
            return temp;
        }
    }

    public static Balloon bloonBlack
    {
        get
        {
            string resourceName = "bloonBlack";
            Bitmap bmp = (Bitmap)Towerdefense.Properties.Resources.ResourceManager.GetObject(resourceName);
            temp.image = bmp;
            temp.name = "Blackloon";
            return temp;
        }
    }

    public static Balloon bloonLightBlue
    {
        get
        {
            string resourceName = "bloonLightBlue";
            Bitmap bmp = (Bitmap)Towerdefense.Properties.Resources.ResourceManager.GetObject(resourceName);
            temp.image = bmp;
            temp.name = "LightBlue";
            return temp;
        }
    }
}


