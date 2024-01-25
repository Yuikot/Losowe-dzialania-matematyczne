using System.Security.Cryptography.Xml;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Losowe_działania_matematyczne
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int num1, num2, result;
        string answer;

        public Form1()
        {
            InitializeComponent();
            textBox1.KeyPress += new KeyPressEventHandler(TextBox1_KeyPress);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateCalculation();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CheckAnswer();
                e.Handled = true;
            }
        }

        private int GenerateRandomNumber()
        {
            int rannum = random.Next(1, 11);
            return rannum;
        }

        private int GenerateCalculation()
        {
            int rancal = random.Next(1, 5);
            return rancal;
        }

        private void CreateCalculation()
        { 
            num1 = GenerateRandomNumber();
            num2 = GenerateRandomNumber();
            int CreateCalc = GenerateCalculation();

            switch (CreateCalc)
            {
                case 1:
                    result = num1 + num2;
                    label1.Text = num1 + " + " + num2 + " =";
                    break;
                case 2:
                    result = num1 - num2;
                    label1.Text = num1 + " - " + num2 + " =";
                    break;
                case 3:
                    result = num1 * num2;
                    label1.Text = num1 + " x " + num2 + " =";
                    break;
                case 4:
                    if (num1 < num2)
                    {
                        result = num2 / num1;
                        label1.Text = num2 + " : " + num1 + " =";
                    }
                    else
                        result = num1 / num2;
                        break;
            }

        }

        private void CheckAnswer()
        {
            answer = textBox1.Text;
            if (answer == result.ToString())
            {
                CreateCalculation();
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
            else
            {
                textBox1.ForeColor = Color.Red;               
            }
        }
    }
    
}
