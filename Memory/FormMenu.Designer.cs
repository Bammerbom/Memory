namespace Memory
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.ThemaBox = new System.Windows.Forms.ComboBox();
            this.pictureBox2Laden = new System.Windows.Forms.PictureBox();
            this.pictureBox3Highscores = new System.Windows.Forms.PictureBox();
            this.pictureBox4Credits = new System.Windows.Forms.PictureBox();
            this.pictureBox1Speel = new System.Windows.Forms.PictureBox();
            this.pictureBox5Afsluiten = new System.Windows.Forms.PictureBox();
            this.pictureBox6Help = new System.Windows.Forms.PictureBox();
            this.Volume = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Laden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3Highscores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4Credits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Speel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5Afsluiten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6Help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            this.SuspendLayout();
            // 
            // ThemaBox
            // 
            this.ThemaBox.FormattingEnabled = true;
            this.ThemaBox.Items.AddRange(new object[] {
            "Default",
            "Disney",
            "StarWars"});
            this.ThemaBox.Location = new System.Drawing.Point(3, 2);
            this.ThemaBox.MaxDropDownItems = 3;
            this.ThemaBox.Name = "ThemaBox";
            this.ThemaBox.Size = new System.Drawing.Size(121, 32);
            this.ThemaBox.TabIndex = 8;
            this.ThemaBox.Text = "Thema";
            this.ThemaBox.SelectedIndexChanged += new System.EventHandler(this.ThemaComboBox_SelectedIndexChanged);
            // 
            // pictureBox2Laden
            // 
            this.pictureBox2Laden.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2Laden.BackgroundImage = global::Memory.Properties.Resources.LadenButtonBlauw;
            this.pictureBox2Laden.Location = new System.Drawing.Point(145, 110);
            this.pictureBox2Laden.Name = "pictureBox2Laden";
            this.pictureBox2Laden.Size = new System.Drawing.Size(192, 48);
            this.pictureBox2Laden.TabIndex = 10;
            this.pictureBox2Laden.TabStop = false;
            this.pictureBox2Laden.Click += new System.EventHandler(this.pictureBox2Laden_Click);
            // 
            // pictureBox3Highscores
            // 
            this.pictureBox3Highscores.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3Highscores.BackgroundImage = global::Memory.Properties.Resources.HighscoresButtonBlauw;
            this.pictureBox3Highscores.Location = new System.Drawing.Point(145, 164);
            this.pictureBox3Highscores.Name = "pictureBox3Highscores";
            this.pictureBox3Highscores.Size = new System.Drawing.Size(192, 50);
            this.pictureBox3Highscores.TabIndex = 11;
            this.pictureBox3Highscores.TabStop = false;
            this.pictureBox3Highscores.Click += new System.EventHandler(this.pictureBox3Highscores_Click);
            // 
            // pictureBox4Credits
            // 
            this.pictureBox4Credits.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4Credits.BackgroundImage = global::Memory.Properties.Resources.CreditsButtonBlauw;
            this.pictureBox4Credits.Location = new System.Drawing.Point(145, 220);
            this.pictureBox4Credits.Name = "pictureBox4Credits";
            this.pictureBox4Credits.Size = new System.Drawing.Size(192, 51);
            this.pictureBox4Credits.TabIndex = 12;
            this.pictureBox4Credits.TabStop = false;
            this.pictureBox4Credits.Click += new System.EventHandler(this.pictureBox4Credits_Click);
            // 
            // pictureBox1Speel
            // 
            this.pictureBox1Speel.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1Speel.BackgroundImage = global::Memory.Properties.Resources.SpeelButtonGroen;
            this.pictureBox1Speel.ErrorImage = null;
            this.pictureBox1Speel.Location = new System.Drawing.Point(124, 40);
            this.pictureBox1Speel.Name = "pictureBox1Speel";
            this.pictureBox1Speel.Size = new System.Drawing.Size(231, 60);
            this.pictureBox1Speel.TabIndex = 13;
            this.pictureBox1Speel.TabStop = false;
            this.pictureBox1Speel.Click += new System.EventHandler(this.pictureBox1Speel_Click);
            // 
            // pictureBox5Afsluiten
            // 
            this.pictureBox5Afsluiten.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5Afsluiten.BackgroundImage = global::Memory.Properties.Resources.AfsluitenButtonRood;
            this.pictureBox5Afsluiten.Location = new System.Drawing.Point(145, 333);
            this.pictureBox5Afsluiten.Name = "pictureBox5Afsluiten";
            this.pictureBox5Afsluiten.Size = new System.Drawing.Size(192, 51);
            this.pictureBox5Afsluiten.TabIndex = 14;
            this.pictureBox5Afsluiten.TabStop = false;
            this.pictureBox5Afsluiten.Click += new System.EventHandler(this.pictureBox5Afsluiten_Click);
            // 
            // pictureBox6Help
            // 
            this.pictureBox6Help.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6Help.BackgroundImage = global::Memory.Properties.Resources.HelpButtonBlauw;
            this.pictureBox6Help.Location = new System.Drawing.Point(145, 277);
            this.pictureBox6Help.Name = "pictureBox6Help";
            this.pictureBox6Help.Size = new System.Drawing.Size(192, 50);
            this.pictureBox6Help.TabIndex = 15;
            this.pictureBox6Help.TabStop = false;
            this.pictureBox6Help.Click += new System.EventHandler(this.pictureBox6Help_Click);
            // 
            // Volume
            // 
            this.Volume.BackColor = System.Drawing.Color.White;
            this.Volume.BackgroundImage = global::Memory.Properties.Resources.Geluidsicoontje;
            this.Volume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Volume.Location = new System.Drawing.Point(21, 347);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(50, 50);
            this.Volume.TabIndex = 16;
            this.Volume.TabStop = false;
            this.Volume.Click += new System.EventHandler(this.Volume_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(476, 409);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.pictureBox6Help);
            this.Controls.Add(this.pictureBox5Afsluiten);
            this.Controls.Add(this.pictureBox1Speel);
            this.Controls.Add(this.pictureBox4Credits);
            this.Controls.Add(this.pictureBox3Highscores);
            this.Controls.Add(this.pictureBox2Laden);
            this.Controls.Add(this.ThemaBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Laden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3Highscores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4Credits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Speel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5Afsluiten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6Help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2Laden;
        private System.Windows.Forms.PictureBox pictureBox3Highscores;
        private System.Windows.Forms.PictureBox pictureBox4Credits;
        private System.Windows.Forms.PictureBox pictureBox1Speel;
        private System.Windows.Forms.PictureBox pictureBox5Afsluiten;
        private System.Windows.Forms.PictureBox pictureBox6Help;
        private System.Windows.Forms.ComboBox ThemaBox;
        private System.Windows.Forms.PictureBox Volume;
    }
}

