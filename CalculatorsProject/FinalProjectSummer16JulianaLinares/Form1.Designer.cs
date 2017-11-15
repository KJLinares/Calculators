namespace FinalProjectSummer16JulianaLinares
{
    partial class DashBoard
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
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMoneyConversion = new System.Windows.Forms.Button();
            this.btnTemperatureConversion = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnLottoMax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(33, 457);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dash Board Applications";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Simple Calculator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lotto Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Temperature Conversion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Money Conversion";
            // 
            // btnMoneyConversion
            // 
            this.btnMoneyConversion.BackgroundImage = global::FinalProjectSummer16JulianaLinares.Properties.Resources.moneyConvert;
            this.btnMoneyConversion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoneyConversion.Location = new System.Drawing.Point(33, 264);
            this.btnMoneyConversion.Name = "btnMoneyConversion";
            this.btnMoneyConversion.Size = new System.Drawing.Size(152, 122);
            this.btnMoneyConversion.TabIndex = 3;
            this.btnMoneyConversion.UseVisualStyleBackColor = true;
            this.btnMoneyConversion.Click += new System.EventHandler(this.btnMoneyConversion_Click);
            // 
            // btnTemperatureConversion
            // 
            this.btnTemperatureConversion.BackgroundImage = global::FinalProjectSummer16JulianaLinares.Properties.Resources.tempConvert;
            this.btnTemperatureConversion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemperatureConversion.Location = new System.Drawing.Point(283, 121);
            this.btnTemperatureConversion.Name = "btnTemperatureConversion";
            this.btnTemperatureConversion.Size = new System.Drawing.Size(124, 100);
            this.btnTemperatureConversion.TabIndex = 2;
            this.btnTemperatureConversion.UseVisualStyleBackColor = true;
            this.btnTemperatureConversion.Click += new System.EventHandler(this.btnTemperatureConversion_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.BackgroundImage = global::FinalProjectSummer16JulianaLinares.Properties.Resources.Calc;
            this.btnCalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalculator.Location = new System.Drawing.Point(283, 264);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(138, 171);
            this.btnCalculator.TabIndex = 1;
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // btnLottoMax
            // 
            this.btnLottoMax.BackgroundImage = global::FinalProjectSummer16JulianaLinares.Properties.Resources.LottoMax;
            this.btnLottoMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLottoMax.Location = new System.Drawing.Point(33, 121);
            this.btnLottoMax.Name = "btnLottoMax";
            this.btnLottoMax.Size = new System.Drawing.Size(150, 100);
            this.btnLottoMax.TabIndex = 0;
            this.btnLottoMax.UseVisualStyleBackColor = true;
            this.btnLottoMax.Click += new System.EventHandler(this.btnLottoMax_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 492);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMoneyConversion);
            this.Controls.Add(this.btnTemperatureConversion);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.btnLottoMax);
            this.Name = "DashBoard";
            this.Text = "Dash Board";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLottoMax;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnTemperatureConversion;
        private System.Windows.Forms.Button btnMoneyConversion;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

