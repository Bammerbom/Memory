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
            this.textboxNaam2 = new System.Windows.Forms.TextBox();
            this.labelSpelgrootte = new System.Windows.Forms.Label();
            this.comboSpelgrootte = new System.Windows.Forms.ComboBox();
            this.textboxIp = new System.Windows.Forms.TextBox();
            this.textboxPort = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxStart = new System.Windows.Forms.PictureBox();
            this.pictureBoxTerug = new System.Windows.Forms.PictureBox();
            this.pictureBoxNaam2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxIPadres = new System.Windows.Forms.PictureBox();
            this.pictureBoxNaam1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSpeelveld = new System.Windows.Forms.PictureBox();
            this.pictureBoxPort = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.textboxPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTerug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNaam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIPadres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNaam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpeelveld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).BeginInit();
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
            this.comboGametype.Location = new System.Drawing.Point(255, 62);
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
            this.textboxNaam1.Location = new System.Drawing.Point(262, 258);
            this.textboxNaam1.MaxLength = 10;
            this.textboxNaam1.Name = "textboxNaam1";
            this.textboxNaam1.Size = new System.Drawing.Size(277, 32);
            this.textboxNaam1.TabIndex = 3;
            this.textboxNaam1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxNaam1_KeyPress);
            // 
            // textboxNaam2
            // 
            this.textboxNaam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxNaam2.Location = new System.Drawing.Point(262, 344);
            this.textboxNaam2.MaxLength = 10;
            this.textboxNaam2.Name = "textboxNaam2";
            this.textboxNaam2.Size = new System.Drawing.Size(278, 32);
            this.textboxNaam2.TabIndex = 15;
            this.textboxNaam2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxNaam1_KeyPress);
            // 
            // labelSpelgrootte
            // 
            this.labelSpelgrootte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSpelgrootte.AutoSize = true;
            this.labelSpelgrootte.BackColor = System.Drawing.SystemColors.Control;
            this.labelSpelgrootte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpelgrootte.Location = new System.Drawing.Point(342, 128);
            this.labelSpelgrootte.Name = "labelSpelgrootte";
            this.labelSpelgrootte.Size = new System.Drawing.Size(0, 26);
            this.labelSpelgrootte.TabIndex = 17;
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
            this.comboSpelgrootte.Location = new System.Drawing.Point(365, 169);
            this.comboSpelgrootte.Name = "comboSpelgrootte";
            this.comboSpelgrootte.Size = new System.Drawing.Size(68, 33);
            this.comboSpelgrootte.TabIndex = 7;
            // 
            // textboxIp
            // 
            this.textboxIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxIp.Location = new System.Drawing.Point(262, 344);
            this.textboxIp.Name = "textboxIp";
            this.textboxIp.Size = new System.Drawing.Size(278, 32);
            this.textboxIp.TabIndex = 18;
            this.textboxIp.TextChanged += new System.EventHandler(this.textboxIp_TextChanged);
            // 
            // textboxPort
            // 
            this.textboxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPort.Increment = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.textboxPort.Location = new System.Drawing.Point(261, 429);
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
            // pictureBoxStart
            // 
            this.pictureBoxStart.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxStart.BackgroundImage")));
            this.pictureBoxStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxStart.Location = new System.Drawing.Point(567, 62);
            this.pictureBoxStart.Name = "pictureBoxStart";
            this.pictureBoxStart.Size = new System.Drawing.Size(190, 49);
            this.pictureBoxStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxStart.TabIndex = 23;
            this.pictureBoxStart.TabStop = false;
            this.pictureBoxStart.Click += new System.EventHandler(this.pictureBoxStartmenuStart_Click_1);
            // 
            // pictureBoxTerug
            // 
            this.pictureBoxTerug.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTerug.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxTerug.BackgroundImage")));
            this.pictureBoxTerug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTerug.Location = new System.Drawing.Point(23, 62);
            this.pictureBoxTerug.Name = "pictureBoxTerug";
            this.pictureBoxTerug.Size = new System.Drawing.Size(190, 49);
            this.pictureBoxTerug.TabIndex = 24;
            this.pictureBoxTerug.TabStop = false;
            this.pictureBoxTerug.Click += new System.EventHandler(this.pictureBoxStartmenuTerug_Click_1);
            // 
            // pictureBoxNaam2
            // 
            this.pictureBoxNaam2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNaam2.Image = global::Memory.Properties.Resources.Naam2InvullenLabel;
            this.pictureBoxNaam2.Location = new System.Drawing.Point(272, 296);
            this.pictureBoxNaam2.Name = "pictureBoxNaam2";
            this.pictureBoxNaam2.Size = new System.Drawing.Size(253, 40);
            this.pictureBoxNaam2.TabIndex = 27;
            this.pictureBoxNaam2.TabStop = false;
            // 
            // pictureBoxIPadres
            // 
            this.pictureBoxIPadres.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxIPadres.Image = global::Memory.Properties.Resources.PortLabelGeel;
            this.pictureBoxIPadres.Location = new System.Drawing.Point(312, 296);
            this.pictureBoxIPadres.Name = "pictureBoxIPadres";
            this.pictureBoxIPadres.Size = new System.Drawing.Size(171, 42);
            this.pictureBoxIPadres.TabIndex = 28;
            this.pictureBoxIPadres.TabStop = false;
            // 
            // pictureBoxNaam1
            // 
            this.pictureBoxNaam1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNaam1.Image = global::Memory.Properties.Resources.Naam1InvullenLabel;
            this.pictureBoxNaam1.Location = new System.Drawing.Point(272, 208);
            this.pictureBoxNaam1.Name = "pictureBoxNaam1";
            this.pictureBoxNaam1.Size = new System.Drawing.Size(253, 42);
            this.pictureBoxNaam1.TabIndex = 29;
            this.pictureBoxNaam1.TabStop = false;
            // 
            // pictureBoxSpeelveld
            // 
            this.pictureBoxSpeelveld.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSpeelveld.Image = global::Memory.Properties.Resources.SpeelveldButtonGeel;
            this.pictureBoxSpeelveld.Location = new System.Drawing.Point(312, 122);
            this.pictureBoxSpeelveld.Name = "pictureBoxSpeelveld";
            this.pictureBoxSpeelveld.Size = new System.Drawing.Size(171, 41);
            this.pictureBoxSpeelveld.TabIndex = 30;
            this.pictureBoxSpeelveld.TabStop = false;
            // 
            // pictureBoxPort
            // 
            this.pictureBoxPort.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPort.Image = global::Memory.Properties.Resources.IPadresLabelGeel;
            this.pictureBoxPort.Location = new System.Drawing.Point(312, 380);
            this.pictureBoxPort.Name = "pictureBoxPort";
            this.pictureBoxPort.Size = new System.Drawing.Size(172, 43);
            this.pictureBoxPort.TabIndex = 31;
            this.pictureBoxPort.TabStop = false;
            // 
            // FormStartgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Memory.Properties.Resources.Thema0StartGameAchtergrond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 601);
            this.Controls.Add(this.pictureBoxPort);
            this.Controls.Add(this.pictureBoxSpeelveld);
            this.Controls.Add(this.pictureBoxNaam1);
            this.Controls.Add(this.pictureBoxIPadres);
            this.Controls.Add(this.pictureBoxNaam2);
            this.Controls.Add(this.pictureBoxTerug);
            this.Controls.Add(this.pictureBoxStart);
            this.Controls.Add(this.textboxPort);
            this.Controls.Add(this.textboxIp);
            this.Controls.Add(this.labelSpelgrootte);
            this.Controls.Add(this.textboxNaam2);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStartgame_FormClosed);
            this.Load += new System.EventHandler(this.FormStartgame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textboxPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTerug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNaam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIPadres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNaam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpeelveld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboGametype;
        private System.Windows.Forms.Label titel;
        private System.Windows.Forms.TextBox textboxNaam1;
        private System.Windows.Forms.Label labelNaam2;
        private System.Windows.Forms.TextBox textboxNaam2;
        private System.Windows.Forms.Label labelSpelgrootte;
        private System.Windows.Forms.ComboBox comboSpelgrootte;
        private System.Windows.Forms.TextBox textboxIp;
        private System.Windows.Forms.NumericUpDown textboxPort;
        private System.Windows.Forms.PictureBox pictureBoxStart;
        private System.Windows.Forms.PictureBox pictureBoxTerug;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxNaam2;
        private System.Windows.Forms.PictureBox pictureBoxIPadres;
        private System.Windows.Forms.PictureBox pictureBoxNaam1;
        private System.Windows.Forms.PictureBox pictureBoxSpeelveld;
        private System.Windows.Forms.PictureBox pictureBoxPort;
    }
}