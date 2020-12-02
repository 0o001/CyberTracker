using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberTracker
{
    public partial class usr_TrackItem : UserControl
    {
        public string Description;
        public usr_TrackItem()
        {
            InitializeComponent();
        }

        private void usr_TrackItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Description, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
