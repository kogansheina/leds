using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace socleds
{
    public partial class Form1 : Form
    {
        general definitions = null;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void hideGeneral()
        {
            label_mode.Hide();
            comboBox_mode.Hide();
            label_ports.Hide();
            textBox_ports.Hide();
            label_gpio_left.Hide();
            textBox_gpio_left.Hide();
            input_file.Hide();
            browse_input.Hide();
            save_file.Hide();
            browse_output.Hide();
            gen_file.Hide();
            button7.Hide();
            save_button.Hide();
            button6.Hide();
        }
        private void hideGPIO()
        {
            checkBox1.Hide(); checkBox2.Hide();
            checkBox3.Hide(); checkBox4.Hide();
            checkBox5.Hide(); checkBox6.Hide();
            checkBox7.Hide(); checkBox8.Hide();
            checkBox9.Hide(); checkBox10.Hide();
            checkBox11.Hide(); checkBox12.Hide();
            checkBox13.Hide(); checkBox14.Hide();
            checkBox15.Hide(); checkBox16.Hide();
            checkBox17.Hide(); checkBox18.Hide();
            checkBox19.Hide(); checkBox20.Hide();
            checkBox21.Hide(); checkBox22.Hide();
            checkBox23.Hide(); checkBox24.Hide();
            checkBox25.Hide(); checkBox26.Hide();
            checkBox27.Hide(); checkBox28.Hide();
            checkBox29.Hide(); checkBox30.Hide();
            checkBox31.Hide(); checkBox32.Hide();
            SOC.Visible = false;
        }
        private void hideLed1P1()
        {
            label1_port11.Hide();
            label2_port11.Hide();
            comboBoxp1l1.Hide();
            checkBoxp1l1.Hide();
            checkBoxp1l1_10.Hide();
            checkBoxp1l1_100.Hide();
            checkBoxp1l1_1000.Hide();
        }
        private void showLed1P1()
        {
            label1_port11.Visible = true;
            label2_port11.Visible = true;
            comboBoxp1l1.Visible = true;
            checkBoxp1l1.Visible = true;
            checkBoxp1l1_10.Visible = true;
            checkBoxp1l1_100.Visible = true;
            checkBoxp1l1_1000.Visible = true;
        }
        private void hideLed2P1()
        {
            label1p1l2.Hide();
            label2p1l2.Hide();
            comboBoxp1l2.Hide();
            checkBoxp1l2_1000.Hide();
            checkBoxp1l2_100.Hide();
            checkBoxp1l2_10.Hide();
            checkBoxp1l2.Hide();
        }
        private void showLed2P1()
        {
            label1p1l2.Visible = true; 
            label2p1l2.Visible = true; 
            comboBoxp1l2.Visible = true; 
            checkBoxp1l2_1000.Visible = true; 
            checkBoxp1l2_100.Visible = true; 
            checkBoxp1l2_10.Visible = true; 
            checkBoxp1l2.Visible = true; 
        }
        private void hideLed3P1()
        {
            label1p1l3.Hide();
            label2p1l3.Hide();
            comboBoxp1l3.Hide();
            checkBoxp1l3_1000.Hide();
            checkBoxp1l3_100.Hide();
            checkBoxp1l3_10.Hide();
            checkBoxp1l3.Hide();
        }
        private void showLed3P1()
        {
            label1p1l3.Visible = true;
            label2p1l3.Visible = true;
            comboBoxp1l3.Visible = true;
            checkBoxp1l3_1000.Visible = true;
            checkBoxp1l3_100.Visible = true;
            checkBoxp1l3_10.Visible = true;
            checkBoxp1l3.Visible = true;
        }
        private void hideLed4P1()
        {
            label1p1l4.Hide();
            label2l1l4.Hide();
            comboBoxp1l4.Hide();
            checkBoxp1l4_1000.Hide();
            checkBoxp1l4_100.Hide();
            checkBoxp1l4_10.Hide();
            checkBoxp1l4.Hide();
        }
        private void showLed4P1()
        {
            label1p1l4.Visible = true;
            label2l1l4.Visible = true;
            comboBoxp1l4.Visible = true;
            checkBoxp1l4_1000.Visible = true;
            checkBoxp1l4_100.Visible = true;
            checkBoxp1l4_10.Visible = true;
            checkBoxp1l4.Visible = true;
        }
        private void hidePort1()
        {
            label1_port.Hide();
            comboBox_port1.Hide();
            comboBox_port1_speed.Hide();
            hideLed1P1();
            hideLed2P1();
            hideLed3P1();
            hideLed4P1();
        }
        private void showPort1()
        {
            label1_port.Visible = true;
            comboBox_port1.Visible = true;
            comboBox_port1_speed.Visible = true;
            showLed1P1();
            if (definitions.get_mode() >= 2)
            {
                showLed2P1();
                if (definitions.get_mode() >= 3)
                {
                    showLed3P1();
                    if (definitions.get_mode() >= 4)
                        showLed4P1();
                }
            }
        }
        private void hideLed1P2()
        {
            label7p2l1.Hide();
            label8p2l1.Hide();
            comboBoxp2l1.Hide();
            checkBoxp2l1_1000.Hide();
            checkBoxp2l1_100.Hide();
            checkBoxp2l1_10.Hide();
            checkBoxp2l1.Hide();
        }
        private void showLed1P2()
        {
            label7p2l1.Visible = true;
            label8p2l1.Visible = true;
            comboBoxp2l1.Visible = true;
            checkBoxp2l1_1000.Visible = true;
            checkBoxp2l1_100.Visible = true;
            checkBoxp2l1_10.Visible = true;
            checkBoxp2l1.Visible = true;
        }
        private void hideLed2P2()
        {
            label6p2l2.Hide();
            label5p2l2.Hide();
            comboBoxp2l2.Hide();
            checkBoxp2l2_1000.Hide();
            checkBoxp2l2_100.Hide();
            checkBoxp2l2_10.Hide();
            checkBoxp2l2.Hide();
        }
        private void showLed2P2()
        {
            label6p2l2.Visible = true;
            label5p2l2.Visible = true;
            comboBoxp2l2.Visible = true;
            checkBoxp2l2_1000.Visible = true;
            checkBoxp2l2_100.Visible = true;
            checkBoxp2l2_10.Visible = true;
            checkBoxp2l2.Visible = true;
        }
        private void hideLed3P2()
        {
            label4p2l3.Hide();
            label3p2l3.Hide();
            comboBoxp2l3.Hide();
            checkBoxp2l3_1000.Hide();
            checkBoxp2l3_100.Hide();
            checkBoxp2l3_10.Hide();
            checkBoxp2l3.Hide();
        }
        private void showLed3P2()
        {
            label4p2l3.Visible = true;
            label3p2l3.Visible = true;
            comboBoxp2l3.Visible = true;
            checkBoxp2l3_1000.Visible = true;
            checkBoxp2l3_100.Visible = true;
            checkBoxp2l3_10.Visible = true;
            checkBoxp2l3.Visible = true;
        }
        private void hideLed4P2()
        {
            label2p2l4.Hide();
            label1p2l4.Hide();
            comboBoxp2l4.Hide();
            checkBoxp2l4_1000.Hide();
            checkBoxp2l4_100.Hide();
            checkBoxp2l4_10.Hide();
            checkBoxp2l4.Hide();
        }
        private void showLed4P2()
        {
            label2p2l4.Visible = true;
            label1p2l4.Visible = true;
            comboBoxp2l4.Visible = true;
            checkBoxp2l4_1000.Visible = true;
            checkBoxp2l4_100.Visible = true;
            checkBoxp2l4_10.Visible = true;
            checkBoxp2l4.Visible = true;
        }
        private void hidePort2()
        {
            label9p2.Hide();
            comboBox_port2_speed.Hide();
            comboBox_port2.Hide();
            hideLed1P2();
            hideLed2P2();
            hideLed3P2();
            hideLed4P2();
        }
        private void showPort2()
        {
            label9p2.Visible = true;
            comboBox_port2_speed.Visible = true;
            comboBox_port2.Visible = true;
            showLed1P2();
            if (definitions.get_mode() >= 2)
            {
                showLed2P2();
                if (definitions.get_mode() >= 3)
                {
                    showLed3P2();
                    if (definitions.get_mode() >= 4)
                        showLed4P2();
                }
            }
        }
        private void hideLed1P3()
        {
            label17.Hide();
            label16.Hide();
            comboBoxp3l1.Hide();
            checkBoxp3l1.Hide();
            checkBoxp3l1_10.Hide();
            checkBoxp3l1_100.Hide();
            checkBoxp3l1_1000.Hide();
        }
        private void showLed1P3()
        {
            label17.Visible = true;
            label16.Visible = true;
            comboBoxp3l1.Visible = true;
            checkBoxp3l1.Visible = true;
            checkBoxp3l1_10.Visible = true;
            checkBoxp3l1_100.Visible = true;
            checkBoxp3l1_1000.Visible = true;
        }
        private void hideLed2P3()
        {
            label15.Hide();
            label14.Hide();
            comboBoxp3l2.Hide();
            checkBoxp3l2.Hide();
            checkBoxp3l2_10.Hide();
            checkBoxp3l2_100.Hide();
            checkBoxp3l2_1000.Hide();
        }
        private void showLed2P3()
        {
            label15.Visible = true;
            label14.Visible = true;
            comboBoxp3l2.Visible = true;
            checkBoxp3l2.Visible = true;
            checkBoxp3l2_10.Visible = true;
            checkBoxp3l2_100.Visible = true;
            checkBoxp3l2_1000.Visible = true;
        }
        private void hideLed3P3()
        {
            label13.Hide();
            label12.Hide();
            comboBoxp3l3.Hide();
            checkBoxp3l3.Hide();
            checkBoxp3l3_10.Hide();
            checkBoxp3l3_100.Hide();
            checkBoxp3l3_1000.Hide();
        }
        private void showLed3P3()
        {
            label13.Visible = true;
            label12.Visible = true;
            comboBoxp3l3.Visible = true;
            checkBoxp3l3.Visible = true;
            checkBoxp3l3_10.Visible = true;
            checkBoxp3l3_100.Visible = true;
            checkBoxp3l3_1000.Visible = true;
        }
        private void hideLed4P3()
        {
            label11.Hide();
            label10.Hide();
            comboBoxp3l4.Hide();
            checkBoxp3l4.Hide();
            checkBoxp3l4_10.Hide();
            checkBoxp3l4_100.Hide();
            checkBoxp3l4_1000.Hide();
        }
        private void showLed4P3()
        {
            label11.Visible = true;
            label10.Visible = true;
            comboBoxp3l4.Visible = true;
            checkBoxp3l4.Visible = true;
            checkBoxp3l4_10.Visible = true;
            checkBoxp3l4_100.Visible = true;
            checkBoxp3l4_1000.Visible = true;
        }
        private void hidePort3()
        {
            label18.Hide();
            comboBox_port3.Hide();
            comboBox_port3_speed.Hide();
            hideLed1P3();
            hideLed2P3();
            hideLed3P3();
            hideLed4P3();
        }
        private void showPort3()
        {
            label18.Visible = true;
            comboBox_port3.Visible = true;
            comboBox_port3_speed.Visible = true;
            showLed1P3();
            if (definitions.get_mode() >= 2)
            {
                showLed2P3();
                if (definitions.get_mode() >= 3)
                {
                    showLed3P3();
                    if (definitions.get_mode() >= 4)
                        showLed4P3();
                }
            }
        }
        private void hideLed1P4()
        {
            label8.Hide();
            label9.Hide();
            comboBoxp4l1.Hide();
            checkBoxp4l1.Hide();
            checkBoxp4l1_10.Hide();
            checkBoxp4l1_100.Hide();
            checkBoxp4l1_1000.Hide();
        }
        private void showLed1P4()
        {
            label8.Visible = true;
            label9.Visible = true;
            comboBoxp4l1.Visible = true;
            checkBoxp4l1.Visible = true;
            checkBoxp4l1_10.Visible = true;
            checkBoxp4l1_100.Visible = true;
            checkBoxp4l1_1000.Visible = true;
        }
        private void hideLed2P4()
        {
            label6.Hide();
            label5.Hide();
            comboBoxp4l2.Hide();
            checkBoxp4l2.Hide();
            checkBoxp4l2_10.Hide();
            checkBoxp4l2_100.Hide();
            checkBoxp4l2_1000.Hide();
        }
        private void showLed2P4()
        {
            label6.Visible = true;
            label5.Visible = true;
            comboBoxp4l2.Visible = true;
            checkBoxp4l2.Visible = true;
            checkBoxp4l2_10.Visible = true;
            checkBoxp4l2_100.Visible = true;
            checkBoxp4l2_1000.Visible = true;
        }
        private void hideLed3P4()
        {
            label4.Hide();
            label3.Hide();
            comboBoxp4l3.Hide();
            checkBoxp4l3.Hide();
            checkBoxp4l3_10.Hide();
            checkBoxp4l3_100.Hide();
            checkBoxp4l3_1000.Hide();
        }
        private void showLed3P4()
        {
            label4.Visible = true;
            label3.Visible = true;
            comboBoxp4l3.Visible = true;
            checkBoxp4l3.Visible = true;
            checkBoxp4l3_10.Visible = true;
            checkBoxp4l3_100.Visible = true;
            checkBoxp4l3_1000.Visible = true;
        }
        private void hideLed4P4()
        {
            label2.Hide();
            label1.Hide();
            comboBoxp4l4.Hide();
            checkBoxp4l4.Hide();
            checkBoxp4l4_10.Hide();
            checkBoxp4l4_100.Hide();
            checkBoxp4l4_1000.Hide();
        }
        private void showLed4P4()
        {
            label2.Visible = true;
            label1.Visible = true;
            comboBoxp4l4.Visible = true;
            checkBoxp4l4.Visible = true;
            checkBoxp4l4_10.Visible = true;
            checkBoxp4l4_100.Visible = true;
            checkBoxp4l4_1000.Visible = true;
        }
        private void hidePort4()
        {
            label9p2.Hide();
            comboBox_port2_speed.Hide();
            comboBox_port2.Hide();
            hideLed1P4();
            hideLed2P4();
            hideLed3P4();
            hideLed4P4();
        }
        private void showPort4()
        {
            label9p2.Visible = true;
            comboBox_port4_speed.Visible = true;
            comboBox_port4.Visible = true;
            showLed1P4();
            if (definitions.get_mode() >= 2)
            {
                showLed2P4();
                if (definitions.get_mode() >= 3)
                {
                    showLed3P4();
                    if (definitions.get_mode() >= 4)
                        showLed4P4();
                }
            }
        }
        // general button
        private void general_button_Click(object sender, EventArgs e)
        {
            label_mode.Visible = true;
            comboBox_mode.Visible = true;
            label_ports.Visible = true;
            textBox_ports.Visible = true;
            label_gpio_left.Visible = true;
            textBox_gpio_left.Visible = true;
            hideGPIO();
            hidePort1();
            hidePort2();
            hidePort3();
            hidePort4();
            save_button.Visible = true;
            button6.Visible = true;
        }
        
        // mode select
        private void comboBox_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mode = 4 - comboBox_mode.SelectedIndex;
            definitions.set_mode(mode);
            definitions.initialize_data();
        }
        private void textBox_ports_TextChanged(object sender, EventArgs e)
        {
            var val = textBox_ports.Text;
            if (val != "")
            {
                definitions.set_ports(int.Parse(val));
                definitions.initialize_data();
            }
            else
                MessageBox.Show("Data is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void textBox_gpio_left_TextChanged(object sender, EventArgs e)
        {
            var val = textBox_gpio_left.Text;
            if (val != "")
            {
                definitions.set_default(int.Parse(val));
                definitions.initialize_data();
            }
            else
                MessageBox.Show("Data is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void initialize_general()
        {
            definitions.initialize_data();
            int number_ports = definitions.get_ports();
            int number_leds = definitions.get_mode();
            /* TEMPORARY *****************************************************/
            if (number_ports > 4) number_ports = 4;
            /* TEMPORARY *****************************************************/
            for (var i = 0; i < number_ports; i++)
            {
                Port port = definitions.portList[i];
                switch (i)
                {
                    case 0:
                        port.comboBoxType = comboBox_port1;
                        port.comboBoxSpeed = comboBox_port1_speed;
                        for (int j = 0; j < number_leds; j++)
                        {
                            Led led = port.leds[j];
                            switch (j)
                            {
                                case 0:
                                    led.comboBoxGpio = comboBoxp1l1;
                                    led.checkBoxActivity = checkBoxp1l1;
                                    led.checkBox10 = checkBoxp1l1_10;
                                    led.checkBox100 = checkBoxp1l1_100;
                                    led.checkBox1000 = checkBoxp1l1_1000;
                                    break;
                                case 1:
                                    led.comboBoxGpio = comboBoxp1l2;
                                    led.checkBoxActivity = checkBoxp1l2;
                                    led.checkBox10 = checkBoxp1l2_10;
                                    led.checkBox100 = checkBoxp1l2_100;
                                    led.checkBox1000 = checkBoxp1l2_1000;
                                    break;
                                case 2:
                                    led.comboBoxGpio = comboBoxp1l3;
                                    led.checkBoxActivity = checkBoxp1l3;
                                    led.checkBox10 = checkBoxp1l3_10;
                                    led.checkBox100 = checkBoxp1l3_100;
                                    led.checkBox1000 = checkBoxp1l3_1000;
                                    break;
                                case 3:
                                    led.comboBoxGpio = comboBoxp1l4;
                                    led.checkBoxActivity = checkBoxp1l4;
                                    led.checkBox10 = checkBoxp1l4_10;
                                    led.checkBox100 = checkBoxp1l4_100;
                                    led.checkBox1000 = checkBoxp1l4_1000;
                                    break;
                                default:
                                    Console.WriteLine("Number of leds is greater than 4 : {0}", number_leds);
                                    break;
                            }
                        }
                        break;
                    case 1: // port 1
                        port.comboBoxType = comboBox_port2;
                        port.comboBoxSpeed = comboBox_port2_speed;
                        for (int j = 0; j < number_leds; j++)
                        {
                            Led led = port.leds[j];
                            switch (j)
                            {
                                case 0:
                                    led.comboBoxGpio = comboBoxp2l1;
                                    led.checkBoxActivity = checkBoxp2l1;
                                    led.checkBox10 = checkBoxp2l1_10;
                                    led.checkBox100 = checkBoxp2l1_100;
                                    led.checkBox1000 = checkBoxp2l1_1000;
                                    break;
                                case 1:
                                    led.comboBoxGpio = comboBoxp2l2;
                                    led.checkBoxActivity = checkBoxp2l2;
                                    led.checkBox10 = checkBoxp2l2_10;
                                    led.checkBox100 = checkBoxp2l2_100;
                                    led.checkBox1000 = checkBoxp2l2_1000;
                                    break;
                                case 2:
                                    led.comboBoxGpio = comboBoxp2l3;
                                    led.checkBoxActivity = checkBoxp2l3;
                                    led.checkBox10 = checkBoxp2l3_10;
                                    led.checkBox100 = checkBoxp2l3_100;
                                    led.checkBox1000 = checkBoxp2l3_1000;
                                    break;
                                case 3:
                                    led.comboBoxGpio = comboBoxp2l4;
                                    led.checkBoxActivity = checkBoxp2l4;
                                    led.checkBox10 = checkBoxp2l4_10;
                                    led.checkBox100 = checkBoxp2l4_100;
                                    led.checkBox1000 = checkBoxp2l4_1000;
                                    break;
                            }
                        }
                        break;
                    case 2: // port 2
                        port.comboBoxType = comboBox_port3;
                        port.comboBoxSpeed = comboBox_port3_speed;
                        for (int j = 0; j < number_leds; j++)
                        {
                            Led led = port.leds[j];
                            switch (j)
                            {
                                case 0:
                                    led.comboBoxGpio = comboBoxp3l1;
                                    led.checkBoxActivity = checkBoxp3l1;
                                    led.checkBox10 = checkBoxp3l1_10;
                                    led.checkBox100 = checkBoxp3l1_100;
                                    led.checkBox1000 = checkBoxp3l1_1000;
                                    break;
                                case 1:
                                    led.comboBoxGpio = comboBoxp3l2;
                                    led.checkBoxActivity = checkBoxp3l2;
                                    led.checkBox10 = checkBoxp3l2_10;
                                    led.checkBox100 = checkBoxp3l2_100;
                                    led.checkBox1000 = checkBoxp3l2_1000;
                                    break;
                                case 2:
                                    led.comboBoxGpio = comboBoxp3l3;
                                    led.checkBoxActivity = checkBoxp3l3;
                                    led.checkBox10 = checkBoxp3l3_10;
                                    led.checkBox100 = checkBoxp3l3_100;
                                    led.checkBox1000 = checkBoxp3l3_1000;
                                    break;
                                case 3:
                                    led.comboBoxGpio = comboBoxp3l4;
                                    led.checkBoxActivity = checkBoxp3l4;
                                    led.checkBox10 = checkBoxp3l4_10;
                                    led.checkBox100 = checkBoxp3l4_100;
                                    led.checkBox1000 = checkBoxp3l4_1000;
                                    break;
                            }
                        }
                        break;
                    case 3:
                        port.comboBoxType = comboBox_port4;
                        port.comboBoxSpeed = comboBox_port4_speed;
                        for (int j = 0; j < number_leds; j++)
                        {
                            Led led = port.leds[j];
                            switch (j)
                            {
                                case 0:
                                    led.comboBoxGpio = comboBoxp4l1;
                                    led.checkBoxActivity = checkBoxp4l1;
                                    led.checkBox10 = checkBoxp4l1_10;
                                    led.checkBox100 = checkBoxp4l1_100;
                                    led.checkBox1000 = checkBoxp4l1_1000;
                                    break;
                                case 1:
                                    led.comboBoxGpio = comboBoxp4l2;
                                    led.checkBoxActivity = checkBoxp4l2;
                                    led.checkBox10 = checkBoxp4l2_10;
                                    led.checkBox100 = checkBoxp4l2_100;
                                    led.checkBox1000 = checkBoxp4l2_1000;
                                    break;
                                case 2:
                                    led.comboBoxGpio = comboBoxp4l3;
                                    led.checkBoxActivity = checkBoxp4l3;
                                    led.checkBox10 = checkBoxp4l3_10;
                                    led.checkBox100 = checkBoxp4l3_100;
                                    led.checkBox1000 = checkBoxp4l3_1000;
                                    break;
                                case 3:
                                    led.comboBoxGpio = comboBoxp4l4;
                                    led.checkBoxActivity = checkBoxp4l4;
                                    led.checkBox10 = checkBoxp4l4_10;
                                    led.checkBox100 = checkBoxp4l4_100;
                                    led.checkBox1000 = checkBoxp4l4_1000;
                                    break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Number of ports is greater than 4 : {0}", number_ports);
                        break;
                }
            }
        }
        private void continueGeneral()
        {
            textBox_ports.Text = definitions.get_ports().ToString();
            textBox_gpio_left.Text = definitions.get_default().ToString();
            comboBox_mode.SelectedText = comboBox_mode.Items[4 - definitions.get_mode()].ToString();
            comboBox_board.Visible = false;
            label19.Text = definitions.get_board();
            label19.ForeColor = System.Drawing.Color.DarkViolet;
            label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label19.Visible = true;
            general_button.Visible = true;
            gpio_button.Visible = true;
            ports_button.Visible = true;
        }
        private void comboBox_board_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = comboBox_board.SelectedItem.ToString();
            if (sel == "Configuration")
            {
                input_file.Visible = true;
                browse_input.Visible = true;
            }
            else
            {
                definitions = new general(sel);
                initialize_general();
                continueGeneral();
            }
        }
        private void ports_button_Click(object sender, EventArgs e)
        {
            //hideGeneral();
            //hideGPIO();
            showGPIO();
            showPort1();
            if (definitions.get_ports() >= 2)
            {
                showPort2();
                if (definitions.get_ports() >= 3)
                {
                    showPort3();
                    if (definitions.get_ports() >= 4)
                    {
                        showPort4();
                    }
                }
            }
        }
        private void open_read_file(string iFile)
        {
            string line;
            bool boardset = false;
            Port defport = null;

            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(iFile);
                if (file == null)
                {
                    MessageBox.Show("File " + iFile + " cannot be open ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                while ((line = file.ReadLine()) != null)
                {
                    //Console.WriteLine(line);
                    int index = line.IndexOf('=');
                    if (index < 0)
                        continue;
                    string[] tokens = new string[2];
                    tokens[0] = line.Substring(0, index).ToLower().Trim();
                    tokens[1] = line.Substring(index + 1).ToLower().Trim();
                    if (tokens[0] == "board")
                    {
                        definitions = new general(tokens[1]);
                        definitions.initialize_data();
                        initialize_general();
                        boardset = true;
                        continue;
                    }
                    if (!boardset)
                    {
                        MessageBox.Show("Board is not defined - it is mandatory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (tokens[0] == "pins")
                    {
                        string val = tokens[1];
                        try
                        {
                            definitions.set_default(Convert.ToInt32(val));
                            definitions.initialize_data();
                            textBox_gpio_left.Text = definitions.get_default().ToString();
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show(tokens[0] + " : Value " + val + " is not in a recognizable format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        continue;
                    }
                    if (tokens[0] == "mode")
                    {
                        string val = tokens[1];
                        try
                        {
                            definitions.set_mode(Convert.ToInt32(val));
                            definitions.initialize_data();
                            string vals = "none";
                            switch (definitions.get_mode())
                            {
                                case 1:
                                    vals = "1 led per port";
                                    break;
                                case 2:
                                    vals = "2 leds per port";
                                    break;
                                case 3:
                                    vals = "3 leds per port";
                                    break;
                                case 4:
                                    vals = "4 leds per port";
                                    break;
                            }
                            comboBox_mode.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate { comboBox_mode.Text = vals; });
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show(tokens[0] + " : Value " + val + " is not in a recognizable format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        continue;
                    }
                    if (tokens[0] == "nports")
                    {
                        string val = tokens[1];
                        try
                        {
                            definitions.set_ports(Convert.ToInt32(val));
                            definitions.initialize_data();
                            textBox_ports.Text = definitions.get_ports().ToString();
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show(tokens[0] + " : Value " + val + " is not in a recognizable format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        continue;
                    }
                    if (tokens[0] == "gpios")
                    {
                        string[] val = tokens[1].Split(' ');
                        foreach (string g in val)
                        {
                            try
                            {
                                int gpio = Convert.ToInt32(g);
                                definitions.gpioListL[gpio] = true;
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show(tokens[0] + " : Value " + g + " is not in a recognizable format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        continue;
                    }
                    if (tokens[0].StartsWith("port"))
                    {
                        try
                        {
                            int port = Convert.ToInt32(tokens[0].Substring(4));
                            if (port >= definitions.get_ports())
                                MessageBox.Show(tokens[0] + " : Value " + port.ToString() + " is greater than defined number of ports.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                defport = definitions.portList[port];
                                string[] defs = tokens[1].Split(',');
                                foreach (string t in defs)
                                {
                                    // t may be 'type'=... OR 'spped'=...
                                    string[] vals = t.Split('=');
                                    for (int v = 0; v < vals.Length; v++)
                                    {
                                        if (vals[v].Trim().ToLower() == "type")
                                        {
                                            defport.type = vals[++v].Trim().ToLower();
                                            defport.comboBoxType.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate { defport.comboBoxType.Text = defport.type; });
                                        }
                                        else if (vals[v].Trim().ToLower() == "speed")
                                        {
                                            defport.speed = vals[++v].Trim().ToLower();
                                            defport.comboBoxSpeed.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate { defport.comboBoxSpeed.Text = defport.speed + " Mb"; });
                                        }
                                        else break;
                                    }
                                }
                            }
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show(tokens[0] + " : Value " + tokens[0].Substring(4) + " is not in a recognizable format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        continue;
                    }
                    if (tokens[0].StartsWith("led") && (defport != null))
                    {
                        try
                        {
                            int led = Convert.ToInt32(tokens[0].Substring(3));
                            if (led >= definitions.get_mode())
                                MessageBox.Show(tokens[0] + " : Value " + led.ToString() + " is greater than defined number of leds per port.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                Led defled = defport.leds[led];
                                string[] defs = tokens[1].Split(',');
                                foreach (string tx in defs)
                                {
                                    string t = tx.Trim().ToLower();
                                    // t may be activity,10,100,1000,gpio
                                    if (t == "activity")
                                    {
                                        defled.activity = true;
                                        defled.checkBoxActivity.Checked = true;
                                        defled.checkBoxActivity.ForeColor = System.Drawing.Color.Red;
                                    }
                                    if (t.StartsWith("10"))
                                    {
                                        defled.s10 = true;
                                        defled.checkBox10.Checked = true;
                                        defled.checkBox10.ForeColor = System.Drawing.Color.LawnGreen;
                                    }
                                    if (t.StartsWith("100"))
                                    {
                                        defled.s100 = true;
                                        defled.checkBox100.Checked = true;
                                        defled.checkBox10.ForeColor = System.Drawing.Color.Orange;
                                    }
                                    if (t.StartsWith("1000"))
                                    {
                                        defled.s1000 = true;
                                        defled.checkBox1000.Checked = true;
                                        defled.checkBox10.ForeColor = System.Drawing.Color.OrangeRed;
                                    }
                                    if (t.StartsWith("gpio"))
                                    {
                                        int gpioIndex = t.IndexOf('=');
                                        if (gpioIndex < 0)
                                            MessageBox.Show(t + " : has no '=' separator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        else
                                        {
                                            try
                                            {
                                                int gpioVal = Convert.ToInt32(t.Substring(gpioIndex + 1).Trim());
                                                defled.gpio = gpioVal;
                                                definitions.gpioListL[gpioVal] = true;
                                                defled.comboBoxGpio.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate { defled.comboBoxGpio.Text = defled.gpio.ToString(); });
                                            }
                                            catch (FormatException)
                                            {
                                                MessageBox.Show(t + " : Value " + t.Substring(5) + " is not in a recognizable format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show(tokens[0] + " : Value " + tokens[0].Substring(4) + " is not in a recognizable format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show(tokens[0] + " is not a recognizable key, or 'led' has not a predefined port.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                file.Close();
                input_file.Visible = false;
                browse_input.Visible = false;
                continueGeneral();
                for (int i = 0; i < definitions.get_default(); i++)
                {
                    if (definitions.gpioListL[i])
                        setGpio(i, true);
                }
                //definitions.print();
            }
            catch (System.IO.FileLoadException)
            {
                MessageBox.Show("File " + iFile + " cannot be read ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("File "+ iFile + " cannot be found ","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ask file name and browser
        private void save_configuration_button(object sender, MouseEventArgs e)
        {
            save_file.Visible = true;
            browse_output.Visible = true;
        }

        // ask file name
        private void generate_button(object sender, EventArgs e)
        {
            gen_file.Visible = true;
            button7.Visible = true;
        }
        private void open_write_file(string iFile)
        {
            string line;

            try
            {
                if (System.IO.File.Exists(iFile))
                    System.IO.File.Delete(iFile);
                System.IO.StreamWriter file = new System.IO.StreamWriter(iFile);
                if (file == null)
                {
                    MessageBox.Show("File " + iFile + " cannot be open ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                line = "board = " + definitions.get_board();
                file.WriteLine(line);
                line = "mode = " + definitions.get_mode().ToString();
                file.WriteLine(line);
                line = "nports = " + definitions.get_ports().ToString();
                file.WriteLine(line);
                line = "pins = " + definitions.get_default().ToString();
                file.WriteLine(line);
                List<int> gpioList = new List<int> { };
                for (int p = 0; p < definitions.get_ports(); p++) 
                {
                    Port port = definitions.portList[p];
                    line = "port" + (port.number-1).ToString() + " = type="+port.type+", speed="+port.speed;
                    file.WriteLine(line);
                    for (int l = 0; l < definitions.get_mode(); l++)
                    {
                        Led led = port.leds[l];
                        line = "led" + led.number.ToString() + " = ";
                        if (led.activity) line += "activity,";
                        if (led.s10) line += "10,";
                        if (led.s100) line += "100,";
                        if (led.s1000) line += "1000,";
                        if (led.gpio != -1)
                        {
                            line += "gpio=" + led.gpio.ToString();
                            gpioList.Add(led.gpio);
                        }
                        else
                            line = line.Substring(0, line.Length-1); // remove last ,
                        file.WriteLine(line);
                    }
                }
                line = "gpios = ";
                for (int j=0; j < definitions.get_default(); j++)
                {
                    if (definitions.gpioListL[j] && (gpioList.IndexOf(j) == -1))
                        line += j.ToString() + " ";
                }
                if (line.Length > "gpios = ".Length)
                    file.WriteLine(line);
                file.Close();
                save_file.Visible = false;
                browse_output.Visible = false;
                MessageBox.Show("File " + iFile + " Done ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("File "+ iFile + " cannot be found ","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // output configuration text
        private void enter_file_name_output(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Int32)Keys.Enter)
            {
                open_write_file(save_file.Text);
            }
        }
        private void open_generate_file(string iFile)
        {
            string line;

            try
            {
                if (System.IO.File.Exists(iFile))
                    System.IO.File.Delete(iFile);
                System.IO.StreamWriter file = new System.IO.StreamWriter(iFile);
                if (file == null)
                {
                    MessageBox.Show("File " + iFile + " cannot be open ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime date = DateTime.Now;
                line = "Generate File at " + date.ToString("dd/MM/yyyy HH:mm");
                file.WriteLine(line);
                file.Close();
                gen_file.Visible = false;
                button7.Visible = false;
                MessageBox.Show("File " + iFile + " Done ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("File " + iFile + " cannot be found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // generated file name
        private void enter_gen_file(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Int32)Keys.Enter)
            {
                open_generate_file(gen_file.Text);
            }
        }
        // browse input
        private void browse_input_changed(object sender, MouseEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Configuration Files|*.txt";
            openFileDialog1.Title = "Select a Configuration File";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                open_read_file(openFileDialog1.FileName);
        }
        // browse output
        private void browse_output_changed(object sender, MouseEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Configuration Files|*.txt";
            openFileDialog1.Title = "Select a Configuration Save File";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                open_write_file(openFileDialog1.FileName);
        }

        private void enter_file_name(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Int32)Keys.Enter)
            {
                open_read_file(input_file.Text);
            }
        }

        private void generate_browse(object sender, MouseEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.Filter = "Configuration Files|*.txt";
            openFileDialog1.Title = "Select a Generate File";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                open_generate_file(openFileDialog1.FileName);
        }
    } // form1
} // socleds
