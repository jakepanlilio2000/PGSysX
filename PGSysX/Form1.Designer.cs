namespace PGSysX
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnPurePOS = new Krypton.Toolkit.KryptonButton();
            this.BtnAnahaw = new Krypton.Toolkit.KryptonButton();
            this.Lblntro = new Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // BtnPurePOS
            // 
            this.BtnPurePOS.Location = new System.Drawing.Point(76, 69);
            this.BtnPurePOS.Name = "BtnPurePOS";
            this.BtnPurePOS.Size = new System.Drawing.Size(90, 25);
            this.BtnPurePOS.TabIndex = 0;
            this.BtnPurePOS.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.BtnPurePOS.Values.Text = "PurePOS";
            // 
            // BtnAnahaw
            // 
            this.BtnAnahaw.Location = new System.Drawing.Point(76, 38);
            this.BtnAnahaw.Name = "BtnAnahaw";
            this.BtnAnahaw.Size = new System.Drawing.Size(90, 25);
            this.BtnAnahaw.TabIndex = 1;
            this.BtnAnahaw.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.BtnAnahaw.Values.Text = "Anahaw";
            this.BtnAnahaw.Click += new System.EventHandler(this.BtnAnahaw_Click);
            // 
            // Lblntro
            // 
            this.Lblntro.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.Lblntro.Location = new System.Drawing.Point(53, 12);
            this.Lblntro.Name = "Lblntro";
            this.Lblntro.Size = new System.Drawing.Size(130, 20);
            this.Lblntro.TabIndex = 2;
            this.Lblntro.Values.Text = "Choose your PG POS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 122);
            this.Controls.Add(this.Lblntro);
            this.Controls.Add(this.BtnAnahaw);
            this.Controls.Add(this.BtnPurePOS);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PGSysX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton BtnPurePOS;
        private Krypton.Toolkit.KryptonButton BtnAnahaw;
        private Krypton.Toolkit.KryptonLabel Lblntro;
    }
}

