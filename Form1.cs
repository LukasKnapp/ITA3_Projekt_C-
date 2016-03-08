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
    public partial class Form1 : Form
    {
        public List<PixelBox> pbx = new List<PixelBox>();
        List<xPanel> xpnl = new List<xPanel>();
        public NeuFenster nF;
        public List<Schritt> Schritte;
        public List<string> Pin;
        public bool manual;
        public int x;
        public int y;
        public int z;
        Image on;
        Image off;


        public Form1()
        {
            InitializeComponent();
            nF = new NeuFenster(this);
            Schritte = new List<Schritt>();
            nF.ShowDialog();
            on = Properties.Resources.LED_an;
            off = Properties.Resources.LED_aus;



            for (int k = 0; k <= z; k++)
              {
                /*xPanel panel = new xPanel();
                panel.Location = new System.Drawing.Point(0, 86);
                panel.Name = "Layer" + k;
                panel.Size = new System.Drawing.Size(695, 329);
                panel.TabIndex = 19;
                this.Controls.Add(panel);
                xpnl.Add(panel);*/

                for (int i = 0; i <= x; i++)
                {
                    for (int j = 0; j <= y; j++)
                    {

                        PixelBox pic = new PixelBox();
                        pic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
                        pic.BackColor = System.Drawing.Color.Transparent;
                        pic.Image = off;
                        pic.Location = new System.Drawing.Point(3 + i * 30,3+ j * 30);
                        pic.Name = "pic[" + i + "," + j + "," + k + "]";
                        pic.Size = new System.Drawing.Size(29, 29);
                        pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;


                        if (k == 0)
                        {
                            pic.Visible = true;
                        }
                        else
                        {
                            pic.Visible = false;
                        }

                        this.ResumeLayout(false);
                        this.LEDpanel.Controls.Add(pic);
                        pbx.Add(pic);

                        pic.Click += (object sender, EventArgs e) =>
                        {
                            string xx = pic.Name.Substring(pic.Name.IndexOf("[") + 1, pic.Name.IndexOf(",") - pic.Name.IndexOf("[") - 1);
                            string yy = pic.Name.Substring(pic.Name.IndexOf(",") + 1, pic.Name.LastIndexOf(",") - pic.Name.IndexOf(",") - 1);
                            string zz = pic.Name.Substring(pic.Name.LastIndexOf(",") + 1, pic.Name.IndexOf("]") - pic.Name.LastIndexOf(",") - 1);
                                if (pic.Image == off)
                                {
                                    pic.Image = on;
                                    Schritte[Convert.ToInt32(schritt_zahl.Value) - 1].LEDs[Convert.ToInt32(xx), Convert.ToInt32(yy), Convert.ToInt32(zz)] = true;
                                }

                                else
                                {
                                    pic.Image = off;
                                    Schritte[Convert.ToInt32(schritt_zahl.Value) - 1].LEDs[Convert.ToInt32(xx), Convert.ToInt32(yy), Convert.ToInt32(zz)] = false;
                                }
                        };
                    }
                }
                
            }
        }

        private void ms_Click(object sender, EventArgs e)
        {

        }

        private void button_weiter_Click(object sender, EventArgs e)
        {
            schritt_zahl.Value++;

            UpdatePic();
        }

        private void button_zurueck_Click(object sender, EventArgs e)
        {
            schritt_zahl.Value--;

            UpdatePic();
        }

        private void button_abbrechen_Click(object sender, EventArgs e)
        {

        }

        private void Neu_Click(object sender, EventArgs e)
        {
            nF.Visible = true;
            
        }

        private void Öffnen_Click(object sender, EventArgs e)
        {

        }

        private void Speichern_Click(object sender, EventArgs e)
        {

        }

        private void SpeichernUnter_Click(object sender, EventArgs e)
        {

        }

        private void Exportieren_Click(object sender, EventArgs e)
        {
            if (z == 0)
            {
                StreamWriter sw = new StreamWriter("test.ino");
                sw.WriteLine("void setup() {");

                for (int i = 0; i <= (x + 1 * y + 1); i++)
                {
                    sw.WriteLine("\tpinMode(" + Pin[i] + ", OUTPUT);");
                }

                sw.WriteLine("}");
                sw.WriteLine("");
                sw.WriteLine("void loop() {");

                foreach (Schritt s in Schritte)
                {
                    sw.WriteLine("for(int i=0;i<=" + s.Dauer + ";i+=0){");
                    for (int i = 0; i <= x; i++)
                    {
                        for (int j = 0; j <= x; j++)
                        {
                            if (j == i)
                            {
                                sw.WriteLine("\tdigitalWrite(" + Pin[j] + ", HIGH);");
                            }
                            else
                            {
                                sw.WriteLine("\tdigitalWrite(" + Pin[j] + ", LOW);");
                            }
                        }

                        for (int j = 0; j <= y; j++)
                        {
                            if (s.LEDs[i, j, 0] == true)
                            {
                                sw.WriteLine("\tdigitalWrite(" + (Pin[Convert.ToInt32(x) + j + 1]) + ", LOW);");
                            }
                            else
                            {
                                sw.WriteLine("\tdigitalWrite(" + (Pin[Convert.ToInt32(x) + j + 1]) + ", HIGH);");
                            }
                        }
                        sw.WriteLine("\tdelay(2);");
                        sw.WriteLine("i+=2;");

                    }
                    sw.WriteLine("}");
                }
                sw.WriteLine("}");

                sw.Close();
            }
            else
            {
                
            }

        }

        private void ebene_zahl_ValueChanged(object sender, EventArgs e)
        {

        }

        private void schritt_zahl_ValueChanged(object sender, EventArgs e)
        {
            UpdatePic();        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void UpdatePic()
        {
            while (Schritte.Count < schritt_zahl.Value)
            {
                bool[, ,] LEDs = new bool[Convert.ToInt32(x + 1), Convert.ToInt32(y + 1), Convert.ToInt32(z + 1)];
                Schritte.Add(new Schritt(LEDs, 500));
            }
                for (int i = 0; i <= x; i++)
                {
                    for (int j = 0; j <= y; j++)
                    {
                        foreach (PixelBox p in this.LEDpanel.Controls)
                        {
                            if (p.Name == "pic[" + i + "," + j + "," + Convert.ToInt32(numericEbene.Value-1) + "]")
                            {
                                if (Schritte[Convert.ToInt32(schritt_zahl.Value) - 1].LEDs[i, j, Convert.ToInt32(numericEbene.Value-1)])
                                {
                                    p.Image = on;
                                }
                                else
                                {
                                    p.Image = off;
                                }
                            }
                        }
                    }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            labelEbene.Text = "Ebene: " + numericEbene.Value;
            
            foreach (PixelBox p in this.LEDpanel.Controls)
            {
                p.Visible = false;
            }


            for (int i = 0; i <= x; i++)
                {
                    for (int j = 0; j <= y; j++)

                            foreach (PixelBox p in this.LEDpanel.Controls)
                            {
                                if (p.Name == "pic[" + i + "," + j + "," + Convert.ToInt32(numericEbene.Value-1) + "]")
                                {
                                    p.Visible = true;
                                }  
                            }                        
                    }

            UpdatePic();    
        }
    }
}
