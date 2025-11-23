using System;
using System.IO;
using System.Windows.Forms;

namespace PGSysX.Anahaw
{
    public partial class Anahaw : Form
    {
        public Anahaw()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // 1. Check Configuration
            if (!File.Exists("config.ini"))
            {
                HideMainForm();
                using (SetupDialog setup = new SetupDialog())
                {
                    if (setup.ShowDialog() != DialogResult.OK)
                    {
                        Application.Exit();
                        return;
                    }
                }
            }

            // 2. Check Prerequisites (Always check on load, or just on first run? 
            // Usually good to check always in case they deleted a tool, 
            // but since the dialog auto-bypasses if found, it's non-intrusive).
            HideMainForm();
            using (PrereqDialog prereq = new PrereqDialog())
            {
                // This will open, auto-check. 
                // If missing -> stays open. 
                // If found -> returns OK immediately.
                if (prereq.ShowDialog() != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }
            }

            // 3. All good, show Anahaw
            ShowMainForm();
        }

        private void HideMainForm()
        {
            this.Opacity = 0;
            this.ShowInTaskbar = false;
            this.Visible = false;
        }

        private void ShowMainForm()
        {
            this.Visible = true;
            this.ShowInTaskbar = true;
            this.Opacity = 100;
        }
    }
}