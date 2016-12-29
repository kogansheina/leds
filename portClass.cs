using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace socleds
{
    public class Port
    {
        public int number;
        public int mode;
        public string type;
        public string speed;
        public List<Led> leds = new List<Led> { };
        public ComboBox comboBoxType;
        public ComboBox comboBoxSpeed;

        public Port(int n, int m, string t, string s)
        {
            // Actual constructor implementation
            number = n;
            mode = m;
            type = t;
            speed = s;
            for (int i = 0; i < mode; i++)
                leds.Add(new Led(i, -1));
        }
        public string print()
        {
            string strToPrint = "Port " + number + " : mode=" + mode.ToString() + ", speed=" + speed
                + " , type=" + type + "\n\n";
            return strToPrint;
        }
    }
}
