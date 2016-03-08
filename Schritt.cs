using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arduino_Matrix_Generator
{
    public class Schritt
    {
        private bool[,,] leds;
        private int dauer;

        public Schritt(){


        }

        public Schritt(bool[,,] LEDs, int Dauer)
        {
            this.leds = LEDs;
            this.dauer = Dauer;
        }


        public bool[,,] LEDs
        {
            get { return this.leds; }
            set { this.leds = value; }
        }

        public int Dauer
        {
            get { return this.dauer; }
            set { this.dauer = value; }
        }

    }
}
