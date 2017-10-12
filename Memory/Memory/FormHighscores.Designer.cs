namespace Memory
{
    partial class FormHighscores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHighscores));
            this.ButtonBack = new System.Windows.Forms.Button();
            this.Button1speler = new System.Windows.Forms.Button();
            this.Button2spelers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1highscore = new System.Windows.Forms.PictureBox();
            this.pictureBox2Sterren = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1highscore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Sterren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ButtonBack.Location = new System.Drawing.Point(11, 724);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(103, 42);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Terug";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // Button1speler
            // 
            this.Button1speler.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Button1speler.Location = new System.Drawing.Point(395, 67);
            this.Button1speler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button1speler.Name = "Button1speler";
            this.Button1speler.Size = new System.Drawing.Size(181, 63);
            this.Button1speler.TabIndex = 1;
            this.Button1speler.Text = "1 speler";
            this.Button1speler.UseVisualStyleBackColor = true;
            // 
            // Button2spelers
            // 
            this.Button2spelers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Button2spelers.Location = new System.Drawing.Point(840, 67);
            this.Button2spelers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button2spelers.Name = "Button2spelers";
            this.Button2spelers.Size = new System.Drawing.Size(181, 63);
            this.Button2spelers.TabIndex = 2;
            this.Button2spelers.Text = "2 spelers";
            this.Button2spelers.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 271);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hier komt scores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(889, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hier komt scores";
            // 
            // pictureBox1highscore
            // 
            this.pictureBox1highscore.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1highscore.Image")));
            this.pictureBox1highscore.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1highscore.Name = "pictureBox1highscore";
            this.pictureBox1highscore.Size = new System.Drawing.Size(314, 284);
            this.pictureBox1highscore.TabIndex = 6;
            this.pictureBox1highscore.TabStop = false;
            // 
            // pictureBox2Sterren
            // 
            this.pictureBox2Sterren.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2Sterren.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2Sterren.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2Sterren.Image")));
            this.pictureBox2Sterren.Location = new System.Drawing.Point(-19, -79);
            this.pictureBox2Sterren.Name = "pictureBox2Sterren";
            this.pictureBox2Sterren.Size = new System.Drawing.Size(844, 512);
            this.pictureBox2Sterren.TabIndex = 7;
            this.pictureBox2Sterren.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(750, -79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(522, 512);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 319);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(824, 512);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(809, 287);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(522, 512);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // FormHighscores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 843);
            this.Controls.Add(this.pictureBox1highscore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button2spelers);
            this.Controls.Add(this.Button1speler);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.pictureBox2Sterren);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormHighscores";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1highscore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Sterren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button Button1speler;
        private System.Windows.Forms.Button Button2spelers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1highscore;
        private System.Windows.Forms.PictureBox pictureBox2Sterren;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}