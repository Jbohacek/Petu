using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petu.Games
{
    public partial class GameSelect : Form
    {
        public GameSelect()
        {
            InitializeComponent();
            
        }




        //Ikona
        private void BackEnter(object sender, EventArgs e)
        {
            BackButton.Image = BasicImages.BackArrow_Activated;
        }
        private void BackLeave(object sender, EventArgs e)
        {
            BackButton.Image = BasicImages.BackArrow;
        }
        //Ikona
        private void Ukonceni(object sender, FormClosingEventArgs e)
        {
            MainForm.instance.Show();
            this.Hide();
            e.Cancel = true;
        }

        private void GetBack(object sender, EventArgs e)
        {
            MainForm.instance.Show();
            this.Hide();
        }

        private void PlaySheephunt(object sender, EventArgs e)
        {
            SheepHunt Hrat = new SheepHunt();
            Hrat.Show();
            

        }

        private void PlayGoldQuest(object sender, EventArgs e)
        {
            GoldQuest GoldQuest = new GoldQuest();
            GoldQuest.Show();
        }
    }
}
