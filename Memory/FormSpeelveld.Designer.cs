namespace Memory
{
    partial class FormSpeelveld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSpeelveld));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Textbox_Score_Speler_1 = new System.Windows.Forms.TextBox();
            this.Label_Score_Speler_1 = new System.Windows.Forms.Label();
            this.Label_Score_Speler_2 = new System.Windows.Forms.Label();
            this.Textbox_Score_Speler_2 = new System.Windows.Forms.TextBox();
            this.Label_Score = new System.Windows.Forms.Label();
            this.Label_Zetten_Speler_1 = new System.Windows.Forms.Label();
            this.Textbox_Zetten_Speler_1 = new System.Windows.Forms.TextBox();
            this.TextBox_Beurt = new System.Windows.Forms.RichTextBox();
            this.Label_Timer = new System.Windows.Forms.Label();
            this.Textbox_Timer = new System.Windows.Forms.TextBox();
            this.Button_Opslaan = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Label_Zetten_Speler_2 = new System.Windows.Forms.Label();
            this.Textbox_Zetten_Speler_2 = new System.Windows.Forms.TextBox();
            this.Buton_Reset = new System.Windows.Forms.Button();
            this.Volume = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1,
            this.exitToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.restartToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem.Text = "Bestand";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "Opslaan en Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructiesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // instructiesToolStripMenuItem
            // 
            this.instructiesToolStripMenuItem.Name = "instructiesToolStripMenuItem";
            this.instructiesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.instructiesToolStripMenuItem.Text = "Instructies";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem1});
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem1
            // 
            this.creditsToolStripMenuItem1.Name = "creditsToolStripMenuItem1";
            this.creditsToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.creditsToolStripMenuItem1.Text = "Credits";
            // 
            // Textbox_Score_Speler_1
            // 
            this.Textbox_Score_Speler_1.Font = new System.Drawing.Font("KenVector Future", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Score_Speler_1.Location = new System.Drawing.Point(195, 145);
            this.Textbox_Score_Speler_1.Name = "Textbox_Score_Speler_1";
            this.Textbox_Score_Speler_1.ReadOnly = true;
            this.Textbox_Score_Speler_1.Size = new System.Drawing.Size(81, 34);
            this.Textbox_Score_Speler_1.TabIndex = 2;
            // 
            // Label_Score_Speler_1
            // 
            this.Label_Score_Speler_1.AutoSize = true;
            this.Label_Score_Speler_1.BackColor = System.Drawing.SystemColors.Control;
            this.Label_Score_Speler_1.Font = new System.Drawing.Font("KenVector Future", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Score_Speler_1.Location = new System.Drawing.Point(26, 150);
            this.Label_Score_Speler_1.Name = "Label_Score_Speler_1";
            this.Label_Score_Speler_1.Size = new System.Drawing.Size(163, 27);
            this.Label_Score_Speler_1.TabIndex = 3;
            this.Label_Score_Speler_1.Text = "Speler 1 :";
            // 
            // Label_Score_Speler_2
            // 
            this.Label_Score_Speler_2.AutoSize = true;
            this.Label_Score_Speler_2.BackColor = System.Drawing.SystemColors.Control;
            this.Label_Score_Speler_2.Font = new System.Drawing.Font("KenVector Future", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Score_Speler_2.Location = new System.Drawing.Point(17, 247);
            this.Label_Score_Speler_2.Name = "Label_Score_Speler_2";
            this.Label_Score_Speler_2.Size = new System.Drawing.Size(172, 27);
            this.Label_Score_Speler_2.TabIndex = 4;
            this.Label_Score_Speler_2.Text = "Speler 2 :";
            // 
            // Textbox_Score_Speler_2
            // 
            this.Textbox_Score_Speler_2.Font = new System.Drawing.Font("KenVector Future", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Score_Speler_2.Location = new System.Drawing.Point(195, 242);
            this.Textbox_Score_Speler_2.Name = "Textbox_Score_Speler_2";
            this.Textbox_Score_Speler_2.ReadOnly = true;
            this.Textbox_Score_Speler_2.Size = new System.Drawing.Size(81, 34);
            this.Textbox_Score_Speler_2.TabIndex = 5;
            // 
            // Label_Score
            // 
            this.Label_Score.AutoSize = true;
            this.Label_Score.BackColor = System.Drawing.Color.White;
            this.Label_Score.Font = new System.Drawing.Font("KenVector Future", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Score.Location = new System.Drawing.Point(82, 52);
            this.Label_Score.Name = "Label_Score";
            this.Label_Score.Size = new System.Drawing.Size(185, 45);
            this.Label_Score.TabIndex = 6;
            this.Label_Score.Text = "Score";
            // 
            // Label_Zetten_Speler_1
            // 
            this.Label_Zetten_Speler_1.AutoSize = true;
            this.Label_Zetten_Speler_1.BackColor = System.Drawing.Color.White;
            this.Label_Zetten_Speler_1.Font = new System.Drawing.Font("KenVector Future", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Zetten_Speler_1.Location = new System.Drawing.Point(43, 191);
            this.Label_Zetten_Speler_1.Name = "Label_Zetten_Speler_1";
            this.Label_Zetten_Speler_1.Size = new System.Drawing.Size(146, 27);
            this.Label_Zetten_Speler_1.TabIndex = 7;
            this.Label_Zetten_Speler_1.Text = "Zetten :";
            // 
            // Textbox_Zetten_Speler_1
            // 
            this.Textbox_Zetten_Speler_1.Font = new System.Drawing.Font("KenVector Future", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Zetten_Speler_1.Location = new System.Drawing.Point(195, 186);
            this.Textbox_Zetten_Speler_1.Name = "Textbox_Zetten_Speler_1";
            this.Textbox_Zetten_Speler_1.ReadOnly = true;
            this.Textbox_Zetten_Speler_1.Size = new System.Drawing.Size(81, 34);
            this.Textbox_Zetten_Speler_1.TabIndex = 8;
            // 
            // TextBox_Beurt
            // 
            this.TextBox_Beurt.Font = new System.Drawing.Font("KenVector Future", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Beurt.Location = new System.Drawing.Point(55, 392);
            this.TextBox_Beurt.Name = "TextBox_Beurt";
            this.TextBox_Beurt.ReadOnly = true;
            this.TextBox_Beurt.Size = new System.Drawing.Size(221, 121);
            this.TextBox_Beurt.TabIndex = 10;
            this.TextBox_Beurt.Text = "BeurtHoi";
            // 
            // Label_Timer
            // 
            this.Label_Timer.AutoSize = true;
            this.Label_Timer.BackColor = System.Drawing.Color.White;
            this.Label_Timer.Font = new System.Drawing.Font("KenVector Future", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Timer.Location = new System.Drawing.Point(0, 521);
            this.Label_Timer.Name = "Label_Timer";
            this.Label_Timer.Size = new System.Drawing.Size(276, 59);
            this.Label_Timer.TabIndex = 11;
            this.Label_Timer.Text = "Timer : ";
            // 
            // Textbox_Timer
            // 
            this.Textbox_Timer.Font = new System.Drawing.Font("KenVector Future", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Timer.Location = new System.Drawing.Point(248, 519);
            this.Textbox_Timer.Name = "Textbox_Timer";
            this.Textbox_Timer.ReadOnly = true;
            this.Textbox_Timer.Size = new System.Drawing.Size(100, 67);
            this.Textbox_Timer.TabIndex = 12;
            this.Textbox_Timer.Text = "10";
            // 
            // Button_Opslaan
            // 
            this.Button_Opslaan.Font = new System.Drawing.Font("KenVector Future", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Opslaan.Location = new System.Drawing.Point(55, 694);
            this.Button_Opslaan.Name = "Button_Opslaan";
            this.Button_Opslaan.Size = new System.Drawing.Size(221, 77);
            this.Button_Opslaan.TabIndex = 13;
            this.Button_Opslaan.Text = "Opslaan en Exit";
            this.Button_Opslaan.UseVisualStyleBackColor = true;
            this.Button_Opslaan.Click += new System.EventHandler(this.Button_Opslaan_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Font = new System.Drawing.Font("KenVector Future", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Exit.Location = new System.Drawing.Point(55, 777);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(221, 77);
            this.Button_Exit.TabIndex = 14;
            this.Button_Exit.Text = "Exit";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Label_Zetten_Speler_2
            // 
            this.Label_Zetten_Speler_2.AutoSize = true;
            this.Label_Zetten_Speler_2.BackColor = System.Drawing.Color.White;
            this.Label_Zetten_Speler_2.Font = new System.Drawing.Font("KenVector Future", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Zetten_Speler_2.Location = new System.Drawing.Point(43, 288);
            this.Label_Zetten_Speler_2.Name = "Label_Zetten_Speler_2";
            this.Label_Zetten_Speler_2.Size = new System.Drawing.Size(146, 27);
            this.Label_Zetten_Speler_2.TabIndex = 31;
            this.Label_Zetten_Speler_2.Text = "Zetten :";
            // 
            // Textbox_Zetten_Speler_2
            // 
            this.Textbox_Zetten_Speler_2.Font = new System.Drawing.Font("KenVector Future", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Zetten_Speler_2.Location = new System.Drawing.Point(195, 283);
            this.Textbox_Zetten_Speler_2.Name = "Textbox_Zetten_Speler_2";
            this.Textbox_Zetten_Speler_2.ReadOnly = true;
            this.Textbox_Zetten_Speler_2.Size = new System.Drawing.Size(81, 34);
            this.Textbox_Zetten_Speler_2.TabIndex = 32;
            // 
            // Buton_Reset
            // 
            this.Buton_Reset.Font = new System.Drawing.Font("KenVector Future", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buton_Reset.Location = new System.Drawing.Point(55, 611);
            this.Buton_Reset.Name = "Buton_Reset";
            this.Buton_Reset.Size = new System.Drawing.Size(221, 77);
            this.Buton_Reset.TabIndex = 14;
            this.Buton_Reset.Text = "Reset";
            this.Buton_Reset.UseVisualStyleBackColor = true;
            this.Buton_Reset.Click += new System.EventHandler(this.Buton_Reset_Click);
            // 
            // Volume
            // 
            this.Volume.BackColor = System.Drawing.Color.White;
            this.Volume.BackgroundImage = global::Memory.Properties.Resources.Geluidsicoontje;
            this.Volume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Volume.Location = new System.Drawing.Point(23, 909);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(50, 50);
            this.Volume.TabIndex = 33;
            this.Volume.TabStop = false;
            this.Volume.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FormSpeelveld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::Memory.Properties.Resources.Thema0SpeelveldAchtergrond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.Buton_Reset);
            this.Controls.Add(this.Textbox_Zetten_Speler_2);
            this.Controls.Add(this.Label_Zetten_Speler_2);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_Opslaan);
            this.Controls.Add(this.Textbox_Timer);
            this.Controls.Add(this.Label_Timer);
            this.Controls.Add(this.TextBox_Beurt);
            this.Controls.Add(this.Textbox_Zetten_Speler_1);
            this.Controls.Add(this.Label_Zetten_Speler_1);
            this.Controls.Add(this.Label_Score);
            this.Controls.Add(this.Textbox_Score_Speler_2);
            this.Controls.Add(this.Label_Score_Speler_2);
            this.Controls.Add(this.Label_Score_Speler_1);
            this.Controls.Add(this.Textbox_Score_Speler_1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormSpeelveld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormSpeelveld_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem1;
        public System.Windows.Forms.TextBox Textbox_Score_Speler_1;
        public System.Windows.Forms.Label Label_Score_Speler_1;
        public System.Windows.Forms.Label Label_Score_Speler_2;
        public System.Windows.Forms.TextBox Textbox_Score_Speler_2;
        public System.Windows.Forms.Label Label_Score;
        public System.Windows.Forms.Label Label_Zetten_Speler_1;
        public System.Windows.Forms.TextBox Textbox_Zetten_Speler_1;
        public System.Windows.Forms.RichTextBox TextBox_Beurt;
        public System.Windows.Forms.Label Label_Timer;
        public System.Windows.Forms.TextBox Textbox_Timer;
        public System.Windows.Forms.Button Button_Opslaan;
        public System.Windows.Forms.Button Button_Exit;
        public System.Windows.Forms.Label Label_Zetten_Speler_2;
        public System.Windows.Forms.TextBox Textbox_Zetten_Speler_2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        public System.Windows.Forms.Button Buton_Reset;
        private System.Windows.Forms.PictureBox Volume;
    }
}