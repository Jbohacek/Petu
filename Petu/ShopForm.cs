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
using System.Threading;

namespace Petu
{
    public partial class ShopForm : Form
    {
        public static ShopForm instance;
        public Label ResetTimer;
        public int index = LoadForm.instance.SelectedPet;
        List<Item> ItemsToBuy = new List<Item>();
        int[] cenyItems = new int[3];
        int IndexItemuCeny = 0;
        List<PictureBox> PredmetyObrazky = new List<PictureBox>();
        List<Label> PredmetyTexty = new List<Label>();
        public int CostToReset = 100;
        public Label MoneyLabel;
        public ShopForm()
        {
            InitializeComponent();
            Random rnd = new Random();
            instance = this;
            ResetTimer = ResetLabelTime;
            ResetButton.Text = CostToReset + ",-\nReset Store";
            MoneyLabel = LMoney;

            Item1Show.Click += PurchaseItem;
            Item2Show.Click += PurchaseItem;
            Item3Show.Click += PurchaseItem;
            PredmetyObrazky.Add(Item1Show);
            PredmetyObrazky.Add(Item2Show);
            PredmetyObrazky.Add(Item3Show);
            PredmetyTexty.Add(Item1Mark);
            PredmetyTexty.Add(Item2Mark);
            PredmetyTexty.Add(Item3Mark);


           
        }

        private void ReturnToMain(object sender, EventArgs e)
        {
            MainForm.instance.Show();
            this.Hide();
        }
        public Item NovyPredmet(char typCoZvednout,char vzacnost,int OkolikZvednout,char typCoSnizit, int OkolikSnizit, bool piti)
        {
            string Zvednuti = typCoZvednout.ToString() + OkolikZvednout.ToString();
            string Snizeni = typCoSnizit.ToString() + OkolikSnizit.ToString();
            Random rnd = new Random();
            Thread.Sleep(10);
            
            int Ikonka = rnd.Next(0, Help.NameOfItems.Count - 1);
            
            
            Item p = new Item(Help.GenerateName(6),vzacnost,Zvednuti,Snizeni,Ikonka);
            return p;
        }
        public Item NovyPredmet(char typCoZvednout, char vzacnost, int OkolikZvednout , bool piti)
        {
            string Zvednuti = typCoZvednout.ToString() + OkolikZvednout.ToString();
            
            Random rnd = new Random();
            int Ikonka;
            if (piti == true)
            {
                Ikonka = rnd.Next(0, 3);

            }
            else
            {
                Ikonka = rnd.Next(5, Help.NameOfItems.Count);
            }
            
            Item p = new Item(Help.GenerateName(20), vzacnost, Zvednuti, "L0", Ikonka);
            Debug.WriteLine("Nazev: " + p.Name);
            Debug.WriteLine("Vzacnost: " + p.typ);
            Debug.WriteLine("Zvednuti: " + Zvednuti);
            Debug.WriteLine("Ikona: " + p.Ikona);
            Debug.WriteLine("Piti: " + piti.ToString() + "\n");

            cenyItems[IndexItemuCeny] = Convert.ToInt32(Math.Round(OkolikZvednout * 1.5));
            IndexItemuCeny++;
            if (IndexItemuCeny == 3)
            { IndexItemuCeny = 0; }
            return p;
        }
        public Item NovyPredmet(char typCoZvednout, char vzacnost, int OkolikZvednout, bool piti,bool Zivoty)
        {
            string Zvednuti = typCoZvednout.ToString() + OkolikZvednout.ToString();

            Random rnd = new Random();
            int Ikonka;
            if (piti == true)
            {
                Ikonka = rnd.Next(0, 5);

            }
            else
            {
                Ikonka = rnd.Next(5, Help.NameOfItems.Count);
            }
            if (Zivoty == true)
            {
                Ikonka = 4;
            }
             
            Item p = new Item(Help.GenerateName(20), vzacnost, Zvednuti, "L0", Ikonka);
            Debug.WriteLine("Nazev: " + p.Name);
            Debug.WriteLine("Vzacnost: " + p.typ);
            Debug.WriteLine("Zvednuti: " + Zvednuti);
            Debug.WriteLine("Ikona: " + p.Ikona);
            Debug.WriteLine("Piti: " + piti.ToString() + "\n");

            cenyItems[IndexItemuCeny] = Convert.ToInt32(Math.Round(OkolikZvednout * 20.5));
            IndexItemuCeny++;
            if (IndexItemuCeny == 3)
            { IndexItemuCeny = 0; }
            
            return p;
        }
        public void ResetItems()
        {
            Debug.WriteLine("\nResetovani Predmetu:\n");
            ItemsToBuy.Clear();
            
            foreach (Label x in PredmetyTexty)
            {
                x.Text = "200,-";
                x.ForeColor = BuyExample.ForeColor;
            }
            
            Random rnd = new Random();
            Random rnd2 = new Random();
            Random rnd3 = new Random();
            
            int[] doplneni = { 0,0,0 };
            char[] rarita = new char[3];
            for (int i = 0; i != 3; i++)
            {
                int cislo = rnd3.Next(0, 100);
                Thread.Sleep(10);
                if (cislo < 40)
                {
                    doplneni[i] += 25 + rnd.Next(0,50);
                    rarita[i] = 'D';
                }
                else if (cislo < 70)
                {
                    doplneni[i] += 50 + rnd.Next(0, 50);
                    rarita[i] = 'C';
                }
                else if (cislo < 90)
                {
                    doplneni[i] += 75 + rnd.Next(0, 50);
                    rarita[i] = 'B';
                }
                else
                {
                    doplneni[i] += 100 + rnd.Next(0, 50);
                    rarita[i] = 'A';
                }
            }
            if (rnd.Next(0, 2) == 0)
            {
                Item Predmet1 = NovyPredmet('W', rarita[0], doplneni[0], true);
                Thread.Sleep(10);
                Item Predmet2 = NovyPredmet('H', rarita[1], doplneni[1], false);
                
                Item1Show.Image = Predmet1.IkonaPredmetu;
                Item2Show.Image = Predmet2.IkonaPredmetu;
                ItemsToBuy.Add(Predmet1);
                ItemsToBuy.Add(Predmet2);

                if (Predmet1.typ == 'D')
                {
                    RarityBox1.BackColor = Color.LightGreen;
                }
                else if (Predmet1.typ == 'C')
                {
                    RarityBox1.BackColor = Color.LightBlue;
                }
                else if (Predmet1.typ == 'B')
                {
                    RarityBox1.BackColor = Color.Purple;
                }
                else if (Predmet1.typ == 'A')
                {
                    RarityBox1.BackColor = Color.Orange;
                }

                if (Predmet2.typ == 'D')
                {
                    RarityBox2.BackColor = Color.LightGreen;
                }
                else if (Predmet2.typ == 'C')
                {
                    RarityBox2.BackColor = Color.LightBlue;
                }
                else if (Predmet2.typ == 'B')
                {
                    RarityBox2.BackColor = Color.Purple;
                }
                else if (Predmet2.typ == 'A')
                {
                    RarityBox2.BackColor = Color.Orange;
                }

            }
            else
            {
                Item Predmet1 = NovyPredmet('H', rarita[0], doplneni[0], false);
                Thread.Sleep(10);
                Item Predmet2 = NovyPredmet('W', rarita[1], doplneni[1], true);
                Item1Show.Image = Predmet1.IkonaPredmetu;
                Item2Show.Image = Predmet2.IkonaPredmetu;
                ItemsToBuy.Add(Predmet1);
                ItemsToBuy.Add(Predmet2);
                if (Predmet1.typ == 'D')
                {
                    RarityBox1.BackColor = Color.LightGreen;
                }
                else if (Predmet1.typ == 'C')
                {
                    RarityBox1.BackColor = Color.LightBlue;
                }
                else if (Predmet1.typ == 'B')
                {
                    RarityBox1.BackColor = Color.Purple;
                }
                else if (Predmet1.typ == 'A')
                {
                    RarityBox1.BackColor = Color.Orange;
                }

                if (Predmet2.typ == 'D')
                {
                    RarityBox2.BackColor = Color.LightGreen;
                }
                else if (Predmet2.typ == 'C')
                {
                    RarityBox2.BackColor = Color.LightBlue;
                }
                else if (Predmet2.typ == 'B')
                {
                    RarityBox2.BackColor = Color.Purple;
                }
                else if (Predmet2.typ == 'A')
                {
                    RarityBox2.BackColor = Color.Orange;
                }
            }
            Thread.Sleep(10);
            Item Predmet3 = NovyPredmet('L',rarita[2],rnd.Next(1,5),false,true);
            Item3Show.Image = Predmet3.IkonaPredmetu;
            ItemsToBuy.Add(Predmet3);
            if (Predmet3.typ == 'D')
            {
                RarityBox3.BackColor = Color.LightGreen;
            }
            else if (Predmet3.typ == 'C')
            {
                RarityBox3.BackColor = Color.LightBlue;
            }
            else if (Predmet3.typ == 'B')
            {
                RarityBox3.BackColor = Color.Purple;
            }
            else if (Predmet3.typ == 'A')
            {
                RarityBox3.BackColor = Color.Orange;
            }
            for (int i = 0; i < PredmetyTexty.Count; i++)
            {
                PredmetyTexty[i].Text = cenyItems[i] + ",-";
            }
            foreach (PictureBox pictureBox in PredmetyObrazky)
            {
                pictureBox.BackColor = Color.FromArgb(255,255,255);
                pictureBox.Enabled = true;
            }
            Debug.WriteLine("\n-----");
        }
        public void PurchaseItem(object sender, EventArgs e)
        {
            PictureBox CokoupilPic = (PictureBox)sender;
            if (LoadForm.instance.Zvirata[index].Money >= cenyItems[Convert.ToInt32(CokoupilPic.Name.Substring(4, 1)) - 1])
            {
                LoadForm.instance.Zvirata[index].Money -= cenyItems[Convert.ToInt32(CokoupilPic.Name.Substring(4, 1)) - 1];
                LMoney.Text = LoadForm.instance.Zvirata[index].Money.ToString();
                PredmetyObrazky[Convert.ToInt32(CokoupilPic.Name.Substring(4, 1)) - 1].Enabled = false;
                PredmetyObrazky[Convert.ToInt32(CokoupilPic.Name.Substring(4, 1)) - 1].BackColor = Color.FromArgb(255,49,49);
                PredmetyTexty[Convert.ToInt32(CokoupilPic.Name.Substring(4, 1)) - 1].ForeColor = SoldExample.ForeColor;
                PredmetyTexty[Convert.ToInt32(CokoupilPic.Name.Substring(4, 1)) - 1].Text = SoldExample.Text;
                MainForm.instance.Items.Add(ItemsToBuy[Convert.ToInt32(CokoupilPic.Name.Substring(4, 1)) - 1]);
            }
            else
            {
                PredmetyTexty[Convert.ToInt32(CokoupilPic.Name.Substring(4, 1)) - 1].ForeColor = SoldExample.ForeColor;
                ResetToBackToNormal.Start();
                Debug.WriteLine("Not enought" + cenyItems[Convert.ToInt32(CokoupilPic.Name.Substring(4, 1)) - 1]);
            }
        }
        private void ResetButtonItems(object sender, EventArgs e)
        {
            if (LoadForm.instance.Zvirata[index].Money >= CostToReset)
            {
                LoadForm.instance.Zvirata[index].Money -= CostToReset;
                MainForm.instance.ShopReset = 600;
                foreach (var x in PredmetyObrazky)
                {
                    x.Enabled = false;
                }
                ResetItems();
            }
            else
            {
                Debug.WriteLine("Not Enought Money to Reset store : " + CostToReset);
                ResetButton.ForeColor = Color.Red;
                
            }
            ResetButton.Enabled = false;
            ResetToBackToNormal.Start();
        }

        private void GetBackToBlack(object sender, EventArgs e)
        {
            foreach (var x in PredmetyTexty)
            {
                x.ForeColor = BuyExample.ForeColor;
            }
            ResetButton.Enabled = true;
            ResetButton.ForeColor= Color.White;
            ResetToBackToNormal.Stop();
        }

        private void ClosingShop(object sender, FormClosingEventArgs e)
        {
            MainForm.instance.Show();
            this.Hide();
            e.Cancel = true;
        }

        private void BackActive(object sender, EventArgs e)
        {
            BackButton.Image = BasicImages.BackArrow_Activated;
        }

        private void BackLeave(object sender, EventArgs e)
        {
            BackButton.Image = BasicImages.BackArrow;
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {

        }
    }
}
