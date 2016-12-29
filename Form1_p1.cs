using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace socleds
{
    public partial class Form1
    {
        // rgmii - port type
        private void comboBox_port1_SelectedIndexChanged(object sender, EventArgs e)
        {
            definitions.portList[0].type = comboBox_port1.SelectedItem.ToString();
        }
        // port speed 
        private void comboBox_port1_speed_SelectedIndexChanged(object sender, EventArgs e)
        {
            definitions.portList[0].speed = comboBox_port1_speed.SelectedItem.ToString();
        }
        private void updateGpioList(int portnumber, int lednumber, int seli)
        {
            List<string> listToBind = new List<string> {"None" };
            for (int i = 0; i < definitions.get_default(); i++)
                if (!definitions.gpioListL[i])
                    listToBind.Add(i.ToString());           
            for (var i = 0; i < definitions.get_ports(); i++)
            {
                Port port = definitions.portList[i];
                for (int j = 0; j < definitions.get_mode(); j++)
                {
                    Led led = port.leds[j];
                    if (led.comboBoxGpio == null) return; // case of pre-configuration from file
                    if ((lednumber == j) && (portnumber == i))
                        led.gpio = seli;
                   led.comboBoxGpio.Items.Clear();
                   foreach (string s in listToBind)
                      led.comboBoxGpio.Items.Add(s);
                }
            }
        }       
        private void updateGpio(string sel, int port, int led)
        {
            int current = definitions.portList[port].leds[led].gpio;
            int seli = -1;

            if (sel != "None")
                seli = Convert.ToInt32(sel);

            if (seli == current) return;
            /* free the old GPIO */
            if (current >= 0)
                definitions.gpioListL[current] = false;
            setGpio(current, false);

            /* occupy selected */
            if (seli != -1)
            {
                definitions.gpioListL[seli] = true;
                setGpio(seli, true);
            }
            updateGpioList(port, led, seli);
        }
        // list of gpios led 1
        private void comboBoxp1l1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = comboBoxp1l1.SelectedItem.ToString();
            updateGpio(sel,0,0);
            comboBoxp1l1.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate { comboBoxp1l1.Text = sel; });
        }

        // activity port 1 led 1
        private void checkBoxp1l1_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[0].leds[0].activity = (bool)checkBoxp1l1.Checked;
            set_activity_color(checkBoxp1l1,0,0);
        }
        private void set_10_color(CheckBox cbx, int port, int led)
        {
            if (definitions.portList[port].leds[led].s10)
                cbx.ForeColor = System.Drawing.Color.LawnGreen;
            else
                cbx.ForeColor = System.Drawing.Color.Black;
        }
        private void set_100_color(CheckBox cbx, int port, int led)
        {
            if (definitions.portList[port].leds[led].s100)
                cbx.ForeColor = System.Drawing.Color.Orange;
            else
                cbx.ForeColor = System.Drawing.Color.Black;
        }
        private void set_1000_color(CheckBox cbx, int port, int led)
        {
            if (definitions.portList[port].leds[led].s1000)
                cbx.ForeColor = System.Drawing.Color.OrangeRed;
            else
                cbx.ForeColor = System.Drawing.Color.Black;
        }
        private void set_activity_color(CheckBox cbx, int port, int led)
        {
            if (definitions.portList[port].leds[led].activity)
                cbx.ForeColor = System.Drawing.Color.Red;
            else
                cbx.ForeColor = System.Drawing.Color.Black;
        }
        // speed 10 port 1 led 1
        private void checkBoxp1l1_10_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[0].leds[0].s10 = (bool)checkBoxp1l1_10.Checked;
            set_10_color(checkBoxp1l1_10, 0, 0);
        }

        // speed 100 port 1 led 1
        private void checkBoxp1l1_100_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[0].leds[0].s100 = (bool)checkBoxp1l1_100.Checked;
            set_100_color(checkBoxp1l1_100, 0, 0);
        }

        // speed G port 1 led 1
        private void checkBoxp1l1_1000_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[0].leds[0].s1000 = (bool)checkBoxp1l1_1000.Checked;
            set_1000_color(checkBoxp1l1_1000, 0, 0);
        }
        private void comboBoxp1l2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = comboBoxp1l2.SelectedItem.ToString();
            updateGpio(sel, 0, 1);
            comboBoxp1l2.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate { comboBoxp1l2.Text = sel; });
        }
        private void checkBoxp1l2_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[0].leds[1].activity = (bool)checkBoxp1l2.Checked;
            set_activity_color(checkBoxp1l2, 0, 1);
        }
        private void checkBoxp1l2_10_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[0].leds[1].s10 = (bool)checkBoxp1l2_10.Checked;
            set_10_color(checkBoxp1l2_10, 0, 1);
        }
        private void checkBoxp1l2_100_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[0].leds[1].s100 = (bool)checkBoxp1l2_100.Checked;
            set_10_color(checkBoxp1l2_100, 0, 1);
        }
        private void checkBoxp1l2_1000_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[0].leds[1].s1000 = (bool)checkBoxp1l2_1000.Checked;
            set_10_color(checkBoxp1l2_1000, 0, 1);
        }
        private void comboBoxp1l3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = comboBoxp1l3.SelectedItem.ToString();
            updateGpio(sel, 0, 2);
            comboBoxp1l3.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate { comboBoxp1l3.Text = sel; });
        }
        private void checkBoxp1l3_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[0].leds[2].activity = (bool)checkBoxp1l3.Checked;
            set_activity_color(checkBoxp1l3, 0, 2);
        }
        private void checkBoxp1l3_10_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[0].leds[2].s10 = (bool)checkBoxp1l3_10.Checked;
            set_10_color(checkBoxp1l3_10, 0, 2);
        }
        private void checkBoxp1l3_100_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[0].leds[2].s100 = (bool)checkBoxp1l3_100.Checked;
            set_100_color(checkBoxp1l3_100, 0, 2);
        }
        private void checkBoxp1l3_1000_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[0].leds[2].s1000 = (bool)checkBoxp1l3_1000.Checked;
            set_1000_color(checkBoxp1l3_1000, 0, 2);
        }
        private void comboBoxp1l4_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = comboBoxp1l4.SelectedItem.ToString();
            updateGpio(sel, 0, 3);
            comboBoxp1l4.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate { comboBoxp1l4.Text = sel; });
        }
        private void checkBoxp1l4_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[0].leds[3].activity = (bool)checkBoxp1l4.Checked;
            set_activity_color(checkBoxp1l4, 0, 3);
        }
        private void checkBoxp1l4_10_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[0].leds[3].s10 = (bool)checkBoxp1l4_10.Checked;
            set_10_color(checkBoxp1l4_10, 0, 3);
        }
        private void checkBoxp1l4_100_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[0].leds[3].s100 = (bool)checkBoxp1l4_100.Checked;
            set_100_color(checkBoxp1l4_100, 0, 3);
        }
        private void checkBoxp1l4_1000_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[0].leds[3].s1000 = (bool)checkBoxp1l4_1000.Checked;
            set_1000_color(checkBoxp1l4_1000, 0, 3);
        }
    }
}
