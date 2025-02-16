using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Petu
{
    public class Item
    {
        public string Name;
        public char typ;
        public double HungerUp = 0;
        public double WaterUp = 0;
        public double LifeUp = 0;
        public double LifeDown = 0;
        public double WaterDown = 0;
        public double HungerDown = 0;
        public Image IkonaPredmetu { get; private set; }
        public int Ikona;

        public Item(string name, char Rarita, string CoZvednout_HWL, string CoSnizit_HWL, int ikona)
        {
            Name = name;
            typ = Rarita;
            switch (CoZvednout_HWL.Substring(0, 1))
            {
                case "H":
                    HungerUp = Convert.ToDouble(CoZvednout_HWL.Substring(1));
                    break;
                case "W":
                    WaterUp = Convert.ToDouble(CoZvednout_HWL.Substring(1));
                    break;
                case "L":
                    LifeUp = Convert.ToDouble(CoZvednout_HWL.Substring(1));
                    break;
            }
            switch (CoSnizit_HWL.Substring(0, 1))
            {
                case "H":
                    HungerDown = Convert.ToDouble(CoSnizit_HWL.Substring(1));
                    break;
                case "W":
                    WaterDown = Convert.ToDouble(CoSnizit_HWL.Substring(1));
                    break;
                case "L":
                    LifeDown = Convert.ToDouble(CoSnizit_HWL.Substring(1));
                    break;
            }

            Ikona = ikona;
            IkonaPredmetu = (Image)Petu.ItemsIcon.ResourceManager.GetObject(Help.NameOfItems[ikona]);
        }

    }
}
