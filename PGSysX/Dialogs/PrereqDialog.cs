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
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            PerformChecks();
        }

        private void PerformChecks()
        {
            bool putty = PrereqChecker.IsPuttyInstalled();
            bool winscp = PrereqChecker.IsWinSCPInstalled();
            bool chrome = PrereqChecker.IsChromeDriverPresent();
            bool python = PrereqChecker.IsPythonInstalled();

            // UPDATE UI
            UpdateStatus(lblStatusPutty, putty);
            UpdateStatus(lblStatusWinSCP, winscp);
            UpdateStatus(lblStatusChrome, chrome);
            UpdateStatus(lblStatusPython, python);

            // BYPASS LOGIC: If everything is installed, auto-close with OK
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

            // Check manually if we can close now
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