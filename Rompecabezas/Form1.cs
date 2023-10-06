using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rompecabezas
{
    public partial class Form1 : Form
    {
        Button[] b = new Button[16]; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button1.Text;
                button1.Text = "";
                return;
            }

            if (button5.Text == "")
            {
                button5.Text = button1.Text;
                button1.Text = "";
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button2.Text;
                button2.Text = "";
                return;
            }

            if (button3.Text == "")
            {
                button3.Text = button2.Text;
                button2.Text = "";
                return;
            }

            if (button6.Text == "")
            {
                button6.Text = button2.Text;
                button2.Text = "";
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button3.Text;
                button3.Text = "";
                return;
            }

            if (button4.Text == "")
            {
                button4.Text = button3.Text;
                button3.Text = "";
                return;
            }

            if (button7.Text == "")
            {
                button7.Text = button3.Text;
                button3.Text = "";
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = button4.Text;
                button4.Text = "";
                return;
            }

            if (button8.Text == "")
            {
                button8.Text = button4.Text;
                button4.Text = "";
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button5.Text;
                button5.Text = "";
                return;
            }

            if (button6.Text == "")
            {
                button6.Text = button5.Text;
                button5.Text = "";
                return;
            }

            if (button9.Text == "")
            {
                button9.Text = button5.Text;
                button5.Text = "";
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button6.Text;
                button6.Text = "";
                return;
            }

            if (button5.Text == "")
            {
                button5.Text = button6.Text;
                button6.Text = "";
                return;
            }

            if (button7.Text == "")
            {
                button7.Text = button6.Text;
                button6.Text = "";
                return;
            }

            if (button10.Text == "")
            {
                button10.Text = button6.Text;
                button6.Text = "";
                return;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = button7.Text;
                button7.Text = "";
                return;
            }

            if (button6.Text == "")
            {
                button6.Text = button7.Text;
                button7.Text = "";
                return;
            }

            if (button8.Text == "")
            {
                button8.Text = button7.Text;
                button7.Text = "";
                return;
            }

            if (button11.Text == "")
            {
                button11.Text = button7.Text;
                button7.Text = "";
                return;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                button4.Text = button8.Text;
                button8.Text = "";
                return;
            }

            if (button7.Text == "")
            {
                button7.Text = button8.Text;
                button8.Text = "";
                return;
            }

            if (button12.Text == "")
            {
                button12.Text = button8.Text;
                button8.Text = "";
                return;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                button5.Text = button9.Text;
                button9.Text = "";
                return;
            }

            if (button10.Text == "")
            {
                button10.Text = button9.Text;
                button9.Text = "";
                return;
            }

            if (button13.Text == "")
            {
                button13.Text = button9.Text;
                button9.Text = "";
                return;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = button10.Text;
                button10.Text = "";
                return;
            }

            if (button9.Text == "")
            {
                button9.Text = button10.Text;
                button10.Text = "";
                return;
            }

            if (button11.Text == "")
            {
                button11.Text = button10.Text;
                button10.Text = "";
                return;
            }

            if (button14.Text == "")
            {
                button14.Text = button10.Text;
                button10.Text = "";
                return;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button12.Text == "")
            {
                button12.Text = button11.Text;
                button11.Text = "";
                return;
            }
            if (button7.Text == "")
            {
                button7.Text = button11.Text;
                button11.Text = "";
                return;
            }
            if (button10.Text == "")
            {
                button10.Text = button11.Text;
                button11.Text = "";
                return;
            }
            if (button15.Text == "")
            {
                button15.Text = button11.Text;
                button11.Text = "";
                return;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button16.Text == "")
            {
                button16.Text = button12.Text;
                button12.Text = "";
                return;
            }
            if (button11.Text == "")
            {
                button11.Text = button12.Text;
                button12.Text = "";
                return;
            }
            if (button8.Text == "")
            {
                button8.Text = button12.Text;
                button12.Text = "";
                return;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                button9.Text = button13.Text;
                button13.Text = "";
                return;
            }

            if (button14.Text == "")
            {
                button14.Text = button13.Text;
                button13.Text = "";
                return;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button10.Text == "")
            {
                button10.Text = button14.Text;
                button14.Text = "";
                return;
            }

            if (button13.Text == "")
            {
                button13.Text = button14.Text;
                button14.Text = "";
                return;
            }

            if (button15.Text == "")
            {
                button15.Text = button14.Text;
                button14.Text = "";
                return;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button16.Text == "")
            {
                button16.Text = button15.Text;
                button15.Text = "";
                return;
            }
            if (button14.Text == "")
            {
                button14.Text = button15.Text;
                button15.Text = "";
                return;
            }
            if (button11.Text == "")
            {
                button11.Text = button15.Text;
                button15.Text = "";
                return;
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button12.Text == "")
            {
                button12.Text = button16.Text;
                button16.Text = "";
                return;
            }
            if (button15.Text == "")
            {
                button15.Text = button16.Text;
                button16.Text = "";
                return;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int aleatorio = new Random().Next(1,15);


            switch (aleatorio)
            {
                case 1:
                    button1.Text = "15";
                    button2.Text = "14";
                    button3.Text = "13";
                    button4.Text = "12";
                    button5.Text = "11";
                    button6.Text = "10";
                    button7.Text = "9";
                    button8.Text = "8";
                    button9.Text = "7";
                    button10.Text = "6";
                    button11.Text = "5";
                    button12.Text = "4";
                    button13.Text = "3";
                    button14.Text = "2";
                    button15.Text = "1";
                    button16.Text = "";
                    break;

                case 2:
                    button1.Text = "10";
                    button2.Text = "14";
                    button3.Text = "5";
                    button4.Text = "12";
                    button5.Text = "1";
                    button6.Text = "15";
                    button7.Text = "3";
                    button8.Text = "8";
                    button9.Text = "2";
                    button10.Text = "6";
                    button11.Text = "13";
                    button12.Text = "4";
                    button13.Text = "9";
                    button14.Text = "7";
                    button15.Text = "11";
                    button16.Text = "";
                    break;

                case 3:
                    button1.Text = "5";
                    button2.Text = "14";
                    button3.Text = "13";
                    button4.Text = "2";
                    button5.Text = "11";
                    button6.Text = "1";
                    button7.Text = "9";
                    button8.Text = "4";
                    button9.Text = "7";
                    button10.Text = "6";
                    button11.Text = "15";
                    button12.Text = "8";
                    button13.Text = "3";
                    button14.Text = "12";
                    button15.Text = "10";
                    button16.Text = "";
                    break;

                case 4:
                    button1.Text = "2";
                    button2.Text = "14";
                    button3.Text = "13";
                    button4.Text = "12";
                    button5.Text = "11";
                    button6.Text = "3";
                    button7.Text = "5";
                    button8.Text = "8";
                    button9.Text = "7";
                    button10.Text = "6";
                    button11.Text = "9";
                    button12.Text = "4";
                    button13.Text = "10";
                    button14.Text = "15";
                    button15.Text = "1";
                    button16.Text = "";
                    break;

                case 5:
                    button1.Text = "9";
                    button2.Text = "3";
                    button3.Text = "1";
                    button4.Text = "12";
                    button5.Text = "4";
                    button6.Text = "10";
                    button7.Text = "15";
                    button8.Text = "8";
                    button9.Text = "7";
                    button10.Text = "6";
                    button11.Text = "5";
                    button12.Text = "11";
                    button13.Text = "14";
                    button14.Text = "2";
                    button15.Text = "13";
                    button16.Text = "";
                    break;

                case 6:
                    button1.Text = "4";
                    button2.Text = "14";
                    button3.Text = "7";
                    button4.Text = "12";
                    button5.Text = "3";
                    button6.Text = "10";
                    button7.Text = "9";
                    button8.Text = "8";
                    button9.Text = "13";
                    button10.Text = "1";
                    button11.Text = "5";
                    button12.Text = "15";
                    button13.Text = "11";
                    button14.Text = "2";
                    button15.Text = "6";
                    button16.Text = "";
                    break;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        
    }
}
