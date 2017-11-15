using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalProjectSummer16JulianaLinares
{
    public partial class simpleCalculatorForm : Form
    { 
        string dir = @"C:\PROJECT\Files\";
        private void simpleCalculatorForm_Load(object sender, EventArgs e)
        {
         
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);   
        }

            


        public simpleCalculatorForm()
        {
            InitializeComponent();
        }
       
        //variables
        string pressValue;
        Calculator objCalc = new Calculator();
      
        private void btnN1_Click(object sender, EventArgs e)
        {
            pressValue = pressValue + "1";
            objCalc.CurrentValue = Convert.ToDouble(pressValue);
            writeText(objCalc.CurrentValue);


        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            pressValue = pressValue + "2";
            objCalc.CurrentValue = Convert.ToDouble(pressValue);
            writeText(objCalc.CurrentValue);
            
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            pressValue = pressValue + "3";
            objCalc.CurrentValue = Convert.ToDouble(pressValue);
            writeText(objCalc.CurrentValue);
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            pressValue = pressValue + "4";
            objCalc.CurrentValue = Convert.ToDouble(pressValue);
            writeText(objCalc.CurrentValue);
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            pressValue = pressValue + "5";
            objCalc.CurrentValue = Convert.ToDouble(pressValue);
            writeText(objCalc.CurrentValue);
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            pressValue = pressValue + "6";
            objCalc.CurrentValue = Convert.ToDouble(pressValue);
            writeText(objCalc.CurrentValue);
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            pressValue = pressValue + "7";
            objCalc.CurrentValue = Convert.ToDouble(pressValue);
            writeText(objCalc.CurrentValue);
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            pressValue = pressValue + "8";
            objCalc.CurrentValue = Convert.ToDouble(pressValue);
            writeText(objCalc.CurrentValue);
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            pressValue = pressValue + "9";
            objCalc.CurrentValue = Convert.ToDouble(pressValue);
            writeText(objCalc.CurrentValue);
        }

        private void btnN0_Click(object sender, EventArgs e)
        {
            pressValue = pressValue + "0";
            objCalc.CurrentValue = Convert.ToDouble(pressValue);
            writeText(objCalc.CurrentValue);
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            pressValue = pressValue + ".";
            objCalc.CurrentValue = Convert.ToDouble(pressValue);
            writeText(objCalc.CurrentValue);
        }

        //Opetarations methods

        private void btnAdd_Click(object sender, EventArgs e)
        {
            objCalc.Add(pressValue);
            pressValue= "";

        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            objCalc.Subs(pressValue);
            pressValue = "";
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            objCalc.Mult(pressValue);
            pressValue = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            objCalc.Div(pressValue);
            pressValue = "";
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            double result = objCalc.Equal(pressValue);
            pressValue = Convert.ToString(result);
            writeText(Convert.ToDouble(pressValue));
            
        }
        //additional Methods
        public void writeText(double value)
        {
            txtBox.Text = Convert.ToString( value);
            //Save in .txt doc
            string path = dir + "CalculatorJulianaLinares.txt";
            FileStream fs = null;
            StreamWriter textOut = null;
            fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            textOut = new StreamWriter(fs);
            textOut.Write(pressValue);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Do you want to quit the application?", "Exit ?", MessageBoxButtons.YesNo);
            if (ans == DialogResult.Yes)
            {
                string path = dir + "LottoMaxJulianaLinares.txt";
                this.Close();
                if (File.Exists(path))
                    File.Delete(path);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            objCalc.Clear();
            writeText(0);
            pressValue = "";
        }

       
   
    }

    public class Calculator
    { 
        //Private fields
        double currentValue, operand1, operand2;
        string oper;
        string dir = @"C:\PROJECT\Files\";
        //property
        public double CurrentValue
        {
            get { return currentValue; }
            set { currentValue = value; }
        }


        //Method
        public void Add(string value)
        {
            currentValue = operand1 = Convert.ToDouble(value);
            oper = "+";
            //Save in .txt doc
            string path = dir + "CalculatorJulianaLinares.txt";
            FileStream fs = null;
            StreamWriter textOut = null;
            fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            textOut = new StreamWriter(fs);
            textOut.Write(oper);
        }
        public void Subs(string value)
        {
            currentValue = operand1 = Convert.ToDouble(value);
            oper = "-";
            //Save in .txt doc
            string path = dir + "CalculatorJulianaLinares.txt";
            FileStream fs = null;
            StreamWriter textOut = null;
            fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            textOut = new StreamWriter(fs);
            textOut.Write(oper);
        }
        public void Mult(string value)
        {
            currentValue = operand1 = Convert.ToDouble(value);
            oper = "*";
            //Save in .txt doc
            string path = dir + "CalculatorJulianaLinares.txt";
            FileStream fs = null;
            StreamWriter textOut = null;
            fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            textOut = new StreamWriter(fs);
            textOut.Write(oper);
        }
        public void Div(string value)
        {
            currentValue = operand1 = Convert.ToDouble(value);
            oper = "/";
            //Save in .txt doc
            string path = dir + "CalculatorJulianaLinares.txt";
            FileStream fs = null;
            StreamWriter textOut = null;
            fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            textOut = new StreamWriter(fs);
            textOut.Write(oper);
        }

        public double Equal(string value)
        {
            operand2 = Convert.ToDouble(value);

            if (oper == "+")
            {
                currentValue = operand1 + operand2;
                operand1 = currentValue;
                operand2 =  0;
            }
            else if (oper == "-")
            {
                currentValue = operand1 - operand2;
                operand1 = currentValue;
                operand2 = 0;
            }
            else if (oper == "*")
            {
                currentValue = operand1 * operand2;
                operand1 = currentValue;
                operand2 = 0;
            }
            else if (oper == "/")
            {
                currentValue = operand1 / operand2;
                operand1 = currentValue;
                operand2 = 0;
            }
            else
            {
                currentValue = operand1;
                operand2 = 0;
            }

            //Save in .txt doc
            string path = dir + "CalculatorJulianaLinares.txt";
            FileStream fs = null;
            StreamWriter textOut = null;
            fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            textOut = new StreamWriter(fs);
            textOut.Write(currentValue);

            return CurrentValue;
        }

        public void Clear()
        {
            operand1 = 0;
            operand2 = 0;
            currentValue = 0;
            string path = dir + "CalculatorJulianaLinares.txt";
            FileStream fs = null;
            StreamWriter textOut = null;
            fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            textOut = new StreamWriter(fs);
            textOut.Write(Environment.NewLine);
        }
    }
    
}
