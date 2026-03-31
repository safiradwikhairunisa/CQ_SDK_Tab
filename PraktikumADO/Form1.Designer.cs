namespace PraktikumADO
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnHitungMhs = new System.Windows.Forms.Button();
            this.btnHitungMK = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.btnInsertProdi = new System.Windows.Forms.Button();
            this.btnUpdateSKS = new System.Windows.Forms.Button();
            this.btnHitungDosen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasil";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(123, 248);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnHitungMhs
            // 
            this.btnHitungMhs.Location = new System.Drawing.Point(239, 247);
            this.btnHitungMhs.Name = "btnHitungMhs";
            this.btnHitungMhs.Size = new System.Drawing.Size(110, 23);
            this.btnHitungMhs.TabIndex = 2;
            this.btnHitungMhs.Text = "Hitung Mhs";
            this.btnHitungMhs.UseVisualStyleBackColor = true;
            this.btnHitungMhs.Click += new System.EventHandler(this.btnHitungMhs_Click);
            // 
            // btnHitungMK
            // 
            this.btnHitungMK.Location = new System.Drawing.Point(389, 247);
            this.btnHitungMK.Name = "btnHitungMK";
            this.btnHitungMK.Size = new System.Drawing.Size(75, 23);
            this.btnHitungMK.TabIndex = 3;
            this.btnHitungMK.Text = "Hitung MK";
            this.btnHitungMK.UseVisualStyleBackColor = true;
            this.btnHitungMK.Click += new System.EventHandler(this.btnHitungMK_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(528, 247);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(202, 137);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(391, 22);
            this.txtHasil.TabIndex = 5;
            // 
            // btnInsertProdi
            // 
            this.btnInsertProdi.Location = new System.Drawing.Point(202, 293);
            this.btnInsertProdi.Name = "btnInsertProdi";
            this.btnInsertProdi.Size = new System.Drawing.Size(75, 23);
            this.btnInsertProdi.TabIndex = 6;
            this.btnInsertProdi.Text = "Prodi";
            this.btnInsertProdi.UseVisualStyleBackColor = true;
            this.btnInsertProdi.Click += new System.EventHandler(this.btnInsertProdi_Click);
            // 
            // btnUpdateSKS
            // 
            this.btnUpdateSKS.Location = new System.Drawing.Point(320, 292);
            this.btnUpdateSKS.Name = "btnUpdateSKS";
            this.btnUpdateSKS.Size = new System.Drawing.Size(98, 23);
            this.btnUpdateSKS.TabIndex = 7;
            this.btnUpdateSKS.Text = "Update SKS";
            this.btnUpdateSKS.UseVisualStyleBackColor = true;
            this.btnUpdateSKS.Click += new System.EventHandler(this.btnUpdateSKS_Click);
            // 
            // btnHitungDosen
            // 
            this.btnHitungDosen.Location = new System.Drawing.Point(455, 292);
            this.btnHitungDosen.Name = "btnHitungDosen";
            this.btnHitungDosen.Size = new System.Drawing.Size(104, 23);
            this.btnHitungDosen.TabIndex = 8;
            this.btnHitungDosen.Text = "Hitung Dosen";
            this.btnHitungDosen.UseVisualStyleBackColor = true;
            this.btnHitungDosen.Click += new System.EventHandler(this.btnHitungDosen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHitungDosen);
            this.Controls.Add(this.btnUpdateSKS);
            this.Controls.Add(this.btnInsertProdi);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnHitungMK);
            this.Controls.Add(this.btnHitungMhs);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnHitungMhs;
        private System.Windows.Forms.Button btnHitungMK;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button btnInsertProdi;
        private System.Windows.Forms.Button btnUpdateSKS;
        private System.Windows.Forms.Button btnHitungDosen;
    }
}

