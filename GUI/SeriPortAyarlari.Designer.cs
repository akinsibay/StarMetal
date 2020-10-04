namespace StarMetal
{
    partial class SeriPortAyarlari
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
            this.serialCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uygulaBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serialCombo
            // 
            this.serialCombo.FormattingEnabled = true;
            this.serialCombo.Location = new System.Drawing.Point(212, 85);
            this.serialCombo.Margin = new System.Windows.Forms.Padding(4);
            this.serialCombo.Name = "serialCombo";
            this.serialCombo.Size = new System.Drawing.Size(241, 32);
            this.serialCombo.TabIndex = 7;
            this.serialCombo.SelectedIndexChanged += new System.EventHandler(this.serialCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Arduino\'nun bağlı olduğu portu seçin";
            // 
            // uygulaBtn
            // 
            this.uygulaBtn.BackColor = System.Drawing.Color.Green;
            this.uygulaBtn.FlatAppearance.BorderSize = 0;
            this.uygulaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uygulaBtn.ForeColor = System.Drawing.Color.White;
            this.uygulaBtn.Location = new System.Drawing.Point(331, 136);
            this.uygulaBtn.Name = "uygulaBtn";
            this.uygulaBtn.Size = new System.Drawing.Size(122, 37);
            this.uygulaBtn.TabIndex = 9;
            this.uygulaBtn.Text = "Uygula";
            this.uygulaBtn.UseVisualStyleBackColor = false;
            this.uygulaBtn.Click += new System.EventHandler(this.uygulaBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(104, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Seçili Port:";
            // 
            // SeriPortAyarları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 195);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uygulaBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serialCombo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SeriPortAyarları";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seri Port Ayarları";
            this.Load += new System.EventHandler(this.SeriPortAyarları_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox serialCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uygulaBtn;
        private System.Windows.Forms.Label label2;
    }
}