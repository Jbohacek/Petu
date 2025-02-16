using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Petu
{
    public partial class AdminForm : Form
    {
        List<TextBox> listA = new List<TextBox>();
        public AdminForm()
        {
            InitializeComponent();
            foreach (object a in this.Controls)
            {
                if (a.GetType() == typeof(TextBox))
                {   
                    listA.Add((TextBox)a);
                }
            }
            
            listA.Reverse();
            Output.Text = Saves.Default.Pozice;
            //listA.ForEach(a => Debug.WriteLine(a.Name.ToString()));
        }

        

        private void CloseAll(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Add(object sender, EventArgs e)
        {
            string Final = "";
            for (int i = 0; i < listA.Count; i++)
            {
                string oznaceni;
                switch (i)
                {
                    case 0: oznaceni = "AK"; break;
                    case 1: oznaceni = "BA"; break;
                    case 2: oznaceni = "CA"; break;
                    case 3: oznaceni = "DE"; break;
                    case 4: oznaceni = "EN"; break;
                    case 5: oznaceni = "ID"; break;
                    case 6: oznaceni = "IN"; break;
                    case 7: oznaceni = "JI"; break;
                    case 8: oznaceni = "JM"; break;
                    case 9: oznaceni = "MO"; break;
                    case 10: oznaceni = "OT"; break;
                    case 11: oznaceni = "OW"; break;
                    case 12: oznaceni = "PF"; break;
                    case 13: oznaceni = "PN"; break;
                    case 14: oznaceni = "PO"; break;
                    case 15: oznaceni = "PR"; break;
                    case 16: oznaceni = "PT"; break;
                    case 17: oznaceni = "PW"; break;
                    case 18: oznaceni = "SM"; break;
                    case 19: oznaceni = "VO"; break;
                    default: oznaceni = null; break;
                }
                Final += "£" + oznaceni + listA[i].Text.Length + "#" + listA[i].Text;

            }
            Final += "&";
            Output.Text += Final;

        }

        private void ClearFinal(object sender, EventArgs e)
        {
            Output.Text = "";
        }

        private void SaveIT(object sender, EventArgs e)
        {
            Saves.Default.Pozice = Output.Text;
            Saves.Default.Save();
        }

        private void ResetSave(object sender, EventArgs e)
        {
            Saves.Default.Reset();
            Debug.WriteLine("Vynulovano");
        }

        private void Test(object sender, EventArgs e)
        {
            foreach (var x in LoadForm.instance.Zvirata)
            {
                Debug.WriteLine("Vidim:" + x.Jmeno.ToString());
            }
        }

        private void ResetTextBox(object sender, EventArgs e)
        {
            Output.Text = Saves.Default.Pozice;
        }

        private void ResetIndex(object sender, EventArgs e)
        {
            Petu.Properties.Settings.Default.IndexOfPet = 0;
            Petu.Properties.Settings.Default.Save();
        }
    }
}
