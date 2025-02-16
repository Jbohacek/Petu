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

namespace Petu.BackGround
{
    public partial class BackgroundChoser : Form
    {
        public static BackgroundChoser Instance;
        private int IndexObrazku = 0;
        
        private int IndexVybranehoPozadí = 0;
        string[] pozadi = {
        "Basic 7"
        
        
        };
        public BackgroundChoser()
        {
            InitializeComponent();
            GetIndexSelected();
            Instance = this;
        }
        public void GetIndexSelected()
        {
            IndexObrazku = 0;
            IndexVybranehoPozadí = LoadForm.instance.Zvirata[LoadForm.instance.SelectedPet].Background;
        }
        public void Reload()
        {
            PanelChoserBig.Controls.Clear();
            PictureBox pictureBox2 = new PictureBox() {Name = "Basic", BackColor = Color.Transparent, Size = new Size(256, 256),Image = BackGround.BackgroundImages.BasicPrewiev,SizeMode = PictureBoxSizeMode.Zoom, Cursor = Cursors.Hand };
            pictureBox2.Click += Chose;
            PanelChoserBig.Controls.Add(pictureBox2);
            
            foreach (Item x in MainForm.instance.BackgroundItems)
            {
                PictureBox pictureBox = new PictureBox() { Name = x.Name, BackColor = Color.Red, Size = new Size(256, 256), SizeMode = PictureBoxSizeMode.Zoom };
                pictureBox.Click += Chose;
                pictureBox.Cursor = Cursors.Hand;
                switch (x.Name)
                {
                    case "background1":
                        pictureBox.BackColor = Color.Gold;
                        break;
                    case "background2":
                        pictureBox.BackColor = Color.Black;
                        break;
                }
                
                PanelChoserBig.Controls.Add(pictureBox);

            }
        }
        public void NextImage()
        {
            IndexObrazku++;
            string[] x = pozadi[IndexVybranehoPozadí].Split(' ');
            if (IndexObrazku > Convert.ToInt32(pozadi[IndexVybranehoPozadí].Substring(pozadi[IndexVybranehoPozadí].Length - x[1].Length)))
            {
                IndexObrazku = 1;
                string nazev = x[0] + IndexObrazku;
                MainForm.instance.BackgroundImage = (Image)BackGround.BackgroundImages.ResourceManager.GetObject(nazev);
                //Debug.WriteLine(IndexObrazku);
            }
            else
            {
                //Debug.WriteLine(IndexObrazku);
                string nazev = x[0] + IndexObrazku;
                MainForm.instance.BackgroundImage = (Image)BackGround.BackgroundImages.ResourceManager.GetObject(nazev);
            }
            

        }

        private void Chose(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            for (int i = 0; i != pozadi.Length; i++)
            {
                if (pozadi[i].Contains(pic.Name))
                {
                    Debug.WriteLine("Pozadí nastavena na " + i);
                    LoadForm.instance.Zvirata[LoadForm.instance.SelectedPet].Background = i;
                    break;
                }
            }
            GetIndexSelected();
            this.Hide();
            MainForm.instance.Show();
        }


        private void BackEnter(object sender, EventArgs e)
        {
            BackButton.Image = BasicImages.BackArrow_Activated;
        }

        private void BackLeave(object sender, EventArgs e)
        {
            BackButton.Image = BasicImages.BackArrow;
        }

        private void End(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MainForm.instance.Show();
            e.Cancel = true;
        }

        private void Goback(object sender, EventArgs e)
        {
            GetIndexSelected();
            this.Hide();
            MainForm.instance.Show();
            
        }
    }
}
