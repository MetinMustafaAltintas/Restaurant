namespace Restaurant
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
            this.btnCiro = new System.Windows.Forms.Button();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.cmbIcecek = new System.Windows.Forms.ComboBox();
            this.cmbTatli = new System.Windows.Forms.ComboBox();
            this.cmbAraSicak = new System.Windows.Forms.ComboBox();
            this.cmbAnaYemek = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMasaNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCiro
            // 
            this.btnCiro.AutoSize = true;
            this.btnCiro.BackColor = System.Drawing.Color.Red;
            this.btnCiro.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCiro.Location = new System.Drawing.Point(134, 288);
            this.btnCiro.Name = "btnCiro";
            this.btnCiro.Size = new System.Drawing.Size(75, 43);
            this.btnCiro.TabIndex = 16;
            this.btnCiro.Text = "Ciro";
            this.btnCiro.UseVisualStyleBackColor = false;
            this.btnCiro.Click += new System.EventHandler(this.btnCiro_Click);
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.BackColor = System.Drawing.Color.Lime;
            this.btnSiparisVer.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparisVer.Location = new System.Drawing.Point(10, 289);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(92, 41);
            this.btnSiparisVer.TabIndex = 17;
            this.btnSiparisVer.Text = "Siparis Ver";
            this.btnSiparisVer.UseVisualStyleBackColor = false;
            this.btnSiparisVer.Click += new System.EventHandler(this.btnSiparisVer_Click);
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.Location = new System.Drawing.Point(215, 12);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(691, 316);
            this.lstSiparisler.TabIndex = 15;
            // 
            // cmbIcecek
            // 
            this.cmbIcecek.FormattingEnabled = true;
            this.cmbIcecek.Location = new System.Drawing.Point(10, 251);
            this.cmbIcecek.Margin = new System.Windows.Forms.Padding(4);
            this.cmbIcecek.Name = "cmbIcecek";
            this.cmbIcecek.Size = new System.Drawing.Size(150, 21);
            this.cmbIcecek.TabIndex = 11;
            // 
            // cmbTatli
            // 
            this.cmbTatli.FormattingEnabled = true;
            this.cmbTatli.Location = new System.Drawing.Point(10, 198);
            this.cmbTatli.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTatli.Name = "cmbTatli";
            this.cmbTatli.Size = new System.Drawing.Size(150, 21);
            this.cmbTatli.TabIndex = 12;
            // 
            // cmbAraSicak
            // 
            this.cmbAraSicak.FormattingEnabled = true;
            this.cmbAraSicak.Location = new System.Drawing.Point(10, 145);
            this.cmbAraSicak.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAraSicak.Name = "cmbAraSicak";
            this.cmbAraSicak.Size = new System.Drawing.Size(151, 21);
            this.cmbAraSicak.TabIndex = 13;
            // 
            // cmbAnaYemek
            // 
            this.cmbAnaYemek.FormattingEnabled = true;
            this.cmbAnaYemek.Location = new System.Drawing.Point(11, 92);
            this.cmbAnaYemek.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAnaYemek.Name = "cmbAnaYemek";
            this.cmbAnaYemek.Size = new System.Drawing.Size(150, 21);
            this.cmbAnaYemek.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tatlı Seçiniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "İçecek Seçiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ara Sıcak Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ana Yemek Seçiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Masa No Giriniz";
            // 
            // txtMasaNo
            // 
            this.txtMasaNo.Location = new System.Drawing.Point(11, 41);
            this.txtMasaNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMasaNo.Name = "txtMasaNo";
            this.txtMasaNo.Size = new System.Drawing.Size(150, 20);
            this.txtMasaNo.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(934, 348);
            this.Controls.Add(this.btnCiro);
            this.Controls.Add(this.btnSiparisVer);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.cmbIcecek);
            this.Controls.Add(this.cmbTatli);
            this.Controls.Add(this.cmbAraSicak);
            this.Controls.Add(this.cmbAnaYemek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMasaNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCiro;
        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.ComboBox cmbIcecek;
        private System.Windows.Forms.ComboBox cmbTatli;
        private System.Windows.Forms.ComboBox cmbAraSicak;
        private System.Windows.Forms.ComboBox cmbAnaYemek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMasaNo;
    }
}

