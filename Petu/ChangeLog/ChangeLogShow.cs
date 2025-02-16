using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Petu.ChangeLog
{
    public partial class ChangeLogShow : Form
    {
        public ChangeLogShow()
        {
            InitializeComponent();
            label1.Text = ChangeLog.Changes;
        }

        private void ChangeLogShow_Load(object sender, EventArgs e)
        {

        }
    }
}
