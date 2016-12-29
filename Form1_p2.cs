using System;

namespace socleds
{
    public partial class Form1
    {
        private void comboBox_port2_SelectedIndexChanged(object sender, EventArgs e)
        {
            definitions.portList[1].type = comboBox_port2_speed.SelectedItem.ToString();
        }
        private void comboBox_port2_speed_SelectedIndexChanged(object sender, EventArgs e)
        {
            definitions.portList[1].speed = comboBox_port2_speed.SelectedItem.ToString();
        }
        private void comboBoxp2l1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = comboBoxp2l1.SelectedItem.ToString();
            updateGpio(sel, 1, 0);
            comboBoxp2l1.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate { comboBoxp2l1.Text = sel; });
        }
        private void checkBoxp2l1_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[1].leds[0].activity = (bool)checkBoxp2l1.Checked;
            set_activity_color(checkBoxp2l1, 1, 0);
        }
        private void checkBoxp2l1_10_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[1].leds[0].s10 = (bool)checkBoxp2l1_10.Checked;
            set_10_color(checkBoxp2l1_10, 1, 0);
        }
        private void checkBoxp2l1_100_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[1].leds[0].s100 = (bool)checkBoxp2l1_100.Checked;
            set_100_color(checkBoxp2l1_100, 1, 0);
        }
        private void checkBoxp2l1_1000_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[1].leds[0].s1000 = (bool)checkBoxp2l1_1000.Checked;
            set_1000_color(checkBoxp2l1_1000, 1, 0);
        }
        private void comboBoxp2l2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = comboBoxp2l2.SelectedItem.ToString();
            updateGpio(sel, 1, 1);
            comboBoxp2l2.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate { comboBoxp2l2.Text = sel; });
        }
        private void checkBoxp2l2_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[1].leds[1].activity = (bool)checkBoxp2l2.Checked;
            set_activity_color(checkBoxp2l2, 1, 1);
        }
        private void checkBoxp2l2_10_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[1].leds[1].s10 = (bool)checkBoxp2l2_10.Checked;
            set_10_color(checkBoxp2l2_10, 1, 1);
        }
        private void checkBoxp2l2_100_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[1].leds[1].s100 = (bool)checkBoxp2l2_100.Checked;
            set_100_color(checkBoxp2l2_100, 1, 1);
        }
        private void checkBoxp2l2_1000_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[1].leds[1].s1000 = (bool)checkBoxp2l2_1000.Checked;
            set_1000_color(checkBoxp2l2_1000, 1, 1);
        }
        private void comboBoxp2l3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = comboBoxp2l3.SelectedItem.ToString();
            updateGpio(sel, 1, 2);
            comboBoxp2l3.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate { comboBoxp2l3.Text = sel; });
        }
        private void checkBoxp2l3_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[1].leds[2].activity = (bool)checkBoxp2l3.Checked;
            set_activity_color(checkBoxp2l3, 1, 2);
        }
        private void checkBoxp2l3_10_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[1].leds[2].s10 = (bool)checkBoxp2l3_10.Checked;
            set_10_color(checkBoxp2l3_10, 1, 2);
        }
        private void checkBoxp2l3_100_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[1].leds[2].s100 = (bool)checkBoxp2l3_100.Checked;
            set_100_color(checkBoxp2l3_100, 1, 2);
        }
        private void checkBoxp2l3_1000_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[1].leds[2].s1000 = (bool)checkBoxp2l3_1000.Checked;
            set_1000_color(checkBoxp2l3_1000, 1, 2);
        }
        private void comboBoxp2l4_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = comboBoxp2l4.SelectedItem.ToString();
            updateGpio(sel, 1, 3);
            comboBoxp2l4.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate { comboBoxp2l4.Text = sel; });
        }
        private void checkBoxp2l4_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[1].leds[3].activity = (bool)checkBoxp2l4.Checked;
            set_activity_color(checkBoxp2l4, 1, 3);
        }
        private void checkBoxp2l4_10_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[1].leds[3].s10 = (bool)checkBoxp2l4_10.Checked;
            set_10_color(checkBoxp2l4_10, 1, 3);
        }
        private void checkBoxp2l4_100_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[1].leds[3].s100 = (bool)checkBoxp2l4_100.Checked;
            set_100_color(checkBoxp2l4_100, 1, 3);
        }
        private void checkBoxp2l4_1000_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[1].leds[3].s1000 = (bool)checkBoxp2l4_1000.Checked;
            set_1000_color(checkBoxp2l4_1000, 1, 3);
        }
    }
}
