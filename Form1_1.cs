using System;
using System.Drawing;

namespace socleds
{
    public partial class Form1 
    {
        private void showGPIO()
        {
            for (var i = 0; i < definitions.get_default(); i++)
            {
                switch (i)
                {
                    case 0:
                        checkBox1.Visible = true;
                        break;
                    case 1:
                        checkBox2.Visible = true;
                        break;
                    case 2:
                        checkBox3.Visible = true;
                        break;
                    case 3:
                        checkBox4.Visible = true;
                        break;
                    case 4:
                        checkBox5.Visible = true;
                        break;
                    case 5:
                        checkBox6.Visible = true;
                        break;
                    case 6:
                        checkBox7.Visible = true;
                        break;
                    case 7:
                        checkBox8.Visible = true;
                        break;
                    case 8:
                        checkBox9.Visible = true;
                        break;
                    case 9:
                        checkBox10.Visible = true;
                        break;
                    case 10:
                        checkBox11.Visible = true;
                        break;
                    case 11:
                        checkBox12.Visible = true;
                        break;
                    case 12:
                        checkBox13.Visible = true;
                        break;
                    case 13:
                        checkBox14.Visible = true;
                        break;
                    case 14:
                        checkBox15.Visible = true;
                        break;
                    case 15:
                        checkBox16.Visible = true;
                        break;
                    case 16:
                        checkBox17.Visible = true;
                        break;
                    case 17:
                        checkBox18.Visible = true;
                        break;
                    case 18:
                        checkBox19.Visible = true;
                        break;
                    case 19:
                        checkBox20.Visible = true;
                        break;
                    case 20:
                        checkBox21.Visible = true;
                        break;
                    case 21:
                        checkBox22.Visible = true;
                        break;
                    case 22:
                        checkBox23.Visible = true;
                        break;
                    case 23:
                        checkBox24.Visible = true;
                        break;
                    case 24:
                        checkBox25.Visible = true;
                        break;
                    case 25:
                        checkBox26.Visible = true;
                        break;
                    case 26:
                        checkBox27.Visible = true;
                        break;
                    case 27:
                        checkBox28.Visible = true;
                        break;
                    case 28:
                        checkBox29.Visible = true;
                        break;
                    case 29:
                        checkBox30.Visible = true;
                        break;
                    case 30:
                        checkBox31.Visible = true;
                        break;
                    case 31:
                        checkBox32.Visible = true;
                        break;
                }
            }
            SOC.Visible = true;
        }
        private void gpio_button_Click(object sender, EventArgs e)
        {
            //hideGeneral();
            hidePort1();
            hidePort2();
            hidePort3();
            hidePort4();
            showGPIO();
        }
        private void setGpio(int pin, bool sel)
        {
            switch (pin)
            {
                case 0:
                    checkBox1.Checked = sel;
                    if (sel)
                        checkBox1.ForeColor = Color.Red;
                    else
                        checkBox1.ForeColor = Color.Green;
                    break;
                case 1:
                    checkBox2.Checked = sel;
                    break;
                case 2:
                    checkBox3.Checked = sel;
                    break;
                case 3:
                    checkBox4.Checked = sel;
                    break;
                case 4:
                    checkBox5.Checked = sel;
                    break;
                case 5:
                    checkBox6.Checked = sel;
                    break;
                case 6:
                    checkBox7.Checked = sel;
                    break;
                case 7:
                    checkBox8.Checked = sel;
                    break;
                case 8:
                    checkBox9.Checked = sel;
                    break;
                case 9:
                    checkBox10.Checked = sel;
                    break;
                case 10:
                    checkBox11.Checked = sel;
                    break;
                case 11:
                    checkBox12.Checked = sel;
                    break;
                case 12:
                    checkBox13.Checked = sel;
                    break;
                case 13:
                    checkBox14.Checked = sel;
                    break;
                case 14:
                    checkBox15.Checked = sel;
                    break;
                case 15:
                    checkBox16.Checked = sel;
                    break;
                case 16:
                    checkBox17.Checked = sel;
                    break;
                case 17:
                    checkBox18.Checked = sel;
                    break;
                case 18:
                    checkBox19.Checked = sel;
                    break;
                case 19:
                    checkBox20.Checked = sel;
                    break;
                case 20:
                    checkBox21.Checked = sel;
                    break;
                case 21:
                    checkBox22.Checked = sel;
                    break;
                case 22:
                    checkBox23.Checked = sel;
                    break;
                case 23:
                    checkBox24.Checked = sel;
                    break;
                case 24:
                    checkBox25.Checked = sel;
                    break;
                case 25:
                    checkBox26.Checked = sel;
                    break;
                case 26:
                    checkBox27.Checked = sel;
                    break;
                case 27:
                    checkBox28.Checked = sel;
                    break;
                case 28:
                    checkBox29.Checked = sel;
                    break;
                case 29:
                    checkBox30.Checked = sel;
                    break;
                case 30:
                    checkBox31.Checked = sel;
                    break;
                case 31:
                    checkBox32.Checked = sel;
                    break;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[0] = checkBox1.Checked;
            updateGpioList(-1, -1, 0);
            if (checkBox1.Checked)
                checkBox1.ForeColor = Color.Red;
            else
                checkBox1.ForeColor = Color.ForestGreen;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[1] = checkBox2.Checked;
            updateGpioList(-1, -1, 1);
            if (checkBox2.Checked)
                checkBox2.ForeColor = Color.Red;
            else
                checkBox2.ForeColor = Color.ForestGreen;
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[2] = checkBox3.Checked;
            updateGpioList(-1, -1, 2);
            if (checkBox3.Checked)
                checkBox3.ForeColor = Color.Red;
            else
                checkBox3.ForeColor = Color.ForestGreen;
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[3] = checkBox4.Checked;
            updateGpioList(-1, -1, 3);
            if (checkBox4.Checked)
                checkBox4.ForeColor = Color.Red;
            else
                checkBox4.ForeColor = Color.ForestGreen;
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[4] = checkBox5.Checked;
            updateGpioList(-1, -1, 4);
            if (checkBox5.Checked)
                checkBox5.ForeColor = Color.Red;
            else
                checkBox5.ForeColor = Color.ForestGreen;
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[5] = checkBox6.Checked;
            updateGpioList(-1, -1, 5);
            if (checkBox6.Checked)
                checkBox6.ForeColor = Color.Red;
            else
                checkBox6.ForeColor = Color.ForestGreen;
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[6] = checkBox7.Checked;
            updateGpioList(-1, -1, 6);
            if (checkBox7.Checked)
                checkBox7.ForeColor = Color.Red;
            else
                checkBox7.ForeColor = Color.ForestGreen;
        }
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[7] = checkBox8.Checked;
            updateGpioList(-1, -1, 7);
            if (checkBox8.Checked)
                checkBox8.ForeColor = Color.Red;
            else
                checkBox8.ForeColor = Color.ForestGreen;
        }
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[8] = checkBox9.Checked;
            updateGpioList(-1, -1, 8);
            if (checkBox9.Checked)
                checkBox9.ForeColor = Color.Red;
            else
                checkBox9.ForeColor = Color.ForestGreen;
        }
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[9] = checkBox10.Checked;
            updateGpioList(-1, -1, 9);
            if (checkBox10.Checked)
                checkBox10.ForeColor = Color.Red;
            else
                checkBox10.ForeColor = Color.ForestGreen;
        }
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[10] = checkBox11.Checked;
            updateGpioList(-1, -1, 10);
            if (checkBox11.Checked)
                checkBox11.ForeColor = Color.Red;
            else
                checkBox11.ForeColor = Color.ForestGreen;
        }
        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[11] = checkBox12.Checked;
            updateGpioList(-1, -1, 11);
            if (checkBox12.Checked)
                checkBox12.ForeColor = Color.Red;
            else
                checkBox12.ForeColor = Color.ForestGreen;
        }
        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[12] = checkBox13.Checked;
            updateGpioList(-1, -1, 12);
            if (checkBox13.Checked)
                checkBox13.ForeColor = Color.Red;
            else
                checkBox13.ForeColor = Color.ForestGreen;
        }
        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[13] = checkBox14.Checked;
            updateGpioList(-1, -1, 13);
            if (checkBox14.Checked)
                checkBox14.ForeColor = Color.Red;
            else
                checkBox14.ForeColor = Color.ForestGreen;
        }
        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[14] = checkBox15.Checked;
            updateGpioList(-1, -1, 14);
            if (checkBox15.Checked)
                checkBox15.ForeColor = Color.Red;
            else
                checkBox15.ForeColor = Color.ForestGreen;
        }
        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[15] = checkBox16.Checked;
            updateGpioList(-1, -1, 15);
            if (checkBox16.Checked)
                checkBox16.ForeColor = Color.Red;
            else
                checkBox16.ForeColor = Color.ForestGreen;
        }
        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[16] = checkBox17.Checked;
            updateGpioList(-1, -1, 16);
            if (checkBox17.Checked)
                checkBox17.ForeColor = Color.Red;
            else
                checkBox17.ForeColor = Color.ForestGreen;
        }
        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[17] = checkBox18.Checked;
            updateGpioList(-1, -1, 17);
            if (checkBox18.Checked)
                checkBox18.ForeColor = Color.Red;
            else
                checkBox18.ForeColor = Color.ForestGreen;
        }
        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[18] = checkBox19.Checked;
            updateGpioList(-1, -1, 18);
            if (checkBox19.Checked)
                checkBox19.ForeColor = Color.Red;
            else
                checkBox18.ForeColor = Color.ForestGreen;
        }
        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[19] = checkBox20.Checked;
            updateGpioList(-1, -1, 19);
            if (checkBox20.Checked)
                checkBox20.ForeColor = Color.Red;
            else
                checkBox20.ForeColor = Color.ForestGreen;
        }
        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[20] = checkBox21.Checked;
            updateGpioList(-1, -1, 20);
            if (checkBox21.Checked)
                checkBox21.ForeColor = Color.Red;
            else
                checkBox21.ForeColor = Color.ForestGreen;
        }
        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[21] = checkBox22.Checked;
            updateGpioList(-1, -1, 21);
            if (checkBox22.Checked)
                checkBox22.ForeColor = Color.Red;
            else
                checkBox22.ForeColor = Color.ForestGreen;
        }
        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[22] = checkBox23.Checked;
            updateGpioList(-1, -1, 22);
            if (checkBox23.Checked)
                checkBox23.ForeColor = Color.Red;
            else
                checkBox23.ForeColor = Color.ForestGreen;
        }
        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[23] = checkBox24.Checked;
            updateGpioList(-1, -1, 23);
            if (checkBox24.Checked)
                checkBox24.ForeColor = Color.Red;
            else
                checkBox24.ForeColor = Color.ForestGreen;
        }
        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[24] = checkBox25.Checked;
            updateGpioList(-1, -1, 24);
            if (checkBox25.Checked)
                checkBox25.ForeColor = Color.Red;
            else
                checkBox25.ForeColor = Color.ForestGreen;
        }
        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[25] = checkBox26.Checked;
            updateGpioList(-1, -1, 25);
            if (checkBox26.Checked)
                checkBox26.ForeColor = Color.Red;
            else
                checkBox26.ForeColor = Color.ForestGreen;
        }
        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[26] = checkBox27.Checked;
            updateGpioList(-1, -1, 26);
            if (checkBox27.Checked)
                checkBox27.ForeColor = Color.Red;
            else
                checkBox27.ForeColor = Color.ForestGreen;
        }
        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[27] = checkBox28.Checked;
            updateGpioList(-1, -1, 27);
            if (checkBox28.Checked)
                checkBox28.ForeColor = Color.Red;
            else
                checkBox28.ForeColor = Color.ForestGreen;
        }
        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[28] = checkBox29.Checked;
            updateGpioList(-1, -1, 28);
            if (checkBox29.Checked)
                checkBox29.ForeColor = Color.Red;
            else
                checkBox29.ForeColor = Color.ForestGreen;
        }
        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[29] = checkBox30.Checked;
            updateGpioList(-1, -1, 29);
            if (checkBox30.Checked)
                checkBox30.ForeColor = Color.Red;
            else
                checkBox30.ForeColor = Color.ForestGreen;
        }
        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[30] = checkBox31.Checked;
            updateGpioList(-1, -1, 30);
            if (checkBox31.Checked)
                checkBox31.ForeColor = Color.Red;
            else
                checkBox31.ForeColor = Color.ForestGreen;
        }
        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            definitions.gpioListL[31] = checkBox32.Checked;
            updateGpioList(-1, -1, 31);
            if (checkBox32.Checked)
                checkBox32.ForeColor = Color.Red;
            else
                checkBox32.ForeColor = Color.ForestGreen;
        }
    }
}
