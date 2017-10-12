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
            this.plaatje1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.plaatje1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonPlay.Location = new System.Drawing.Point(155, 100);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(161, 46);
            this.ButtonPlay.TabIndex = 1;
            this.ButtonPlay.Text = "Play";
            this.ButtonPlay.UseVisualStyleBackColor = false;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.Location = new System.Drawing.Point(155, 152);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(161, 46);
            this.ButtonLoad.TabIndex = 2;
            this.ButtonLoad.Text = "Load";
            this.ButtonLoad.UseVisualStyleBackColor = true;
            // 
            // ButtonHighscores
            // 
            this.ButtonHighscores.Location = new System.Drawing.Point(155, 204);
            this.ButtonHighscores.Name = "ButtonHighscores";
            this.ButtonHighscores.Size = new System.Drawing.Size(161, 46);
            this.ButtonHighscores.TabIndex = 3;
            this.ButtonHighscores.Text = "Highscores";
            this.ButtonHighscores.UseVisualStyleBackColor = true;
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.Location = new System.Drawing.Point(155, 256);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(161, 46);
            this.ButtonHelp.TabIndex = 4;
            this.ButtonHelp.Text = "Help";
            this.ButtonHelp.UseVisualStyleBackColor = true;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(155, 308);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(161, 46);
            this.ButtonExit.TabIndex = 5;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // plaatje1
            // 
            this.plaatje1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.plaatje1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plaatje1.BackgroundImage")));
            this.plaatje1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.plaatje1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plaatje1.ErrorImage = null;
            this.plaatje1.InitialImage = null;
            this.plaatje1.Location = new System.Drawing.Point(-5, -15);
            this.plaatje1.Name = "plaatje1";
            this.plaatje1.Size = new System.Drawing.Size(479, 412);
            this.plaatje1.TabIndex = 6;
            this.plaatje1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Memory";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 409);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonHelp);
            this.Controls.Add(this.ButtonHighscores);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.ButtonPlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plaatje1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.Text = "Memory";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plaatje1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonPlay;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.Button ButtonHighscores;
        private System.Windows.Forms.Button ButtonHelp;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.PictureBox plaatje1;
        private System.Windows.Forms.Label label1;
    }
}

