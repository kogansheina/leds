using System;
using System.Windows.Forms;

namespace socleds
{
    public class Led
    {
        public int number;
        public int gpio;       
        public bool activity;
        public bool s10;
        public bool s100;
        public bool s1000;
        public ComboBox comboBoxGpio;
        public CheckBox checkBoxActivity;
        public CheckBox checkBox10;
        public CheckBox checkBox100;
        public CheckBox checkBox1000;
        public Led(int n, int m)
        {
            // Actual constructor implementation
            number = n;
            gpio = m;
            activity = false;
            s10 = false;
            s100 = false;
            s1000 = false;
            checkBox10 = null;
            checkBox100 = null;
            checkBox1000 = null;
        }
        public string print()
        {
            string strToPrint = "Led " + number + " : gpio=" + gpio.ToString()  
                + ", activity=" + activity.ToString() + ", 10 Mb=" + s10.ToString() + ", 100 Mb=" + s100.ToString()
                + ", s1000=" + s1000.ToString() + "\n\n";
            return strToPrint;
        }
    }
}
