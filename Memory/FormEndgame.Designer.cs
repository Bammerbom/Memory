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
            this.LabelResultatenmatch = new System.Windows.Forms.Label();
            this.pictureBoxSpeelopnieuw = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpeelopnieuw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelResultatenmatch
            // 
            this.LabelResultatenmatch.AutoSize = true;
            this.LabelResultatenmatch.BackColor = System.Drawing.Color.Transparent;
            this.LabelResultatenmatch.Font = new System.Drawing.Font("KenVector Future", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResultatenmatch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelResultatenmatch.Location = new System.Drawing.Point(161, 125);
            this.LabelResultatenmatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelResultatenmatch.Name = "LabelResultatenmatch";
            this.LabelResultatenmatch.Size = new System.Drawing.Size(73, 18);
            this.LabelResultatenmatch.TabIndex = 5;
            this.LabelResultatenmatch.Text = "Label";
            // 
            // pictureBoxSpeelopnieuw
            // 
            this.pictureBoxSpeelopnieuw.Image = global::Memory.Properties.Resources.SpeelopnieuwButtonGreen1;
            this.pictureBoxSpeelopnieuw.Location = new System.Drawing.Point(3, 377);
            this.pictureBoxSpeelopnieuw.Name = "pictureBoxSpeelopnieuw";
            this.pictureBoxSpeelopnieuw.Size = new System.Drawing.Size(149, 72);
            this.pictureBoxSpeelopnieuw.TabIndex = 8;
            this.pictureBoxSpeelopnieuw.TabStop = false;
            this.pictureBoxSpeelopnieuw.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Memory.Properties.Resources.InstellingenButtonBlauw1;
            this.pictureBox1.Location = new System.Drawing.Point(158, 377);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 73);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.ButtonStartgame_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Memory.Properties.Resources.HighscoresButtonBlauw12;
            this.pictureBox2.Location = new System.Drawing.Point(475, 377);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 73);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.ButtonHighscored_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Memory.Properties.Resources.HoofdmenuButtonBlauw12;
            this.pictureBox3.Location = new System.Drawing.Point(316, 377);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(153, 73);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Memory.Properties.Resources.SpelAfsluitenButtonRood1;
            this.pictureBox4.Location = new System.Drawing.Point(633, 377);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(153, 73);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.ButtonSluiten_Click);
            // 
            // FormEndgame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BackgroundImage = global::Memory.Properties.Resources.Game_over_lagere_resolutie;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxSpeelopnieuw);
            this.Controls.Add(this.LabelResultatenmatch);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEndgame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory";
            this.Load += new System.EventHandler(this.FormEndgame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpeelopnieuw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label LabelResultatenmatch;
        private System.Windows.Forms.PictureBox pictureBoxSpeelopnieuw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}