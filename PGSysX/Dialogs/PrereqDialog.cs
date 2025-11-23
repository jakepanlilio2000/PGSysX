using System;
using System.Drawing;
using System.Windows.Forms;

namespace PGSysX.Anahaw
{
    public partial class PrereqDialog : Form
    {
        public PrereqDialog()
        {
            InitializeComponent();

            // --- MOVE YOUR LINK LOGIC HERE ---
            // The constructor is safe for lambdas and manual event wiring
            this.lnkPutty.LinkClicked += (s, e) => System.Diagnostics.Process.Start("https://www.chiark.greenend.org.uk/~sgtatham/putty/latest.html");
            this.lnkWinSCP.LinkClicked += (s, e) => System.Diagnostics.Process.Start("https://winscp.net/eng/download.php");
            this.lnkChrome.LinkClicked += (s, e) => System.Diagnostics.Process.Start("https://googlechromelabs.github.io/chrome-for-testing/");
            this.lnkPython.LinkClicked += (s, e) => System.Diagnostics.Process.Start("https://www.python.org/downloads/");
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            PerformChecks();
        }

        private void PerformChecks()
        {
            // (Your existing logic remains the same...)
            bool putty = PrereqChecker.IsPuttyInstalled();
            bool winscp = PrereqChecker.IsWinSCPInstalled();
            bool chrome = PrereqChecker.IsChromeDriverPresent();
            bool python = PrereqChecker.IsPythonInstalled();

            UpdateStatus(lblStatusPutty, putty);
            UpdateStatus(lblStatusWinSCP, winscp);
            UpdateStatus(lblStatusChrome, chrome);
            UpdateStatus(lblStatusPython, python);

            if (putty && winscp && chrome && python)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void UpdateStatus(Label lbl, bool isInstalled)
        {
            if (isInstalled)
            {
                lbl.Text = "Installed";
                lbl.ForeColor = Color.Green;
            }
            else
            {
                lbl.Text = "Missing";
                lbl.ForeColor = Color.Red;
            }
        }

        private void btnRecheck_Click(object sender, EventArgs e)
        {
            PerformChecks();

            if (lblStatusPutty.ForeColor == Color.Green &&
                lblStatusWinSCP.ForeColor == Color.Green &&
                lblStatusChrome.ForeColor == Color.Green &&
                lblStatusPython.ForeColor == Color.Green)
            {
                MessageBox.Show("All prerequisites found. Proceeding...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Some prerequisites are still missing.", "Check Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}