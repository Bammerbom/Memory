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
            this.comboGametype = new System.Windows.Forms.ComboBox();
            this.titel = new System.Windows.Forms.Label();
            this.labelSingleplayer = new System.Windows.Forms.Label();
            this.inputANaam = new System.Windows.Forms.TextBox();
            this.labelANaam = new System.Windows.Forms.Label();
            this.labelASpelgrootte = new System.Windows.Forms.Label();
            this.comboASpelgrootte = new System.Windows.Forms.ComboBox();
            this.buttonTerug = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelMultiplayerLocal = new System.Windows.Forms.Label();
            this.labelBNaam1 = new System.Windows.Forms.Label();
            this.inputBNaam1 = new System.Windows.Forms.TextBox();
            this.labelBNaam2 = new System.Windows.Forms.Label();
            this.inputBNaam2 = new System.Windows.Forms.TextBox();
            this.comboBSpelgrootte = new System.Windows.Forms.ComboBox();
            this.labelBSpelgrootte = new System.Windows.Forms.Label();
            this.comboCSpelgrootte = new System.Windows.Forms.ComboBox();
            this.labelCSpelgrootte = new System.Windows.Forms.Label();
            this.labelCNaam = new System.Windows.Forms.Label();
            this.inputCNaam = new System.Windows.Forms.TextBox();
            this.labelMultiplayerOnline = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboGametype
            // 
            this.comboGametype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGametype.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGametype.FormattingEnabled = true;
            this.comboGametype.Items.AddRange(new object[] {
            "Singleplayer",
            "Multiplayer Local",
            "Multiplayer Online"});
            this.comboGametype.Location = new System.Drawing.Point(406, 149);
            this.comboGametype.Name = "comboGametype";
            this.comboGametype.Size = new System.Drawing.Size(253, 33);
            this.comboGametype.TabIndex = 0;
            this.comboGametype.SelectedIndexChanged += new System.EventHandler(this.gametype_SelectedIndexChanged);
            // 
            // titel
            // 
            this.titel.AutoSize = true;
            this.titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel.Location = new System.Drawing.Point(379, 109);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(305, 37);
            this.titel.TabIndex = 1;
            this.titel.Text = "Start een nieuw spel";
            // 
            // labelSingleplayer
            // 
            this.labelSingleplayer.AutoSize = true;
            this.labelSingleplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSingleplayer.Location = new System.Drawing.Point(120, 265);
            this.labelSingleplayer.Name = "labelSingleplayer";
            this.labelSingleplayer.Size = new System.Drawing.Size(163, 31);
            this.labelSingleplayer.TabIndex = 2;
            this.labelSingleplayer.Text = "Singleplayer";
            // 
            // inputANaam
            // 
            this.inputANaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputANaam.Location = new System.Drawing.Point(67, 366);
            this.inputANaam.Name = "inputANaam";
            this.inputANaam.Size = new System.Drawing.Size(253, 32);
            this.inputANaam.TabIndex = 3;
            // 
            // labelANaam
            // 
            this.labelANaam.AutoSize = true;
            this.labelANaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelANaam.Location = new System.Drawing.Point(121, 337);
            this.labelANaam.Name = "labelANaam";
            this.labelANaam.Size = new System.Drawing.Size(151, 26);
            this.labelANaam.TabIndex = 4;
            this.labelANaam.Text = "Naam invullen";
            // 
            // labelASpelgrootte
            // 
            this.labelASpelgrootte.AutoSize = true;
            this.labelASpelgrootte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelASpelgrootte.Location = new System.Drawing.Point(121, 441);
            this.labelASpelgrootte.Name = "labelASpelgrootte";
            this.labelASpelgrootte.Size = new System.Drawing.Size(123, 26);
            this.labelASpelgrootte.TabIndex = 6;
            this.labelASpelgrootte.Text = "Spelgrootte";
            // 
            // comboASpelgrootte
            // 
            this.comboASpelgrootte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboASpelgrootte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboASpelgrootte.FormattingEnabled = true;
            this.comboASpelgrootte.Items.AddRange(new object[] {
            "2x2",
            "2x3",
            "2x4",
            "3x4",
            "4x4"});
            this.comboASpelgrootte.Location = new System.Drawing.Point(67, 470);
            this.comboASpelgrootte.Name = "comboASpelgrootte";
            this.comboASpelgrootte.Size = new System.Drawing.Size(253, 33);
            this.comboASpelgrootte.TabIndex = 7;
            // 
            // buttonTerug
            // 
            this.buttonTerug.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTerug.Location = new System.Drawing.Point(93, 129);
            this.buttonTerug.Name = "buttonTerug";
            this.buttonTerug.Size = new System.Drawing.Size(196, 65);
            this.buttonTerug.TabIndex = 10;
            this.buttonTerug.Text = "Terug";
            this.buttonTerug.UseVisualStyleBackColor = true;
            this.buttonTerug.Click += new System.EventHandler(this.buttonTerug_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(811, 117);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(196, 65);
            this.buttonStart.TabIndex = 11;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelMultiplayerLocal
            // 
            this.labelMultiplayerLocal.AutoSize = true;
            this.labelMultiplayerLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMultiplayerLocal.Location = new System.Drawing.Point(442, 265);
            this.labelMultiplayerLocal.Name = "labelMultiplayerLocal";
            this.labelMultiplayerLocal.Size = new System.Drawing.Size(217, 31);
            this.labelMultiplayerLocal.TabIndex = 12;
            this.labelMultiplayerLocal.Text = "Local Multiplayer";
            // 
            // labelBNaam1
            // 
            this.labelBNaam1.AutoSize = true;
            this.labelBNaam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBNaam1.Location = new System.Drawing.Point(460, 337);
            this.labelBNaam1.Name = "labelBNaam1";
            this.labelBNaam1.Size = new System.Drawing.Size(169, 26);
            this.labelBNaam1.TabIndex = 14;
            this.labelBNaam1.Text = "Naam 1 invullen";
            // 
            // inputBNaam1
            // 
            this.inputBNaam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBNaam1.Location = new System.Drawing.Point(406, 366);
            this.inputBNaam1.Name = "inputBNaam1";
            this.inputBNaam1.Size = new System.Drawing.Size(253, 32);
            this.inputBNaam1.TabIndex = 13;
            // 
            // labelBNaam2
            // 
            this.labelBNaam2.AutoSize = true;
            this.labelBNaam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBNaam2.Location = new System.Drawing.Point(460, 442);
            this.labelBNaam2.Name = "labelBNaam2";
            this.labelBNaam2.Size = new System.Drawing.Size(169, 26);
            this.labelBNaam2.TabIndex = 16;
            this.labelBNaam2.Text = "Naam 2 invullen";
            // 
            // inputBNaam2
            // 
            this.inputBNaam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBNaam2.Location = new System.Drawing.Point(406, 471);
            this.inputBNaam2.Name = "inputBNaam2";
            this.inputBNaam2.Size = new System.Drawing.Size(253, 32);
            this.inputBNaam2.TabIndex = 15;
            // 
            // comboBSpelgrootte
            // 
            this.comboBSpelgrootte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBSpelgrootte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBSpelgrootte.FormattingEnabled = true;
            this.comboBSpelgrootte.Items.AddRange(new object[] {
            "2x2",
            "2x3",
            "2x4",
            "3x4",
            "4x4"});
            this.comboBSpelgrootte.Location = new System.Drawing.Point(406, 567);
            this.comboBSpelgrootte.Name = "comboBSpelgrootte";
            this.comboBSpelgrootte.Size = new System.Drawing.Size(253, 33);
            this.comboBSpelgrootte.TabIndex = 18;
            // 
            // labelBSpelgrootte
            // 
            this.labelBSpelgrootte.AutoSize = true;
            this.labelBSpelgrootte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBSpelgrootte.Location = new System.Drawing.Point(479, 539);
            this.labelBSpelgrootte.Name = "labelBSpelgrootte";
            this.labelBSpelgrootte.Size = new System.Drawing.Size(123, 26);
            this.labelBSpelgrootte.TabIndex = 17;
            this.labelBSpelgrootte.Text = "Spelgrootte";
            // 
            // comboCSpelgrootte
            // 
            this.comboCSpelgrootte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCSpelgrootte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCSpelgrootte.FormattingEnabled = true;
            this.comboCSpelgrootte.Items.AddRange(new object[] {
            "2x2",
            "2x3",
            "2x4",
            "3x4",
            "4x4"});
            this.comboCSpelgrootte.Location = new System.Drawing.Point(794, 470);
            this.comboCSpelgrootte.Name = "comboCSpelgrootte";
            this.comboCSpelgrootte.Size = new System.Drawing.Size(253, 33);
            this.comboCSpelgrootte.TabIndex = 25;
            // 
            // labelCSpelgrootte
            // 
            this.labelCSpelgrootte.AutoSize = true;
            this.labelCSpelgrootte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCSpelgrootte.Location = new System.Drawing.Point(848, 441);
            this.labelCSpelgrootte.Name = "labelCSpelgrootte";
            this.labelCSpelgrootte.Size = new System.Drawing.Size(123, 26);
            this.labelCSpelgrootte.TabIndex = 24;
            this.labelCSpelgrootte.Text = "Spelgrootte";
            // 
            // labelCNaam
            // 
            this.labelCNaam.AutoSize = true;
            this.labelCNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCNaam.Location = new System.Drawing.Point(848, 337);
            this.labelCNaam.Name = "labelCNaam";
            this.labelCNaam.Size = new System.Drawing.Size(151, 26);
            this.labelCNaam.TabIndex = 23;
            this.labelCNaam.Text = "Naam invullen";
            // 
            // inputCNaam
            // 
            this.inputCNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCNaam.Location = new System.Drawing.Point(794, 366);
            this.inputCNaam.Name = "inputCNaam";
            this.inputCNaam.Size = new System.Drawing.Size(253, 32);
            this.inputCNaam.TabIndex = 22;
            // 
            // labelMultiplayerOnline
            // 
            this.labelMultiplayerOnline.AutoSize = true;
            this.labelMultiplayerOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMultiplayerOnline.Location = new System.Drawing.Point(805, 265);
            this.labelMultiplayerOnline.Name = "labelMultiplayerOnline";
            this.labelMultiplayerOnline.Size = new System.Drawing.Size(230, 31);
            this.labelMultiplayerOnline.TabIndex = 21;
            this.labelMultiplayerOnline.Text = "Online Multiplayer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(912, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ik maak dit later mooi, dit is puur om te testen!";
            // 
            // FormStartgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 894);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboCSpelgrootte);
            this.Controls.Add(this.labelCSpelgrootte);
            this.Controls.Add(this.labelCNaam);
            this.Controls.Add(this.inputCNaam);
            this.Controls.Add(this.labelMultiplayerOnline);
            this.Controls.Add(this.comboBSpelgrootte);
            this.Controls.Add(this.labelBSpelgrootte);
            this.Controls.Add(this.labelBNaam2);
            this.Controls.Add(this.inputBNaam2);
            this.Controls.Add(this.labelBNaam1);
            this.Controls.Add(this.inputBNaam1);
            this.Controls.Add(this.labelMultiplayerLocal);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonTerug);
            this.Controls.Add(this.comboASpelgrootte);
            this.Controls.Add(this.labelASpelgrootte);
            this.Controls.Add(this.labelANaam);
            this.Controls.Add(this.inputANaam);
            this.Controls.Add(this.labelSingleplayer);
            this.Controls.Add(this.titel);
            this.Controls.Add(this.comboGametype);
            this.Name = "FormStartgame";
            this.Text = "Memory";
            this.Load += new System.EventHandler(this.FormStartgame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboGametype;
        private System.Windows.Forms.Label titel;
        private System.Windows.Forms.Label labelSingleplayer;
        private System.Windows.Forms.TextBox inputANaam;
        private System.Windows.Forms.Label labelANaam;
        private System.Windows.Forms.Label labelASpelgrootte;
        private System.Windows.Forms.ComboBox comboASpelgrootte;
        private System.Windows.Forms.Button buttonTerug;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelMultiplayerLocal;
        private System.Windows.Forms.Label labelBNaam1;
        private System.Windows.Forms.TextBox inputBNaam1;
        private System.Windows.Forms.Label labelBNaam2;
        private System.Windows.Forms.TextBox inputBNaam2;
        private System.Windows.Forms.ComboBox comboBSpelgrootte;
        private System.Windows.Forms.Label labelBSpelgrootte;
        private System.Windows.Forms.ComboBox comboCSpelgrootte;
        private System.Windows.Forms.Label labelCSpelgrootte;
        private System.Windows.Forms.Label labelCNaam;
        private System.Windows.Forms.TextBox inputCNaam;
        private System.Windows.Forms.Label labelMultiplayerOnline;
        private System.Windows.Forms.Label label1;
    }
}