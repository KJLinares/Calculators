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
    public partial class lottoMaxForm : Form
    {
        public lottoMaxForm()
        {
            InitializeComponent();
        }
        //new dir 
        string dir = @"C:\PROJECT\Files\";
        private void lottoMaxForm_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Constants
            const int MAX_NUMBERS = 8 ;
           
            //Variables 
            Random random = new Random();
            string winningNumbers= "";
            string newLine = Environment.NewLine;
            int[] numbers = new int[MAX_NUMBERS];
            DateTime currentTime = DateTime.Now;
            

            for ( int i = 0; i < MAX_NUMBERS; i++)
            {
                bool sameNum = false; 
                int randomNumber ;
                
                do 
                { 
                    randomNumber = random.Next(1, 49);
                    sameNum = checkEqual(randomNumber, numbers);
                }
                while (sameNum == true);
                numbers[i] = randomNumber;
            }
        
            for (int i = 0; i < MAX_NUMBERS; i++)
            {
                winningNumbers += numbers[i].ToString() + "," ;
            }
            
            //display ---- Max,7/21/2016 2:17:42 PM,5,11,14,3,46,10,21,23
            txtWinningNumbers.Text = txtWinningNumbers.Text + newLine + winningNumbers;
           
            //Save in .txt doc
            string path = dir + "LottoMaxJulianaLinares.txt";
            FileStream fs = null;
            StreamWriter textOut = null;
            fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            textOut = new StreamWriter(fs);
           
            //write
            textOut.Write("Max," + currentTime +"\t" + winningNumbers + newLine);
            //close
            if (textOut != null) { textOut.Close(); }
            if (fs != null) { fs.Close(); }
            
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            
            string path = dir + "LottoMaxJulianaLinares.txt";
            
            try 
            { 
           
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader textIn = new StreamReader(fs);

            //message in box
            string messageToPrint = "Winnig Numbers \n";

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                messageToPrint += row + "\n";
            }
            MessageBox.Show(messageToPrint);
            
            if (textIn != null) { textIn.Close(); }
            if (fs != null) { fs.Close(); }  
            }
            catch (FileNotFoundException exp1 )
            {
                MessageBox.Show("Generate a winnig numbers before.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
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

        private bool checkEqual(int num, int[] array)
        {
            bool sameNum = false;

           for (int j = 0; j < 8; j++)
           {
                        if (num == array[j])
                        {
                            sameNum = true;
                        }
           }

            return sameNum;
        }
    }
}
