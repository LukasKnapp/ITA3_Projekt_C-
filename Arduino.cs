using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arduino_Matrix_Generator
{
    class Arduino
    {
        public string name { get; set; }
        private List<string> pins= new List<string>();

        public Arduino(string name, List<string> Pins)
        {
            this.name = name;
            this.pins = Pins;
        }

        public List<string> Pins{
            get{return this.pins;}
            set{this.pins= value;}
        }

    }
}
