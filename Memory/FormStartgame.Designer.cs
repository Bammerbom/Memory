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
            this.buttonTerug = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelNaam1 = new System.Windows.Forms.Label();
            this.labelNaam2 = new System.Windows.Forms.Label();
            this.textboxNaam2 = new System.Windows.Forms.TextBox();
            this.labelSpelgrootte = new System.Windows.Forms.Label();
            this.comboSpelgrootte = new System.Windows.Forms.ComboBox();
            this.labelIp = new System.Windows.Forms.Label();
            this.textboxIp = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textboxPort = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.textboxPort)).BeginInit();
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
            this.textboxNaam1.Name = "textboxNaam1";
            this.textboxNaam1.Size = new System.Drawing.Size(277, 32);
            this.textboxNaam1.TabIndex = 3;
            // 
            // buttonTerug
            // 
            this.buttonTerug.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTerug.Location = new System.Drawing.Point(12, 62);
            this.buttonTerug.Name = "buttonTerug";
            this.buttonTerug.Size = new System.Drawing.Size(196, 45);
            this.buttonTerug.TabIndex = 10;
            this.buttonTerug.Text = "Terug";
            this.buttonTerug.UseVisualStyleBackColor = true;
            this.buttonTerug.Click += new System.EventHandler(this.buttonTerug_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(576, 62);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(196, 45);
            this.buttonStart.TabIndex = 11;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
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
            this.textboxIp.Location = new System.Drawing.Point(261, 326);
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
            // FormStartgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Memory.Properties.Resources.floppy_disks;
            this.ClientSize = new System.Drawing.Size(784, 601);
            this.Controls.Add(this.textboxPort);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelIp);
            this.Controls.Add(this.textboxIp);
            this.Controls.Add(this.labelSpelgrootte);
            this.Controls.Add(this.labelNaam2);
            this.Controls.Add(this.textboxNaam2);
            this.Controls.Add(this.labelNaam1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonTerug);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboGametype;
        private System.Windows.Forms.Label titel;
        private System.Windows.Forms.TextBox textboxNaam1;
        private System.Windows.Forms.Button buttonTerug;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelNaam1;
        private System.Windows.Forms.Label labelNaam2;
        private System.Windows.Forms.TextBox textboxNaam2;
        private System.Windows.Forms.Label labelSpelgrootte;
        private System.Windows.Forms.ComboBox comboSpelgrootte;
        private System.Windows.Forms.Label labelIp;
        private System.Windows.Forms.TextBox textboxIp;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.NumericUpDown textboxPort;
    }
}