using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Arduino_Matrix_Generator
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        

        public static Form1 f1;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            f1 = new Form1();
            Application.Run(f1);
            f1.Enabled = false;
        }
    }
}
