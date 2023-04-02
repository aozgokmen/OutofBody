namespace PlanetFormsApp
{
    partial class BagisForm
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
            this.btnBagisOnayla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBitki = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLokasyon = new System.Windows.Forms.ComboBox();
            this.txtbagis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbciftci = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBagisOnayla
            // 
            this.btnBagisOnayla.Location = new System.Drawing.Point(57, 175);
            this.btnBagisOnayla.Name = "btnBagisOnayla";
            this.btnBagisOnayla.Size = new System.Drawing.Size(153, 38);
            this.btnBagisOnayla.TabIndex = 18;
            this.btnBagisOnayla.Text = "Bağışı Onayla";
            this.btnBagisOnayla.UseVisualStyleBackColor = true;
            this.btnBagisOnayla.Click += new System.EventHandler(this.btnBagisOnayla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Bağış";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Bitki";
            // 
            // cmbBitki
            // 
            this.cmbBitki.FormattingEnabled = true;
            this.cmbBitki.Location = new System.Drawing.Point(110, 103);
            this.cmbBitki.Name = "cmbBitki";
            this.cmbBitki.Size = new System.Drawing.Size(121, 21);
            this.cmbBitki.TabIndex = 14;
            this.cmbBitki.SelectedIndexChanged += new System.EventHandler(this.cmbBitki_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kategoriler";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(110, 49);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 21);
            this.cmbKategori.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lokasyon Bilgisi";
            // 
            // cmbLokasyon
            // 
            this.cmbLokasyon.FormattingEnabled = true;
            this.cmbLokasyon.Location = new System.Drawing.Point(110, 22);
            this.cmbLokasyon.Name = "cmbLokasyon";
            this.cmbLokasyon.Size = new System.Drawing.Size(121, 21);
            this.cmbLokasyon.TabIndex = 10;
            // 
            // txtbagis
            // 
            this.txtbagis.Location = new System.Drawing.Point(110, 130);
            this.txtbagis.Name = "txtbagis";
            this.txtbagis.ReadOnly = true;
            this.txtbagis.Size = new System.Drawing.Size(121, 20);
            this.txtbagis.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Çiftci";
            // 
            // cmbciftci
            // 
            this.cmbciftci.FormattingEnabled = true;
            this.cmbciftci.Location = new System.Drawing.Point(110, 76);
            this.cmbciftci.Name = "cmbciftci";
            this.cmbciftci.Size = new System.Drawing.Size(121, 21);
            this.cmbciftci.TabIndex = 20;
            // 
            // BagisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 249);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbciftci);
            this.Controls.Add(this.txtbagis);
            this.Controls.Add(this.btnBagisOnayla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBitki);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLokasyon);
            this.Name = "BagisForm";
            this.Text = "BagisForm";
            this.Load += new System.EventHandler(this.BagisForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBagisOnayla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBitki;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLokasyon;
        private System.Windows.Forms.TextBox txtbagis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbciftci;
    }
}