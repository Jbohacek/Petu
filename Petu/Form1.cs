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
    public partial class Form1 : Form
    {
        static List<Pet> Zvirata = new List<Pet>();
        private List<PictureBox> Hunger = new List<PictureBox>();
        private List<PictureBox> Water = new List<PictureBox>();
        public Form1()
        {
            
            InitializeComponent();

            foreach (object x in this.Controls)
            {
                if (x.GetType().Name == "PictureBox")
                {
                    PictureBox t = (PictureBox)x;
                    //Debug.WriteLine(t.Name.ToLower().Contains("water"));
                    if (t.Name.ToString().ToLower().Contains("water"))
                    { Water.Add(t); Debug.WriteLine(t.Name); }
                    if (t.Name.ToString().ToLower().Contains("food"))
                    { Hunger.Add(t); Debug.WriteLine(t.Name); }

                }
            } // Hunger/Water picrubox
            if (Petu.Properties.Settings.Default.StartAsAdmin == true) { AdminForm aaa = new AdminForm();aaa.Show();LWater.Visible = true; LFood.Visible = true; } // admin privilages
            Water.Reverse(); Hunger.Reverse();

            Hunger.ForEach(c => Debug.WriteLine(c.Name));
        }
        void Nacist()
        {
            Zvirata.Clear();
            
            if (Saves.Default.Pozice.Length != 0)
            {
                LMoney.Visible = true; LNazev.Visible = true;
                Saves.Default.Pozice = "&" + Saves.Default.Pozice;
                string[] Celky = Saves.Default.Pozice.Trim('&').Split('&');
                for (int i = 0; i < Celky.Length; i++)
                {
                    Debug.WriteLine("Celek " + i  + ")\t"+ Celky[i]);
                } // vypis
                Debug.WriteLine("Načítání...");
                for (int i = 0; i < Celky.Length; i++)
                {
                    Pet pet = new Pet();
                    Debug.WriteLine(i + ") " + Celky[i]);
                    string[] PodCelky = Celky[i].Trim('£').Split('£');
                    for (int j = 0; j < PodCelky.Length; j++)
                    {
                        Debug.WriteLine(j + ")");
                        Debug.WriteLine(PodCelky[j]);

                        string[] ZahlaviApaticka = PodCelky[j].Split('#');
                        string Oznaceni = ZahlaviApaticka[0].Substring(0, 2);
                        Debug.WriteLine("Oznaceni:\t" + Oznaceni);

                        int Delkatextu = Convert.ToInt32(ZahlaviApaticka[0].Substring(2));
                        Debug.WriteLine("Delka Obsahu:\t" +Delkatextu);

                        string Obsah = ZahlaviApaticka[1];
                        Debug.WriteLine("Obsah:\t" + Obsah);

                        

                        switch (Oznaceni)
                        {
                            case "AK": pet.AktualnePouzivany = Convert.ToBoolean(Obsah); break;
                            case "BA": pet.Background = Convert.ToInt32(Obsah); break;
                            case "CA": pet.CasVytvoreni = Convert.ToDateTime(Obsah); break;
                            case "DE": pet.DelkaZivotaVeVterinach = Convert.ToInt32(Obsah); break;
                            case "EN": pet.enabled = Convert.ToBoolean(Obsah); break;
                            case "ID": pet.ID = Obsah; break;
                            case "IN": pet.Index = Convert.ToInt32(Obsah); break;
                            case "JI": pet.Jidlo = Convert.ToDouble(Obsah);break;
                            case "JM": pet.Jmeno = Obsah; break;
                            case "MO": pet.Money = Convert.ToDouble(Obsah); break;
                            case "OT": pet.PosledniOtevreni = Convert.ToDateTime(Obsah);break;
                            case "OW": pet.Owner = Obsah.ToString(); break;
                            case "PF": pet.PFilePath = Convert.ToString(Obsah); break;
                            case "PN": pet.PNG = Convert.ToInt32(Obsah.ToString()); break;
                            case "PO": pet.PocetSmrti = Convert.ToInt32(Obsah.ToString());break;
                            case "PR": pet.Prejedenost = Convert.ToInt32(Obsah.ToString());break;
                            case "PT": pet.PTransparency = Convert.ToBoolean(Obsah.ToString());break;
                            case "PW": pet.PWidthxHeight = Array.ConvertAll(Obsah.Split('x'), x => Convert.ToInt32(x));break;
                            case "SM": pet.SmrtPosleni = Convert.ToDateTime(Obsah);break;
                            case "VO": pet.Voda = Convert.ToDouble(Obsah);break;
                        }

                        Debug.WriteLine("---------------------------------------");


                    }
                    Zvirata.Add(pet);
                }
                List<int> o = new List<int>();
                foreach (var pet in Zvirata)
                {
                    Debug.WriteLine(pet.Jmeno + " Bylo nactono");
                    
                }
                for (int i = 0; i < Zvirata.Count;i++)
                {
                    Debug.WriteLine(Zvirata[i].Jmeno);
                    if (Zvirata[i].enabled == false)
                    {
                        o.Add(i);
                    }
                }
                foreach (int d in o)
                {
                    Zvirata.RemoveAt(d);
                }
                
                trackBar1.Enabled = true;
                trackBar1.Maximum = Zvirata.Count - 1;
                LNazev.Text = Zvirata[0].Jmeno;
                LMoney.Text = Zvirata[0].Money.ToString();
                LWater.Text = Zvirata[0].Voda.ToString();
                LFood.Text = Zvirata[0].Jidlo.ToString();
                for (int i = 0; i < 9; i++)
                {
                    if (i * 100 < Zvirata[0].Jidlo)
                    {
                        Hunger[i].Visible = true;
                    }
                }
                for (int i = 0; i < 9; i++)
                {
                    if (i * 100 < Zvirata[0].Voda)
                    {
                        Water[i].Visible = true;
                    }
                }
            }
        }

        private void LoadButton(object sender, EventArgs e)
        {
            button1.Text = "Znova Načíst";
            Nacist();
        }

        private void ChangeProfile(object sender, EventArgs e)
        {
            Hunger.ForEach(c => c.Visible = false);
            Water.ForEach(c => c.Visible = false);
            LNazev.Text = Zvirata[trackBar1.Value].Jmeno;
            LMoney.Text = Zvirata[trackBar1.Value].Money.ToString();
            LWater.Text = Zvirata[trackBar1.Value].Voda.ToString();
            LFood.Text = Zvirata[trackBar1.Value].Jidlo.ToString();
            for (int i = 0; i < 9; i++)
            {
                if (i * 100 < Zvirata[trackBar1.Value].Jidlo)
                {
                    Hunger[i].Visible = true;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (i * 100 < Zvirata[trackBar1.Value].Voda)
                {
                    Water[i].Visible = true;
                }
            }
        }

        private void DeletePet(object sender, EventArgs e)
        {
            Zvirata[trackBar1.Value].enabled = false;
        }
    }
}
