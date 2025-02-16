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

namespace Petu.Games
{
    public partial class GoldQuest : Form
    {
        public int[] PolohaHraceMinula = { 5, 0 };
        public int[] PolohaHrace = { 5, 0 };
     
        public Policko[,] Pole = new Policko[10, 20];
        public List<int> PolohaNetopiruX = new List<int>();
        public List<int> PolohaNetopiruY = new List<int>();
        public List<bool> PolohaNetopiruBool = new List<bool>();
        public List<bool> Kridla = new List<bool>();
        bool hrabezi = true;
        bool Nesmrtelny = false;
        Image Mazlicek = MainForm.instance.mazel;

        int score = 0;
        public GoldQuest()
        {

            InitializeComponent();
            NextRoom();
        }

        private void KeyPressing(object sender, KeyEventArgs e)
        {
            if (hrabezi == true)
            {
                Pole[PolohaHrace[0], PolohaHrace[1]].Grafika.Image = null;
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        PolohaHrace[0] -= 1;
                        if (PolohaHrace[0] == -1)
                        {
                            PolohaHrace[0] += 1;
                        }
                        break;
                    case Keys.Down:
                        PolohaHrace[0] += 1;
                        if (PolohaHrace[0] == 10)
                        {
                            PolohaHrace[0] -= 1;
                        }
                        break;
                    case Keys.Right:
                        PolohaHrace[1] += 1;
                        if (PolohaHrace[1] == 20)
                        {
                            PolohaHrace[1] -= 1;
                            Nesmrtelny = true;
                            PolohaHrace[1] = 0;
                            this.Controls.Clear();
                            ShowScore(250);
                            NextRoom();
                        }

                        break;
                    case Keys.Left:
                        PolohaHrace[1] -= 1;
                        if (PolohaHrace[1] == -1)
                        {
                            PolohaHrace[1] += 1;
                        }
                        break;

                    //
                    case Keys.W:
                        PolohaHrace[0] -= 1;
                        if (PolohaHrace[0] == -1)
                        {
                            PolohaHrace[0] += 1;
                        }
                        break;
                    case Keys.S:
                        PolohaHrace[0] += 1;
                        if (PolohaHrace[0] == 10)
                        {
                            PolohaHrace[0] -= 1;
                        }
                        break;
                    case Keys.D:
                        PolohaHrace[1] += 1;
                        if (PolohaHrace[1] == 20)
                        {
                            PolohaHrace[1] -= 1;
                            Nesmrtelny = true;
                            PolohaHrace[1] = 0;
                            this.Controls.Clear();
                            ShowScore(250);
                            NextRoom();
                        }
                        break;
                    case Keys.A:
                        PolohaHrace[1] -= 1;
                        if (PolohaHrace[1] == -1)
                        {
                            PolohaHrace[1] += 1;
                        }
                        break;

                }
                if (Pole[PolohaHrace[0], PolohaHrace[1]].Grafika.Image != null)
                {
                    Konec();
                }

                if (Pole[PolohaHrace[0], PolohaHrace[1]].Grafika.Tag.ToString() == "Dark")
                {
                    Konec();
                }
                if (Pole[PolohaHrace[0], PolohaHrace[1]].Grafika.Tag.ToString() == "FloorMoney")
                {
                    Pole[PolohaHrace[0], PolohaHrace[1]].Grafika.Tag = "Floor";
                    Pole[PolohaHrace[0], PolohaHrace[1]].Grafika.BackgroundImage = GoldQuestResources.stonefloor;
                    ShowScore(100);
                }



                //if (Pole[PolohaHrace[0], PolohaHrace[1]].Grafika.BackColor == Color.Red)
                //{

                //    PolohaHrace[1] = 0;
                //    this.Controls.Clear();
                //    ShowScore(250);
                //    NextRoom();
                //}
                Nesmrtelny = false;
                Pole[PolohaHrace[0], PolohaHrace[1]].Grafika.Image = Mazlicek;
            }
            if (e.KeyCode == Keys.Enter && hrabezi == false)
            {
                this.Close();
            }
        }
        void Konec()
        {
            if (!Nesmrtelny)
            {
                if (score > 5000)
                {
                    bool Obsahuje = false;
                    Item p = new Item("background2", 'A', "0L", "0L", 0);
                    foreach (Item o in MainForm.instance.Items)
                    {
                        if (o.Name == "background2") { Obsahuje = true; }
                    }
                    if (!Obsahuje)
                    {
                        MainForm.instance.BackgroundItems.Add(p);
                        MainForm.instance.Items.Add(p);
                    }
                }
                hrabezi = false;
                Debug.WriteLine("Score:" + score);
                LoadForm.instance.Zvirata[LoadForm.instance.SelectedPet].Money += score;
                this.Controls.Clear();
                InitializeComponent();
                GameOver.Visible = true;
                NaseScore.Visible = false;
                MoneyAdd.Visible = true;
                MoneyAdd.Text = score.ToString();
                PressEnterToleave.Visible = true;
            }
        }
        void ShowScore(int kolikpridat)
        {
            foreach (object a in this.Controls)
            {
                if (a.GetType().Name == "Label")
                {
                    Label o = (Label)a;
                    o.Visible = false;
                }
            }
            score += kolikpridat;
            text Baleb = new text(score.ToString());
            this.Controls.Add(Baleb.Text);
            

        }
        public void NextRoom()
        {
            EnemyMovement.Stop();
            // y , x


            for (int i = 0; i != 10; i++)
            {

                for (int j = 0; j != 20; j++)
                {
                    Policko bla = new Policko(j * 50, i * 50);
                    Pole[i, j] = bla;
                    this.Controls.Add(bla.Grafika);

                }
            }
            Random rnd = new Random();


            PolohaNetopiruX.Clear();
            PolohaNetopiruBool.Clear();
            int polohaNetopiruTemp = rnd.Next(3, 17);
            PolohaNetopiruX.Add(polohaNetopiruTemp);
            Debug.WriteLine(polohaNetopiruTemp);
            while (polohaNetopiruTemp < 18)
            {
                polohaNetopiruTemp += rnd.Next(3,5);
                if (polohaNetopiruTemp >= 18)
                {
                    break;
                }
                PolohaNetopiruX.Add(polohaNetopiruTemp);
                
                Debug.WriteLine(polohaNetopiruTemp);
            }
            
          
            




            int[] PolohaGuidera = new int[] { PolohaHrace[0], 0 };
            int[] PolohaGuideraNext = new int[] { PolohaHrace[0], 0 };
            Pole[PolohaGuidera[0], PolohaGuidera[1]].Grafika.BackgroundImage = GoldQuestResources.stonefloor;
            Pole[PolohaGuidera[0], PolohaGuidera[1]].Grafika.Tag = "Floor";
            for (int i = 0; i != 100; i++)
            {
                int pocetPokusu = 0;
            toto:
                pocetPokusu++;
                if (pocetPokusu < 3)
                {


                    PolohaGuideraNext[0] = PolohaGuidera[0];
                    PolohaGuideraNext[1] = PolohaGuidera[1];


                    int KamDal = rnd.Next(1, 4);

                    switch (KamDal)
                    {
                        case 1:
                            PolohaGuideraNext[0] -= 1;
                            if (PolohaGuideraNext[0] == -1)
                            { goto toto; }
                            break;
                        case 2:
                            PolohaGuideraNext[1] += 1;
                            if (PolohaGuideraNext[1] == 20)
                            { goto toto; }
                            break;
                        case 3:
                            PolohaGuideraNext[0] += 1;
                            if (PolohaGuideraNext[0] == 10)
                            { goto toto; }
                            break;
                        case 4:
                            PolohaGuideraNext[1] -= 1;
                            if (PolohaGuideraNext[1] == -1)
                            { goto toto; }
                            break;
                    }


                    //Debug.WriteLine(PolohaGuideraNext[0] + " - " + PolohaGuideraNext[1]);
                    if (Pole[PolohaGuideraNext[0], PolohaGuideraNext[1]].Grafika.Tag.ToString() != "Floor")
                    {
                        Pole[PolohaGuideraNext[0], PolohaGuideraNext[1]].Grafika.BackgroundImage = GoldQuestResources.stonefloor;
                        Pole[PolohaGuideraNext[0], PolohaGuideraNext[1]].Grafika.Tag = "Floor";
                        PolohaGuidera[0] = PolohaGuideraNext[0];
                        PolohaGuidera[1] = PolohaGuideraNext[1];

                        if (PolohaGuidera[1] == 19)
                        {
                            break;
                        }
                        if (rnd.Next(1, 20) == 1)
                        {
                            Pole[PolohaGuideraNext[0], PolohaGuideraNext[1]].Grafika.BackgroundImage = GoldQuestResources.MoneyOnfloor;
                            Pole[PolohaGuideraNext[0], PolohaGuideraNext[1]].Grafika.Tag = "FloorMoney";
                        }
                    }
                    else
                    {
                        goto toto;
                    }
                }





            }
            PolohaNetopiruY.Clear();
            foreach (int a in PolohaNetopiruX)
            {
                int Provizorni = rnd.Next(1, 9);
                PolohaNetopiruY.Add(Provizorni);
                PolohaNetopiruBool.Add(true);
                Kridla.Add(false);
                Pole[Provizorni, a].Grafika.Image = GoldQuestResources.BatUp;

            }
            Pole[PolohaGuideraNext[0], PolohaGuideraNext[1]].Grafika.BackColor = Color.Red;
            Pole[PolohaGuideraNext[0], PolohaGuideraNext[1]].Grafika.BackgroundImage = GoldQuestResources.stonefloorWithArrow;
            Pole[PolohaHrace[0], PolohaHrace[1]].Grafika.Image = Mazlicek;
            EnemyMovement.Start();
        }

        private void EnemyMove(object sender, EventArgs e)
        {
            if (PolohaNetopiruX.Count != 0)
            {
                for (int i = 0; i != PolohaNetopiruX.Count; i++)
                {
                    Pole[PolohaNetopiruY[i], PolohaNetopiruX[i]].Grafika.Image = null;
                    
                    if (PolohaNetopiruBool[i] == true)
                    {
                        

                        PolohaNetopiruY[i] += 1;
                        if (Pole[PolohaNetopiruY[i], PolohaNetopiruX[i]].Grafika.Image != null)
                        {
                            Debug.WriteLine("Score:" + score);
                            Konec();
                        }
                        if (Kridla[i] == false)
                        {
                            Pole[PolohaNetopiruY[i], PolohaNetopiruX[i]].Grafika.Image = GoldQuestResources.BatUp;
                            Kridla[i] = true;
                        }
                        else
                        {
                            Pole[PolohaNetopiruY[i], PolohaNetopiruX[i]].Grafika.Image = GoldQuestResources.Batdown;
                            Kridla[i] = false;
                        }
                        
                        
                        if (PolohaNetopiruY[i] == 9)
                        {
                            PolohaNetopiruBool[i] = false;
                        }
                    }
                    else
                    {
                        
                        PolohaNetopiruY[i] -= 1;
                        if (Pole[PolohaNetopiruY[i], PolohaNetopiruX[i]].Grafika.Image != null)
                        {
                            Debug.WriteLine("Score:" + score);
                            Konec();
                        }
                        if (Kridla[i] == false)
                        {
                            Pole[PolohaNetopiruY[i], PolohaNetopiruX[i]].Grafika.Image = GoldQuestResources.BatUp;
                            Kridla[i] = true;
                        }
                        else
                        {
                            Pole[PolohaNetopiruY[i], PolohaNetopiruX[i]].Grafika.Image = GoldQuestResources.Batdown;
                            Kridla[i] = false;
                        }
                        if (PolohaNetopiruY[i] == 0)
                        {
                            PolohaNetopiruBool[i] = true;
                        }
                    }
                    



                }
            }
        }
    }
     class text
    {
         public Label Text = new Label();
        public text(string CoTamBude)
        {
            Text.Font = new Font("Windows Command Prompt", 48);
            Text.Location = new Point(370, 503);
            Text.AutoSize = false;
            Text.Size = new Size(261, 56);
            Text.ForeColor = Color.FromArgb(0, 192, 0);
            Text.TextAlign = ContentAlignment.MiddleCenter;
            Text.Text = CoTamBude;
            Text.Name = "NaseScore";
        }
    }
}
