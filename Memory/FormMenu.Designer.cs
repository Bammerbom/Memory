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
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.ButtonHighscores = new System.Windows.Forms.Button();
            this.ButtonHelp = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.Button_Credits = new System.Windows.Forms.Button();
            this.ThemaComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonPlay.Location = new System.Drawing.Point(155, 83);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(161, 46);
            this.ButtonPlay.TabIndex = 1;
            this.ButtonPlay.Text = "Speel";
            this.ButtonPlay.UseVisualStyleBackColor = false;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.Location = new System.Drawing.Point(155, 135);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(161, 46);
            this.ButtonLoad.TabIndex = 2;
            this.ButtonLoad.Text = "Laden";
            this.ButtonLoad.UseVisualStyleBackColor = true;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // ButtonHighscores
            // 
            this.ButtonHighscores.Location = new System.Drawing.Point(155, 187);
            this.ButtonHighscores.Name = "ButtonHighscores";
            this.ButtonHighscores.Size = new System.Drawing.Size(161, 46);
            this.ButtonHighscores.TabIndex = 3;
            this.ButtonHighscores.Text = "Highscores";
            this.ButtonHighscores.UseVisualStyleBackColor = true;
            this.ButtonHighscores.Click += new System.EventHandler(this.ButtonHighscores_Click);
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.Location = new System.Drawing.Point(155, 239);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(161, 46);
            this.ButtonHelp.TabIndex = 4;
            this.ButtonHelp.Text = "Help";
            this.ButtonHelp.UseVisualStyleBackColor = true;
            this.ButtonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(155, 343);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(161, 46);
            this.ButtonExit.TabIndex = 5;
            this.ButtonExit.Text = "Afsluiten";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Button_Credits
            // 
            this.Button_Credits.Location = new System.Drawing.Point(155, 291);
            this.Button_Credits.Name = "Button_Credits";
            this.Button_Credits.Size = new System.Drawing.Size(161, 46);
            this.Button_Credits.TabIndex = 7;
            this.Button_Credits.Text = "Credits";
            this.Button_Credits.UseVisualStyleBackColor = true;
            this.Button_Credits.Click += new System.EventHandler(this.Button_Credits_Click);
            // 
            // ThemaComboBox
            // 
            this.ThemaComboBox.FormattingEnabled = true;
            this.ThemaComboBox.Items.AddRange(new object[] {
            "Default",
            "Disney",
            "StarWars"});
            this.ThemaComboBox.Location = new System.Drawing.Point(0, 0);
            this.ThemaComboBox.MaxDropDownItems = 3;
            this.ThemaComboBox.Name = "ThemaComboBox";
            this.ThemaComboBox.Size = new System.Drawing.Size(121, 32);
            this.ThemaComboBox.TabIndex = 8;
            this.ThemaComboBox.Text = "Thema";
            this.ThemaComboBox.SelectedIndexChanged += new System.EventHandler(this.ThemaComboBox_SelectedIndexChanged);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(476, 409);
            this.Controls.Add(this.ThemaComboBox);
            this.Controls.Add(this.Button_Credits);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonHelp);
            this.Controls.Add(this.ButtonHighscores);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.ButtonPlay);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonPlay;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.Button ButtonHighscores;
        private System.Windows.Forms.Button ButtonHelp;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button Button_Credits;
        private System.Windows.Forms.ComboBox ThemaComboBox;
    }
}

