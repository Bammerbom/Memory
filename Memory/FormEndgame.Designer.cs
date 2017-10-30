namespace Memory
{
    partial class FormEndgame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEndgame));
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ButtonStartgame = new System.Windows.Forms.Button();
            this.ButtonHighscored = new System.Windows.Forms.Button();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.LabelResultatenmatch = new System.Windows.Forms.Label();
            this.ButtonSluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonReset
            // 
            this.ButtonReset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonReset.Location = new System.Drawing.Point(11, 373);
            this.ButtonReset.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(150, 70);
            this.ButtonReset.TabIndex = 0;
            this.ButtonReset.Text = "Speel opnieuw";
            this.ButtonReset.UseVisualStyleBackColor = false;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ButtonStartgame
            // 
            this.ButtonStartgame.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonStartgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStartgame.Location = new System.Drawing.Point(165, 373);
            this.ButtonStartgame.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonStartgame.Name = "ButtonStartgame";
            this.ButtonStartgame.Size = new System.Drawing.Size(150, 70);
            this.ButtonStartgame.TabIndex = 1;
            this.ButtonStartgame.Text = "Instellingen";
            this.ButtonStartgame.UseVisualStyleBackColor = false;
            this.ButtonStartgame.Click += new System.EventHandler(this.ButtonStartgame_Click);
            // 
            // ButtonHighscored
            // 
            this.ButtonHighscored.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonHighscored.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHighscored.Location = new System.Drawing.Point(473, 373);
            this.ButtonHighscored.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonHighscored.Name = "ButtonHighscored";
            this.ButtonHighscored.Size = new System.Drawing.Size(150, 70);
            this.ButtonHighscored.TabIndex = 2;
            this.ButtonHighscored.Text = "Highscores";
            this.ButtonHighscored.UseVisualStyleBackColor = false;
            this.ButtonHighscored.Click += new System.EventHandler(this.ButtonHighscored_Click);
            // 
            // ButtonHome
            // 
            this.ButtonHome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHome.Location = new System.Drawing.Point(319, 373);
            this.ButtonHome.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(150, 70);
            this.ButtonHome.TabIndex = 3;
            this.ButtonHome.Text = "Hoofdmenu";
            this.ButtonHome.UseVisualStyleBackColor = false;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // LabelResultatenmatch
            // 
            this.LabelResultatenmatch.AutoSize = true;
            this.LabelResultatenmatch.BackColor = System.Drawing.Color.Transparent;
            this.LabelResultatenmatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResultatenmatch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelResultatenmatch.Location = new System.Drawing.Point(161, 125);
            this.LabelResultatenmatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelResultatenmatch.Name = "LabelResultatenmatch";
            this.LabelResultatenmatch.Size = new System.Drawing.Size(48, 20);
            this.LabelResultatenmatch.TabIndex = 5;
            this.LabelResultatenmatch.Text = "Label";
            // 
            // ButtonSluiten
            // 
            this.ButtonSluiten.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonSluiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSluiten.Location = new System.Drawing.Point(627, 373);
            this.ButtonSluiten.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSluiten.Name = "ButtonSluiten";
            this.ButtonSluiten.Size = new System.Drawing.Size(150, 70);
            this.ButtonSluiten.TabIndex = 7;
            this.ButtonSluiten.Text = "Spel afsluiten";
            this.ButtonSluiten.UseVisualStyleBackColor = false;
            this.ButtonSluiten.Click += new System.EventHandler(this.ButtonSluiten_Click);
            // 
            // FormEndgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BackgroundImage = global::Memory.Properties.Resources.Game_over_lagere_resolutie;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(785, 454);
            this.Controls.Add(this.LabelResultatenmatch);
            this.Controls.Add(this.ButtonSluiten);
            this.Controls.Add(this.ButtonHome);
            this.Controls.Add(this.ButtonHighscored);
            this.Controls.Add(this.ButtonStartgame);
            this.Controls.Add(this.ButtonReset);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEndgame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory";
            this.Load += new System.EventHandler(this.FormEndgame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button ButtonReset;
        public System.Windows.Forms.Button ButtonStartgame;
        public System.Windows.Forms.Button ButtonHighscored;
        public System.Windows.Forms.Button ButtonHome;
        public System.Windows.Forms.Label LabelResultatenmatch;
        public System.Windows.Forms.Button ButtonSluiten;
    }
}