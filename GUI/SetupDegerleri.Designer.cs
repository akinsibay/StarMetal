namespace StarMetal
{
    partial class SetupDegerleri
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.kapKal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.topAlan = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.yeniSetupBtn = new System.Windows.Forms.Button();
            this.goKalibrasyonBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(362, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 52);
            this.label2.TabIndex = 11;
            this.label2.Text = "İstenen \r\nKaplama Kalınlığı (um)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kapKal
            // 
            this.kapKal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapKal.Location = new System.Drawing.Point(366, 207);
            this.kapKal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kapKal.Name = "kapKal";
            this.kapKal.ReadOnly = true;
            this.kapKal.Size = new System.Drawing.Size(208, 29);
            this.kapKal.TabIndex = 9;
            this.kapKal.TabStop = false;
            this.kapKal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kapKal.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "Toplam \r\nYüzey Alanı (dm2)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topAlan
            // 
            this.topAlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.topAlan.Location = new System.Drawing.Point(29, 207);
            this.topAlan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.topAlan.Name = "topAlan";
            this.topAlan.ReadOnly = true;
            this.topAlan.Size = new System.Drawing.Size(172, 29);
            this.topAlan.TabIndex = 6;
            this.topAlan.TabStop = false;
            this.topAlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.topAlan.UseWaitCursor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboBox1.Location = new System.Drawing.Point(170, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 32);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Malzeme Seçin";
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // yeniSetupBtn
            // 
            this.yeniSetupBtn.Location = new System.Drawing.Point(475, 1);
            this.yeniSetupBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yeniSetupBtn.Name = "yeniSetupBtn";
            this.yeniSetupBtn.Size = new System.Drawing.Size(129, 30);
            this.yeniSetupBtn.TabIndex = 13;
            this.yeniSetupBtn.Text = "Yeni Setup";
            this.yeniSetupBtn.UseVisualStyleBackColor = true;
            this.yeniSetupBtn.Click += new System.EventHandler(this.yeniSetupBtn_Click);
            // 
            // goKalibrasyonBtn
            // 
            this.goKalibrasyonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.goKalibrasyonBtn.Location = new System.Drawing.Point(357, 314);
            this.goKalibrasyonBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.goKalibrasyonBtn.Name = "goKalibrasyonBtn";
            this.goKalibrasyonBtn.Size = new System.Drawing.Size(230, 46);
            this.goKalibrasyonBtn.TabIndex = 14;
            this.goKalibrasyonBtn.Text = "Kalibrasyon Verileri >";
            this.goKalibrasyonBtn.UseVisualStyleBackColor = true;
            this.goKalibrasyonBtn.Click += new System.EventHandler(this.goKalibrasyonBtn_Click);
            // 
            // SetupDegerleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 374);
            this.Controls.Add(this.goKalibrasyonBtn);
            this.Controls.Add(this.yeniSetupBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kapKal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topAlan);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SetupDegerleri";
            this.Text = "Setup Değerleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kapKal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox topAlan;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button yeniSetupBtn;
        private System.Windows.Forms.Button goKalibrasyonBtn;
    }
}

