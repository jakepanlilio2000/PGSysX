namespace PGSysX.Anahaw
{
    partial class Anahaw
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonManager = new Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanelMain = new Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();

            // --- Groups ---
            this.groupTerminal = new Krypton.Toolkit.KryptonHeaderGroup();
            this.groupWeb = new Krypton.Toolkit.KryptonHeaderGroup();
            this.groupFiles = new Krypton.Toolkit.KryptonHeaderGroup();

            // --- Buttons: Terminal ---
            this.btnPricelist = new Krypton.Toolkit.KryptonButton();
            this.btnBIR = new Krypton.Toolkit.KryptonButton();
            this.dropStoreScripts = new Krypton.Toolkit.KryptonDropButton();
            this.ctxStoreScripts = new Krypton.Toolkit.KryptonContextMenu();

            // --- Buttons: Web ---
            this.btnEJ = new Krypton.Toolkit.KryptonButton();
            this.btnPCA = new Krypton.Toolkit.KryptonButton();
            this.btnTPLinux = new Krypton.Toolkit.KryptonButton();
            this.btnAMAX = new Krypton.Toolkit.KryptonButton();

            // --- Buttons: Files ---
            this.btnGetFiles = new Krypton.Toolkit.KryptonButton();
            this.btnUploadFiles = new Krypton.Toolkit.KryptonButton();
            this.btnRename = new Krypton.Toolkit.KryptonButton();

            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();

            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelMain)).BeginInit();
            this.kryptonPanelMain.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.groupTerminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTerminal.Panel)).BeginInit();
            this.groupTerminal.Panel.SuspendLayout();
            this.groupTerminal.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.groupWeb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWeb.Panel)).BeginInit();
            this.groupWeb.Panel.SuspendLayout();
            this.groupWeb.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.groupFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupFiles.Panel)).BeginInit();
            this.groupFiles.Panel.SuspendLayout();
            this.groupFiles.SuspendLayout();

            this.SuspendLayout();

            // 
            // kryptonManager
            // 
            this.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;

            // 
            // kryptonPanelMain
            // 
            this.kryptonPanelMain.Controls.Add(this.tableLayoutPanel);
            this.kryptonPanelMain.Controls.Add(this.statusStrip);
            this.kryptonPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelMain.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelMain.Name = "kryptonPanelMain";
            this.kryptonPanelMain.Size = new System.Drawing.Size(950, 550);
            this.kryptonPanelMain.TabIndex = 0;

            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel.Controls.Add(this.groupTerminal, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.groupWeb, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.groupFiles, 2, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(950, 528);
            this.tableLayoutPanel.TabIndex = 0;

            // 
            // --- GROUP 1: POS & TERMINAL (Left) ---
            // 
            this.groupTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTerminal.HeaderStylePrimary = Krypton.Toolkit.HeaderStyle.Secondary;
            this.groupTerminal.ValuesPrimary.Heading = "POS & Terminal Ops";
            this.groupTerminal.ValuesPrimary.Description = "SSH / Putty";
            this.groupTerminal.Panel.Padding = new System.Windows.Forms.Padding(10);

            // Layout Container for Buttons
            System.Windows.Forms.FlowLayoutPanel flowTerminal = new System.Windows.Forms.FlowLayoutPanel();
            flowTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            flowTerminal.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowTerminal.Controls.Add(this.btnPricelist);
            flowTerminal.Controls.Add(this.btnBIR);
            flowTerminal.Controls.Add(this.dropStoreScripts);
            this.groupTerminal.Panel.Controls.Add(flowTerminal);

            // Button 1: Pricelist
            ConfigureButton(this.btnPricelist, "1. Pricelist Update");

            // Button 2: BIR
            ConfigureButton(this.btnBIR, "2. BIR Report");

            // Button 10: Store Scripts (Drop Down)
            this.dropStoreScripts.Text = "10. Store Scripts";
            this.dropStoreScripts.Size = new System.Drawing.Size(260, 45);
            this.dropStoreScripts.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.dropStoreScripts.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.dropStoreScripts.KryptonContextMenu = this.ctxStoreScripts;

            // 
            // --- GROUP 2: WEB & MONITORING (Center) ---
            // 
            this.groupWeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupWeb.HeaderStylePrimary = Krypton.Toolkit.HeaderStyle.Secondary;
            this.groupWeb.ValuesPrimary.Heading = "Web Automation";
            this.groupWeb.ValuesPrimary.Description = "Selenium & Chrome";
            this.groupWeb.Panel.Padding = new System.Windows.Forms.Padding(10);

            System.Windows.Forms.FlowLayoutPanel flowWeb = new System.Windows.Forms.FlowLayoutPanel();
            flowWeb.Dock = System.Windows.Forms.DockStyle.Fill;
            flowWeb.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowWeb.Controls.Add(this.btnEJ);
            flowWeb.Controls.Add(this.btnAMAX);
            flowWeb.Controls.Add(this.btnPCA);
            flowWeb.Controls.Add(this.btnTPLinux);
            this.groupWeb.Panel.Controls.Add(flowWeb);

            // Buttons
            ConfigureButton(this.btnEJ, "3. EJ Consolidated Report");
            ConfigureButton(this.btnAMAX, "4. AMAX Shelftag (Link)");
            ConfigureButton(this.btnPCA, "5. PCA Monitoring");
            ConfigureButton(this.btnTPLinux, "6. TPLINUX Kiosk Check");

            // 
            // --- GROUP 3: DATA SYNC (Right) ---
            // 
            this.groupFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupFiles.HeaderStylePrimary = Krypton.Toolkit.HeaderStyle.Secondary;
            this.groupFiles.ValuesPrimary.Heading = "Data Synchronization";
            this.groupFiles.ValuesPrimary.Description = "WinSCP & Batch";
            this.groupFiles.Panel.Padding = new System.Windows.Forms.Padding(10);

            System.Windows.Forms.FlowLayoutPanel flowFiles = new System.Windows.Forms.FlowLayoutPanel();
            flowFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            flowFiles.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowFiles.Controls.Add(this.btnGetFiles);
            flowFiles.Controls.Add(this.btnRename);
            flowFiles.Controls.Add(this.btnUploadFiles);
            this.groupFiles.Panel.Controls.Add(flowFiles);

            // Buttons
            ConfigureButton(this.btnGetFiles, "7. Get Shelftag/SIS98");
            ConfigureButton(this.btnRename, "8. Rename Batch Files");
            ConfigureButton(this.btnUploadFiles, "9. Upload to HO");

            // 
            // Status Strip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblStatus });
            this.statusStrip.Location = new System.Drawing.Point(0, 528);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(950, 22);
            this.statusStrip.TabIndex = 1;
            this.lblStatus.Text = "System Ready";

            // 
            // Anahaw Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.kryptonPanelMain);
            this.Name = "Anahaw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PGSysX: Anahaw Control Center";

            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelMain)).EndInit();
            this.kryptonPanelMain.ResumeLayout(false);
            this.kryptonPanelMain.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(this.groupTerminal.Panel)).EndInit();
            this.groupTerminal.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupTerminal)).EndInit();
            this.groupTerminal.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(this.groupWeb.Panel)).EndInit();
            this.groupWeb.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupWeb)).EndInit();
            this.groupWeb.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(this.groupFiles.Panel)).EndInit();
            this.groupFiles.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupFiles)).EndInit();
            this.groupFiles.ResumeLayout(false);

            this.ResumeLayout(false);
        }

        private void ConfigureButton(Krypton.Toolkit.KryptonButton btn, string text)
        {
            btn.Text = text;
            btn.Size = new System.Drawing.Size(260, 45);
            btn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
        }

        #endregion

        private Krypton.Toolkit.KryptonManager kryptonManager;
        private Krypton.Toolkit.KryptonPanel kryptonPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;

        private Krypton.Toolkit.KryptonHeaderGroup groupTerminal;
        private Krypton.Toolkit.KryptonHeaderGroup groupWeb;
        private Krypton.Toolkit.KryptonHeaderGroup groupFiles;

        // Controls
        private Krypton.Toolkit.KryptonButton btnPricelist;
        private Krypton.Toolkit.KryptonButton btnBIR;
        private Krypton.Toolkit.KryptonDropButton dropStoreScripts;
        private Krypton.Toolkit.KryptonContextMenu ctxStoreScripts;

        private Krypton.Toolkit.KryptonButton btnEJ;
        private Krypton.Toolkit.KryptonButton btnPCA;
        private Krypton.Toolkit.KryptonButton btnTPLinux;
        private Krypton.Toolkit.KryptonButton btnAMAX;

        private Krypton.Toolkit.KryptonButton btnGetFiles;
        private Krypton.Toolkit.KryptonButton btnUploadFiles;
        private Krypton.Toolkit.KryptonButton btnRename;
    }
}