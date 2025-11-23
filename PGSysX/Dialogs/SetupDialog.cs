using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PGSysX.Anahaw
{
    public partial class SetupDialog : Form
    {
        public SetupDialog()
        {
            InitializeComponent();
            LoadStores();
        }

        private void LoadStores()
        {
            cmbStores.DataSource = StoreRepository.Stores;
            cmbStores.DisplayMember = "Name"; // Shows "SF1", "MASANTOL"
            cmbStores.ValueMember = "Code";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StoreInfo selectedStore = cmbStores.SelectedItem as StoreInfo;

            if (selectedStore == null)
            {
                MessageBox.Show("Please select a store.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                GenerateConfig(selectedStore);
                MessageBox.Show("Configuration saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save config: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateConfig(StoreInfo store)
        {
            StringBuilder sb = new StringBuilder();

            // [Global]
            sb.AppendLine("[Global]");
            sb.AppendLine($"storeid = {store.Code}");
            sb.AppendLine(@"sod_directory = C:\Users\Administrator\Desktop\SOD");
            sb.AppendLine(@"winscp_path = C:\Program Files (x86)\WinSCP\WinSCP.com");
            sb.AppendLine();

            // [SSH_Server]
            // Note: Python script implies Host is the Couch IP without port
            sb.AppendLine("[SSH_Server]");
            sb.AppendLine($"host = {StoreRepository.GetIpOnly(store.CouchHost)}");
            sb.AppendLine($"user = {store.PuttyUser}");
            sb.AppendLine($"pass = {store.PuttyPass}");
            sb.AppendLine();

            // [Anahaw_EJ_Report] - From User Input
            sb.AppendLine("[Anahaw_EJ_Report]");
            sb.AppendLine($"user = {txtEjUser.Text.Trim()}");
            sb.AppendLine($"pass = {txtEjPass.Text.Trim()}");
            sb.AppendLine();

            // [Monitoring_DB]
            sb.AppendLine("[Monitoring_DB]");
            sb.AppendLine($"ip = {StoreRepository.GetIpOnly(store.MonitoringIP)}");
            sb.AppendLine();

            // [TPLinux]
            sb.AppendLine("[TPLinux]");
            sb.AppendLine($"ip = {StoreRepository.GetIpOnly(store.TPLinuxIP)}");
            sb.AppendLine();

            // [FTP] - Hardcoded from Python script
            sb.AppendLine("[FTP]");
            sb.AppendLine("server = 192.168.200.177");
            sb.AppendLine("password = pw@1234");
            sb.AppendLine("usernames = puregold/ftp11, puregold/ftp12, puregold/ftp1a, puregold/ftp1b, puregold/ftp1c");

            // Write to file
            File.WriteAllText("config.ini", sb.ToString(), Encoding.UTF8);
        }
    }
}