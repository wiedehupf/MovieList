namespace MovieList
{
    partial class Main
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
            this.ButtonVerzeichnisWaehlen = new System.Windows.Forms.Button();
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxFilmtitel = new System.Windows.Forms.TextBox();
            this.textBoxAngezeigteFilme = new System.Windows.Forms.TextBox();
            this.buttonzurDatenbank = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.labelaktuellesVerzeichnis = new System.Windows.Forms.Label();
            this.labelDisplayaktuellesVerzeichnis = new System.Windows.Forms.Label();
            this.progressBarUpload = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // ButtonVerzeichnisWaehlen
            // 
            this.ButtonVerzeichnisWaehlen.Location = new System.Drawing.Point(33, 26);
            this.ButtonVerzeichnisWaehlen.Name = "ButtonVerzeichnisWaehlen";
            this.ButtonVerzeichnisWaehlen.Size = new System.Drawing.Size(172, 75);
            this.ButtonVerzeichnisWaehlen.TabIndex = 1;
            this.ButtonVerzeichnisWaehlen.Text = "Filmverzeichnis wählen";
            this.ButtonVerzeichnisWaehlen.UseVisualStyleBackColor = true;
            // 
            // textBoxFilmtitel
            // 
            this.textBoxFilmtitel.Location = new System.Drawing.Point(247, 26);
            this.textBoxFilmtitel.Name = "textBoxFilmtitel";
            this.textBoxFilmtitel.Size = new System.Drawing.Size(291, 20);
            this.textBoxFilmtitel.TabIndex = 2;
            // 
            // textBoxAngezeigteFilme
            // 
            this.textBoxAngezeigteFilme.Location = new System.Drawing.Point(247, 52);
            this.textBoxAngezeigteFilme.Multiline = true;
            this.textBoxAngezeigteFilme.Name = "textBoxAngezeigteFilme";
            this.textBoxAngezeigteFilme.ReadOnly = true;
            this.textBoxAngezeigteFilme.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAngezeigteFilme.Size = new System.Drawing.Size(291, 399);
            this.textBoxAngezeigteFilme.TabIndex = 3;
            // 
            // buttonzurDatenbank
            // 
            this.buttonzurDatenbank.Location = new System.Drawing.Point(33, 196);
            this.buttonzurDatenbank.Name = "buttonzurDatenbank";
            this.buttonzurDatenbank.Size = new System.Drawing.Size(172, 75);
            this.buttonzurDatenbank.TabIndex = 4;
            this.buttonzurDatenbank.Text = "in die Datenbank laden";
            this.buttonzurDatenbank.UseVisualStyleBackColor = true;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(33, 420);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(113, 31);
            this.buttonSettings.TabIndex = 6;
            this.buttonSettings.Text = "Einstellungen";
            this.buttonSettings.UseVisualStyleBackColor = true;
            // 
            // labelaktuellesVerzeichnis
            // 
            this.labelaktuellesVerzeichnis.AutoSize = true;
            this.labelaktuellesVerzeichnis.Location = new System.Drawing.Point(36, 116);
            this.labelaktuellesVerzeichnis.Name = "labelaktuellesVerzeichnis";
            this.labelaktuellesVerzeichnis.Size = new System.Drawing.Size(106, 13);
            this.labelaktuellesVerzeichnis.TabIndex = 7;
            this.labelaktuellesVerzeichnis.Text = "aktuelles Verzeichnis";
            // 
            // labelDisplayaktuellesVerzeichnis
            // 
            this.labelDisplayaktuellesVerzeichnis.AutoSize = true;
            this.labelDisplayaktuellesVerzeichnis.Location = new System.Drawing.Point(36, 146);
            this.labelDisplayaktuellesVerzeichnis.Name = "labelDisplayaktuellesVerzeichnis";
            this.labelDisplayaktuellesVerzeichnis.Size = new System.Drawing.Size(88, 13);
            this.labelDisplayaktuellesVerzeichnis.TabIndex = 8;
            this.labelDisplayaktuellesVerzeichnis.Text = "Text rauslöschen";
            // 
            // progressBarUpload
            // 
            this.progressBarUpload.Location = new System.Drawing.Point(33, 277);
            this.progressBarUpload.Name = "progressBarUpload";
            this.progressBarUpload.Size = new System.Drawing.Size(172, 24);
            this.progressBarUpload.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 479);
            this.Controls.Add(this.progressBarUpload);
            this.Controls.Add(this.labelDisplayaktuellesVerzeichnis);
            this.Controls.Add(this.labelaktuellesVerzeichnis);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonzurDatenbank);
            this.Controls.Add(this.textBoxAngezeigteFilme);
            this.Controls.Add(this.textBoxFilmtitel);
            this.Controls.Add(this.ButtonVerzeichnisWaehlen);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonVerzeichnisWaehlen;
        private System.Windows.Forms.FolderBrowserDialog FolderDialog;
        private System.Windows.Forms.TextBox textBoxFilmtitel;
        private System.Windows.Forms.TextBox textBoxAngezeigteFilme;
        private System.Windows.Forms.Button buttonzurDatenbank;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Label labelaktuellesVerzeichnis;
        private System.Windows.Forms.Label labelDisplayaktuellesVerzeichnis;
        private System.Windows.Forms.ProgressBar progressBarUpload;
    }
}