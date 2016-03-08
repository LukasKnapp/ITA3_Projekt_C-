namespace Arduino_Matrix_Generator
{
    partial class NeuFenster
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            this.Laenge = new System.Windows.Forms.Label();
            this.Breite = new System.Windows.Forms.Label();
            this.Hoehe = new System.Windows.Forms.Label();
            this.Verzoegerung = new System.Windows.Forms.Label();
            this.zahl_laenge = new System.Windows.Forms.NumericUpDown();
            this.zahl_hoehe = new System.Windows.Forms.NumericUpDown();
            this.zahl_breite = new System.Windows.Forms.NumericUpDown();
            this.zahl_verzoegerung = new System.Windows.Forms.NumericUpDown();
            this.ms2 = new System.Windows.Forms.Label();
            this.LED = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_abbrechen = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zahl_laenge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahl_hoehe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahl_breite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahl_verzoegerung)).BeginInit();
            this.SuspendLayout();
            // 
            // Laenge
            // 
            this.Laenge.AutoSize = true;
            this.Laenge.Location = new System.Drawing.Point(232, 9);
            this.Laenge.Name = "Laenge";
            this.Laenge.Size = new System.Drawing.Size(40, 13);
            this.Laenge.TabIndex = 0;
            this.Laenge.Text = "Länge:";
            // 
            // Breite
            // 
            this.Breite.AutoSize = true;
            this.Breite.Location = new System.Drawing.Point(232, 35);
            this.Breite.Name = "Breite";
            this.Breite.Size = new System.Drawing.Size(37, 13);
            this.Breite.TabIndex = 2;
            this.Breite.Text = "Breite:";
            // 
            // Hoehe
            // 
            this.Hoehe.AutoSize = true;
            this.Hoehe.Location = new System.Drawing.Point(232, 61);
            this.Hoehe.Name = "Hoehe";
            this.Hoehe.Size = new System.Drawing.Size(36, 13);
            this.Hoehe.TabIndex = 4;
            this.Hoehe.Text = "Höhe:";
            // 
            // Verzoegerung
            // 
            this.Verzoegerung.AutoSize = true;
            this.Verzoegerung.Location = new System.Drawing.Point(232, 85);
            this.Verzoegerung.Name = "Verzoegerung";
            this.Verzoegerung.Size = new System.Drawing.Size(70, 13);
            this.Verzoegerung.TabIndex = 8;
            this.Verzoegerung.Text = "Verzögerung:";
            // 
            // zahl_laenge
            // 
            this.zahl_laenge.Location = new System.Drawing.Point(310, 7);
            this.zahl_laenge.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.zahl_laenge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.zahl_laenge.Name = "zahl_laenge";
            this.zahl_laenge.Size = new System.Drawing.Size(120, 20);
            this.zahl_laenge.TabIndex = 10;
            this.zahl_laenge.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.zahl_laenge.ValueChanged += new System.EventHandler(this.zahl_laenge_ValueChanged);
            // 
            // zahl_hoehe
            // 
            this.zahl_hoehe.Location = new System.Drawing.Point(310, 59);
            this.zahl_hoehe.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.zahl_hoehe.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.zahl_hoehe.Name = "zahl_hoehe";
            this.zahl_hoehe.Size = new System.Drawing.Size(120, 20);
            this.zahl_hoehe.TabIndex = 11;
            this.zahl_hoehe.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // zahl_breite
            // 
            this.zahl_breite.Location = new System.Drawing.Point(310, 33);
            this.zahl_breite.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.zahl_breite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.zahl_breite.Name = "zahl_breite";
            this.zahl_breite.Size = new System.Drawing.Size(120, 20);
            this.zahl_breite.TabIndex = 12;
            this.zahl_breite.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // zahl_verzoegerung
            // 
            this.zahl_verzoegerung.Location = new System.Drawing.Point(310, 85);
            this.zahl_verzoegerung.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.zahl_verzoegerung.Name = "zahl_verzoegerung";
            this.zahl_verzoegerung.Size = new System.Drawing.Size(120, 20);
            this.zahl_verzoegerung.TabIndex = 13;
            // 
            // ms2
            // 
            this.ms2.AutoSize = true;
            this.ms2.Location = new System.Drawing.Point(436, 87);
            this.ms2.Name = "ms2";
            this.ms2.Size = new System.Drawing.Size(20, 13);
            this.ms2.TabIndex = 14;
            this.ms2.Text = "ms";
            // 
            // LED
            // 
            this.LED.AutoSize = true;
            this.LED.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LED.Location = new System.Drawing.Point(436, 9);
            this.LED.Name = "LED";
            this.LED.Size = new System.Drawing.Size(49, 20);
            this.LED.TabIndex = 15;
            this.LED.Text = "LEDs";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(232, 115);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(102, 23);
            this.button_ok.TabIndex = 16;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_abbrechen
            // 
            this.button_abbrechen.Location = new System.Drawing.Point(340, 115);
            this.button_abbrechen.Name = "button_abbrechen";
            this.button_abbrechen.Size = new System.Drawing.Size(99, 23);
            this.button_abbrechen.TabIndex = 17;
            this.button_abbrechen.Text = "Abbrechen";
            this.button_abbrechen.UseVisualStyleBackColor = true;
            this.button_abbrechen.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Uno",
            "Mega",
            "Pro",
            "Pro Mini",
            "Micro",
            "Nano",
            "Zero"});
            this.comboBox1.Location = new System.Drawing.Point(94, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(94, 35);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Arduino:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Zubehör:";
            // 
            // NeuFenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 146);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_abbrechen);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.LED);
            this.Controls.Add(this.ms2);
            this.Controls.Add(this.zahl_verzoegerung);
            this.Controls.Add(this.zahl_breite);
            this.Controls.Add(this.zahl_hoehe);
            this.Controls.Add(this.zahl_laenge);
            this.Controls.Add(this.Verzoegerung);
            this.Controls.Add(this.Hoehe);
            this.Controls.Add(this.Breite);
            this.Controls.Add(this.Laenge);
            this.Name = "NeuFenster";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zahl_laenge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahl_hoehe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahl_breite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahl_verzoegerung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Laenge;
        private System.Windows.Forms.Label Breite;
        private System.Windows.Forms.Label Hoehe;
        private System.Windows.Forms.Label Verzoegerung;
        private System.Windows.Forms.NumericUpDown zahl_laenge;
        private System.Windows.Forms.NumericUpDown zahl_hoehe;
        private System.Windows.Forms.NumericUpDown zahl_breite;
        private System.Windows.Forms.NumericUpDown zahl_verzoegerung;
        private System.Windows.Forms.Label ms2;
        private System.Windows.Forms.Label LED;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_abbrechen;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}