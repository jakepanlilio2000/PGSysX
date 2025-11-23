namespace PGSysX.Anahaw
{
    partial class PrereqDialog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lnkPutty = new System.Windows.Forms.LinkLabel();
            this.lnkWinSCP = new System.Windows.Forms.LinkLabel();
            this.lnkChrome = new System.Windows.Forms.LinkLabel();
            this.lnkPython = new System.Windows.Forms.LinkLabel();
            this.lblStatusPutty = new System.Windows.Forms.Label();
            this.lblStatusWinSCP = new System.Windows.Forms.Label();
            this.lblStatusChrome = new System.Windows.Forms.Label();
            this.lblStatusPython = new System.Windows.Forms.Label();
            this.btnRecheck = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblHeader
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(20, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(400, 30);
            this.lblHeader.Text = "Missing Dependencies Detected";

            // lblInstruction
            this.lblInstruction.Location = new System.Drawing.Point(23, 50);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(380, 40);
            this.lblInstruction.Text = "You must be connected to the internet and download these prerequisites before proceeding.";

            // LINK: Putty
            this.lnkPutty.AutoSize = true;
            this.lnkPutty.Location = new System.Drawing.Point(25, 100);
            this.lnkPutty.TabStop = true;
            this.lnkPutty.Text = "1. Download Putty (Latest)";
            this.lnkPutty.LinkClicked += (s, e) => System.Diagnostics.Process.Start("https://www.chiark.greenend.org.uk/~sgtatham/putty/latest.html");

            this.lblStatusPutty.AutoSize = true;
            this.lblStatusPutty.Location = new System.Drawing.Point(250, 100);
            this.lblStatusPutty.ForeColor = System.Drawing.Color.Red;
            this.lblStatusPutty.Text = "Missing";

            // LINK: WinSCP
            this.lnkWinSCP.AutoSize = true;
            this.lnkWinSCP.Location = new System.Drawing.Point(25, 130);
            this.lnkWinSCP.TabStop = true;
            this.lnkWinSCP.Text = "2. Download WinSCP (Latest)";
            this.lnkWinSCP.LinkClicked += (s, e) => System.Diagnostics.Process.Start("https://winscp.net/eng/download.php");

            this.lblStatusWinSCP.AutoSize = true;
            this.lblStatusWinSCP.Location = new System.Drawing.Point(250, 130);
            this.lblStatusWinSCP.ForeColor = System.Drawing.Color.Red;
            this.lblStatusWinSCP.Text = "Missing";

            // LINK: ChromeDriver
            this.lnkChrome.AutoSize = true;
            this.lnkChrome.Location = new System.Drawing.Point(25, 160);
            this.lnkChrome.TabStop = true;
            this.lnkChrome.Text = "3. Download ChromeDriver (Match Chrome Version)";
            this.lnkChrome.LinkClicked += (s, e) => System.Diagnostics.Process.Start("https://googlechromelabs.github.io/chrome-for-testing/");

            this.lblStatusChrome.AutoSize = true;
            this.lblStatusChrome.Location = new System.Drawing.Point(250, 160);
            this.lblStatusChrome.ForeColor = System.Drawing.Color.Red;
            this.lblStatusChrome.Text = "Missing (Place in App Folder)";

            // LINK: Python
            this.lnkPython.AutoSize = true;
            this.lnkPython.Location = new System.Drawing.Point(25, 190);
            this.lnkPython.TabStop = true;
            this.lnkPython.Text = "4. Download Python (Install 'pip install selenium' after)";
            this.lnkPython.LinkClicked += (s, e) => System.Diagnostics.Process.Start("https://www.python.org/downloads/");

            this.lblStatusPython.AutoSize = true;
            this.lblStatusPython.Location = new System.Drawing.Point(250, 190);
            this.lblStatusPython.ForeColor = System.Drawing.Color.Red;
            this.lblStatusPython.Text = "Missing";

            // Button
            this.btnRecheck.Location = new System.Drawing.Point(28, 230);
            this.btnRecheck.Size = new System.Drawing.Size(350, 35);
            this.btnRecheck.Text = "I have installed them, Continue";
            this.btnRecheck.Click += new System.EventHandler(this.btnRecheck_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(420, 290);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lnkPutty);
            this.Controls.Add(this.lblStatusPutty);
            this.Controls.Add(this.lnkWinSCP);
            this.Controls.Add(this.lblStatusWinSCP);
            this.Controls.Add(this.lnkChrome);
            this.Controls.Add(this.lblStatusChrome);
            this.Controls.Add(this.lnkPython);
            this.Controls.Add(this.lblStatusPython);
            this.Controls.Add(this.btnRecheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Requirements";
        }

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.LinkLabel lnkPutty;
        private System.Windows.Forms.Label lblStatusPutty;
        private System.Windows.Forms.LinkLabel lnkWinSCP;
        private System.Windows.Forms.Label lblStatusWinSCP;
        private System.Windows.Forms.LinkLabel lnkChrome;
        private System.Windows.Forms.Label lblStatusChrome;
        private System.Windows.Forms.LinkLabel lnkPython;
        private System.Windows.Forms.Label lblStatusPython;
        private System.Windows.Forms.Button btnRecheck;
    }
}