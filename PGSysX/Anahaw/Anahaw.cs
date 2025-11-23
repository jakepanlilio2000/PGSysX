using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using Krypton.Toolkit;

namespace PGSysX.Anahaw
{
    public partial class Anahaw : KryptonForm
    {
        private string _storeCode = "";
        private string _storeName = "";
        private bool _isLoaded = false;

        public Anahaw()
        {
            InitializeComponent();
            // Start invisible to prevent flickering while we check prereqs
            this.Opacity = 0;
        }

        // CHANGED: Use Shown instead of OnLoad
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (!_isLoaded)
            {
                PerformStartupChecks();
                _isLoaded = true;
            }
        }

        private void PerformStartupChecks()
        {
            // 1. Check Configuration
            if (!File.Exists("config.ini"))
            {
                using (SetupDialog setup = new SetupDialog())
                {
                    if (setup.ShowDialog() != DialogResult.OK)
                    {
                        this.Close(); // Go back to Form1
                        return;
                    }
                }
            }

            // 2. Check Prerequisites
            using (PrereqDialog prereq = new PrereqDialog())
            {
                if (prereq.ShowDialog() != DialogResult.OK)
                {
                    this.Close(); // Go back to Form1
                    return;
                }
            }

            // 3. If we passed everything, Load Data and Show Form
            LoadConfigInfo();
            InitializeEvents();
            InitializeDropdown();

            // Fade in or instant show
            this.Opacity = 1.0;
            this.BringToFront();
        }

        private void LoadConfigInfo()
        {
            try
            {
                string[] lines = File.ReadAllLines("config.ini");
                foreach (var line in lines)
                {
                    if (line.ToLower().StartsWith("storeid"))
                        _storeCode = line.Split('=')[1].Trim();
                }

                var store = StoreRepository.Stores.Find(s => s.Code == _storeCode);
                if (store != null) _storeName = store.Name;

                this.Text = $"PGSysX: Anahaw - {_storeName} ({_storeCode})";
                lblStatus.Text = $"Connected to Store: {_storeName}";
            }
            catch
            {
                lblStatus.Text = "Config Error";
            }
        }

        private void InitializeEvents()
        {
            // Terminal
            btnPricelist.Click += (s, e) => RunTask("Pricelist Update", () => { /* Putty Logic */ });
            btnBIR.Click += (s, e) => RunTask("BIR Report", () => { /* Putty Logic */ });

            // Web
            btnEJ.Click += (s, e) => RunTask("EJ Consolidated", () => { /* Selenium Logic */ });
            btnPCA.Click += (s, e) => RunTask("PCA Monitoring", () => { /* Selenium Logic */ });
            btnTPLinux.Click += (s, e) => RunTask("TPLinux Check", () => { /* Selenium Logic */ });
            btnAMAX.Click += (s, e) => Process.Start("http://192.92.1.100/amax");

            // Files
            btnGetFiles.Click += (s, e) => RunTask("Downloading Files", () => { /* WinSCP Logic */ });
            btnRename.Click += (s, e) => RunTask("Renaming Files", () => { /* Batch Logic */ });
            btnUploadFiles.Click += (s, e) => RunTask("Uploading Files", () => { /* WinSCP Logic */ });
        }

        private void InitializeDropdown()
        {
            KryptonContextMenuItems items = new KryptonContextMenuItems();
            ctxStoreScripts.Items.Add(items);

            AddMenuItem(items, "Restart Spooler", () => MessageBox.Show("Spooler Restarted"));
            AddMenuItem(items, "Delete Old Logs", () => MessageBox.Show("Logs Deleted"));
            AddMenuItem(items, "Ping Main Server", () => MessageBox.Show("Ping Success"));
        }

        private void AddMenuItem(KryptonContextMenuItems parent, string text, Action action)
        {
            KryptonContextMenuItem item = new KryptonContextMenuItem(text);
            item.Click += (s, e) => action.Invoke();
            parent.Items.Add(item);
        }

        private void RunTask(string taskName, Action action)
        {
            lblStatus.Text = $"Running: {taskName}...";
            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            try
            {
                action.Invoke();
                lblStatus.Text = $"Completed: {taskName}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error executing {taskName}:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Error Occurred";
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}