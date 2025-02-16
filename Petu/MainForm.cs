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
    public partial class MainForm : Form
    {
        List<PictureBox> Water = new List<PictureBox>();
        List<PictureBox> Hunger = new List<PictureBox>();
        List<PictureBox> Live = new List<PictureBox>();
        public List<Item> Items = new List<Item>();
        public List<Item> BackgroundItems = new List<Item>();
        int index = LoadForm.instance.SelectedPet;
        private int MaxLevel = 374;
        private bool InventarOtevreny = false;
        double vodaDolu;
        double JidloDolu;
        double VodaMultiplayer;
        double JidloMultiplayer;
        bool VodaDole = false;
        bool JidloDole = false;
        bool LifeTimerBezi = false;
        public static MainForm instance;
        private int shopResetTimer = 140;
        public int ShopReset;
        ShopForm shopForm = new ShopForm();
        Games.GameSelect Play = new Games.GameSelect();
        BackGround.BackgroundChoser BackPlayChoser = new BackGround.BackgroundChoser();
        public Image mazel;

        public bool[] NotifyVoda = {false,false};
        public bool[] NotifyJidlo = {false,false};
        public MainForm()
        {
            InitializeComponent();
            //Text
            ShopReset = shopResetTimer;

            Debug.WriteLine("\n\n\n\nNačítání " + LoadForm.instance.Zvirata[index].Jmeno);
            Debug.WriteLine("ID: " + LoadForm.instance.Zvirata[index].ID);
            Debug.WriteLine("Jidlo: " + LoadForm.instance.Zvirata[index].Jidlo);
            Debug.WriteLine("Voda: " + LoadForm.instance.Zvirata[index].Voda);
            Debug.WriteLine("Životy: " + LoadForm.instance.Zvirata[index].Life);
            Debug.WriteLine("");

            //Hunger Water Life Load
            Debug.Write("Načítání Vody,Jidla,Hp....");
            foreach (object x in HungerAndFood.Controls)
            {
                if (x.GetType().Name == "PictureBox")
                {
                    PictureBox t = (PictureBox)x;
                    if (t.Name.ToString().ToLower().Contains("water"))
                    { Water.Add(t); }
                    if (t.Name.ToString().ToLower().Contains("food"))
                    { Hunger.Add(t); }
                }
            }
            foreach (object x in LifeAndLevel.Controls)
            {
                if (x.GetType().Name == "PictureBox")
                {
                    PictureBox t = (PictureBox)x;
                    if (t.Name.ToString().ToLower().Contains("live"))
                    { Live.Add(t); }
                }
            }
            Live.Reverse(); Hunger.Reverse(); Water.Reverse();
            for (int i = 0; i <= 9; i++)
            {
                if (i * 1000 <= LoadForm.instance.Zvirata[index].Jidlo)
                {
                    Hunger[i].Image = Petu.BasicImages.Food_Icon;
                }
            }
            for (int i = 0; i <= 9; i++)
            {
                if (i * 1000 < LoadForm.instance.Zvirata[index].Voda)
                {
                    Water[i].Image = Petu.BasicImages.Water_Icon;
                }
            }
            for (int i = 0; i <= 9; i++)
            {
                if (i < LoadForm.instance.Zvirata[index].Life)
                {
                    Live[i].Image = Petu.BasicImages.Hearth_icon;
                }
            }
            Debug.WriteLine("Uspěch");

            //Name
            Debug.Write("Načítání Jmena....");
            LName.Text = LoadForm.instance.Zvirata[index].Jmeno;
            Debug.WriteLine("Uspěch");


            // ImageLoad
            Debug.Write("Načítání Obrazku....");
            if (LoadForm.instance.Zvirata[index].PNG == -1)
            {
                MainPicture.Image = Image.FromFile(LoadForm.instance.Zvirata[index].PFilePath);
            }
            else
            {
                MainPicture.Image = (Image)AnimalsIcon.ResourceManager.GetObject(Help.NameOfAnimals[LoadForm.instance.Zvirata[index].PNG]);
            }
            Debug.WriteLine("Uspěch");


            //Levels
            Debug.WriteLine("Načítání levelu/Velikosti....");
            switch (LoadForm.instance.Zvirata[index].PWidthxHeight[0])
            {
                case 32:
                    Debug.WriteLine("Velikost: 32");
                    break;
                case 64:
                    Debug.WriteLine("Velikost: 64");
                    MainPicture.Size = new Size(64, 64);
                    MainPicture.Location = new Point(MainPicture.Location.X - 24, MainPicture.Location.Y - 32);
                    break;
                case 128:
                    Debug.WriteLine("Velikost: 128");
                    MainPicture.Size = new Size(128, 128);
                    MainPicture.Location = new Point(MainPicture.Location.X - 48, MainPicture.Location.Y - 96);
                    break;
                case 256:
                    Debug.WriteLine("Velikost: 256");
                    MainPicture.Size = new Size(256, 256);
                    MainPicture.Location = new Point(MainPicture.Location.X - 96, MainPicture.Location.Y - 224);
                    break;
            }
            Debug.WriteLine("Uspěch");

            //Inventař
            Debug.WriteLine("Načítání Inventaře....\n");
            if (LoadForm.instance.Zvirata[index].Inventory != "")
            {
                int a = -1;
                string[] Celky = LoadForm.instance.Zvirata[index].Inventory.Split('$');
                foreach (string item in Celky)
                {
                    a++;
                    if (item != "")
                    {
                        string[] Podcelky = item.Split('§');
                        Item p = new Item(Podcelky[0], Convert.ToChar(Podcelky[4]), Podcelky[1], Podcelky[2], Convert.ToInt32(Podcelky[3]));

                        //Text
                        Debug.WriteLine("Item: " + Podcelky[0]);
                        Debug.WriteLine("Rarita: " + Podcelky[4]);
                        Debug.WriteLine("Zvyšuje: " + Podcelky[1]);
                        Debug.WriteLine("Snižuje: " + Podcelky[2]);
                        Debug.WriteLine("Ikona: " + Help.NameOfItems[Convert.ToInt32(Podcelky[3])]);
                        //Text

                        if (p.Name.ToLower().Contains("background"))
                        { BackgroundItems.Add(p);Debug.WriteLine("Background: true"); Items.Add(p); }
                        else {Items.Add(p); }
                        Debug.WriteLine("\n-----------------");

                    }
                }
                Debug.WriteLine("Uspěch, celkem: " + a);
            }
            else { Debug.WriteLine("Inventař prazdny"); }
            //Money
            LMoney.Text = LoadForm.instance.Zvirata[index].Money.ToString();

            //add-ons
            
            Updater.Start();

            vodaDolu = 5;
            JidloDolu = 2.5;
            VodaMultiplayer = 20;
            JidloMultiplayer = 20;
            
            ShopForm.instance.ResetItems(); // Resetovani predmetu
            mazel = MainPicture.Image;
            this.Text = LoadForm.instance.Zvirata[index].Jmeno;

            //Admin
            if (Petu.Properties.Settings.Default.StartAsAdmin == true)
            {
                Lwater.Visible = true;
                LHunger.Visible = true;
            }
            instance = this;
            Lwater.Visible = true;
            LHunger.Visible = true;

            //Icons
            ShopOpenImage.MouseEnter += ShopChangeEnter;
            ShopOpenImage.MouseLeave += ShopChangeLeave;

            OpenBackPackImage.MouseEnter += BackpackChangeEnter;
            OpenBackPackImage.MouseLeave += BackpackChangeLeave;

            
        }

        // Icons
        private void ShopChangeEnter(object sender, EventArgs e)
        {
            ShopOpenImage.Image = BasicImages.Shopicon_Selected;
        }
        private void ShopChangeLeave(object sender, EventArgs e)
        {
            ShopOpenImage.Image = BasicImages.Shopicon;
        }
        private void BackpackChangeEnter(object sender, EventArgs e)
        {
            OpenBackPackImage.Image = BasicImages.Backpack_Active;
        }
        private void BackpackChangeLeave(object sender, EventArgs e)
        {
            if (InventarOtevreny == false)
            {
                OpenBackPackImage.Image = BasicImages.Backpack;
            } 
        }
        private void PlayEnter(object sender, EventArgs e)
        {
            PlayButton.Image = BasicImages.PlayButton_Active;
        }
        private void PlayLeave(object sender, EventArgs e)
        {
            PlayButton.Image = BasicImages.PlayButton;
        }

        private void SaveEnter(object sender, EventArgs e)
        {
            SaveButton.Image = BasicImages.SaveIcon_active;
        }

        private void SaveLeave(object sender, EventArgs e)
        {
            SaveButton.Image = BasicImages.SaveIcon;
        }
        // Icons
        public void UložitItemy()
        {
            // Ukladaní
            Debug.WriteLine("Ukladaní itemu \nLokalně vytvořene: ");
            string fin = "";
            for (int i = 0; i < Items.Count; i++)
            {
                fin += Items[i].Name + "§";

                if (Items[i].LifeUp != 0)
                {
                    fin += "L" + Items[i].LifeUp;
                }
                else if (Items[i].WaterUp != 0)
                {
                    fin += "W" + Items[i].WaterUp;
                }
                else if (Items[i].HungerUp != 0)
                {
                    fin += "H" + Items[i].HungerUp;
                }
                else { fin += "L" + Items[i].LifeUp; }

                fin += "§";
                if (Items[i].LifeDown != 0)
                {
                    fin += "L" + Items[i].LifeDown;
                }
                else if (Items[i].WaterDown != 0)
                {
                    fin += "W" + Items[i].WaterDown;
                }
                else if (Items[i].HungerDown != 0)
                {
                    fin += "H" + Items[i].HungerDown;
                }
                else { fin += "L" + Items[i].LifeDown; }

                fin += "§" + Items[i].Ikona + "§" + Items[i].typ + "$";
                Debug.WriteLine(fin);
            }
            LoadForm.instance.Zvirata[index].Inventory = fin;
            Debug.WriteLine("Lokalně uloženo");
            LoadForm.instance.Ulozit();
            Debug.WriteLine("Uloženo");
        }

        private void End(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Do you want to exit the game?\nYour progress will be saved even if you press no", "Exiting Petu", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                UložitItemy();
                
                Environment.Exit(0);
            }
            else if (dialogResult == DialogResult.No)
            {
                UložitItemy();
            }
        }

        private void CreateItem(object sender, EventArgs e)
        {
            //smazat
            Random random = new Random();
            
            Item a = new Item(Help.GenerateName(6), 'B', "W" + random.Next(0, 100), "L0", random.Next(0, 2));
            Debug.WriteLine("Item: " + a.Name);
            Debug.WriteLine("Rarita: " + a.typ);
            Debug.WriteLine("Zvyšuje: " + a.WaterUp);
            Debug.WriteLine("Snižuje: " + a.LifeDown);
            Debug.WriteLine("Ikona: " + Help.NameOfItems[Convert.ToInt32(a.Ikona)] + "\n-----------------");
            Items.Add(a);


        }

        private void OpenInventory(object sender, EventArgs e)
        {
            if (InventarOtevreny == false)
            {
                LoadingBox.Visible = true;
                CloseButton.Visible = true;
                InventarOtevreny = true;
                InventoryShow.Visible = true;
                for (int i = 0; i < Items.Count; i++)
                {
                    if (!Items[i].Name.ToLower().Contains("background"))
                    {
                        Panel p = new Panel() { Size = PanelItem.Size, BorderStyle = BorderStyle.None, Visible = false,BackgroundImage = PanelItem.BackgroundImage,BackgroundImageLayout = PanelItem.BackgroundImageLayout };
                        PictureBox pic1 = new PictureBox()
                        {
                            Image = Items[i].IkonaPredmetu,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Location = PanelItem.Controls[2].Location,
                            Size = PanelItem.Controls[2].Size,
                            Cursor = Cursors.Hand,
                            Name = Items[i].Name,
                            BackColor = Color.Transparent,
                        };
                        pic1.Click += ClickOnItem;
                        pic1.MouseEnter += NajetiZmenseni;
                        pic1.MouseLeave += NajetiZvetseni;
                        PictureBox pic2 = new PictureBox()
                        {
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Location = PanelItem.Controls[0].Location,
                            Size = PanelItem.Controls[0].Size,
                            BackColor = Color.Transparent,

                        };
                        PictureBox pic3 = new PictureBox()
                        {
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Location = PanelItem.Controls[1].Location,
                            Size = PanelItem.Controls[1].Size,
                            BackColor = Color.Transparent,

                        };

                        Label labNeg = new Label()
                        {
                            AutoSize = false,
                            Size = PanelItem.Controls[3].Size,
                            Location = PanelItem.Controls[3].Location,
                            Font = PanelItem.Controls[3].Font,
                            ForeColor = PanelItem.Controls[3].ForeColor,
                            TextAlign = ContentAlignment.MiddleCenter,
                            BackColor = Color.Transparent,

                        };
                        Label labPos = new Label()
                        {
                            AutoSize = false,
                            Size = PanelItem.Controls[4].Size,
                            Location = PanelItem.Controls[4].Location,
                            Font = PanelItem.Controls[4].Font,
                            ForeColor = PanelItem.Controls[4].ForeColor,
                            TextAlign = ContentAlignment.MiddleCenter,
                            BackColor = Color.Transparent,

                        };
                        if (Items[i].LifeUp != 0)
                        {
                            pic3.Image = BasicImages.Hearth_icon;
                            labPos.Text = "+" + Items[i].LifeUp;
                        }
                        else if (Items[i].WaterUp != 0)
                        {
                            pic3.Image = BasicImages.Water_Icon;
                            labPos.Text = "+" + (Items[i].WaterUp * 2);
                        }
                        else if (Items[i].HungerUp != 0)
                        {
                            pic3.Image = BasicImages.Food_Icon;
                            labPos.Text = "+" + (Items[i].HungerUp * 2);
                        }

                        if (Items[i].LifeDown != 0)
                        {
                            pic2.Image = BasicImages.Hearth_icon_Empty;
                            labNeg.Text = "-" + Items[i].LifeDown;
                        }
                        else if (Items[i].WaterDown != 0)
                        {
                            pic2.Image = BasicImages.Water_Icon_Empty;
                            labNeg.Text = "-" + Items[i].WaterDown * 2;
                        }
                        else if (Items[i].HungerDown != 0)
                        {
                            pic2.Image = BasicImages.Food_Icon_Empty;
                            labNeg.Text = "-" + Items[i].HungerDown * 2;
                        }


                        p.Controls.Add(pic1);
                        p.Controls.Add(pic2);
                        p.Controls.Add(pic3);
                        p.Controls.Add(labPos);
                        p.Controls.Add(labNeg);
                        InventoryShow.Controls.Add(p);
                    }
                }
                foreach (Panel x in InventoryShow.Controls)
                {
                    x.Visible = true;
                }
                LoadingBox.Visible = false;

            }
            else
            {
                InventoryShow.Controls.Clear();
                CloseButton.Visible = false;
                InventarOtevreny = false;
                OpenBackPackImage.Image = BasicImages.Backpack;
                InventoryShow.Visible = false;
            }
        }

        private void NajetiZmenseni(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            //pictureBox.Location = new Point(pictureBox.Location.X - 5, pictureBox.Location.Y - 5);
            //pictureBox.Size = new Size(pictureBox.Size.Width + 10, pictureBox.Size.Height + 10);
            pictureBox.BackColor = Color.FromArgb(80,80,80) ;
            
        }
        private void NajetiZvetseni(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BackColor = Color.Transparent;
            //pictureBox.Location = new Point(pictureBox.Location.X + 5, pictureBox.Location.Y + 5);
            //pictureBox.Size = new Size(pictureBox.Size.Width - 10, pictureBox.Size.Height - 10);
        }

        private void ClickOnItem(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            CloseButton.Visible = false;
            int o = Items.FindIndex(x => x.Name == pictureBox.Name);
            Debug.WriteLine(Items[o].Name);

            if (Items[o].LifeUp != 0)
            {
                LoadForm.instance.Zvirata[index].Life += Convert.ToInt32(Items[o].LifeUp);
            }
            else if (Items[o].WaterUp != 0)
            {
                LoadForm.instance.Zvirata[index].Voda += (Items[o].WaterUp * VodaMultiplayer);

            }
            else if (Items[o].HungerUp != 0)
            {
                LoadForm.instance.Zvirata[index].Jidlo += (Items[o].HungerUp * JidloMultiplayer);
            }

            if (Items[o].LifeDown != 0)
            {
                LoadForm.instance.Zvirata[index].Life -= Convert.ToInt32(Items[o].LifeDown);
            }
            else if (Items[o].WaterDown != 0)
            {
                LoadForm.instance.Zvirata[index].Voda -= (Items[o].WaterUp * 10);
            }
            else if (Items[o].HungerDown != 0)
            {
                LoadForm.instance.Zvirata[index].Jidlo -= (Items[o].HungerUp * 10);
            }

            Items.RemoveAt(Items.FindIndex(x => x.Name == pictureBox.Name));
            InventarOtevreny = false;
            InventoryShow.Visible = false;
            InventoryShow.Controls.Clear();
            OpenBackPackImage.Image = BasicImages.Backpack;
            Debug.WriteLine("byl vybran: " + pictureBox.Name);
            
        }

        private void CloseInventory(object sender, EventArgs e)
        {
            InventoryShow.Controls.Clear();
            CloseButton.Visible = false;
            InventarOtevreny = false;
            OpenBackPackImage.Image = BasicImages.Backpack;
            InventoryShow.Visible = false;
        }
        public void OpenWindow(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Show();
        }
        private void Update(object sender, EventArgs e)
        {
            //Debug.WriteLine("Tick");
            ShopReset--;
            ShopForm.instance.ResetTimer.Text = "Resets in..\n" + Help.SekundyNacas(ShopReset).ToString().Substring(3);
            if (ShopReset == 0) {ShopReset = shopResetTimer; ShopForm.instance.ResetItems(); }

            //Money
            ShopForm.instance.MoneyLabel.Text = LoadForm.instance.Zvirata[index].Money.ToString();
            LMoney.Text = LoadForm.instance.Zvirata[index].Money.ToString();
            //Zivot
            LoadForm.instance.Zvirata[index].DelkaZivotaVeVterinach += 1;

            //Notify
            Alerter.Visible = true;
            Alerter.Text = LoadForm.instance.Zvirata[index].Jmeno;
            Alerter.BalloonTipTitle = LoadForm.instance.Zvirata[index].Jmeno;
            Alerter.BalloonTipText = "Text";
            Alerter.BalloonTipIcon = ToolTipIcon.None;
            Alerter.Icon = Icons.Ikony.Petuikona;

            // Veliost
            if (LoadForm.instance.Zvirata[index].DelkaZivotaVeVterinach > 900 && LoadForm.instance.Zvirata[index].DelkaZivotaVeVterinach < 1800)
            {
                LoadForm.instance.Zvirata[index].PWidthxHeight[0] = 64;
            }
            if (LoadForm.instance.Zvirata[index].DelkaZivotaVeVterinach > 1800 && LoadForm.instance.Zvirata[index].DelkaZivotaVeVterinach < 3600)
            {
                LoadForm.instance.Zvirata[index].PWidthxHeight[0] = 128;
            }
            if (LoadForm.instance.Zvirata[index].DelkaZivotaVeVterinach > 7200)
            {
                LoadForm.instance.Zvirata[index].PWidthxHeight[0] = 256;
            }

            switch (LoadForm.instance.Zvirata[index].PWidthxHeight[0])
            {
                case 32:
                    
                    break;
                case 64:
                    if (MainPicture.Size.Width != 64)
                    {
                        MainPicture.Location = new Point(396, 392);
                        MainPicture.Size = new Size(64, 64);
                    MainPicture.Location = new Point(MainPicture.Location.X - 24, MainPicture.Location.Y - 32);
                    }
                    
                    break;
                case 128:
                    if (MainPicture.Size.Width != 128)
                    {
                        MainPicture.Location = new Point(396, 392);
                        MainPicture.Size = new Size(128, 128);
                        MainPicture.Location = new Point(MainPicture.Location.X - 48, MainPicture.Location.Y - 96);
                    }
                    
                    break;
                case 256:
                    if (MainPicture.Size.Width != 256)
                    {
                        MainPicture.Location = new Point(396, 392);
                        MainPicture.Size = new Size(256, 256);
                        MainPicture.Location = new Point(MainPicture.Location.X - 96, MainPicture.Location.Y - 224); 
                    }
                    
                    break;
            }


            Notify(LoadForm.instance.Zvirata[index].Voda, LoadForm.instance.Zvirata[index].Jidlo);
            //BackgrounUpdate
            BackPlayChoser.NextImage();

            if (LoadForm.instance.Zvirata[index].Voda > 10000)
            {
                LoadForm.instance.Zvirata[index].Voda = 10000;
            }
            if (LoadForm.instance.Zvirata[index].Jidlo > 10000)
            {
                LoadForm.instance.Zvirata[index].Jidlo = 10000;
            }

            if (LoadForm.instance.Zvirata[index].Voda <= 0)
            {
                VodaDole = true;
                LoadForm.instance.Zvirata[index].Voda = 0;
            }
            else {LoadForm.instance.Zvirata[index].Voda -= vodaDolu; VodaDole = false; }

            if (LoadForm.instance.Zvirata[index].Jidlo <= 0)
            {
                JidloDole = true;
                LoadForm.instance.Zvirata[index].Jidlo = 0;
            }
            else { LoadForm.instance.Zvirata[index].Jidlo -= JidloDolu; JidloDole = false; }
            
            for (int i = 0; i <= 9; i++)
            {
                if (i * 1000 <= LoadForm.instance.Zvirata[index].Jidlo)
                {
                    Hunger[i].Image = Petu.BasicImages.Food_Icon;
                }
                else
                {
                    Hunger[i].Image = Petu.BasicImages.Food_Icon_Empty;
                }
            }
            for (int i = 0; i <= 9; i++)
            {
                if (i * 1000 < LoadForm.instance.Zvirata[index].Voda)
                {
                    Water[i].Image = Petu.BasicImages.Water_Icon;
                }
                else
                {
                    Water[i].Image = Petu.BasicImages.Water_Icon_Empty;
                }
            }
            for (int i = 0; i <= 9; i++)
            {
                if (i < LoadForm.instance.Zvirata[index].Life)
                {
                    Live[i].Image = Petu.BasicImages.Hearth_icon;
                }
                else
                {
                    Live[i].Image = Petu.BasicImages.Hearth_icon_Empty;
                }
            }

            if (VodaDole == true || JidloDole == true)
            {
                if (LifeTimerBezi == false)
                {
                    LifeTimer.Start();
                }
            }

            if (VodaDole == false && JidloDole == false)
            {
                LifeTimer.Stop();
            }

            if (LoadForm.instance.Zvirata[index].Voda > 0)
            {
                Lwater.Text = Math.Round(LoadForm.instance.Zvirata[index].Voda).ToString().Substring(0, Math.Round(LoadForm.instance.Zvirata[index].Voda).ToString().Length-1);
            }
            else
            {
                Lwater.Text = "0";
            }
            
            LHunger.Text = Math.Round(LoadForm.instance.Zvirata[index].Jidlo).ToString().Substring(0,3);
        }
        private void Notify(double voda, double jidlo)
        {
            
           
            if (voda < 5000 && NotifyVoda[0] == false )
            {
                Alerter.BalloonTipText = "I'm thirsty";
                Alerter.ShowBalloonTip(500);
                Debug.WriteLine("Piti pod 5000");
                NotifyVoda[0] = true;
            }
            if (voda > 5000)
            {
                NotifyVoda[0] = false;
            }
            
            if (voda < 500 && NotifyVoda[1] == false)
            {
                Alerter.BalloonTipText = "I need to drink!";
                Alerter.ShowBalloonTip(500);
                Debug.WriteLine("Piti pod 500");
                NotifyVoda[1] = true;
            }
            if (voda > 500)
            {
                NotifyVoda[1] = false;
            }

            if (jidlo < 5000 && NotifyJidlo[0] == false)
            {
                Alerter.BalloonTipText = "I'm hungry";
                Alerter.ShowBalloonTip(500);
                Debug.WriteLine("Jidlo pod 5000");
                NotifyJidlo[0] = true;
            }
            else if (jidlo > 5000)
            {
                NotifyJidlo[0] = false;
            }
            if (jidlo < 500 && NotifyJidlo[1] == false)
            {
                Alerter.BalloonTipText = "I need to eat!";
                Alerter.ShowBalloonTip(500);
                Debug.WriteLine("Jidlo pod 500");
                NotifyJidlo[1] = true;
            }
            else if (jidlo > 500)
            {
                NotifyJidlo[1] = false;
            }


        }
        private void LifeDown(object sender, EventArgs e)
        {
            Debug.WriteLine("Life Down");
            Alerter.BalloonTipText = "OOF :c";
            Alerter.ShowBalloonTip(500);
            LoadForm.instance.Zvirata[index].Life -= 1;
            if (LoadForm.instance.Zvirata[index].Hardcore == true)
            { Debug.WriteLine("Hardcore yes"); }
            if (LoadForm.instance.Zvirata[index].Life == 0 && LoadForm.instance.Zvirata[index].Hardcore == true)
            {
                string jmeno = LoadForm.instance.Zvirata[index].Jmeno;
                Debug.WriteLine("Smrt");
                LoadForm.instance.Zvirata[index].enabled = false;
                LoadForm.instance.Ulozit();
                MessageBox.Show("Your pet " + jmeno + " has died...");
                Environment.Exit(0);
            }
        }

        private void OpenShop(object sender, EventArgs e)
        {
            
            shopForm.Show();
            this.Hide();
        }

        private void PlayGame(object sender, EventArgs e)
        {
            Play.Show();
            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            e.Cancel = true; Debug.WriteLine("Konec");
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void AutoSave(object sender, EventArgs e)
        {
            Debug.WriteLine("--------------\nAutomatické uložení");
            UložitItemy();
            Debug.WriteLine("--------------");
           
        }

        private void OpenBackGroundMenu(object sender, EventArgs e)
        {
            BackPlayChoser.Show();
            BackGround.BackgroundChoser.Instance.Reload();
            this.Hide();
        }

        private void BackgroundChoserEnter(object sender, EventArgs e)
        {
            BackgroundChoser.Image = BasicImages.BacgroundChoseIcon_Active;
        }

        private void BackgroundChoserLeaver(object sender, EventArgs e)
        {
            BackgroundChoser.Image = BasicImages.BacgroundChoseIcon;
        }
    }
}
