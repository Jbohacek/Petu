using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petu
{
    public partial class AdminPowerOnOf : Form
    {
        public AdminPowerOnOf()
        {
            InitializeComponent();
        }

        private void Activeate(object sender, EventArgs e)
        {
            string[] pas = DateTime.Now.ToString().Split(' ');
            string[] pas2 = pas[1].Split(':');
            if (textBox1.Text == pas2[0] + pas2[1] + "8")
            {
                Petu.Properties.Settings.Default.StartAsAdmin = true;
                Petu.Properties.Settings.Default.Save();
                MessageBox.Show("Pasword correct\nRestart will follow..");
            }
            else
            {
                MessageBox.Show("Password incorrect");
            }
            Application.Restart();
        }

        private void DisbaleAdmin(object sender, EventArgs e)
        {
            Petu.Properties.Settings.Default.StartAsAdmin = false;
            Petu.Properties.Settings.Default.Save();
            Application.Restart();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Activeate(sender, e);
            }
        }
    }
}
