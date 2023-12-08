using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string MemorySaveNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void paste_Click(object sender, EventArgs e)
        {
            try
            {
                var num = Convert.ToDouble(Clipboard.GetText());
                var x = num.GetType();
                if(num.GetType().Name == "Double")
                {
                    textBox1.Text = Clipboard.GetText();
                }
            }
            catch(Exception ex)
            {
                textBox1.Text = "Invalid Input!";
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != "")
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                Operation = "+";
            }  
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double currentValue;
            currentValue = Convert.ToDouble(textBox1.Text);
            if (double.TryParse(textBox1.Text, out currentValue))
            {
                if (currentValue != 0)
                {
                    double reciprocal = 1.0 / currentValue;
                    textBox1.Text = reciprocal.ToString();
                }
                else
                {
                    textBox1.Text = "Error: Division by zero";
                }
            }
            else
            {
                textBox1.Text = "Error: Invalid input";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != null && textBox1.Text != "")
            {
                if (textBox1.Text.Last() != '.')
                {
                    textBox1.Text = textBox1.Text + ".";
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double currentValue;
            currentValue = Convert.ToDouble(textBox1.Text);
            if (double.TryParse(textBox1.Text, out currentValue))
            {
                double changedSignValue = -currentValue;
                textBox1.Text = changedSignValue.ToString();
            }
        }

        private void MemoryAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != null)
            {
                textBox1.Text = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(MemorySaveNumber)).ToString();
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox1.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "%")
            {
                Result = (FirstNumber * (SecondNumber/100));
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != "")
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                Operation = "/";
            }    
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != "")
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                Operation = "*";
            }       
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != "")
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                Operation = "-";
            }
        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != null && textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }  
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void Modulo_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != "")
            {
                FirstNumber = double.Parse(textBox1.Text);
                textBox1.Text = "0";
                Operation = "%";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double currentValue;
            currentValue = Convert.ToDouble(textBox1.Text);
            if (double.TryParse(textBox1.Text, out currentValue))
            {
                if (currentValue >= 0)
                {
                    double squareRoot = Math.Sqrt(currentValue);
                    textBox1.Text = squareRoot.ToString();
                }
                else
                {
                    textBox1.Text = "Error: Square root of a negative number";
                }
            }
            else
            {
                textBox1.Text = "Error: Invalid input";
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManualForm manualForm = new ManualForm();
            manualForm.ShowDialog();
        }

        private void MemorySave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != "")
            {
                MemorySaveNumber = textBox1.Text;
                textBox1.Text = "0";
            }
        }

        private void MemoryRead_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1 && textBox1.Text == "0")
            {
                textBox1.Text = MemorySaveNumber;
            }
            else
            {
                textBox1.Text = textBox1.Text + MemorySaveNumber;
            }
        }

        private void MemoryClear_Click(object sender, EventArgs e)
        {
            MemorySaveNumber = "";
        }

        private void MemorySubstract_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != null)
            {
                textBox1.Text = (Convert.ToDouble(MemorySaveNumber) - Convert.ToDouble(textBox1.Text)).ToString();
            }
        }

        private void copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }
    }
}
