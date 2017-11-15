using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectSummer16JulianaLinares
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLottoMax_Click(object sender, EventArgs e)
        {
            lottoMaxForm lottoMax = new lottoMaxForm();
            lottoMax.ShowDialog();
        }

        private void btnTemperatureConversion_Click(object sender, EventArgs e)
        {
            tempConvertionForm tempConvert = new tempConvertionForm() ;
            tempConvert.ShowDialog();
        }

        private void btnMoneyConversion_Click(object sender, EventArgs e)
        {
            moneyConvertionForm moneyConvertion = new moneyConvertionForm();
            moneyConvertion.ShowDialog();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            simpleCalculatorForm simpleCalculator = new simpleCalculatorForm();
            simpleCalculator.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Do you want to quit the application?", "Exit ?", MessageBoxButtons.YesNo);
            if (ans == DialogResult.Yes )
            {
                this.Close();
            }
        }
    }
}
