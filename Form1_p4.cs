using System;

namespace socleds
{
    public partial class Form1
    {
        private void comboBox_port4_SelectedIndexChanged(object sender, EventArgs e)
        {
            definitions.portList[3].type = comboBox_port4.SelectedItem.ToString();
        }
        private void comboBox_port4_speed_SelectedIndexChanged(object sender, EventArgs e)
        {
            definitions.portList[3].speed = comboBox_port4_speed.SelectedItem.ToString();
        }
        private void checkBoxp4l1_1000_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[3].leds[0].s1000 = (bool)checkBoxp4l1_1000.Checked;
            set_1000_color(checkBoxp4l1_1000, 3, 0);
        }
        private void checkBoxp4l2_1000_CheckedChange(object sender, EventArgs e)
        {
            definitions.portList[3].leds[1].s1000 = (bool)checkBoxp4l2_1000.Checked;
            set_1000_color(checkBoxp4l2_1000, 3, 1);
        }
        private void checkBoxp4l3_1000_CheckedChange(object sender, EventArgs e)
        {
            definitions.portList[3].leds[2].s1000 = (bool)checkBoxp4l3_1000.Checked;
            set_1000_color(checkBoxp4l3_1000, 3, 2);
        }
        private void checkBoxp4l4_1000_CheckedChange(object sender, EventArgs e)
        {
            definitions.portList[3].leds[3].s1000 = (bool)checkBoxp4l4_1000.Checked;
            set_1000_color(checkBoxp4l4_1000, 3, 3);
        }
        private void checkBoxp4l1_100_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[3].leds[0].s100 = (bool)checkBoxp4l1_100.Checked;
            set_100_color(checkBoxp4l1_100, 3, 0);
        }
        private void checkBoxp4l2_100_CheckedChange(object sender, EventArgs e)
        {
            definitions.portList[3].leds[1].s100 = (bool)checkBoxp4l2_100.Checked;
            set_100_color(checkBoxp4l2_100, 3, 1);
        }
        private void checkBoxp4l3_100_CheckedChange(object sender, EventArgs e)
        {
            definitions.portList[3].leds[2].s100 = (bool)checkBoxp4l3_100.Checked;
            set_100_color(checkBoxp4l3_100, 3, 2);
        }
        private void checkBoxp4l4_100_CheckedChange(object sender, EventArgs e)
        {
            definitions.portList[3].leds[3].s100 = (bool)checkBoxp4l4_100.Checked;
            set_100_color(checkBoxp4l4_100, 3, 3);
        }
        private void checkBoxp4l1_10_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[3].leds[0].s10 = (bool)checkBoxp4l1_10.Checked;
            set_10_color(checkBoxp4l1_10, 3, 0);
        }
        private void checkBoxp4l2_10_CheckedChange(object sender, EventArgs e)
        {
            definitions.portList[3].leds[1].s10 = (bool)checkBoxp4l2_10.Checked;
            set_10_color(checkBoxp4l2_10, 3, 1);
        }
        private void checkBoxp4l3_10_CheckedChange(object sender, EventArgs e)
        {
            definitions.portList[3].leds[2].s10 = (bool)checkBoxp4l3_10.Checked;
            set_10_color(checkBoxp4l3_10, 3, 2);
        }
        private void checkBoxp4l4_10_CheckedChange(object sender, EventArgs e)
        {
            definitions.portList[3].leds[3].s10 = (bool)checkBoxp4l4_10.Checked;
            set_10_color(checkBoxp4l4_10, 3, 3);
        }
        private void checkBoxp4l1_CheckedChanged(object sender, EventArgs e)
        {
            definitions.portList[3].leds[0].activity = (bool)checkBoxp4l1.Checked;
            set_activity_color(checkBoxp4l1, 3, 0);
        }
        private void checkBoxp4l2_CheckedChange(object sender, EventArgs e)
        {
            definitions.portList[3].leds[1].activity = (bool)checkBoxp4l2.Checked;
            set_activity_color(checkBoxp4l2, 3, 1);
        }
        private void checkBoxp4l3_CheckedChange(object sender, EventArgs e)
        {
            definitions.portList[3].leds[2].activity = (bool)checkBoxp4l3.Checked;
            set_activity_color(checkBoxp4l3, 3, 2);
        }
        private void checkBoxp4l4_CheckedChange(object sender, EventArgs e)
        {
            definitions.portList[3].leds[3].activity = (bool)checkBoxp4l4.Checked;
            set_activity_color(checkBoxp4l4, 3, 3);
        }
        private void comboBoxp4l1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = comboBoxp4l1.SelectedItem.ToString();
            updateGpio(sel, 3, 0);
            comboBoxp4l1.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate { comboBoxp4l1.Text = sel; });
        }
        private void comboBoxp4l2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = comboBoxp4l2.SelectedItem.ToString();
            updateGpio(sel, 3, 1);
            comboBoxp4l2.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate { comboBoxp4l2.Text = sel; });
        }
        private void comboBoxp4l3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = comboBoxp4l3.SelectedItem.ToString();
            updateGpio(sel, 3, 2);
            comboBoxp4l3.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate { comboBoxp4l3.Text = sel; });
        }
        private void comboBoxp4l4_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = comboBoxp4l4.SelectedItem.ToString();
            updateGpio(sel, 3, 3);
            comboBoxp4l4.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate { comboBoxp4l4.Text = sel; });
        }
    }
}
