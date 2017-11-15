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
    public partial class moneyConvertionForm : Form
    {
        string dir = @"C:\PROJECT\Files\";

        public moneyConvertionForm()
        {
            InitializeComponent();
        }

        private void moneyConvertionForm_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
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

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                //Variables
                double enterValue = Convert.ToDouble(txtEntered.Text);
                double converValue = 0;
                string fromCurr = "";
                string toCurr = "";
                //set from
                if (rBtnCANfrom.Checked)
                {
                    fromCurr = "CAN";
                }
                else if (rBtnUSDfrom.Checked)
                {
                    fromCurr = "USD";
                }
                else if (rBtnEURfrom.Checked)
                {
                    fromCurr = "EUR";
                }
                else if (rBtnGBPto.Checked)
                {
                    fromCurr = "GBP";
                }

                //set to
                if (rBtnCANto.Checked)
                {
                    toCurr = "CAN";

                }
                else if (rBtnUSDto.Checked)
                {
                    toCurr = "USD";
                }
                else if (rBtnEURto.Checked)
                {
                    toCurr = "EUR";
                }
                else if (rBtnGBPto.Checked)
                {
                    toCurr = "GBP";
                }


                //conversion
                if (fromCurr == "CAN")
                {
                    if (toCurr == "CAN")
                    {
                        const double RATE = 1;
                        converValue = enterValue * RATE;

                    }
                    else if (toCurr == "USD")
                    {
                        const double RATE = 0.77;
                        converValue = enterValue * RATE;
                    }
                    else if (toCurr == "EUR")
                    {
                        const double RATE = 0.70;
                        converValue = enterValue * RATE;
                    }
                    else if (toCurr == "GBP")
                    {
                        const double RATE = 0.59;
                        converValue = enterValue * RATE;
                    }
                }
                else if (fromCurr == "USD")
                {
                    if (toCurr == "CAN")
                    {
                        const double RATE = 1.30;
                        converValue = enterValue * RATE;

                    }
                    else if (toCurr == "USD")
                    {
                        const double RATE = 1;
                        converValue = enterValue * RATE;
                    }
                    else if (toCurr == "EUR")
                    {
                        const double RATE = 0.91;
                        converValue = enterValue * RATE;
                    }
                    else if (toCurr == "GBP")
                    {
                        const double RATE = 0.76;
                        converValue = enterValue * RATE;
                    }
                }
                else if (fromCurr == "EUR")
                {
                    if (toCurr == "CAN")
                    {
                        const double RATE = 1.44;
                        converValue = enterValue * RATE;

                    }
                    else if (toCurr == "USD")
                    {
                        const double RATE = 1.10;
                        converValue = enterValue * RATE;
                    }
                    else if (toCurr == "EUR")
                    {
                        const double RATE = 1;
                        converValue = enterValue * RATE;
                    }
                    else if (toCurr == "GBP")
                    {
                        const double RATE = 0.84;
                        converValue = enterValue * RATE;
                    }
                }
                else if (fromCurr == "GBP")
                {
                    if (toCurr == "CAN")
                    {
                        const double RATE = 1.71;
                        converValue = enterValue * RATE;

                    }
                    else if (toCurr == "USD")
                    {
                        const double RATE = 1.31;
                        converValue = enterValue * RATE;
                    }
                    else if (toCurr == "EUR")
                    {
                        const double RATE = 1.19;
                        converValue = enterValue * RATE;
                    }
                    else if (toCurr == "GBP")
                    {
                        const double RATE = 1;
                        converValue = enterValue * RATE;
                    }
                }

                //Display 
                txtConverted.Text = Convert.ToString(converValue);

                //Save in .txt doc 
                string path = dir + "MoneyConvertionJulianaLinares.txt";
                FileStream fs = null;
                StreamWriter textOut = null;
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                textOut = new StreamWriter(fs);

                //write
                textOut.Write(enterValue + fromCurr + "=" + converValue + toCurr + "," + DateTime.Now + Environment.NewLine);
                //close
                if (textOut != null) { textOut.Close(); }
                if (fs != null) { fs.Close(); }
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Enter valid values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = dir + "MoneyConvertionJulianaLinares.txt";
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);

                //message in box
                string messageToPrint = "Currency exchange \n";

                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    messageToPrint += row + "\n";
                }
                MessageBox.Show(messageToPrint);

                if (textIn != null) { textIn.Close(); }
                if (fs != null) { fs.Close(); }
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Generate a conversion before.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
