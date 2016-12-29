using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace socleds
{
    public class general
    {
        static Dictionary<string, int> default_6858_a0 = new Dictionary<string, int>
        {
            {"ports", 7 },
            {"mode", 4 },
            {"default_gpio", 64 }
        };
        static Dictionary<string, int> default_6858_b0 = new Dictionary<string, int>
        {
            {"ports", 7 },
            {"mode", 4 },
            {"default_gpio", 64 }
        };
        static Dictionary<string, int> default_4908 = new Dictionary<string, int>
        {
            {"ports", 4 },
            {"mode", 4 },
            {"default_gpio", 32 }
        };

        private static string board = "none";
        private static int ports = 0;
        private static int mode = 0;
        private static int default_gpio = 0;

        public List<bool> gpioListL = new List<bool> { };      // gpio status on the left of the SoC
        public List<Port> portList = new List<Port> { };      // main data mase - list of ports objects

        public string get_board() { return board; }      
        public void set_mode(int m) { mode = m; }
        public int get_mode() { return mode; }       
        public void set_ports(int p) { ports = p; }
        public int get_ports() { return ports; }
        public void set_default(int l) { default_gpio = l; }
        public int get_default() { return default_gpio; }

        public general(string boardi) // constructor
        {
            Dictionary<string, int> defs = null;
            board = boardi;
            switch (board)
            {
                case "6858_a0":
                    defs = default_6858_a0;
                    break;
                case "6858_b0":
                    defs = default_6858_b0;
                    break;
                case "4908":
                    defs = default_4908;
                    break;
            }
            default_gpio = defs["default_gpio"];
            ports = defs["ports"];
            mode = defs["mode"];
            for (var i = 0; i < default_gpio; i++)
                gpioListL.Add(false);
            for (var i = 1; i <= ports; i++)
                portList.Add(new Port(i, mode, "rgmii", "10 Mb"));
        }
        public void print()
        {
            MessageBox.Show("Board="+board+"\nMode="+mode.ToString()+"\nPorts="+ports.ToString()
                +"\nGpios="+ default_gpio.ToString()+ "\n");
            string str = "";
            for (var t=0; t < default_gpio; t++)
            {
                str += gpioListL[t].ToString() + ",";
            }
            string s = string.Copy(str);
            MessageBox.Show("GPIos: " + s + "\n");
            foreach (Port port in portList)
                MessageBox.Show(port.print());
        }
       
        private bool check_data(Dictionary<string, int> defs)
        {
            if ((mode > defs["mode"]) || (mode <= 0))
                return false;
            if ((ports > defs["ports"]) || (ports <= 0))
                return false;
            if (((default_gpio) > defs["default_gpio"]) || (default_gpio <= 0))
                return false;
            return true;
        }
               
        public void initialize_data()
        {
             switch (board)
             {
                case "6858_a0":
                    if (!check_data(default_6858_a0))
                        MessageBox.Show("Some data is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "6858_b0":
                    if (!check_data(default_6858_b0))
                        MessageBox.Show("Some data is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "4908":
                    if (!check_data(default_4908))
                        MessageBox.Show("Some data is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;
             }
         }
    }
}
