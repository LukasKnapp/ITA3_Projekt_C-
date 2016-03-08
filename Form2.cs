using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Arduino_Matrix_Generator
{
    public partial class NeuFenster : Form
    {
        List<Arduino> arduinos = new List<Arduino>();
        private Form1 f1;
        public NeuFenster(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("arduinos.opt");
            string[] seperator = new string[1];
            seperator[0] = ";";

            while(!sr.EndOfStream){
                string input=sr.ReadLine();
                string name = input.Split(seperator,StringSplitOptions.None)[0];
                string[] Pin = input.Split(seperator,StringSplitOptions.None);
                List<string> Pins = new List<string>();
                bool skip = true;
                foreach(string p in Pin){
                    if (!skip)
                    {
                        Pins.Add(p);
                    }
                    skip = false;
                }
                Arduino a = new Arduino(name, Pins);
                arduinos.Add(a);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            f1.x = Convert.ToInt32(zahl_laenge.Value) - 1;
            f1.y = Convert.ToInt32(zahl_breite.Value) - 1;
            f1.z = Convert.ToInt32(zahl_hoehe.Value) - 1;
            f1.schritt_zahl.Enabled = true;
            f1.dauer_zahl.Enabled = true;
            f1.button_abbrechen.Enabled = true;
            f1.button_weiter.Enabled = true;
            f1.button_zurueck.Enabled = true;
            f1.Schritte.Clear();
            bool[,,] LEDs = new bool[Convert.ToInt32(zahl_laenge.Value), Convert.ToInt32(zahl_breite.Value), Convert.ToInt32(zahl_hoehe.Value)];
            f1.Schritte.Add(new Schritt(LEDs, 500));
            foreach(Arduino a in arduinos){
                if (this.comboBox1.Text == a.name)
                {
                    f1.Pin = a.Pins;
                    break;
                }
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f1.schritt_zahl.Enabled = false;
            f1.dauer_zahl.Enabled = false;
            f1.button_abbrechen.Enabled = false;
            f1.button_weiter.Enabled = false;
            f1.button_zurueck.Enabled = false;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void zahl_laenge_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
