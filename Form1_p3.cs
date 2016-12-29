using System;

namespace socleds
{
    public partial class Form1
    {
        private void comboBox_port3_SelectedIndexChanged(object sender, EventArgs e)
        {
            definitions.portList[2].type = comboBox_port3.SelectedItem.ToString();
        }
        private void comboBox_port3_speed_SelectedIndexChanged(object sender, EventArgs e)
        {
            definitions.portList[2].speed = comboBox_port3_speed.SelectedItem.ToString();
        }
        private void checkBoxp3l1_1000_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[2].leds[0].s1000 = (bool)checkBoxp3l1_1000.Checked;
            set_1000_color(checkBoxp3l1_1000, 2, 0);
        }
        private void checkBoxp3l2_1000_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[2].leds[1].s1000 = (bool)checkBoxp3l2_1000.Checked;
            set_1000_color(checkBoxp3l2_1000, 2, 1);
        }
        private void checkBoxp3l3_1000_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[2].leds[2].s1000 = (bool)checkBoxp3l3_1000.Checked;
            set_1000_color(checkBoxp3l3_1000, 2, 2);
        }
        private void checkBoxp3l4_1000_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[2].leds[3].s1000 = (bool)checkBoxp3l4_1000.Checked;
            set_1000_color(checkBoxp3l4_1000, 2, 3);
        }
        private void checkBoxp3l1_100_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[2].leds[0].s100 = (bool)checkBoxp3l1_100.Checked;
            set_100_color(checkBoxp3l1_100, 2, 0);
        }
        private void checkBoxp3l2_100_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[2].leds[1].s100 = (bool)checkBoxp3l2_100.Checked;
            set_100_color(checkBoxp3l2_100, 2, 1);
        }
        private void checkBoxp3l3_100_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[2].leds[2].s100 = (bool)checkBoxp3l3_100.Checked;
            set_100_color(checkBoxp3l3_100, 2, 2);
        }
        private void checkBoxp3l4_100_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[2].leds[3].s100 = (bool)checkBoxp3l4_100.Checked;
            set_100_color(checkBoxp3l4_100, 2, 3);
        }
        private void checkBoxp3l1_10_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[2].leds[0].s10 = (bool)checkBoxp3l1_10.Checked;
            set_10_color(checkBoxp3l1_10, 2, 0);
        }
        private void checkBoxp3l2_10_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[2].leds[1].s10 = (bool)checkBoxp3l2_10.Checked;
            set_10_color(checkBoxp3l2_10, 2, 1);
        }
        private void checkBoxp3l3_10_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[2].leds[2].s10 = (bool)checkBoxp3l3_10.Checked;
            set_10_color(checkBoxp3l3_10, 2, 2);
        }
        private void checkBoxp3l4_10_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[2].leds[3].s10 = (bool)checkBoxp3l4_10.Checked;
            set_10_color(checkBoxp3l4_10, 2, 3);
        }
        private void checkBoxp3l1_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[2].leds[0].activity = (bool)checkBoxp3l1.Checked;
            set_activity_color(checkBoxp3l1, 2, 0);
        }
        private void checkBoxp3l2_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[2].leds[1].activity = (bool)checkBoxp3l2.Checked;
            set_activity_color(checkBoxp3l2, 2, 1);
        }
        private void checkBoxp3l3_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[2].leds[2].activity = (bool)checkBoxp3l3.Checked;
            set_activity_color(checkBoxp3l3, 2, 2);
        }
        private void checkBoxp3l4_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[2].leds[3].activity = (bool)checkBoxp3l4.Checked;
            set_activity_color(checkBoxp3l4, 2, 3);
        }
        private void comboBoxp3l1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = comboBoxp3l1.SelectedItem.ToString();
            updateGpio(sel, 2, 0);
            comboBoxp3l1.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate { comboBoxp3l1.Text = sel; });
        }
        private void comboBoxp3l2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = comboBoxp3l2.SelectedItem.ToString();
            updateGpio(sel, 2, 1);
            comboBoxp3l2.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate { comboBoxp3l2.Text = sel; });
        }
        private void comboBoxp3l3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = comboBoxp3l3.SelectedItem.ToString();
            updateGpio(sel, 2, 2);
            comboBoxp3l3.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate { comboBoxp3l3.Text = sel; });
        }
        private void comboBoxp3l4_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = comboBoxp3l4.SelectedItem.ToString();
            updateGpio(sel, 2, 3);
            comboBoxp3l4.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate { comboBoxp3l4.Text = sel; });
        }
    }
}
