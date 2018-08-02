namespace Lab8_ResturantBillCalculator
{
    partial class RestaurantBillCalculator
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbMenuItem = new System.Windows.Forms.GroupBox();
            this.cbDessert = new System.Windows.Forms.ComboBox();
            this.cbMainCourse = new System.Windows.Forms.ComboBox();
            this.cbAppetizer = new System.Windows.Forms.ComboBox();
            this.lblDessert = new System.Windows.Forms.Label();
            this.lblMainCourse = new System.Windows.Forms.Label();
            this.lblAppetizer = new System.Windows.Forms.Label();
            this.cbBeverage = new System.Windows.Forms.ComboBox();
            this.lblBeverage = new System.Windows.Forms.Label();
            this.gbWaiterInformation = new System.Windows.Forms.GroupBox();
            this.txtTableNumber = new System.Windows.Forms.TextBox();
            this.lblWaitersName = new System.Windows.Forms.Label();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.cbWaitersName = new System.Windows.Forms.ComboBox();
            this.txtItemOutput = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.llblTip = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txtSubtotalValue = new System.Windows.Forms.TextBox();
            this.txtTaxValue = new System.Windows.Forms.TextBox();
            this.txtTipValue = new System.Windows.Forms.TextBox();
            this.txtTotalValue = new System.Windows.Forms.TextBox();
            this.nubTipPercent = new System.Windows.Forms.NumericUpDown();
            this.btnTotalBill = new System.Windows.Forms.Button();
            this.btnClearBill = new System.Windows.Forms.Button();
            this.gbMenuItem.SuspendLayout();
            this.gbWaiterInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nubTipPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(145, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(389, 59);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Roadside Restaurant";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbMenuItem
            // 
            this.gbMenuItem.Controls.Add(this.cbDessert);
            this.gbMenuItem.Controls.Add(this.cbMainCourse);
            this.gbMenuItem.Controls.Add(this.cbAppetizer);
            this.gbMenuItem.Controls.Add(this.lblDessert);
            this.gbMenuItem.Controls.Add(this.lblMainCourse);
            this.gbMenuItem.Controls.Add(this.lblAppetizer);
            this.gbMenuItem.Controls.Add(this.cbBeverage);
            this.gbMenuItem.Controls.Add(this.lblBeverage);
            this.gbMenuItem.Location = new System.Drawing.Point(25, 98);
            this.gbMenuItem.Name = "gbMenuItem";
            this.gbMenuItem.Size = new System.Drawing.Size(305, 205);
            this.gbMenuItem.TabIndex = 1;
            this.gbMenuItem.TabStop = false;
            this.gbMenuItem.Text = "Menu Items";
            // 
            // cbDessert
            // 
            this.cbDessert.FormattingEnabled = true;
            this.cbDessert.Location = new System.Drawing.Point(127, 154);
            this.cbDessert.Name = "cbDessert";
            this.cbDessert.Size = new System.Drawing.Size(152, 28);
            this.cbDessert.TabIndex = 7;
            this.cbDessert.SelectedIndexChanged += new System.EventHandler(this.cbDessert_SelectedIndexChanged);
            // 
            // cbMainCourse
            // 
            this.cbMainCourse.FormattingEnabled = true;
            this.cbMainCourse.Location = new System.Drawing.Point(127, 113);
            this.cbMainCourse.Name = "cbMainCourse";
            this.cbMainCourse.Size = new System.Drawing.Size(152, 28);
            this.cbMainCourse.TabIndex = 6;
            this.cbMainCourse.SelectedIndexChanged += new System.EventHandler(this.cbMainCourse_SelectedIndexChanged);
            // 
            // cbAppetizer
            // 
            this.cbAppetizer.FormattingEnabled = true;
            this.cbAppetizer.Location = new System.Drawing.Point(127, 76);
            this.cbAppetizer.Name = "cbAppetizer";
            this.cbAppetizer.Size = new System.Drawing.Size(152, 28);
            this.cbAppetizer.TabIndex = 5;
            this.cbAppetizer.SelectedIndexChanged += new System.EventHandler(this.cbAppetizer_SelectedIndexChanged);
            // 
            // lblDessert
            // 
            this.lblDessert.AutoSize = true;
            this.lblDessert.Location = new System.Drawing.Point(39, 157);
            this.lblDessert.Name = "lblDessert";
            this.lblDessert.Size = new System.Drawing.Size(69, 20);
            this.lblDessert.TabIndex = 4;
            this.lblDessert.Text = "Dessert:";
            this.lblDessert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMainCourse
            // 
            this.lblMainCourse.AutoSize = true;
            this.lblMainCourse.Location = new System.Drawing.Point(9, 116);
            this.lblMainCourse.Name = "lblMainCourse";
            this.lblMainCourse.Size = new System.Drawing.Size(99, 20);
            this.lblMainCourse.TabIndex = 3;
            this.lblMainCourse.Text = "Main course:";
            this.lblMainCourse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAppetizer
            // 
            this.lblAppetizer.AutoSize = true;
            this.lblAppetizer.Location = new System.Drawing.Point(27, 79);
            this.lblAppetizer.Name = "lblAppetizer";
            this.lblAppetizer.Size = new System.Drawing.Size(81, 20);
            this.lblAppetizer.TabIndex = 2;
            this.lblAppetizer.Text = "Appetizer:";
            this.lblAppetizer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbBeverage
            // 
            this.cbBeverage.FormattingEnabled = true;
            this.cbBeverage.Location = new System.Drawing.Point(127, 33);
            this.cbBeverage.Name = "cbBeverage";
            this.cbBeverage.Size = new System.Drawing.Size(152, 28);
            this.cbBeverage.TabIndex = 1;
            this.cbBeverage.SelectedIndexChanged += new System.EventHandler(this.cbBeverage_SelectedIndexChanged);
            // 
            // lblBeverage
            // 
            this.lblBeverage.AutoSize = true;
            this.lblBeverage.Location = new System.Drawing.Point(27, 36);
            this.lblBeverage.Name = "lblBeverage";
            this.lblBeverage.Size = new System.Drawing.Size(85, 20);
            this.lblBeverage.TabIndex = 0;
            this.lblBeverage.Text = "&Beverage: ";
            this.lblBeverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbWaiterInformation
            // 
            this.gbWaiterInformation.Controls.Add(this.txtTableNumber);
            this.gbWaiterInformation.Controls.Add(this.lblWaitersName);
            this.gbWaiterInformation.Controls.Add(this.lblTableNumber);
            this.gbWaiterInformation.Controls.Add(this.cbWaitersName);
            this.gbWaiterInformation.Location = new System.Drawing.Point(358, 98);
            this.gbWaiterInformation.Name = "gbWaiterInformation";
            this.gbWaiterInformation.Size = new System.Drawing.Size(307, 105);
            this.gbWaiterInformation.TabIndex = 2;
            this.gbWaiterInformation.TabStop = false;
            this.gbWaiterInformation.Text = "Waiter Information";
            // 
            // txtTableNumber
            // 
            this.txtTableNumber.Location = new System.Drawing.Point(144, 26);
            this.txtTableNumber.Name = "txtTableNumber";
            this.txtTableNumber.Size = new System.Drawing.Size(100, 26);
            this.txtTableNumber.TabIndex = 9;
            this.txtTableNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWaitersName
            // 
            this.lblWaitersName.AutoSize = true;
            this.lblWaitersName.Location = new System.Drawing.Point(24, 65);
            this.lblWaitersName.Name = "lblWaitersName";
            this.lblWaitersName.Size = new System.Drawing.Size(114, 20);
            this.lblWaitersName.TabIndex = 8;
            this.lblWaitersName.Text = "Waiter\'s name:";
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Location = new System.Drawing.Point(28, 33);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(110, 20);
            this.lblTableNumber.TabIndex = 7;
            this.lblTableNumber.Text = "Table number:";
            this.lblTableNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbWaitersName
            // 
            this.cbWaitersName.FormattingEnabled = true;
            this.cbWaitersName.Location = new System.Drawing.Point(144, 62);
            this.cbWaitersName.Name = "cbWaitersName";
            this.cbWaitersName.Size = new System.Drawing.Size(152, 28);
            this.cbWaitersName.TabIndex = 6;
            // 
            // txtItemOutput
            // 
            this.txtItemOutput.Location = new System.Drawing.Point(25, 318);
            this.txtItemOutput.Multiline = true;
            this.txtItemOutput.Name = "txtItemOutput";
            this.txtItemOutput.Size = new System.Drawing.Size(305, 252);
            this.txtItemOutput.TabIndex = 3;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(386, 343);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(73, 20);
            this.lblSubtotal.TabIndex = 5;
            this.lblSubtotal.Text = "Subtotal:";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(417, 376);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(38, 20);
            this.lblTax.TabIndex = 6;
            this.lblTax.Text = "Tax:";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // llblTip
            // 
            this.llblTip.AutoSize = true;
            this.llblTip.Location = new System.Drawing.Point(421, 409);
            this.llblTip.Name = "llblTip";
            this.llblTip.Size = new System.Drawing.Size(34, 20);
            this.llblTip.TabIndex = 7;
            this.llblTip.Text = "Tip:";
            this.llblTip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(407, 447);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(48, 20);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "Total:";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSubtotalValue
            // 
            this.txtSubtotalValue.Location = new System.Drawing.Point(465, 343);
            this.txtSubtotalValue.Name = "txtSubtotalValue";
            this.txtSubtotalValue.ReadOnly = true;
            this.txtSubtotalValue.Size = new System.Drawing.Size(100, 26);
            this.txtSubtotalValue.TabIndex = 9;
            // 
            // txtTaxValue
            // 
            this.txtTaxValue.Location = new System.Drawing.Point(465, 376);
            this.txtTaxValue.Name = "txtTaxValue";
            this.txtTaxValue.ReadOnly = true;
            this.txtTaxValue.Size = new System.Drawing.Size(100, 26);
            this.txtTaxValue.TabIndex = 10;
            // 
            // txtTipValue
            // 
            this.txtTipValue.Location = new System.Drawing.Point(465, 409);
            this.txtTipValue.Name = "txtTipValue";
            this.txtTipValue.ReadOnly = true;
            this.txtTipValue.Size = new System.Drawing.Size(100, 26);
            this.txtTipValue.TabIndex = 11;
            // 
            // txtTotalValue
            // 
            this.txtTotalValue.Location = new System.Drawing.Point(465, 441);
            this.txtTotalValue.Name = "txtTotalValue";
            this.txtTotalValue.ReadOnly = true;
            this.txtTotalValue.Size = new System.Drawing.Size(100, 26);
            this.txtTotalValue.TabIndex = 12;
            // 
            // nubTipPercent
            // 
            this.nubTipPercent.Location = new System.Drawing.Point(572, 408);
            this.nubTipPercent.Name = "nubTipPercent";
            this.nubTipPercent.Size = new System.Drawing.Size(60, 26);
            this.nubTipPercent.TabIndex = 13;
            this.nubTipPercent.ValueChanged += new System.EventHandler(this.nubTipPercent_ValueChanged);
            // 
            // btnTotalBill
            // 
            this.btnTotalBill.Location = new System.Drawing.Point(527, 493);
            this.btnTotalBill.Name = "btnTotalBill";
            this.btnTotalBill.Size = new System.Drawing.Size(105, 30);
            this.btnTotalBill.TabIndex = 14;
            this.btnTotalBill.Text = "Total Bill";
            this.btnTotalBill.UseVisualStyleBackColor = true;
            // 
            // btnClearBill
            // 
            this.btnClearBill.Location = new System.Drawing.Point(391, 493);
            this.btnClearBill.Name = "btnClearBill";
            this.btnClearBill.Size = new System.Drawing.Size(105, 30);
            this.btnClearBill.TabIndex = 15;
            this.btnClearBill.Text = "Clear Bill";
            this.btnClearBill.UseVisualStyleBackColor = true;
            this.btnClearBill.Click += new System.EventHandler(this.btnClearBill_Click);
            // 
            // RestaurantBillCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 596);
            this.Controls.Add(this.btnClearBill);
            this.Controls.Add(this.btnTotalBill);
            this.Controls.Add(this.nubTipPercent);
            this.Controls.Add(this.txtTotalValue);
            this.Controls.Add(this.txtTipValue);
            this.Controls.Add(this.txtTaxValue);
            this.Controls.Add(this.txtSubtotalValue);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.llblTip);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.txtItemOutput);
            this.Controls.Add(this.gbWaiterInformation);
            this.Controls.Add(this.gbMenuItem);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RestaurantBillCalculator";
            this.Text = "Restaurant Bill Calculator";
            this.Load += new System.EventHandler(this.RestaurantBillCalculator_Load);
            this.gbMenuItem.ResumeLayout(false);
            this.gbMenuItem.PerformLayout();
            this.gbWaiterInformation.ResumeLayout(false);
            this.gbWaiterInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nubTipPercent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbMenuItem;
        private System.Windows.Forms.Label lblMainCourse;
        private System.Windows.Forms.Label lblAppetizer;
        private System.Windows.Forms.ComboBox cbBeverage;
        private System.Windows.Forms.Label lblBeverage;
        private System.Windows.Forms.ComboBox cbDessert;
        private System.Windows.Forms.ComboBox cbMainCourse;
        private System.Windows.Forms.ComboBox cbAppetizer;
        private System.Windows.Forms.Label lblDessert;
        private System.Windows.Forms.GroupBox gbWaiterInformation;
        private System.Windows.Forms.TextBox txtTableNumber;
        private System.Windows.Forms.Label lblWaitersName;
        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.ComboBox cbWaitersName;
        private System.Windows.Forms.TextBox txtItemOutput;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label llblTip;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtSubtotalValue;
        private System.Windows.Forms.TextBox txtTaxValue;
        private System.Windows.Forms.TextBox txtTipValue;
        private System.Windows.Forms.TextBox txtTotalValue;
        private System.Windows.Forms.NumericUpDown nubTipPercent;
        private System.Windows.Forms.Button btnTotalBill;
        private System.Windows.Forms.Button btnClearBill;
    }
}

