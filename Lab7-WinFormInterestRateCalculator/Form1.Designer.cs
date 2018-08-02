namespace Lab7_WinFormInterestRateCalculator
{
    partial class frmInterestCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInterestCalculator));
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtPrincipleAmount = new System.Windows.Forms.TextBox();
            this.lblPrincipalAmount = new System.Windows.Forms.Label();
            this.nudInterestRate = new System.Windows.Forms.NumericUpDown();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblYears = new System.Windows.Forms.Label();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(266, 14);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(103, 31);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtPrincipleAmount
            // 
            this.txtPrincipleAmount.Location = new System.Drawing.Point(142, 20);
            this.txtPrincipleAmount.Name = "txtPrincipleAmount";
            this.txtPrincipleAmount.Size = new System.Drawing.Size(116, 23);
            this.txtPrincipleAmount.TabIndex = 1;
            // 
            // lblPrincipalAmount
            // 
            this.lblPrincipalAmount.Location = new System.Drawing.Point(64, 20);
            this.lblPrincipalAmount.Name = "lblPrincipalAmount";
            this.lblPrincipalAmount.Size = new System.Drawing.Size(71, 23);
            this.lblPrincipalAmount.TabIndex = 2;
            this.lblPrincipalAmount.Text = "Principal:";
            this.lblPrincipalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudInterestRate
            // 
            this.nudInterestRate.Location = new System.Drawing.Point(142, 50);
            this.nudInterestRate.Name = "nudInterestRate";
            this.nudInterestRate.Size = new System.Drawing.Size(117, 23);
            this.nudInterestRate.TabIndex = 3;
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.Location = new System.Drawing.Point(42, 50);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(93, 23);
            this.lblInterestRate.TabIndex = 4;
            this.lblInterestRate.Text = "Interest Rate:";
            this.lblInterestRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(267, 50);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 33);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblYears
            // 
            this.lblYears.Location = new System.Drawing.Point(42, 73);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(93, 27);
            this.lblYears.TabIndex = 6;
            this.lblYears.Text = "Year:";
            this.lblYears.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(142, 80);
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(117, 23);
            this.nudYear.TabIndex = 7;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(42, 118);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(131, 15);
            this.lblDisplay.TabIndex = 8;
            this.lblDisplay.Text = "Yearly account balance:";
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(45, 136);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisplay.Size = new System.Drawing.Size(322, 134);
            this.txtDisplay.TabIndex = 9;
            // 
            // frmInterestCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 313);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.nudInterestRate);
            this.Controls.Add(this.lblPrincipalAmount);
            this.Controls.Add(this.txtPrincipleAmount);
            this.Controls.Add(this.btnCalculate);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInterestCalculator";
            this.Text = "Interest Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.nudInterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtPrincipleAmount;
        private System.Windows.Forms.Label lblPrincipalAmount;
        private System.Windows.Forms.NumericUpDown nudInterestRate;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.TextBox txtDisplay;
    }
}

