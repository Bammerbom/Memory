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
            this.ButtonBack = new System.Windows.Forms.Button();
            this.Button1speler = new System.Windows.Forms.Button();
            this.Button2spelers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(50, 208);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(147, 564);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Terug";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // Button1speler
            // 
            this.Button1speler.Location = new System.Drawing.Point(500, 83);
            this.Button1speler.Name = "Button1speler";
            this.Button1speler.Size = new System.Drawing.Size(241, 77);
            this.Button1speler.TabIndex = 1;
            this.Button1speler.Text = "1 speler";
            this.Button1speler.UseVisualStyleBackColor = true;
            // 
            // Button2spelers
            // 
            this.Button2spelers.Location = new System.Drawing.Point(884, 83);
            this.Button2spelers.Name = "Button2spelers";
            this.Button2spelers.Size = new System.Drawing.Size(241, 77);
            this.Button2spelers.TabIndex = 2;
            this.Button2spelers.Text = "2 spelers";
            this.Button2spelers.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(654, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hier komt scores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label2.Location = new System.Drawing.Point(53, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "Highscores:";
            // 
            // FormHighscores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 1037);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button2spelers);
            this.Controls.Add(this.Button1speler);
            this.Controls.Add(this.ButtonBack);
            this.Name = "FormHighscores";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button Button1speler;
        private System.Windows.Forms.Button Button2spelers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}