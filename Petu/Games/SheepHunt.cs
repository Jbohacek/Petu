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
    public partial class SheepHunt : Form
    {
        PictureBox[,] Pole = new PictureBox[19,12];
        
        int[] HracovaPozice = new int[2];
        int[] CilovaPozice = new int[2];

        int score = 0;
        int MoneyEarner = 20;
        const int MoneyMultiPlayer = 2;
        bool nesmrtelnost = false;
        bool gameisOn = true;
        bool CanShoot = true;
        int timeToShootAgin = 5000;
        int time;
        int collected = 0;

        Image Mazlicek = MainForm.instance.mazel;
        public SheepHunt()
        {
            InitializeComponent();
            flowLayoutPanel1.BackgroundImage = SheepHuntResources.Background;

            TimeToshotAgin.Interval = timeToShootAgin;
            time = timeToShootAgin /1000;
            MoneyAdd.ForeColor = Color.FromArgb(255,215,0);
            label1.Text = score.ToString();
            int a = 0;
            int b = 0;
            for (int i = 0; i != 228; i++)
            {

                PictureBox lol = new PictureBox();
               
                lol.AutoSize = false;
                lol.SizeMode = PictureBoxSizeMode.Zoom;
                lol.Size = new Size(50, 50);
                lol.BackColor = Color.Transparent;
                lol.Click += DeathCell;
                lol.Tag = "No";
                lol.BackgroundImageLayout = ImageLayout.Zoom;

                
                flowLayoutPanel1.Controls.Add(lol);
                if (b != 19)
                {
                    //Debug.WriteLine(a + " " + b);
                    Pole[b, a] = lol;
                    b++;
                }
                else
                {
                    b = 0;
                    a++;
                    //Debug.WriteLine(a + " " + b);
                    Pole[b, a] = lol;
                    b++;
                }
                
            }
            Debug.WriteLine("Succes");
            Random rnd1 = new Random();
            Random rnd2 = new Random();

            int xr = rnd1.Next(0, 18);
            Thread.Sleep(500);
            int yr = rnd2.Next(0, 11);
            Debug.WriteLine("random is = " + xr + " " + yr);
            Pole[xr, yr].Image = Mazlicek;
            HracovaPozice[0] = xr; HracovaPozice[1] = yr;

            xr = rnd1.Next(1, 17);
            Thread.Sleep(500);
            yr = rnd2.Next(1, 10);
            //Pole[xr, yr].BackColor = Color.Red;
            Pole[xr, yr].Image = SheepHuntResources.MoneyOnGround;
            CilovaPozice[0] = xr; CilovaPozice[1] = yr;
            
        }

        private void KeyPlay(object sender, KeyEventArgs e)
        {

            if (gameisOn == true)
            {

                if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up) // Nahoru
                {
                    //Debug.WriteLine("Up");
                    Vykresli(HracovaPozice[0], HracovaPozice[1] - 1);
                }
                if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down) // Dolu
                {
                    //Debug.WriteLine("Down");
                    Vykresli(HracovaPozice[0], HracovaPozice[1] + 1);
                }
                if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right) // Doprava
                {
                    //Debug.WriteLine("Right");
                    Vykresli(HracovaPozice[0] + 1, HracovaPozice[1]);
                }
                if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left) // Doleva
                {
                    //Debug.WriteLine("Left");
                    Vykresli(HracovaPozice[0] - 1, HracovaPozice[1]);
                }
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.Close();
                }
            }
        }
        private void Vykresli(int x, int y)
        {
            if (x == -1)
            {
                x = 0;
            }
            if (x == 19)
            {
                x = 18;            
            }
            if (y == -1)
            {
                y = 0;
            }
            if (y == 12)
            {
                y = 11;
            }

            if (CilovaPozice[0] == x && CilovaPozice[1] == y)
            {
                collected++;
                nesmrtelnost = true;
                score += MoneyEarner + Convert.ToInt32( Math.Round(collected * 1.5));
                MoneyEarner = 20;
                label1.Text = (score*MoneyMultiPlayer + Convert.ToInt32(Math.Round(collected * 1.5))).ToString();
                Pole[CilovaPozice[0], CilovaPozice[1]].BackgroundImage = GoldQuestResources.BatUp;
                Pole[CilovaPozice[0], CilovaPozice[1]].Tag = "Yes";


                Random rnd = new Random();
                Debug.WriteLine("Doing, colleced: " + collected);
                
                CilovaPozice[0] = rnd.Next(1, 17);
                CilovaPozice[1] = rnd.Next(1, 10);
                //Pole[CilovaPozice[0], CilovaPozice[1]].BackColor = Color.Red;
                Pole[CilovaPozice[0], CilovaPozice[1]].Image = SheepHuntResources.MoneyOnGround;
                Pole[CilovaPozice[0], CilovaPozice[1]].BackgroundImage = null;
                Pole[CilovaPozice[0], CilovaPozice[1]].Tag = "No";
            }

            
            Pole[HracovaPozice[0], HracovaPozice[1]].Image = null;
            Pole[x, y].Image = Mazlicek;
            HracovaPozice[0] = x; HracovaPozice[1] = y;
            if (Pole[x, y].Tag.ToString() == "Yes" && nesmrtelnost == false)
            {
                ScoreLower.Stop();
                Debug.WriteLine("Lost");
                flowLayoutPanel1.Visible = false;
                Pole[x, y].Image = null;
                gameisOn = false;
                LoadForm.instance.Zvirata[LoadForm.instance.SelectedPet].Money += score * MoneyMultiPlayer + Convert.ToInt32(Math.Round(collected * 1.5));
                int hodnota = score * MoneyMultiPlayer + Convert.ToInt32(Math.Round(collected * 1.5));
                MoneyAdd.Text = "+" + hodnota;
                MoneyAdd.Visible = true;
                GameOver.Visible = true;
                PressEnterToleave.Visible = true;
                label1.Visible = false;
                AdderLabel.Visible = false;
                LabelTimeToShot.Visible = false;
                if (score * MoneyMultiPlayer > 5000)
                {
                    bool Obsahuje = false;
                    Item p = new Item("background1", 'A', "0L", "0L",0);
                    foreach (Item o in MainForm.instance.Items)
                    {
                        if (o.Name == "background1") { Obsahuje = true; }
                    }
                    if (!Obsahuje)
                    {
                        MainForm.instance.BackgroundItems.Add(p);
                        MainForm.instance.Items.Add(p);
                    }
                    

                }
            }
            nesmrtelnost = false;
        }

        private void GameBegin(object sender, EventArgs e)
        {
            
        }

        public void DeathCell(object sender, EventArgs e)
        {
            if (CanShoot == true)
            {
                collected--;
                Frame.Start();
                LabelTimeToShot.Visible = true;
                TimeToshotAgin.Start();
                CanShoot = false;
                time = timeToShootAgin / 1000;
                LabelTimeToShot.Text = time.ToString();
                PictureBox pictureBox = (PictureBox)sender;
                pictureBox.Cursor = Cursors.Arrow;
                pictureBox.Tag = "No";
                pictureBox.BackgroundImage = null;
                Debug.WriteLine("Shotted, collected: " + collected);
            }
            
        }

        private void LowerScore(object sender, EventArgs e)
        {
            if (MoneyEarner > 0)
            {
                MoneyEarner--;
                int hodnota = (MoneyEarner * MoneyMultiPlayer) + Convert.ToInt32(Math.Round(collected * 1.5));
                AdderLabel.Text = "+ " + hodnota;
            }
        }

        private void ShowTimer(object sender, EventArgs e)
        {
            Debug.WriteLine("Can shoot");
            CanShoot = true;
            LabelTimeToShot.Visible = false;
            Frame.Stop();
            TimeToshotAgin.Stop();
        }

        private void FrameTick(object sender, EventArgs e)
        {
            
            time--;
            LabelTimeToShot.Text = time.ToString();
            Debug.WriteLine("Sec down: " + time);
        }
    }
}
