using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberTracker
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            tmr_tracker_Tick(null, null);
        }

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            Hide();
        }

        private void ni_program_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        List<Track> tracksTemp = new List<Track>();
        private void tmr_tracker_Tick(object sender, EventArgs e)
        {
            List<Track> tracks = Response.getTracks()
                .Where(track => Process.GetProcesses(".")
                .Any(process => process.ProcessName.ToLower() == track.Name.ToLower()))
                .OrderByDescending(track => track.DangerType)
                .ToList();

            if(!tracks.SequenceEqual(tracksTemp))
            {
                flp_tracks.Controls.Clear();

                foreach (var item in tracks)
                {
                    flp_tracks.Controls.Add(new usr_TrackItem { lbl_title = { Text = item.Name }, Description = item.Description, BackColor = DangerTypeColors.GetColor(item.DangerType) });
                }

                if (tracksTemp.Count > 0)
                {
                    if(tracks.Count > tracksTemp.Count)
                    {
                        ni_program.ShowBalloonTip(1000);
                    }
                }

                tracksTemp = tracks;
            }  
        }

        private void ni_program_BalloonTipClicked(object sender, EventArgs e)
        {
            Show();
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }
    }
}
