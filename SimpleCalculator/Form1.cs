using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        float ans = 0,number1 = 0, number2 = 0,tempNum = 0,result = 0;
        bool alreadyDot = false, changeText = true, alreadyOperator = false;
        string command = "";
        public Form1()
        {
            InitializeComponent();
        }

        string txt = "";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void changeDisplayText()
        {
            Console.WriteLine(command);
            if(changeText)
            {
                textBox1.Text = "";
                changeText = false;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            changeDisplayText();
            textBox1.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeDisplayText();
            textBox1.Text += "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeDisplayText();
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            changeDisplayText();
            textBox1.Text += "3";

        }
        private void button4_Click(object sender, EventArgs e)
        {
            changeDisplayText();
            textBox1.Text += "4";

        }
        private void button5_Click(object sender, EventArgs e)
        {
            changeDisplayText();
            textBox1.Text += "5";

        }
        private void button6_Click(object sender, EventArgs e)
        {
            changeDisplayText();
            textBox1.Text += "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            changeDisplayText();
            textBox1.Text += "7";

        }
        private void button8_Click(object sender, EventArgs e)
        {
            changeDisplayText();
            textBox1.Text += "8";

        }
        private void button9_Click(object sender, EventArgs e)
        {
            changeDisplayText();
            textBox1.Text += "9";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txt += textBox1.Text + " + ";
            textBox2.Text = txt;
            if(alreadyOperator)
            {
                number2 = float.Parse(textBox1.Text, System.Globalization.CultureInfo.InstalledUICulture);
                result += number2;
                textBox1.Text = result.ToString();
                alreadyOperator = false;
            }
            else
            {
                number1 = float.Parse(textBox1.Text, System.Globalization.CultureInfo.InstalledUICulture);
                alreadyOperator = true;
                result += number1;
                textBox1.Text = result.ToString();
            }
            changeText = true;
            Console.WriteLine(result);
            command = "+";
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            txt += textBox1.Text + " - ";
            textBox2.Text = txt;
            if (alreadyOperator)
            {
                number2 = float.Parse(textBox1.Text, System.Globalization.CultureInfo.InstalledUICulture);
                result = result - number2;
                textBox1.Text = result.ToString();
                alreadyOperator = false;
            }
            else
            {
                number1 = float.Parse(textBox1.Text, System.Globalization.CultureInfo.InstalledUICulture);
                alreadyOperator = true;
                if (command != "") result -= number1;
                else result = number1;
                textBox1.Text = result.ToString();
            }
            changeText = true;
            Console.WriteLine(result);
            command = "-";
        }
        private void btnMult_Click(object sender, EventArgs e)
        {
            txt += textBox1.Text + " * ";
            textBox2.Text = txt;
            if (alreadyOperator)
            {
                number2 = float.Parse(textBox1.Text, System.Globalization.CultureInfo.InstalledUICulture);
                result = result * number2;
                textBox1.Text = result.ToString();
                alreadyOperator = false;
            }
            else
            {
                number1 = float.Parse(textBox1.Text, System.Globalization.CultureInfo.InstalledUICulture);
                alreadyOperator = true;
                if (command != "") result *= number1;
                else result = number1;
                textBox1.Text = result.ToString();
            }
            textBox1.Text = result.ToString();
            changeText = true;
            Console.WriteLine(result);
            command = "*";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txt += textBox1.Text + " / ";
            textBox2.Text = txt;
            if (alreadyOperator)
            {
                number2 = float.Parse(textBox1.Text, System.Globalization.CultureInfo.InstalledUICulture);
                result = result / number2;
                textBox1.Text = result.ToString();
                alreadyOperator = false;
            }
            else
            {
                number1 = float.Parse(textBox1.Text, System.Globalization.CultureInfo.InstalledUICulture);
                alreadyOperator = true;
                if (command != "") result /= number1;
                else result = number1;
                textBox1.Text = result.ToString();
            }
            changeText = true;
            Console.WriteLine(result);
            command = "/";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            textBox2.Text = "";
            changeText = true;
            result = 0;
            textBox1.Text = "0";
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            number1 = float.Parse(textBox1.Text, System.Globalization.CultureInfo.InstalledUICulture);
            Console.WriteLine(number1);
            float percent = number1 / 100 * result;
            textBox1.Text = percent.ToString();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!alreadyDot)
            {
                alreadyDot = !alreadyDot;
                textBox1.Text += ".";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            number2 = float.Parse(textBox1.Text);
            Console.WriteLine(command);
            switch (command)
            {
                case "+":
                    result += number2;
                    break;
                case "-":
                    result -= number2;
                    break;
                case "*":
                    result *= number2;
                    break;
                case "/":
                    result /= number2;
                    break;
                default:
                    result = float.Parse(textBox1.Text);
                    break;
            }
            txt += number2.ToString();
            textBox2.Text = txt;
            txt = "";
            Console.WriteLine(result);
            alreadyOperator = false;
            command = "";
            textBox1.Text = result.ToString();
            result = 0;
        }
    }
}
