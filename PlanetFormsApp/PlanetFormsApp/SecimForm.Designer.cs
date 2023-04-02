namespace PlanetFormsApp
{
    partial class SecimForm
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
            this.btnbagis = new System.Windows.Forms.Button();
            this.btnfidan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbagis
            // 
            this.btnbagis.Location = new System.Drawing.Point(92, 50);
            this.btnbagis.Name = "btnbagis";
            this.btnbagis.Size = new System.Drawing.Size(153, 81);
            this.btnbagis.TabIndex = 0;
            this.btnbagis.Text = "Bağış Yapma";
            this.btnbagis.UseVisualStyleBackColor = true;
            this.btnbagis.Click += new System.EventHandler(this.btnbagis_Click);
            // 
            // btnfidan
            // 
            this.btnfidan.Location = new System.Drawing.Point(261, 50);
            this.btnfidan.Name = "btnfidan";
            this.btnfidan.Size = new System.Drawing.Size(150, 81);
            this.btnfidan.TabIndex = 1;
            this.btnfidan.Text = "Fidan Ekme";
            this.btnfidan.UseVisualStyleBackColor = true;
            this.btnfidan.Click += new System.EventHandler(this.btnfidan_Click);
            // 
            // SecimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 182);
            this.Controls.Add(this.btnfidan);
            this.Controls.Add(this.btnbagis);
            this.Name = "SecimForm";
            this.Text = "SecimForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbagis;
        private System.Windows.Forms.Button btnfidan;
    }
}