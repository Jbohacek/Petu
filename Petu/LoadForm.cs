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
    public partial class LoadForm : Form
    {
        
        public List<Pet> Zvirata = new List<Pet>();
        private List<PictureBox> Hunger = new List<PictureBox>();
        private List<PictureBox> Water = new List<PictureBox>();
        private List<PictureBox> Live = new List<PictureBox>();
        public int SelectedPet;
        public static LoadForm instance;
        public LoadForm()
        {
            
            InitializeComponent();
            instance = this;
            GameVersionLabel.Text = Properties.Settings.Default.VerzeHry;
            foreach (object x in this.Controls)
            {
                if (x.GetType().Name == "PictureBox")
                {
                    PictureBox t = (PictureBox)x;
                    //Debug.WriteLine(t.Name.ToLower().Contains("water"));
                    if (t.Name.ToString().ToLower().Contains("water"))
                    { Water.Add(t);  }
                    if (t.Name.ToString().ToLower().Contains("food"))
                    { Hunger.Add(t);  }
                    if (t.Name.ToString().ToLower().Contains("live"))
                    { Live.Add(t); }

                }
            } // Hunger/Water picrubox
            if (Petu.Properties.Settings.Default.StartAsAdmin == true) { AdminForm aaa = new AdminForm();aaa.Show();LWater.Visible = true; LFood.Visible = true; Lindex.Visible = true;lADminpower.Visible = true;button1.Enabled = true; button1.Visible = true; } // admin privilages
            Water.Reverse(); Hunger.Reverse(); Live.Reverse();
            Nacist();

            //Kontrola Fontu
            const string fontname = "Windows Command Prompt";
            using (Font fonttester = new Font(fontname, 12f, FontStyle.Regular, GraphicsUnit.Pixel))
            {
                if (fonttester.Name == fontname)
                {
                    Debug.WriteLine("Nainstalovano");
                }
                else
                {
                    
                    FontPopUp fontPopUp = new FontPopUp();
                    fontPopUp.Show();
                    fontPopUp.TopMost = true;
                    this.Size = new System.Drawing.Size(0, 0);
                    this.Opacity = 0;
                    
                }
            }

            
        }
        public void Nacist()
        {
            trackBar1.Value = 0;
            Zvirata.Clear();
            CreateButton.Enabled = true;

            if (Saves.Default.Pozice.Length != 0)
            {
                
                button1.Text = "Load Again";
                Imoney.Visible = true;
                Live.ForEach(item => item.Visible = true);
                Hunger.ForEach(item => item.Visible = true);
                Water.ForEach(item => item.Visible = true);
                LPosledniUprava.Visible = true;
                Lvytvořen.Visible = true;
                LdobaZivota.Visible = true;
                CountOF.Visible = true;
                DeleteButton.Enabled = true;
                SelectButton.Enabled = true;
                DeleteButton.FlatStyle = FlatStyle.Flat;
                SelectButton.FlatStyle = FlatStyle.Flat;
                LMoney.Visible = true; LNazev.Visible = true; trackBar1.Value = 0;

                Saves.Default.Pozice = "&" + Saves.Default.Pozice;
                string[] Celky = Saves.Default.Pozice.Trim('&').Split('&');
                for (int i = 0; i < Celky.Length; i++)
                {
                    Debug.WriteLine("Celek " + i + ")\t" + Celky[i]);
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
                        Debug.WriteLine("Delka Obsahu:\t" + Delkatextu);

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
                            case "JI": pet.Jidlo = Convert.ToDouble(Obsah); break;
                            case "JM": pet.Jmeno = Obsah; break;
                            case "MO": pet.Money = Convert.ToDouble(Obsah); break;
                            case "OT": pet.PosledniOtevreni = Convert.ToDateTime(Obsah); break;
                            case "OW": pet.Owner = Obsah.ToString(); break;
                            case "PF": pet.PFilePath = Convert.ToString(Obsah); break;
                            case "PN": pet.PNG = Convert.ToInt32(Obsah.ToString()); break;
                            case "PO": pet.PocetSmrti = Convert.ToInt32(Obsah.ToString()); break;
                            case "PR": pet.Prejedenost = Convert.ToInt32(Obsah.ToString()); break;
                            case "PT": pet.PTransparency = Convert.ToBoolean(Obsah.ToString()); break;
                            case "PW": pet.PWidthxHeight = Array.ConvertAll(Obsah.Split('x'), x => Convert.ToInt32(x)); break;
                            case "SM": pet.SmrtPosleni = Convert.ToDateTime(Obsah); break;
                            case "VO": pet.Voda = Convert.ToDouble(Obsah); break;
                            case "OB": pet.Inventory = Convert.ToString(Obsah);break;
                            case "HR": pet.Hardcore = Convert.ToBoolean(Obsah);break;
                            case "LI": pet.Life = Convert.ToInt32(Obsah); break;
                        }

                        Debug.WriteLine("---------------------------------------");


                    }
                    if (pet.enabled == true)
                    {
                        Zvirata.Add(pet);
                    }

                }



                foreach (var pet in Zvirata)
                {
                    if (pet.enabled == false)
                    {
                        Debug.WriteLine("Zvire " + pet.Jmeno + " je neplatne");
                    }
                    else
                    {
                        Debug.WriteLine("Zvire " + pet.Jmeno + " je platne");
                    }
                }





                trackBar1.Enabled = true;
                trackBar1.Maximum = Zvirata.Count - 1;
                CountOF.Text = (trackBar1.Value + 1) + " / " + (trackBar1.Maximum + 1);
                if (Zvirata[0].Hardcore == true) { IhardcoreMode.Visible = true; }
                LNazev.Text = Zvirata[0].Jmeno;
                LMoney.Text = Zvirata[0].Money.ToString();
                LWater.Text = Zvirata[0].Voda.ToString();
                LFood.Text = Zvirata[0].Jidlo.ToString();
                Lindex.Text = Zvirata[0].Index.ToString();
                Lvytvořen.Text =  Zvirata[0].CasVytvoreni.ToString();
                LPosledniUprava.Text = Zvirata[0].PosledniOtevreni.ToString();
                LdobaZivota.Text =  Help.SekundyNacas(Zvirata[0].DelkaZivotaVeVterinach);

                if (Zvirata[0].PNG != -1)
                {
                    MainPicture.Image = (Image)AnimalsIcon.ResourceManager.GetObject(Help.NameOfAnimals[Zvirata[0].PNG]);
                }
                else
                {
                    try
                    {
                        MainPicture.Image = Image.FromFile(Zvirata[0].PFilePath);
                    }
                    catch
                    {
                        MainPicture.Image = BasicImages.Missing;
                        Debug.WriteLine("Chybí obrazek");
                        DialogResult dialogResult = MessageBox.Show("Picture of " + Zvirata[0].Jmeno + " was not been found\nWould you like to change image position of it?", "Missing", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            OpenFileDialog choofdlog = new OpenFileDialog();
                            choofdlog.Filter = "Image files|*.jpg;*.gif;*.png;";
                            choofdlog.FilterIndex = 1;
                            choofdlog.Multiselect = false;

                            if (choofdlog.ShowDialog() == DialogResult.OK)
                            {

                                Zvirata[0].PFilePath = choofdlog.FileName;
                                MainPicture.Image = Image.FromFile(Zvirata[0].PFilePath);
                                Ulozit();

                            }
                            
                        }
                    }

                }

                for (int i = 0; i <= 9; i++)
                {
                    if (i * 1000 <= Zvirata[0].Jidlo)
                    {
                        Hunger[i].Image = Petu.BasicImages.Food_Icon;
                    }
                }
                for (int i = 0; i <= 9; i++)
                {
                    if (i * 1000 < Zvirata[0].Voda)
                    {
                        Water[i].Image = Petu.BasicImages.Water_Icon;
                    }
                }
                for (int i = 0; i <= 9; i++)
                {
                    if (i < Zvirata[0].Life)
                    {
                        Live[i].Image = Petu.BasicImages.Hearth_icon; ;
                    }
                }

            }
            else
            {
                CountOF.Visible = false;
                DeleteButton.Enabled = false;
                SelectButton.Enabled = false;
                DeleteButton.FlatStyle = FlatStyle.Popup;
                SelectButton.FlatStyle = FlatStyle.Popup;
                LMoney.Visible = false; LNazev.Visible = false; trackBar1.Value = 0;
                trackBar1.Enabled = false;
                Hunger.ForEach(item => item.Image = BasicImages.Food_Icon_Empty);
                Water.ForEach(item => item.Image = BasicImages.Water_Icon_Empty);
                Live.ForEach(item => item.Image = Petu.BasicImages.Hearth_icon_Empty);
                Live.ForEach(item => item.Visible = false);
                Hunger.ForEach(item => item.Visible = false);
                Water.ForEach(item => item.Visible = false);
                Imoney.Visible = false;
                Lvytvořen.Visible = false;
                LdobaZivota.Visible = false;
                LPosledniUprava.Visible = false;
                IhardcoreMode.Visible = false;
                MainPicture.Image = null;
            }
        }

        private void LoadButton(object sender, EventArgs e)
        {
            
           
            
            Nacist();
        }

        private void ChangeProfile(object sender, EventArgs e)
        {
            CountOF.Text = (trackBar1.Value + 1) + " / " + (trackBar1.Maximum + 1); 
            Hunger.ForEach(c => c.Image = BasicImages.Food_Icon_Empty);
            Water.ForEach(c => c.Image = BasicImages.Water_Icon_Empty);
            Live.ForEach(item => item.Image = Petu.BasicImages.Hearth_icon_Empty);
            LNazev.Text = Zvirata[trackBar1.Value].Jmeno;
            LMoney.Text = Zvirata[trackBar1.Value].Money.ToString();
            LWater.Text = Zvirata[trackBar1.Value].Voda.ToString();
            LFood.Text = Zvirata[trackBar1.Value].Jidlo.ToString();
            Lindex.Text = Zvirata[trackBar1.Value].Index.ToString();
            Lvytvořen.Text =  Zvirata[trackBar1.Value].CasVytvoreni.ToString();
            LdobaZivota.Text =  Help.SekundyNacas(Zvirata[trackBar1.Value].DelkaZivotaVeVterinach);
            LPosledniUprava.Text =  Zvirata[trackBar1.Value].PosledniOtevreni.ToString();

            if (Zvirata[trackBar1.Value].PNG != -1)
            {
                MainPicture.Image = (Image)AnimalsIcon.ResourceManager.GetObject(Help.NameOfAnimals[Zvirata[trackBar1.Value].PNG]);
            }
            else
            {
                try
                {
                    MainPicture.Image = Image.FromFile(Zvirata[trackBar1.Value].PFilePath);
                }
                catch 
                {
                    MainPicture.Image = BasicImages.Missing;
                    Debug.WriteLine("Chybí obrazek");
                    DialogResult dialogResult = MessageBox.Show("Picture of " + Zvirata[trackBar1.Value].Jmeno + " was not been found\nWould you like to change image position of it?", "Missing", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        OpenFileDialog choofdlog = new OpenFileDialog();
                        choofdlog.Filter = "Image files|*.jpg;*.gif;*.png;";
                        choofdlog.FilterIndex = 1;
                        choofdlog.Multiselect = false;

                        if (choofdlog.ShowDialog() == DialogResult.OK)
                        {
                            
                            Zvirata[trackBar1.Value].PFilePath = choofdlog.FileName;
                            MainPicture.Image = Image.FromFile(Zvirata[trackBar1.Value].PFilePath);
                            Ulozit();
                            
                        }
                    }
                }
                
            }
            

            if (Zvirata[trackBar1.Value].Hardcore == true) { IhardcoreMode.Visible = true; } else { IhardcoreMode.Visible = false; }

            for (int i = 0; i <= 9; i++)
            {
                if (i * 1000 < Zvirata[trackBar1.Value].Jidlo)
                {
                    Hunger[i].Image = BasicImages.Food_Icon;
                }
            }
            for (int i = 0; i <= 9; i++)
            {
                if (i * 1000 < Zvirata[trackBar1.Value].Voda)
                {
                    Water[i].Image = Petu.BasicImages.Water_Icon;
                }
            }
            for (int i = 0; i <= 9; i++)
            {
                if (i < Zvirata[trackBar1.Value].Life)
                {
                    Live[i].Image = Petu.BasicImages.Hearth_icon;
                }
            }
        }

        private void DeletePet(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Chcete opravu smazat " + Zvirata[trackBar1.Value].Jmeno + "?", "Smazaní", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                Zvirata[trackBar1.Value].enabled = false;
                trackBar1.Value = 0;
                Ulozit();
                Zvirata.Clear();
                Nacist();
            }
            
        }
        public void Ulozit()
        {
            Debug.WriteLine("Ukladani");
            trackBar1.Value = 0;
            Saves.Default.Pozice = "";
            string Final = "";
            foreach (Pet x in Zvirata)
            {
                if (x.enabled == true)
                {
                    Final += "£" + "AK" + x.AktualnePouzivany.ToString().Length + "#" + x.AktualnePouzivany.ToString();
                    Final += "£" + "BA" + x.Background.ToString().Length + "#" + x.Background.ToString();
                    Final += "£" + "CA" + x.CasVytvoreni.ToString().Length + "#" + x.CasVytvoreni.ToString();
                    Final += "£" + "DE" + x.DelkaZivotaVeVterinach.ToString().Length + "#" + x.DelkaZivotaVeVterinach.ToString();
                    Final += "£" + "EN" + x.enabled.ToString().Length + "#" + x.enabled.ToString();
                    Final += "£" + "ID" + x.ID.ToString().Length + "#" + x.ID.ToString();
                    Final += "£" + "IN" + x.Index.ToString().Length + "#" + x.Index.ToString();
                    Final += "£" + "JI" + x.Jidlo.ToString().Length + "#" + x.Jidlo.ToString();
                    Final += "£" + "JM" + x.Jmeno.ToString().Length + "#" + x.Jmeno.ToString();
                    Final += "£" + "MO" + x.Money.ToString().Length + "#" + x.Money.ToString();
                    Final += "£" + "OT" + x.PosledniOtevreni.ToString().Length + "#" + x.PosledniOtevreni.ToString();
                    Final += "£" + "OW" + x.Owner.ToString().Length + "#" + x.Owner.ToString();
                    Final += "£" + "PF" + x.PFilePath.ToString().Length + "#" + x.PFilePath.ToString();
                    Final += "£" + "PN" + x.PNG.ToString().Length + "#" + x.PNG.ToString();
                    Final += "£" + "PO" + x.PocetSmrti.ToString().Length + "#" + x.PocetSmrti.ToString();
                    Final += "£" + "PR" + x.Prejedenost.ToString().Length + "#" + x.Prejedenost.ToString();
                    Final += "£" + "PT" + x.PTransparency.ToString().Length + "#" + x.PTransparency.ToString();
                    Final += "£" + "PW" + x.PWidthxHeight.ToString().Length + "#" + x.PWidthxHeight[0].ToString() + "x" + x.PWidthxHeight[1].ToString();
                    Final += "£" + "SM" + x.SmrtPosleni.ToString().Length + "#" + x.SmrtPosleni.ToString();
                    Final += "£" + "VO" + x.Voda.ToString().Length + "#" + x.Voda.ToString();
                    Final += "£" + "OB" + x.Inventory.ToString().Length + "#" + x.Inventory.ToString();
                    Final += "£" + "HR" + x.Hardcore.ToString().Length + "#" + x.Hardcore.ToString();
                    Final += "£" + "LI" + x.Life.ToString().Length + "#" + x.Life.ToString();
                    Final += "&";
                }
            }
            Saves.Default.Pozice += Final;
            Saves.Default.Save();

        }

        private void CreateNewPet(object sender, EventArgs e)
        {
            this.Hide();
            CreateForm lol = new CreateForm();
            lol.Show();
        }

        private void ToEnableAdmin(object sender, EventArgs e)
        {
            AdminPowerOnOf adminPowerOnOf = new AdminPowerOnOf();
            adminPowerOnOf.Show();
            this.Hide();
        }

        private void Vybrat(object sender, EventArgs e)
        {
            SelectedPet = trackBar1.Value;
            Zvirata[SelectedPet].PosledniOtevreni = DateTime.Now;
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
            
        }

        private void ShowChangeLogClick(object sender, EventArgs e)
        {
            ChangeLog.ChangeLogShow lol = new ChangeLog.ChangeLogShow();
            lol.Show();
        }

        
    }
}
