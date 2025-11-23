using System;
using System.Windows.Forms;
using PGSysX.Anahaw;

namespace PGSysX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAnahaw_Click(object sender, EventArgs e)
        {
            // 1. Hide the Main Menu
            this.Hide();

            // 2. Open Anahaw
            // If config.ini is missing, Anahaw will automatically trigger SetupDialog 
            // because of the code we put in Anahaw.cs "OnLoad"
            using (Anahaw.Anahaw frm = new Anahaw.Anahaw())
            {
                frm.ShowDialog();
            }

            // 3. When Anahaw closes (or if Setup is cancelled), show Main Menu again
            this.Show();
        }
    }
}