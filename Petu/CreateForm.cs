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
using System.Resources;
using System.Globalization;

namespace Petu
{
    public partial class CreateForm : Form
    {
        
        Pet Novy = new Pet();
        bool VybranyObrazek = false;

        public CreateForm()
        {
            InitializeComponent();
            

        }

        private void Create(object sender, EventArgs e)
        {
            if (VybranyObrazek == false || TNazev.Text == "")
            {
                if (Novy.PNG == -1 && Novy.PFilePath.ToLower() == "none")
                {
                    MessageBox.Show("Zvolte Obrazek");
                }
                if (TNazev.Text == "")
                {
                    MessageBox.Show("Zvolte Nazev");
                }
            }
            else
            {
                if (TNazev.Text.Contains('&') || TNazev.Text.Contains('#') || TNazev.Text.Contains('£') || TNazev.Text.Contains('$') || TNazev.Text.Contains('§'))
                {
                    MessageBox.Show("Name includes charakters that are banned, please remove them\nBanned charakters: '&'#'£'$'§'");

                }
                else
                {
                    Random rnd = new Random();
                    Novy.AktualnePouzivany = false;
                    Novy.Background = 0;
                    Novy.CasVytvoreni = DateTime.Now;
                    Novy.DelkaZivotaVeVterinach = 0;
                    Novy.enabled = true;
                    Novy.ID = rnd.Next().ToString();
                    Novy.Index = Petu.Properties.Settings.Default.IndexOfPet;
                    Petu.Properties.Settings.Default.IndexOfPet = Petu.Properties.Settings.Default.IndexOfPet + 1;
                    Petu.Properties.Settings.Default.Save();
                    Novy.Jidlo = 10000;
                    Novy.Jmeno = TNazev.Text;
                    Novy.Money = 50;
                    Novy.PosledniOtevreni = DateTime.Now;
                    Novy.Owner = Environment.UserName.ToString();



                    Novy.PocetSmrti = 0;
                    Novy.Prejedenost = 0;
                    Novy.PTransparency = true;
                    Novy.PWidthxHeight[0] = 32;
                    Novy.PWidthxHeight[1] = 0;
                    Novy.SmrtPosleni = DateTime.Now;
                    Novy.Voda = 10000;
                    Novy.Inventory = "Muffin§H250§L0§7§E$";
                    Novy.Hardcore = CAbilityToDie.Checked;
                    LoadForm.instance.Zvirata.Add(Novy);
                    LoadForm.instance.Ulozit();
                    LoadForm.instance.Nacist();
                    LoadForm.instance.Show();
                    this.Close();
                }
            }
            
        }
        private void Vybrani(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            Novy.PNG = Convert.ToInt32(pictureBox.Name.Substring(1));
            OrignalPanel.Visible = false;
            ShowPicture.Image = (Image)AnimalsIcon.ResourceManager.GetObject(Help.NameOfAnimals[Novy.PNG]);
            OrignalPanel.Controls.Clear();
            Novy.PFilePath = "None";
            VybranyObrazek = true;
        }
        private void VyberObrazku(object sender, EventArgs e)
        {
            if (OrignalPanel.Visible == false)
            {
                OrignalPanel.Visible = true;

                //ShowPicture.Image = (Image)BasicImages.ResourceManager.GetObject("Skull");
                for (int i = 0; i < Help.NameOfAnimals.Count; i++)
                {
                    PictureBox pic = new PictureBox()
                    {
                        Name = "P" + i,
                        Image = (Image)AnimalsIcon.ResourceManager.GetObject(Help.NameOfAnimals[i]),
                        Size = new Size(64, 64),
                        SizeMode = PictureBoxSizeMode.Zoom
                    };
                    pic.Click += Vybrani;
                    OrignalPanel.Controls.Add(pic);
                }
            }
        }

        private void Upload(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Image files|*.jpg;*.gif;*.png;";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                Novy.PNG = -1;
                Novy.PFilePath = choofdlog.FileName;
                ShowPicture.Image = Image.FromFile(choofdlog.FileName);
                VybranyObrazek = true;
            }
            
        }

        private void Zavíraní(object sender, FormClosingEventArgs e)
        {
            LoadForm.instance.Show();
        }
    }
}
