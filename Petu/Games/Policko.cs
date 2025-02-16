using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petu.Games
{


    public class Policko
    {
        public PictureBox Grafika = new PictureBox();
        public int souradniceX { private set; get; }
        public int souradniceY { private set; get; }
        public Policko(int souradX, int souradY)
        {
            souradniceX = souradX;
            souradniceY = souradY;
            Grafika.Location = new Point(souradniceX, souradniceY);
            Grafika.BackgroundImage = GoldQuestResources.dark;
            Grafika.Tag = "Dark";
            Grafika.Size = new Size(50, 50);
            Grafika.SizeMode = PictureBoxSizeMode.Zoom;
            Grafika.BackgroundImageLayout = ImageLayout.Zoom;
            
            
        }
        

    }
}
