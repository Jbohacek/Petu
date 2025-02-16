using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Petu
{
    public class Pet
    {
        /*
        0	AK	Aktualně používaný	bool
        1	BA	Background	        int
        2	ČA	Čas vytvoření	    date
        3	DE	Delka života	    int
        4	EN	Enabled	            bool
        5	ID	ID	                guid
        6	IN	Index	            int
        7	JI	Jidlo	            double
        8	JM	Jméno	            string
        9	MO	Money	            double
        14	OT	Otevření Poslední	date
        10	OW	Owner	            String
        11	PF	PFilePath	        String
        12	PN	PNG	                image
        13	PO	Počet Smrtí	        int
        15	PŘ	Přejedenost	        int
        16	PT	Ptransparency	    bool
        17	PW	Pwidth x Height	    int[2]
        18	SM	Smrt poslední	    date
        19	VO	Voda	            double
        */
        public bool AktualnePouzivany;
        public int Background;
        public DateTime CasVytvoreni;
        public int DelkaZivotaVeVterinach;
        public bool enabled;
        public string ID;
        public int Index;
        public double Jidlo;
        public string Jmeno;
        public double Money;
        public DateTime PosledniOtevreni;
        public string Owner;
        public string PFilePath = "None";
        public int PNG = -1;
        public int PocetSmrti;
        public int Prejedenost;
        public bool PTransparency;
        public int[] PWidthxHeight = new int[2];
        public DateTime SmrtPosleni;
        public double Voda;
        public string Inventory; // OB
        public bool Hardcore; // HR
        public int Life = 10; // LI




    }
}
