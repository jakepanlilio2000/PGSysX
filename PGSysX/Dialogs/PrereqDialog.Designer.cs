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
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(20, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(400, 30);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Missing Dependencies Detected";
            // 
            // lblInstruction
            // 
            this.lblInstruction.Location = new System.Drawing.Point(23, 50);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(456, 40);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "You must be connected to the internet and download these prerequisites before pro" +
    "ceeding.";
            // 
            // lnkPutty
            // 
            this.lnkPutty.AutoSize = true;
            this.lnkPutty.Location = new System.Drawing.Point(25, 100);
            this.lnkPutty.Name = "lnkPutty";
            this.lnkPutty.Size = new System.Drawing.Size(132, 13);
            this.lnkPutty.TabIndex = 2;
            this.lnkPutty.TabStop = true;
            this.lnkPutty.Text = "1. Download Putty (Latest)";
            // 
            // lnkWinSCP
            // 
            this.lnkWinSCP.AutoSize = true;
            this.lnkWinSCP.Location = new System.Drawing.Point(25, 130);
            this.lnkWinSCP.Name = "lnkWinSCP";
            this.lnkWinSCP.Size = new System.Drawing.Size(148, 13);
            this.lnkWinSCP.TabIndex = 4;
            this.lnkWinSCP.TabStop = true;
            this.lnkWinSCP.Text = "2. Download WinSCP (Latest)";
            // 
            // lnkChrome
            // 
            this.lnkChrome.AutoSize = true;
            this.lnkChrome.Location = new System.Drawing.Point(25, 160);
            this.lnkChrome.Name = "lnkChrome";
            this.lnkChrome.Size = new System.Drawing.Size(250, 13);
            this.lnkChrome.TabIndex = 6;
            this.lnkChrome.TabStop = true;
            this.lnkChrome.Text = "3. Download ChromeDriver (Match Chrome Version)";
            // 
            // lnkPython
            // 
            this.lnkPython.AutoSize = true;
            this.lnkPython.Location = new System.Drawing.Point(25, 190);
            this.lnkPython.Name = "lnkPython";
            this.lnkPython.Size = new System.Drawing.Size(257, 13);
            this.lnkPython.TabIndex = 8;
            this.lnkPython.TabStop = true;
            this.lnkPython.Text = "4. Download Python (Install \'pip install selenium\' after)";
            // 
            // lblStatusPutty
            // 
            this.lblStatusPutty.AutoSize = true;
            this.lblStatusPutty.ForeColor = System.Drawing.Color.Red;
            this.lblStatusPutty.Location = new System.Drawing.Point(336, 100);
            this.lblStatusPutty.Name = "lblStatusPutty";
            this.lblStatusPutty.Size = new System.Drawing.Size(42, 13);
            this.lblStatusPutty.TabIndex = 3;
            this.lblStatusPutty.Text = "Missing";
            // 
            // lblStatusWinSCP
            // 
            this.lblStatusWinSCP.AutoSize = true;
            this.lblStatusWinSCP.ForeColor = System.Drawing.Color.Red;
            this.lblStatusWinSCP.Location = new System.Drawing.Point(336, 130);
            this.lblStatusWinSCP.Name = "lblStatusWinSCP";
            this.lblStatusWinSCP.Size = new System.Drawing.Size(42, 13);
            this.lblStatusWinSCP.TabIndex = 5;
            this.lblStatusWinSCP.Text = "Missing";
            // 
            // lblStatusChrome
            // 
            this.lblStatusChrome.AutoSize = true;
            this.lblStatusChrome.ForeColor = System.Drawing.Color.Red;
            this.lblStatusChrome.Location = new System.Drawing.Point(336, 160);
            this.lblStatusChrome.Name = "lblStatusChrome";
            this.lblStatusChrome.Size = new System.Drawing.Size(143, 13);
            this.lblStatusChrome.TabIndex = 7;
            this.lblStatusChrome.Text = "Missing (Place in App Folder)";
            // 
            // lblStatusPython
            // 
            this.lblStatusPython.AutoSize = true;
            this.lblStatusPython.ForeColor = System.Drawing.Color.Red;
            this.lblStatusPython.Location = new System.Drawing.Point(336, 190);
            this.lblStatusPython.Name = "lblStatusPython";
            this.lblStatusPython.Size = new System.Drawing.Size(42, 13);
            this.lblStatusPython.TabIndex = 9;
            this.lblStatusPython.Text = "Missing";
            // 
            // btnRecheck
            // 
            this.btnRecheck.Location = new System.Drawing.Point(28, 230);
            this.btnRecheck.Name = "btnRecheck";
            this.btnRecheck.Size = new System.Drawing.Size(483, 35);
            this.btnRecheck.TabIndex = 10;
            this.btnRecheck.Text = "I have installed them, Continue";
            this.btnRecheck.Click += new System.EventHandler(this.btnRecheck_Click);
            // 
            // PrereqDialog
            // 
            this.ClientSize = new System.Drawing.Size(534, 290);
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
            this.Name = "PrereqDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Requirements";
            this.ResumeLayout(false);
            this.PerformLayout();

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