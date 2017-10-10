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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.titel = new System.Windows.Forms.Label();
            this.labelSingleplayer = new System.Windows.Forms.Label();
            this.inputANaam = new System.Windows.Forms.TextBox();
            this.labelANaam = new System.Windows.Forms.Label();
            this.labelAGrootte = new System.Windows.Forms.Label();
            this.comboAGrootte = new System.Windows.Forms.ComboBox();
            this.labelASet = new System.Windows.Forms.Label();
            this.comboASet = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelMultiplayerLocal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Singleplayer",
            "Multiplayer Local",
            "Multiplayer Online"});
            this.comboBox1.Location = new System.Drawing.Point(835, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 33);
            this.comboBox1.TabIndex = 0;
            // 
            // titel
            // 
            this.titel.AutoSize = true;
            this.titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel.Location = new System.Drawing.Point(808, 98);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(305, 37);
            this.titel.TabIndex = 1;
            this.titel.Text = "Start een nieuw spel";
            // 
            // labelSingleplayer
            // 
            this.labelSingleplayer.AutoSize = true;
            this.labelSingleplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSingleplayer.Location = new System.Drawing.Point(877, 233);
            this.labelSingleplayer.Name = "labelSingleplayer";
            this.labelSingleplayer.Size = new System.Drawing.Size(163, 31);
            this.labelSingleplayer.TabIndex = 2;
            this.labelSingleplayer.Text = "Singleplayer";
            // 
            // inputANaam
            // 
            this.inputANaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputANaam.Location = new System.Drawing.Point(835, 334);
            this.inputANaam.Name = "inputANaam";
            this.inputANaam.Size = new System.Drawing.Size(253, 32);
            this.inputANaam.TabIndex = 3;
            // 
            // labelANaam
            // 
            this.labelANaam.AutoSize = true;
            this.labelANaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelANaam.Location = new System.Drawing.Point(889, 305);
            this.labelANaam.Name = "labelANaam";
            this.labelANaam.Size = new System.Drawing.Size(151, 26);
            this.labelANaam.TabIndex = 4;
            this.labelANaam.Text = "Naam invullen";
            // 
            // labelAGrootte
            // 
            this.labelAGrootte.AutoSize = true;
            this.labelAGrootte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAGrootte.Location = new System.Drawing.Point(889, 409);
            this.labelAGrootte.Name = "labelAGrootte";
            this.labelAGrootte.Size = new System.Drawing.Size(123, 26);
            this.labelAGrootte.TabIndex = 6;
            this.labelAGrootte.Text = "Spelgrootte";
            // 
            // comboAGrootte
            // 
            this.comboAGrootte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAGrootte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAGrootte.FormattingEnabled = true;
            this.comboAGrootte.Items.AddRange(new object[] {
            "2x2",
            "2x3",
            "2x4",
            "3x4",
            "4x4"});
            this.comboAGrootte.Location = new System.Drawing.Point(835, 438);
            this.comboAGrootte.Name = "comboAGrootte";
            this.comboAGrootte.Size = new System.Drawing.Size(253, 33);
            this.comboAGrootte.TabIndex = 7;
            // 
            // labelASet
            // 
            this.labelASet.AutoSize = true;
            this.labelASet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelASet.Location = new System.Drawing.Point(889, 507);
            this.labelASet.Name = "labelASet";
            this.labelASet.Size = new System.Drawing.Size(168, 26);
            this.labelASet.TabIndex = 8;
            this.labelASet.Text = "Afbeeldingenset";
            // 
            // comboASet
            // 
            this.comboASet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboASet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboASet.FormattingEnabled = true;
            this.comboASet.Items.AddRange(new object[] {
            "Logo\'s"});
            this.comboASet.Location = new System.Drawing.Point(835, 536);
            this.comboASet.Name = "comboASet";
            this.comboASet.Size = new System.Drawing.Size(253, 33);
            this.comboASet.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(730, 850);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 65);
            this.button1.TabIndex = 10;
            this.button1.Text = "Terug";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(986, 850);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 65);
            this.button2.TabIndex = 11;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelMultiplayerLocal
            // 
            this.labelMultiplayerLocal.AutoSize = true;
            this.labelMultiplayerLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMultiplayerLocal.Location = new System.Drawing.Point(853, 233);
            this.labelMultiplayerLocal.Name = "labelMultiplayerLocal";
            this.labelMultiplayerLocal.Size = new System.Drawing.Size(217, 31);
            this.labelMultiplayerLocal.TabIndex = 12;
            this.labelMultiplayerLocal.Text = "Local Multiplayer";
            // 
            // FormStartgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.labelMultiplayerLocal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboASet);
            this.Controls.Add(this.labelASet);
            this.Controls.Add(this.comboAGrootte);
            this.Controls.Add(this.labelAGrootte);
            this.Controls.Add(this.labelANaam);
            this.Controls.Add(this.inputANaam);
            this.Controls.Add(this.labelSingleplayer);
            this.Controls.Add(this.titel);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormStartgame";
            this.Text = "FormStartgame";
            this.Load += new System.EventHandler(this.FormStartgame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label titel;
        private System.Windows.Forms.Label labelSingleplayer;
        private System.Windows.Forms.TextBox inputANaam;
        private System.Windows.Forms.Label labelANaam;
        private System.Windows.Forms.Label labelAGrootte;
        private System.Windows.Forms.ComboBox comboAGrootte;
        private System.Windows.Forms.Label labelASet;
        private System.Windows.Forms.ComboBox comboASet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelMultiplayerLocal;
    }
}