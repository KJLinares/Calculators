namespace FinalProjectSummer16JulianaLinares
{
    partial class tempConvertionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rBtnCtoF = new System.Windows.Forms.RadioButton();
            this.rBtnFtoC = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEntered = new System.Windows.Forms.TextBox();
            this.txtConverted = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rTxtMessage = new System.Windows.Forms.RichTextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rBtnCtoF
            // 
            this.rBtnCtoF.AutoSize = true;
            this.rBtnCtoF.Location = new System.Drawing.Point(105, 12);
            this.rBtnCtoF.Name = "rBtnCtoF";
            this.rBtnCtoF.Size = new System.Drawing.Size(79, 17);
            this.rBtnCtoF.TabIndex = 0;
            this.rBtnCtoF.TabStop = true;
            this.rBtnCtoF.Text = "From C to F";
            this.rBtnCtoF.UseVisualStyleBackColor = true;
            // 
            // rBtnFtoC
            // 
            this.rBtnFtoC.AutoSize = true;
            this.rBtnFtoC.Location = new System.Drawing.Point(105, 35);
            this.rBtnFtoC.Name = "rBtnFtoC";
            this.rBtnFtoC.Size = new System.Drawing.Size(79, 17);
            this.rBtnFtoC.TabIndex = 1;
            this.rBtnFtoC.TabStop = true;
            this.rBtnFtoC.Text = "From F to C";
            this.rBtnFtoC.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "to";
            // 
            // txtEntered
            // 
            this.txtEntered.Location = new System.Drawing.Point(12, 68);
            this.txtEntered.Name = "txtEntered";
            this.txtEntered.Size = new System.Drawing.Size(100, 20);
            this.txtEntered.TabIndex = 3;
            // 
            // txtConverted
            // 
            this.txtConverted.Location = new System.Drawing.Point(159, 68);
            this.txtConverted.Name = "txtConverted";
            this.txtConverted.ReadOnly = true;
            this.txtConverted.Size = new System.Drawing.Size(100, 20);
            this.txtConverted.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message:";
            // 
            // rTxtMessage
            // 
            this.rTxtMessage.Location = new System.Drawing.Point(12, 140);
            this.rTxtMessage.Name = "rTxtMessage";
            this.rTxtMessage.ReadOnly = true;
            this.rTxtMessage.Size = new System.Drawing.Size(244, 75);
            this.rTxtMessage.TabIndex = 6;
            this.rTxtMessage.Text = "";
            this.rTxtMessage.TextChanged += new System.EventHandler(this.rTxtMessage_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(12, 238);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(105, 238);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(75, 23);
            this.btnReadFile.TabIndex = 8;
            this.btnReadFile.Text = "Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(205, 238);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "C or F ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(178, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "F or C";
            // 
            // tempConvertionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.rTxtMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConverted);
            this.Controls.Add(this.txtEntered);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rBtnFtoC);
            this.Controls.Add(this.rBtnCtoF);
            this.Name = "tempConvertionForm";
            this.Text = "tempConvertionForm";
            this.Load += new System.EventHandler(this.tempConvertionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rBtnCtoF;
        private System.Windows.Forms.RadioButton rBtnFtoC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntered;
        private System.Windows.Forms.TextBox txtConverted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rTxtMessage;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}