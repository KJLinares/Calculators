namespace FinalProjectSummer16JulianaLinares
{
    partial class moneyConvertionForm
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.txtEntered = new System.Windows.Forms.TextBox();
            this.txtConverted = new System.Windows.Forms.TextBox();
            this.rBtnCANfrom = new System.Windows.Forms.RadioButton();
            this.gBxFrom = new System.Windows.Forms.GroupBox();
            this.rBtnGBPfrom = new System.Windows.Forms.RadioButton();
            this.rBtnEURfrom = new System.Windows.Forms.RadioButton();
            this.rBtnUSDfrom = new System.Windows.Forms.RadioButton();
            this.gBxTo = new System.Windows.Forms.GroupBox();
            this.rBtnGBPto = new System.Windows.Forms.RadioButton();
            this.rBtnEURto = new System.Windows.Forms.RadioButton();
            this.rBtnUSDto = new System.Windows.Forms.RadioButton();
            this.rBtnCANto = new System.Windows.Forms.RadioButton();
            this.gBxFrom.SuspendLayout();
            this.gBxTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(14, 238);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(205, 238);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(109, 238);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(75, 23);
            this.btnReadFile.TabIndex = 2;
            this.btnReadFile.Text = "Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // txtEntered
            // 
            this.txtEntered.Location = new System.Drawing.Point(14, 192);
            this.txtEntered.Name = "txtEntered";
            this.txtEntered.Size = new System.Drawing.Size(121, 20);
            this.txtEntered.TabIndex = 3;
            // 
            // txtConverted
            // 
            this.txtConverted.Location = new System.Drawing.Point(157, 192);
            this.txtConverted.Name = "txtConverted";
            this.txtConverted.ReadOnly = true;
            this.txtConverted.Size = new System.Drawing.Size(123, 20);
            this.txtConverted.TabIndex = 4;
            // 
            // rBtnCANfrom
            // 
            this.rBtnCANfrom.AutoSize = true;
            this.rBtnCANfrom.Location = new System.Drawing.Point(20, 19);
            this.rBtnCANfrom.Name = "rBtnCANfrom";
            this.rBtnCANfrom.Size = new System.Drawing.Size(47, 17);
            this.rBtnCANfrom.TabIndex = 5;
            this.rBtnCANfrom.TabStop = true;
            this.rBtnCANfrom.Text = "CAN";
            this.rBtnCANfrom.UseVisualStyleBackColor = true;
            // 
            // gBxFrom
            // 
            this.gBxFrom.Controls.Add(this.rBtnGBPfrom);
            this.gBxFrom.Controls.Add(this.rBtnEURfrom);
            this.gBxFrom.Controls.Add(this.rBtnUSDfrom);
            this.gBxFrom.Controls.Add(this.rBtnCANfrom);
            this.gBxFrom.Location = new System.Drawing.Point(12, 26);
            this.gBxFrom.Name = "gBxFrom";
            this.gBxFrom.Size = new System.Drawing.Size(123, 146);
            this.gBxFrom.TabIndex = 6;
            this.gBxFrom.TabStop = false;
            this.gBxFrom.Text = "From";
            // 
            // rBtnGBPfrom
            // 
            this.rBtnGBPfrom.AutoSize = true;
            this.rBtnGBPfrom.Location = new System.Drawing.Point(20, 88);
            this.rBtnGBPfrom.Name = "rBtnGBPfrom";
            this.rBtnGBPfrom.Size = new System.Drawing.Size(47, 17);
            this.rBtnGBPfrom.TabIndex = 8;
            this.rBtnGBPfrom.TabStop = true;
            this.rBtnGBPfrom.Text = "GBP";
            this.rBtnGBPfrom.UseVisualStyleBackColor = true;
            // 
            // rBtnEURfrom
            // 
            this.rBtnEURfrom.AutoSize = true;
            this.rBtnEURfrom.Location = new System.Drawing.Point(20, 65);
            this.rBtnEURfrom.Name = "rBtnEURfrom";
            this.rBtnEURfrom.Size = new System.Drawing.Size(48, 17);
            this.rBtnEURfrom.TabIndex = 7;
            this.rBtnEURfrom.TabStop = true;
            this.rBtnEURfrom.Text = "EUR";
            this.rBtnEURfrom.UseVisualStyleBackColor = true;
            // 
            // rBtnUSDfrom
            // 
            this.rBtnUSDfrom.AutoSize = true;
            this.rBtnUSDfrom.Location = new System.Drawing.Point(20, 42);
            this.rBtnUSDfrom.Name = "rBtnUSDfrom";
            this.rBtnUSDfrom.Size = new System.Drawing.Size(48, 17);
            this.rBtnUSDfrom.TabIndex = 6;
            this.rBtnUSDfrom.TabStop = true;
            this.rBtnUSDfrom.Text = "USD";
            this.rBtnUSDfrom.UseVisualStyleBackColor = true;
            // 
            // gBxTo
            // 
            this.gBxTo.Controls.Add(this.rBtnGBPto);
            this.gBxTo.Controls.Add(this.rBtnEURto);
            this.gBxTo.Controls.Add(this.rBtnUSDto);
            this.gBxTo.Controls.Add(this.rBtnCANto);
            this.gBxTo.Location = new System.Drawing.Point(157, 26);
            this.gBxTo.Name = "gBxTo";
            this.gBxTo.Size = new System.Drawing.Size(123, 146);
            this.gBxTo.TabIndex = 7;
            this.gBxTo.TabStop = false;
            this.gBxTo.Text = "To";
            // 
            // rBtnGBPto
            // 
            this.rBtnGBPto.AutoSize = true;
            this.rBtnGBPto.Location = new System.Drawing.Point(20, 88);
            this.rBtnGBPto.Name = "rBtnGBPto";
            this.rBtnGBPto.Size = new System.Drawing.Size(47, 17);
            this.rBtnGBPto.TabIndex = 8;
            this.rBtnGBPto.TabStop = true;
            this.rBtnGBPto.Text = "GBP";
            this.rBtnGBPto.UseVisualStyleBackColor = true;
            // 
            // rBtnEURto
            // 
            this.rBtnEURto.AutoSize = true;
            this.rBtnEURto.Location = new System.Drawing.Point(20, 65);
            this.rBtnEURto.Name = "rBtnEURto";
            this.rBtnEURto.Size = new System.Drawing.Size(48, 17);
            this.rBtnEURto.TabIndex = 7;
            this.rBtnEURto.TabStop = true;
            this.rBtnEURto.Text = "EUR";
            this.rBtnEURto.UseVisualStyleBackColor = true;
            // 
            // rBtnUSDto
            // 
            this.rBtnUSDto.AutoSize = true;
            this.rBtnUSDto.Location = new System.Drawing.Point(20, 42);
            this.rBtnUSDto.Name = "rBtnUSDto";
            this.rBtnUSDto.Size = new System.Drawing.Size(48, 17);
            this.rBtnUSDto.TabIndex = 6;
            this.rBtnUSDto.TabStop = true;
            this.rBtnUSDto.Text = "USD";
            this.rBtnUSDto.UseVisualStyleBackColor = true;
            // 
            // rBtnCANto
            // 
            this.rBtnCANto.AutoSize = true;
            this.rBtnCANto.Location = new System.Drawing.Point(20, 19);
            this.rBtnCANto.Name = "rBtnCANto";
            this.rBtnCANto.Size = new System.Drawing.Size(47, 17);
            this.rBtnCANto.TabIndex = 5;
            this.rBtnCANto.TabStop = true;
            this.rBtnCANto.Text = "CAN";
            this.rBtnCANto.UseVisualStyleBackColor = true;
            // 
            // moneyConvertionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.gBxTo);
            this.Controls.Add(this.gBxFrom);
            this.Controls.Add(this.txtConverted);
            this.Controls.Add(this.txtEntered);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvert);
            this.Name = "moneyConvertionForm";
            this.Text = "moneyConvertionForm";
            this.Load += new System.EventHandler(this.moneyConvertionForm_Load);
            this.gBxFrom.ResumeLayout(false);
            this.gBxFrom.PerformLayout();
            this.gBxTo.ResumeLayout(false);
            this.gBxTo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.TextBox txtEntered;
        private System.Windows.Forms.TextBox txtConverted;
        private System.Windows.Forms.RadioButton rBtnCANfrom;
        private System.Windows.Forms.GroupBox gBxFrom;
        private System.Windows.Forms.RadioButton rBtnGBPfrom;
        private System.Windows.Forms.RadioButton rBtnEURfrom;
        private System.Windows.Forms.RadioButton rBtnUSDfrom;
        private System.Windows.Forms.GroupBox gBxTo;
        private System.Windows.Forms.RadioButton rBtnGBPto;
        private System.Windows.Forms.RadioButton rBtnEURto;
        private System.Windows.Forms.RadioButton rBtnUSDto;
        private System.Windows.Forms.RadioButton rBtnCANto;

    }
}