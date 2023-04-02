namespace PlanetFormsApp
{
    partial class FidanForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.isiAl = new System.Windows.Forms.Button();
            this.txtis = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 150);
            this.dataGridView1.TabIndex = 0;
//            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // isiAl
            // 
            this.isiAl.Location = new System.Drawing.Point(694, 12);
            this.isiAl.Name = "isiAl";
            this.isiAl.Size = new System.Drawing.Size(119, 55);
            this.isiAl.TabIndex = 1;
            this.isiAl.Text = "İşi Al";
            this.isiAl.UseVisualStyleBackColor = true;
            this.isiAl.Click += new System.EventHandler(this.isiAl_Click);
            // 
            // txtis
            // 
            this.txtis.Location = new System.Drawing.Point(694, 73);
            this.txtis.Name = "txtis";
            this.txtis.Size = new System.Drawing.Size(119, 20);
            this.txtis.TabIndex = 2;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(694, 99);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(119, 20);
            this.txtid.TabIndex = 3;
            // 
            // FidanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 326);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtis);
            this.Controls.Add(this.isiAl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FidanForm";
            this.Text = "FidanForm";
            this.Load += new System.EventHandler(this.FidanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button isiAl;
        private System.Windows.Forms.TextBox txtis;
        private System.Windows.Forms.TextBox txtid;
    }
}