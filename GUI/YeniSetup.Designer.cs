namespace StarMetal
{
    partial class YeniSetup
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
            this.malzemeAdi = new System.Windows.Forms.TextBox();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(110, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Malzeme Adı : ";
            // 
            // malzemeAdi
            // 
            this.malzemeAdi.Location = new System.Drawing.Point(273, 52);
            this.malzemeAdi.Name = "malzemeAdi";
            this.malzemeAdi.Size = new System.Drawing.Size(100, 20);
            this.malzemeAdi.TabIndex = 1;
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(273, 88);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(100, 23);
            this.ekleBtn.TabIndex = 2;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            // 
            // YeniSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 133);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.malzemeAdi);
            this.Controls.Add(this.label1);
            this.Name = "YeniSetup";
            this.Text = "YeniSetup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox malzemeAdi;
        private System.Windows.Forms.Button ekleBtn;
    }
}