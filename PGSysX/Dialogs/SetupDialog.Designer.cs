namespace PGSysX.Anahaw
{
    partial class SetupDialog
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
            this.lblStore = new System.Windows.Forms.Label();
            this.cmbStores = new System.Windows.Forms.ComboBox();
            this.lblEjUser = new System.Windows.Forms.Label();
            this.txtEjUser = new System.Windows.Forms.TextBox();
            this.lblEjPass = new System.Windows.Forms.Label();
            this.txtEjPass = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.groupBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Location = new System.Drawing.Point(25, 25);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(69, 13);
            this.lblStore.TabIndex = 0;
            this.lblStore.Text = "Select Store:";
            // 
            // cmbStores
            // 
            this.cmbStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStores.FormattingEnabled = true;
            this.cmbStores.Location = new System.Drawing.Point(28, 45);
            this.cmbStores.Name = "cmbStores";
            this.cmbStores.Size = new System.Drawing.Size(320, 21);
            this.cmbStores.TabIndex = 1;
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.txtEjPass);
            this.groupBoxDetails.Controls.Add(this.lblEjPass);
            this.groupBoxDetails.Controls.Add(this.txtEjUser);
            this.groupBoxDetails.Controls.Add(this.lblEjUser);
            this.groupBoxDetails.Location = new System.Drawing.Point(28, 85);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(320, 130);
            this.groupBoxDetails.TabIndex = 2;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Anahaw EJ Report Credentials";
            // 
            // lblEjUser
            // 
            this.lblEjUser.AutoSize = true;
            this.lblEjUser.Location = new System.Drawing.Point(15, 30);
            this.lblEjUser.Name = "lblEjUser";
            this.lblEjUser.Size = new System.Drawing.Size(32, 13);
            this.lblEjUser.TabIndex = 0;
            this.lblEjUser.Text = "User:";
            // 
            // txtEjUser
            // 
            this.txtEjUser.Location = new System.Drawing.Point(18, 48);
            this.txtEjUser.Name = "txtEjUser";
            this.txtEjUser.Size = new System.Drawing.Size(280, 20);
            this.txtEjUser.TabIndex = 1;
            // 
            // lblEjPass
            // 
            this.lblEjPass.AutoSize = true;
            this.lblEjPass.Location = new System.Drawing.Point(15, 75);
            this.lblEjPass.Name = "lblEjPass";
            this.lblEjPass.Size = new System.Drawing.Size(56, 13);
            this.lblEjPass.TabIndex = 2;
            this.lblEjPass.Text = "Password:";
            // 
            // txtEjPass
            // 
            this.txtEjPass.Location = new System.Drawing.Point(18, 93);
            this.txtEjPass.Name = "txtEjPass";
            this.txtEjPass.PasswordChar = '*';
            this.txtEjPass.Size = new System.Drawing.Size(280, 20);
            this.txtEjPass.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(28, 235);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(320, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Generate Configuration";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SetupDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 291);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.cmbStores);
            this.Controls.Add(this.lblStore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First Run Setup";
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.ComboBox cmbStores;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Label lblEjUser;
        private System.Windows.Forms.TextBox txtEjUser;
        private System.Windows.Forms.Label lblEjPass;
        private System.Windows.Forms.TextBox txtEjPass;
        private System.Windows.Forms.Button btnSave;
    }
}