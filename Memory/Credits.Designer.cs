namespace Memory
{
    partial class Credits
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
            this.Terug_Knop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Terug_Knop
            // 
            this.Terug_Knop.Location = new System.Drawing.Point(143, 413);
            this.Terug_Knop.Name = "Terug_Knop";
            this.Terug_Knop.Size = new System.Drawing.Size(300, 116);
            this.Terug_Knop.TabIndex = 0;
            this.Terug_Knop.Text = "Terug";
            this.Terug_Knop.UseVisualStyleBackColor = true;
            this.Terug_Knop.Click += new System.EventHandler(this.Terug_Knop_Click);
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 541);
            this.Controls.Add(this.Terug_Knop);
            this.Name = "Credits";
            this.Text = "Credits";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Terug_Knop;
    }
}