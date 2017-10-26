namespace Memory
{
    partial class FormStartgame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStartgame));
            this.comboGametype = new System.Windows.Forms.ComboBox();
            this.titel = new System.Windows.Forms.Label();
            this.textboxNaam1 = new System.Windows.Forms.TextBox();
            this.labelNaam1 = new System.Windows.Forms.Label();
            this.labelNaam2 = new System.Windows.Forms.Label();
            this.textboxNaam2 = new System.Windows.Forms.TextBox();
            this.labelSpelgrootte = new System.Windows.Forms.Label();
            this.comboSpelgrootte = new System.Windows.Forms.ComboBox();
            this.labelIp = new System.Windows.Forms.Label();
            this.textboxIp = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textboxPort = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxStartmenuStart = new System.Windows.Forms.PictureBox();
            this.pictureBoxStartmenuTerug = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.textboxPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartmenuStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartmenuTerug)).BeginInit();
            this.SuspendLayout();
            // 
            // comboGametype
            // 
            this.comboGametype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGametype.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGametype.FormattingEnabled = true;
            this.comboGametype.Items.AddRange(new object[] {
            "Kies spelmodus",
            "Singleplayer",
            "Local Multiplayer",
            "Host Multiplayer",
            "Join Multiplayer"});
            this.comboGametype.Location = new System.Drawing.Point(261, 62);
            this.comboGametype.Name = "comboGametype";
            this.comboGametype.Size = new System.Drawing.Size(278, 45);
            this.comboGametype.TabIndex = 0;
            this.comboGametype.SelectedIndexChanged += new System.EventHandler(this.gametype_SelectedIndexChanged);
            // 
            // titel
            // 
            this.titel.AutoSize = true;
            this.titel.BackColor = System.Drawing.Color.Transparent;
            this.titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel.Location = new System.Drawing.Point(248, 10);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(305, 37);
            this.titel.TabIndex = 1;
            this.titel.Text = "Start een nieuw spel";
            // 
            // textboxNaam1
            // 
            this.textboxNaam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxNaam1.Location = new System.Drawing.Point(262, 239);
            this.textboxNaam1.MaxLength = 15;
            this.textboxNaam1.Name = "textboxNaam1";
            this.textboxNaam1.Size = new System.Drawing.Size(277, 32);
            this.textboxNaam1.TabIndex = 3;
            // 
            // labelNaam1
            // 
            this.labelNaam1.AutoSize = true;
            this.labelNaam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaam1.Location = new System.Drawing.Point(316, 210);
            this.labelNaam1.Name = "labelNaam1";
            this.labelNaam1.Size = new System.Drawing.Size(169, 26);
            this.labelNaam1.TabIndex = 14;
            this.labelNaam1.Text = "Naam 1 invullen";
            // 
            // labelNaam2
            // 
            this.labelNaam2.AutoSize = true;
            this.labelNaam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaam2.Location = new System.Drawing.Point(315, 297);
            this.labelNaam2.Name = "labelNaam2";
            this.labelNaam2.Size = new System.Drawing.Size(169, 26);
            this.labelNaam2.TabIndex = 16;
            this.labelNaam2.Text = "Naam 2 invullen";
            // 
            // textboxNaam2
            // 
            this.textboxNaam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxNaam2.Location = new System.Drawing.Point(261, 326);
            this.textboxNaam2.MaxLength = 15;
            this.textboxNaam2.Name = "textboxNaam2";
            this.textboxNaam2.Size = new System.Drawing.Size(278, 32);
            this.textboxNaam2.TabIndex = 15;
            // 
            // labelSpelgrootte
            // 
            this.labelSpelgrootte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSpelgrootte.AutoSize = true;
            this.labelSpelgrootte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpelgrootte.Location = new System.Drawing.Point(342, 128);
            this.labelSpelgrootte.Name = "labelSpelgrootte";
            this.labelSpelgrootte.Size = new System.Drawing.Size(108, 26);
            this.labelSpelgrootte.TabIndex = 17;
            this.labelSpelgrootte.Text = "Speelveld";
            // 
            // comboSpelgrootte
            // 
            this.comboSpelgrootte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSpelgrootte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSpelgrootte.FormattingEnabled = true;
            this.comboSpelgrootte.Items.AddRange(new object[] {
            "2x2",
            "2x3",
            "2x4",
            "3x4",
            "4x4"});
            this.comboSpelgrootte.Location = new System.Drawing.Point(366, 157);
            this.comboSpelgrootte.Name = "comboSpelgrootte";
            this.comboSpelgrootte.Size = new System.Drawing.Size(68, 33);
            this.comboSpelgrootte.TabIndex = 7;
            // 
            // labelIp
            // 
            this.labelIp.AutoSize = true;
            this.labelIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIp.Location = new System.Drawing.Point(342, 297);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(96, 26);
            this.labelIp.TabIndex = 19;
            this.labelIp.Text = "IP Adres";
            // 
            // textboxIp
            // 
            this.textboxIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxIp.Location = new System.Drawing.Point(262, 326);
            this.textboxIp.Name = "textboxIp";
            this.textboxIp.Size = new System.Drawing.Size(278, 32);
            this.textboxIp.TabIndex = 18;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.Location = new System.Drawing.Point(361, 381);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(52, 26);
            this.labelPort.TabIndex = 21;
            this.labelPort.Text = "Port";
            // 
            // textboxPort
            // 
            this.textboxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPort.Increment = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.textboxPort.Location = new System.Drawing.Point(262, 410);
            this.textboxPort.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.textboxPort.Name = "textboxPort";
            this.textboxPort.Size = new System.Drawing.Size(277, 32);
            this.textboxPort.TabIndex = 22;
            this.textboxPort.Value = new decimal(new int[] {
            8978,
            0,
            0,
            0});
            // 
            // pictureBoxStartmenuStart
            // 
            this.pictureBoxStartmenuStart.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStartmenuStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxStartmenuStart.Image = global::Memory.Properties.Resources.Button_SpeelveldStart;
            this.pictureBoxStartmenuStart.Location = new System.Drawing.Point(571, 62);
            this.pictureBoxStartmenuStart.Name = "pictureBoxStartmenuStart";
            this.pictureBoxStartmenuStart.Size = new System.Drawing.Size(179, 49);
            this.pictureBoxStartmenuStart.TabIndex = 23;
            this.pictureBoxStartmenuStart.TabStop = false;
            // 
            // pictureBoxStartmenuTerug
            // 
            this.pictureBoxStartmenuTerug.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStartmenuTerug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxStartmenuTerug.Image = global::Memory.Properties.Resources.Button_SpeelveldTerug;
            this.pictureBoxStartmenuTerug.Location = new System.Drawing.Point(45, 62);
            this.pictureBoxStartmenuTerug.Name = "pictureBoxStartmenuTerug";
            this.pictureBoxStartmenuTerug.Size = new System.Drawing.Size(177, 49);
            this.pictureBoxStartmenuTerug.TabIndex = 24;
            this.pictureBoxStartmenuTerug.TabStop = false;
            // 
            // FormStartgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Memory.Properties.Resources.Thema0StartGameAchtergrond;
            this.ClientSize = new System.Drawing.Size(784, 601);
            this.Controls.Add(this.pictureBoxStartmenuTerug);
            this.Controls.Add(this.pictureBoxStartmenuStart);
            this.Controls.Add(this.textboxPort);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelIp);
            this.Controls.Add(this.textboxIp);
            this.Controls.Add(this.labelSpelgrootte);
            this.Controls.Add(this.labelNaam2);
            this.Controls.Add(this.textboxNaam2);
            this.Controls.Add(this.labelNaam1);
            this.Controls.Add(this.comboSpelgrootte);
            this.Controls.Add(this.textboxNaam1);
            this.Controls.Add(this.titel);
            this.Controls.Add(this.comboGametype);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormStartgame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory";
            this.Load += new System.EventHandler(this.FormStartgame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textboxPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartmenuStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartmenuTerug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboGametype;
        private System.Windows.Forms.Label titel;
        private System.Windows.Forms.TextBox textboxNaam1;
        private System.Windows.Forms.Label labelNaam1;
        private System.Windows.Forms.Label labelNaam2;
        private System.Windows.Forms.TextBox textboxNaam2;
        private System.Windows.Forms.Label labelSpelgrootte;
        private System.Windows.Forms.ComboBox comboSpelgrootte;
        private System.Windows.Forms.Label labelIp;
        private System.Windows.Forms.TextBox textboxIp;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.NumericUpDown textboxPort;
        private System.Windows.Forms.PictureBox pictureBoxStartmenuStart;
        private System.Windows.Forms.PictureBox pictureBoxStartmenuTerug;
    }
}