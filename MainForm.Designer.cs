namespace StarMetal
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.motorBaslatBtn = new System.Windows.Forms.Button();
            this.motorDurdurBtn = new System.Windows.Forms.Button();
            this.arduino = new System.IO.Ports.SerialPort(this.components);
            this.motorStatusLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.göstergePaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.değerGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seriPortAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.portInfoLbl = new System.Windows.Forms.Label();
            this.manuelSürmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phLbl = new System.Windows.Forms.Label();
            this.modbusTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // motorBaslatBtn
            // 
            this.motorBaslatBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.motorBaslatBtn.FlatAppearance.BorderSize = 0;
            this.motorBaslatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.motorBaslatBtn.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.motorBaslatBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.motorBaslatBtn.Location = new System.Drawing.Point(50, 115);
            this.motorBaslatBtn.Name = "motorBaslatBtn";
            this.motorBaslatBtn.Size = new System.Drawing.Size(238, 126);
            this.motorBaslatBtn.TabIndex = 3;
            this.motorBaslatBtn.Text = "Motorları Sür";
            this.motorBaslatBtn.UseVisualStyleBackColor = false;
            this.motorBaslatBtn.Click += new System.EventHandler(this.motorBaslatBtn_Click);
            // 
            // motorDurdurBtn
            // 
            this.motorDurdurBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.motorDurdurBtn.FlatAppearance.BorderSize = 0;
            this.motorDurdurBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.motorDurdurBtn.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.motorDurdurBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.motorDurdurBtn.Location = new System.Drawing.Point(382, 115);
            this.motorDurdurBtn.Name = "motorDurdurBtn";
            this.motorDurdurBtn.Size = new System.Drawing.Size(249, 126);
            this.motorDurdurBtn.TabIndex = 4;
            this.motorDurdurBtn.Text = "Motorları Durdur";
            this.motorDurdurBtn.UseVisualStyleBackColor = false;
            this.motorDurdurBtn.Click += new System.EventHandler(this.motorDurdurBtn_Click);
            // 
            // motorStatusLbl
            // 
            this.motorStatusLbl.AutoSize = true;
            this.motorStatusLbl.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.motorStatusLbl.Location = new System.Drawing.Point(470, 26);
            this.motorStatusLbl.Name = "motorStatusLbl";
            this.motorStatusLbl.Size = new System.Drawing.Size(195, 23);
            this.motorStatusLbl.TabIndex = 10;
            this.motorStatusLbl.Text = "BAĞLANTI KAPATILDI";
            this.motorStatusLbl.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.göstergePaneliToolStripMenuItem,
            this.değerGToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.manuelSürmeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 38);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // göstergePaneliToolStripMenuItem
            // 
            this.göstergePaneliToolStripMenuItem.Name = "göstergePaneliToolStripMenuItem";
            this.göstergePaneliToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.göstergePaneliToolStripMenuItem.Text = "Gösterge Paneli";
            this.göstergePaneliToolStripMenuItem.Click += new System.EventHandler(this.göstergePaneliToolStripMenuItem_Click);
            // 
            // değerGToolStripMenuItem
            // 
            this.değerGToolStripMenuItem.Name = "değerGToolStripMenuItem";
            this.değerGToolStripMenuItem.Size = new System.Drawing.Size(163, 34);
            this.değerGToolStripMenuItem.Text = "Değer Girişleri";
            this.değerGToolStripMenuItem.Click += new System.EventHandler(this.değerGToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seriPortAyarlarıToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(93, 34);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // seriPortAyarlarıToolStripMenuItem
            // 
            this.seriPortAyarlarıToolStripMenuItem.Name = "seriPortAyarlarıToolStripMenuItem";
            this.seriPortAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.seriPortAyarlarıToolStripMenuItem.Text = "Seri Port Ayarları";
            this.seriPortAyarlarıToolStripMenuItem.Click += new System.EventHandler(this.seriPortAyarlarıToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Çalışma Portu:";
            // 
            // portInfoLbl
            // 
            this.portInfoLbl.AutoSize = true;
            this.portInfoLbl.BackColor = System.Drawing.Color.Goldenrod;
            this.portInfoLbl.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.portInfoLbl.Location = new System.Drawing.Point(158, 27);
            this.portInfoLbl.Name = "portInfoLbl";
            this.portInfoLbl.Size = new System.Drawing.Size(69, 23);
            this.portInfoLbl.TabIndex = 13;
            this.portInfoLbl.Text = "label3";
            // 
            // manuelSürmeToolStripMenuItem
            // 
            this.manuelSürmeToolStripMenuItem.Name = "manuelSürmeToolStripMenuItem";
            this.manuelSürmeToolStripMenuItem.Size = new System.Drawing.Size(166, 34);
            this.manuelSürmeToolStripMenuItem.Text = "Manuel Sürme";
            this.manuelSürmeToolStripMenuItem.Click += new System.EventHandler(this.manuelSürmeToolStripMenuItem_Click);
            // 
            // phLbl
            // 
            this.phLbl.AutoSize = true;
            this.phLbl.BackColor = System.Drawing.Color.Goldenrod;
            this.phLbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phLbl.Location = new System.Drawing.Point(286, 12);
            this.phLbl.Name = "phLbl";
            this.phLbl.Size = new System.Drawing.Size(41, 28);
            this.phLbl.TabIndex = 15;
            this.phLbl.Text = "PH";
            // 
            // modbusTimer
            // 
            this.modbusTimer.Enabled = true;
            this.modbusTimer.Interval = 1500;
            this.modbusTimer.Tick += new System.EventHandler(this.modbusTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.phLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 51);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.portInfoLbl);
            this.panel2.Controls.Add(this.motorStatusLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 57);
            this.panel2.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(688, 324);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.motorDurdurBtn);
            this.Controls.Add(this.motorBaslatBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button motorBaslatBtn;
        private System.Windows.Forms.Button motorDurdurBtn;
        private System.IO.Ports.SerialPort arduino;
        private System.Windows.Forms.Label motorStatusLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem göstergePaneliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem değerGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seriPortAyarlarıToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label portInfoLbl;
        private System.Windows.Forms.ToolStripMenuItem manuelSürmeToolStripMenuItem;
        private System.Windows.Forms.Label phLbl;
        private System.Windows.Forms.Timer modbusTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}