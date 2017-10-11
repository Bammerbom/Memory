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
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ButtonStartgame = new System.Windows.Forms.Button();
            this.ButtonHighscored = new System.Windows.Forms.Button();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.LabelKlaar = new System.Windows.Forms.Label();
            this.LabelResultatenmatch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonReset
            // 
            this.ButtonReset.Location = new System.Drawing.Point(35, 338);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(130, 72);
            this.ButtonReset.TabIndex = 0;
            this.ButtonReset.Text = "Speel opnieuw";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ButtonStartgame
            // 
            this.ButtonStartgame.Location = new System.Drawing.Point(215, 338);
            this.ButtonStartgame.Name = "ButtonStartgame";
            this.ButtonStartgame.Size = new System.Drawing.Size(130, 72);
            this.ButtonStartgame.TabIndex = 1;
            this.ButtonStartgame.Text = "Spel aanpassen";
            this.ButtonStartgame.UseVisualStyleBackColor = true;
            this.ButtonStartgame.Click += new System.EventHandler(this.ButtonStartgame_Click);
            // 
            // ButtonHighscored
            // 
            this.ButtonHighscored.Location = new System.Drawing.Point(397, 338);
            this.ButtonHighscored.Name = "ButtonHighscored";
            this.ButtonHighscored.Size = new System.Drawing.Size(130, 72);
            this.ButtonHighscored.TabIndex = 2;
            this.ButtonHighscored.Text = "Highscores";
            this.ButtonHighscored.UseVisualStyleBackColor = true;
            this.ButtonHighscored.Click += new System.EventHandler(this.ButtonHighscored_Click);
            // 
            // ButtonHome
            // 
            this.ButtonHome.Location = new System.Drawing.Point(575, 338);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(130, 72);
            this.ButtonHome.TabIndex = 3;
            this.ButtonHome.Text = "Hoofdmenu";
            this.ButtonHome.UseVisualStyleBackColor = true;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // LabelKlaar
            // 
            this.LabelKlaar.AutoSize = true;
            this.LabelKlaar.Location = new System.Drawing.Point(358, 59);
            this.LabelKlaar.Name = "LabelKlaar";
            this.LabelKlaar.Size = new System.Drawing.Size(50, 17);
            this.LabelKlaar.TabIndex = 4;
            this.LabelKlaar.Text = "Klaar!!!";
            // 
            // LabelResultatenmatch
            // 
            this.LabelResultatenmatch.AutoSize = true;
            this.LabelResultatenmatch.Location = new System.Drawing.Point(239, 202);
            this.LabelResultatenmatch.Name = "LabelResultatenmatch";
            this.LabelResultatenmatch.Size = new System.Drawing.Size(288, 17);
            this.LabelResultatenmatch.TabIndex = 5;
            this.LabelResultatenmatch.Text = "Gegevens over de match: Me big boi now?!?";
            // 
            // FormEndgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 440);
            this.Controls.Add(this.LabelResultatenmatch);
            this.Controls.Add(this.LabelKlaar);
            this.Controls.Add(this.ButtonHome);
            this.Controls.Add(this.ButtonHighscored);
            this.Controls.Add(this.ButtonStartgame);
            this.Controls.Add(this.ButtonReset);
            this.Name = "FormEndgame";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Button ButtonStartgame;
        private System.Windows.Forms.Button ButtonHighscored;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.Label LabelKlaar;
        private System.Windows.Forms.Label LabelResultatenmatch;
    }
}