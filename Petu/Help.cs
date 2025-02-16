using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petu
{
    static class Help
    {
        public static string SekundyNacas(int sekundy)
        {
            int hodiny = 0;
            int minuty = 0;
            int vteriny = 0;

            while (sekundy != 0)
            {
                if (sekundy >= 3600)
                {
                    hodiny++;
                    sekundy -= 3600;
                }
                else if (sekundy >= 60)
                {
                    minuty++;
                    sekundy -= 60;
                }
                else
                {
                    vteriny = sekundy;
                    break;
                }
            }
            string fin;
            if (vteriny.ToString().Length == 1)
            {
                fin = hodiny + " : " + minuty + " : 0" + vteriny;
            }
            else
            {
                fin = hodiny + " : " + minuty + " : " + vteriny;
            }
            
            return fin;
        }

        // Pets Images

        public static List<string> NameOfAnimals = new List<string>();
        public static List<string> NameOfItems = new List<string>();
        static Help()
        {
            string[] NameItems =
            {
                "WaterBottle","WaterBottle","WaterBottle","WaterBottle","HearthBottle", // 0 - 4
                "Steak",    //5
                "Honey",    //6
                "Muffin",    //7
                "Apple",    //8
            };
            NameOfItems = NameItems.ToList();
            string[] NameZvirata = {
                "cat",
                "Red_panda",
                "squrtle",
                "Cutecat"
            };

            NameOfAnimals = NameZvirata.ToList();


        }
        public static string GenerateName(int len)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;


        }
    }
}
