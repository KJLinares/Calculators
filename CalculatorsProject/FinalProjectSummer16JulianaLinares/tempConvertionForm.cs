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
    public partial class tempConvertionForm : Form
    {
        //new dir 
        string dir = @"C:\PROJECT\Files\";

        public tempConvertionForm()
        {
            InitializeComponent();
        }

        private void rTxtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void tempConvertionForm_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Do you want to quit the application?", "Exit ?", MessageBoxButtons.YesNo);
            if (ans == DialogResult.Yes)
            {
                string path = dir + "TemperatureConvertionJulianaLinares.txt";
                this.Close();
                if (File.Exists(path))
                    File.Delete(path);
            }
        }
       
        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double enterValue, convertValue;
                string message = "";
                string from= "", to= "";
                enterValue = Convert.ToInt16(txtEntered.Text);

                if (rBtnCtoF.Checked)
                {
                    from = "C";
                    to = "F";
                }
                else if (rBtnFtoC.Checked)
                {
                    from = "F";
                    to = "C";
                }

                if( from == "C")
                {
                    //Celsius to Fahrenheit: (°C × 9/5) + 32 = °F 
                    convertValue = (enterValue * 9/5) +32 ;
                    if (enterValue == 212)
                    {
                        message = "Watter boils";
                    }
                    else if (enterValue == 104)
                    {
                        message = "Hot Bath";
                    }
                    else if (enterValue == 98.6)
                    {
                        message = "Body Temperature";
                    }
                    else if (enterValue == 86)
                    {
                        message = "Beach Weather";
                    }
                    else if (enterValue == 70)
                    {
                        message = "Room Temperature";
                    }
                    else if (enterValue == 50)
                    {
                        message = "Cool Day";
                    }
                    else if (enterValue == 32)
                    {
                        message = "Freezing point of watter";
                    }
                    else if (enterValue == 0)
                    {
                        message = "Very cold day";
                    }
                    else if (enterValue == -40)
                    {
                        message = "Extremely Cold Day";
                    }
                 
                }
                else 
                {
                    //Fahrenheit to Celsius: (°F − 32) x 5/9 = °C
                    convertValue = (enterValue - 32) * 5/9;
                    
                    if (enterValue == 100)
                    {
                        message = "Watter boils";
                    }
                    else if (enterValue == 40)
                    {
                        message = "Hot Bath";
                    }
                    else if (enterValue == 37)
                    {
                        message = "Body Temperature";
                    }
                    else if (enterValue == 30)
                    {
                        message = "Beach Weather";
                    }
                    else if (enterValue == 21)
                    {
                        message = "Room Temperature";
                    }
                    else if (enterValue == 10)
                    {
                        message = "Cool Day";
                    }
                    else if (enterValue == 0)
                    {
                        message = "Freezing point of watter";
                    }
                    else if (enterValue == -18)
                    {
                        message = "Very cold day";
                    }
                    else if (enterValue == -40)
                    {
                        message = "Extremely Cold Day";
                    }
                }

                //display
                txtConverted.Text = Convert.ToString(convertValue);
                rTxtMessage.Text = message;
                // save in .txt
                string path = dir + "TemperatureConvertionJulianaLinares.txt";
                FileStream fs = null;
                StreamWriter textOut = null;
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                textOut = new StreamWriter(fs);

                //write
                textOut.Write(enterValue + from + "=" + convertValue + to +","+ DateTime.Now + Environment.NewLine);
                //close
                if (textOut != null) { textOut.Close(); }
                if (fs != null) { fs.Close(); }
 
            }
            catch
            {
                MessageBox.Show("Enter value !!! ", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            string path = dir + "TemperatureConvertionJulianaLinares.txt";

            try
            {

                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);

                //message in box
                string messageToPrint = "Temperature convertions : \n";

                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    messageToPrint += row + "\n";
                }
                MessageBox.Show(messageToPrint);

                if (textIn != null) { textIn.Close(); }
                if (fs != null) { fs.Close(); }
            }
            catch (FileNotFoundException exp1)
            {
                MessageBox.Show("Generate a convertion before.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
