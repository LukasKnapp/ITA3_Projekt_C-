using System.Drawing.Drawing2D;
namespace Arduino_Matrix_Generator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        public void InitializeComponent()
        {
            this.Menue = new System.Windows.Forms.MenuStrip();
            this.Datei = new System.Windows.Forms.ToolStripMenuItem();
            this.Neu = new System.Windows.Forms.ToolStripMenuItem();
            this.Öffnen = new System.Windows.Forms.ToolStripMenuItem();
            this.Speichern = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeichernUnter = new System.Windows.Forms.ToolStripMenuItem();
            this.Exportieren = new System.Windows.Forms.ToolStripMenuItem();
            this.Bearbeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.Hilfe = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Schritt = new System.Windows.Forms.Label();
            this.Dauer = new System.Windows.Forms.Label();
            this.ms = new System.Windows.Forms.Label();
            this.schritt_zahl = new System.Windows.Forms.NumericUpDown();
            this.dauer_zahl = new System.Windows.Forms.NumericUpDown();
            this.button_weiter = new System.Windows.Forms.Button();
            this.button_abbrechen = new System.Windows.Forms.Button();
            this.button_zurueck = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEbene = new System.Windows.Forms.Label();
            this.numericEbene = new System.Windows.Forms.NumericUpDown();
            this.LEDpanel = new Arduino_Matrix_Generator.xPanel();
            this.Menue.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schritt_zahl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dauer_zahl)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEbene)).BeginInit();
            this.SuspendLayout();
            // 
            // Menue
            // 
            this.Menue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Datei,
            this.Bearbeiten,
            this.Hilfe});
            this.Menue.Location = new System.Drawing.Point(0, 0);
            this.Menue.Name = "Menue";
            this.Menue.Size = new System.Drawing.Size(695, 24);
            this.Menue.TabIndex = 0;
            this.Menue.Text = "menuStrip1";
            // 
            // Datei
            // 
            this.Datei.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Neu,
            this.Öffnen,
            this.Speichern,
            this.SpeichernUnter,
            this.Exportieren});
            this.Datei.Name = "Datei";
            this.Datei.Size = new System.Drawing.Size(46, 20);
            this.Datei.Text = "Datei";
            // 
            // Neu
            // 
            this.Neu.Name = "Neu";
            this.Neu.Size = new System.Drawing.Size(157, 22);
            this.Neu.Text = "Neu";
            this.Neu.Click += new System.EventHandler(this.Neu_Click);
            // 
            // Öffnen
            // 
            this.Öffnen.Name = "Öffnen";
            this.Öffnen.Size = new System.Drawing.Size(157, 22);
            this.Öffnen.Text = "Öffnen";
            this.Öffnen.Click += new System.EventHandler(this.Öffnen_Click);
            // 
            // Speichern
            // 
            this.Speichern.Name = "Speichern";
            this.Speichern.Size = new System.Drawing.Size(157, 22);
            this.Speichern.Text = "Speichern";
            this.Speichern.Click += new System.EventHandler(this.Speichern_Click);
            // 
            // SpeichernUnter
            // 
            this.SpeichernUnter.Name = "SpeichernUnter";
            this.SpeichernUnter.Size = new System.Drawing.Size(157, 22);
            this.SpeichernUnter.Text = "Speichern unter";
            this.SpeichernUnter.Click += new System.EventHandler(this.SpeichernUnter_Click);
            // 
            // Exportieren
            // 
            this.Exportieren.Name = "Exportieren";
            this.Exportieren.Size = new System.Drawing.Size(157, 22);
            this.Exportieren.Text = "Exportieren";
            this.Exportieren.Click += new System.EventHandler(this.Exportieren_Click);
            // 
            // Bearbeiten
            // 
            this.Bearbeiten.Name = "Bearbeiten";
            this.Bearbeiten.Size = new System.Drawing.Size(75, 20);
            this.Bearbeiten.Text = "Bearbeiten";
            // 
            // Hilfe
            // 
            this.Hilfe.Name = "Hilfe";
            this.Hilfe.Size = new System.Drawing.Size(44, 20);
            this.Hilfe.Text = "Hilfe";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(695, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(490, 17);
            this.toolStripStatusLabel1.Text = "© MegaManMasterrace (Rick Marlon Kroniger, Kevin \"TheKev\" Dietze, Lukas-Fabian Kn" +
    "app)";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Schritt
            // 
            this.Schritt.AutoSize = true;
            this.Schritt.Location = new System.Drawing.Point(300, 57);
            this.Schritt.Name = "Schritt";
            this.Schritt.Size = new System.Drawing.Size(40, 13);
            this.Schritt.TabIndex = 3;
            this.Schritt.Text = "Schritt:";
            // 
            // Dauer
            // 
            this.Dauer.AutoSize = true;
            this.Dauer.Location = new System.Drawing.Point(167, 55);
            this.Dauer.Name = "Dauer";
            this.Dauer.Size = new System.Drawing.Size(39, 13);
            this.Dauer.TabIndex = 4;
            this.Dauer.Text = "Dauer:";
            // 
            // ms
            // 
            this.ms.AutoSize = true;
            this.ms.Location = new System.Drawing.Point(257, 55);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(20, 13);
            this.ms.TabIndex = 5;
            this.ms.Text = "ms";
            this.ms.Click += new System.EventHandler(this.ms_Click);
            // 
            // schritt_zahl
            // 
            this.schritt_zahl.Location = new System.Drawing.Point(346, 55);
            this.schritt_zahl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.schritt_zahl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.schritt_zahl.Name = "schritt_zahl";
            this.schritt_zahl.Size = new System.Drawing.Size(37, 20);
            this.schritt_zahl.TabIndex = 9;
            this.schritt_zahl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.schritt_zahl.ValueChanged += new System.EventHandler(this.schritt_zahl_ValueChanged);
            // 
            // dauer_zahl
            // 
            this.dauer_zahl.Location = new System.Drawing.Point(212, 55);
            this.dauer_zahl.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.dauer_zahl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dauer_zahl.Name = "dauer_zahl";
            this.dauer_zahl.Size = new System.Drawing.Size(37, 20);
            this.dauer_zahl.TabIndex = 10;
            this.dauer_zahl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_weiter
            // 
            this.button_weiter.Location = new System.Drawing.Point(487, 57);
            this.button_weiter.Name = "button_weiter";
            this.button_weiter.Size = new System.Drawing.Size(75, 23);
            this.button_weiter.TabIndex = 11;
            this.button_weiter.Text = "Weiter";
            this.button_weiter.UseVisualStyleBackColor = true;
            this.button_weiter.Click += new System.EventHandler(this.button_weiter_Click);
            // 
            // button_abbrechen
            // 
            this.button_abbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_abbrechen.Location = new System.Drawing.Point(568, 57);
            this.button_abbrechen.Name = "button_abbrechen";
            this.button_abbrechen.Size = new System.Drawing.Size(75, 23);
            this.button_abbrechen.TabIndex = 12;
            this.button_abbrechen.Text = "Abbrechen";
            this.button_abbrechen.UseVisualStyleBackColor = true;
            this.button_abbrechen.Click += new System.EventHandler(this.button_abbrechen_Click);
            // 
            // button_zurueck
            // 
            this.button_zurueck.Location = new System.Drawing.Point(406, 57);
            this.button_zurueck.Name = "button_zurueck";
            this.button_zurueck.Size = new System.Drawing.Size(75, 23);
            this.button_zurueck.TabIndex = 13;
            this.button_zurueck.Text = "Zurück";
            this.button_zurueck.UseVisualStyleBackColor = true;
            this.button_zurueck.Click += new System.EventHandler(this.button_zurueck_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.numericEbene);
            this.panel1.Controls.Add(this.labelEbene);
            this.panel1.Location = new System.Drawing.Point(581, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 22);
            this.panel1.TabIndex = 0;
            // 
            // labelEbene
            // 
            this.labelEbene.AutoSize = true;
            this.labelEbene.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEbene.Location = new System.Drawing.Point(3, 2);
            this.labelEbene.Name = "labelEbene";
            this.labelEbene.Size = new System.Drawing.Size(58, 13);
            this.labelEbene.TabIndex = 2;
            this.labelEbene.Text = "Ebene: 1";
            this.labelEbene.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericEbene
            // 
            this.numericEbene.Location = new System.Drawing.Point(81, 0);
            this.numericEbene.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericEbene.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericEbene.Name = "numericEbene";
            this.numericEbene.Size = new System.Drawing.Size(18, 20);
            this.numericEbene.TabIndex = 1;
            this.numericEbene.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericEbene.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // LEDpanel
            // 
            this.LEDpanel.Location = new System.Drawing.Point(0, 86);
            this.LEDpanel.Name = "LEDpanel";
            this.LEDpanel.Size = new System.Drawing.Size(695, 329);
            this.LEDpanel.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_abbrechen;
            this.ClientSize = new System.Drawing.Size(695, 440);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LEDpanel);
            this.Controls.Add(this.button_zurueck);
            this.Controls.Add(this.button_abbrechen);
            this.Controls.Add(this.button_weiter);
            this.Controls.Add(this.dauer_zahl);
            this.Controls.Add(this.schritt_zahl);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.Dauer);
            this.Controls.Add(this.Schritt);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Menue);
            this.MainMenuStrip = this.Menue;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Dauer:";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Menue.ResumeLayout(false);
            this.Menue.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schritt_zahl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dauer_zahl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEbene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip Menue;
        public System.Windows.Forms.ToolStripMenuItem Datei;
        public System.Windows.Forms.ToolStripMenuItem Neu;
        public System.Windows.Forms.ToolStripMenuItem Speichern;
        public System.Windows.Forms.ToolStripMenuItem SpeichernUnter;
        public System.Windows.Forms.ToolStripMenuItem Exportieren;
        public System.Windows.Forms.ToolStripMenuItem Bearbeiten;
        public System.Windows.Forms.ToolStripMenuItem Hilfe;
        public System.Windows.Forms.ToolStripMenuItem Öffnen;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.Label Schritt;
        public System.Windows.Forms.Label Dauer;
        public System.Windows.Forms.Label ms;
        public System.Windows.Forms.NumericUpDown schritt_zahl;
        public System.Windows.Forms.NumericUpDown dauer_zahl;
        public System.Windows.Forms.Button button_weiter;
        public System.Windows.Forms.Button button_abbrechen;
        public System.Windows.Forms.Button button_zurueck;
        private xPanel LEDpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelEbene;
        private System.Windows.Forms.NumericUpDown numericEbene;
    }
}

