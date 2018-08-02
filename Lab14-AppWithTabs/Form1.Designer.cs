namespace Lab14_AppWithTabs
{
    partial class TabsWithCheckedListBoxes
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
            this.linksTabControl = new System.Windows.Forms.TabControl();
            this.includesTab = new System.Windows.Forms.TabPage();
            this.chkListBox = new System.Windows.Forms.CheckedListBox();
            this.lblIncludesTab = new System.Windows.Forms.Label();
            this.urlsTab = new System.Windows.Forms.TabPage();
            this.txtURL6 = new System.Windows.Forms.TextBox();
            this.txtURL5 = new System.Windows.Forms.TextBox();
            this.txtURL4 = new System.Windows.Forms.TextBox();
            this.txtURL3 = new System.Windows.Forms.TextBox();
            this.txtURL2 = new System.Windows.Forms.TextBox();
            this.txtURL1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnURL5 = new System.Windows.Forms.Button();
            this.btnURL4 = new System.Windows.Forms.Button();
            this.btnURL3 = new System.Windows.Forms.Button();
            this.btnURL2 = new System.Windows.Forms.Button();
            this.btnURL1 = new System.Windows.Forms.Button();
            this.lblURL6 = new System.Windows.Forms.Label();
            this.lblURL5 = new System.Windows.Forms.Label();
            this.lblURL4 = new System.Windows.Forms.Label();
            this.lblURL3 = new System.Windows.Forms.Label();
            this.lblURL2 = new System.Windows.Forms.Label();
            this.lblURL1 = new System.Windows.Forms.Label();
            this.linksTab = new System.Windows.Forms.TabPage();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linksTabControl.SuspendLayout();
            this.includesTab.SuspendLayout();
            this.urlsTab.SuspendLayout();
            this.linksTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // linksTabControl
            // 
            this.linksTabControl.Controls.Add(this.includesTab);
            this.linksTabControl.Controls.Add(this.urlsTab);
            this.linksTabControl.Controls.Add(this.linksTab);
            this.linksTabControl.Location = new System.Drawing.Point(12, 12);
            this.linksTabControl.Name = "linksTabControl";
            this.linksTabControl.SelectedIndex = 0;
            this.linksTabControl.Size = new System.Drawing.Size(534, 383);
            this.linksTabControl.TabIndex = 0;
            // 
            // includesTab
            // 
            this.includesTab.BackColor = System.Drawing.SystemColors.Control;
            this.includesTab.Controls.Add(this.chkListBox);
            this.includesTab.Controls.Add(this.lblIncludesTab);
            this.includesTab.Location = new System.Drawing.Point(4, 29);
            this.includesTab.Name = "includesTab";
            this.includesTab.Padding = new System.Windows.Forms.Padding(3);
            this.includesTab.Size = new System.Drawing.Size(526, 350);
            this.includesTab.TabIndex = 0;
            this.includesTab.Text = "Includes";
            // 
            // chkListBox
            // 
            this.chkListBox.CheckOnClick = true;
            this.chkListBox.FormattingEnabled = true;
            this.chkListBox.Items.AddRange(new object[] {
            "Link1",
            "Link2",
            "Link3",
            "Link4",
            "Link5",
            "Link6"});
            this.chkListBox.Location = new System.Drawing.Point(79, 125);
            this.chkListBox.Name = "chkListBox";
            this.chkListBox.Size = new System.Drawing.Size(347, 151);
            this.chkListBox.TabIndex = 1;
            this.chkListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkListBox_ItemCheck);
            // 
            // lblIncludesTab
            // 
            this.lblIncludesTab.AutoSize = true;
            this.lblIncludesTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncludesTab.Location = new System.Drawing.Point(84, 29);
            this.lblIncludesTab.Name = "lblIncludesTab";
            this.lblIncludesTab.Size = new System.Drawing.Size(306, 64);
            this.lblIncludesTab.TabIndex = 0;
            this.lblIncludesTab.Text = "Select which links you \r\nwant to appear in Links";
            // 
            // urlsTab
            // 
            this.urlsTab.BackColor = System.Drawing.SystemColors.Control;
            this.urlsTab.Controls.Add(this.txtURL6);
            this.urlsTab.Controls.Add(this.txtURL5);
            this.urlsTab.Controls.Add(this.txtURL4);
            this.urlsTab.Controls.Add(this.txtURL3);
            this.urlsTab.Controls.Add(this.txtURL2);
            this.urlsTab.Controls.Add(this.txtURL1);
            this.urlsTab.Controls.Add(this.button1);
            this.urlsTab.Controls.Add(this.btnURL5);
            this.urlsTab.Controls.Add(this.btnURL4);
            this.urlsTab.Controls.Add(this.btnURL3);
            this.urlsTab.Controls.Add(this.btnURL2);
            this.urlsTab.Controls.Add(this.btnURL1);
            this.urlsTab.Controls.Add(this.lblURL6);
            this.urlsTab.Controls.Add(this.lblURL5);
            this.urlsTab.Controls.Add(this.lblURL4);
            this.urlsTab.Controls.Add(this.lblURL3);
            this.urlsTab.Controls.Add(this.lblURL2);
            this.urlsTab.Controls.Add(this.lblURL1);
            this.urlsTab.Location = new System.Drawing.Point(4, 29);
            this.urlsTab.Name = "urlsTab";
            this.urlsTab.Padding = new System.Windows.Forms.Padding(3);
            this.urlsTab.Size = new System.Drawing.Size(526, 350);
            this.urlsTab.TabIndex = 1;
            this.urlsTab.Text = "URLs";
            // 
            // txtURL6
            // 
            this.txtURL6.Location = new System.Drawing.Point(62, 259);
            this.txtURL6.Name = "txtURL6";
            this.txtURL6.Size = new System.Drawing.Size(320, 26);
            this.txtURL6.TabIndex = 17;
            // 
            // txtURL5
            // 
            this.txtURL5.Location = new System.Drawing.Point(62, 216);
            this.txtURL5.Name = "txtURL5";
            this.txtURL5.Size = new System.Drawing.Size(320, 26);
            this.txtURL5.TabIndex = 16;
            // 
            // txtURL4
            // 
            this.txtURL4.Location = new System.Drawing.Point(62, 174);
            this.txtURL4.Name = "txtURL4";
            this.txtURL4.Size = new System.Drawing.Size(320, 26);
            this.txtURL4.TabIndex = 15;
            // 
            // txtURL3
            // 
            this.txtURL3.Location = new System.Drawing.Point(62, 133);
            this.txtURL3.Name = "txtURL3";
            this.txtURL3.Size = new System.Drawing.Size(320, 26);
            this.txtURL3.TabIndex = 14;
            // 
            // txtURL2
            // 
            this.txtURL2.Location = new System.Drawing.Point(62, 86);
            this.txtURL2.Name = "txtURL2";
            this.txtURL2.Size = new System.Drawing.Size(320, 26);
            this.txtURL2.TabIndex = 13;
            // 
            // txtURL1
            // 
            this.txtURL1.Location = new System.Drawing.Point(62, 43);
            this.txtURL1.Name = "txtURL1";
            this.txtURL1.Size = new System.Drawing.Size(320, 26);
            this.txtURL1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnURL5
            // 
            this.btnURL5.Location = new System.Drawing.Point(388, 216);
            this.btnURL5.Name = "btnURL5";
            this.btnURL5.Size = new System.Drawing.Size(111, 30);
            this.btnURL5.TabIndex = 10;
            this.btnURL5.Text = "Submit";
            this.btnURL5.UseVisualStyleBackColor = true;
            this.btnURL5.Click += new System.EventHandler(this.btnURL5_Click);
            // 
            // btnURL4
            // 
            this.btnURL4.Location = new System.Drawing.Point(388, 172);
            this.btnURL4.Name = "btnURL4";
            this.btnURL4.Size = new System.Drawing.Size(111, 30);
            this.btnURL4.TabIndex = 9;
            this.btnURL4.Text = "Submit";
            this.btnURL4.UseVisualStyleBackColor = true;
            this.btnURL4.Click += new System.EventHandler(this.btnURL4_Click);
            // 
            // btnURL3
            // 
            this.btnURL3.Location = new System.Drawing.Point(388, 131);
            this.btnURL3.Name = "btnURL3";
            this.btnURL3.Size = new System.Drawing.Size(111, 30);
            this.btnURL3.TabIndex = 8;
            this.btnURL3.Text = "Submit";
            this.btnURL3.UseVisualStyleBackColor = true;
            this.btnURL3.Click += new System.EventHandler(this.btnURL3_Click);
            // 
            // btnURL2
            // 
            this.btnURL2.Location = new System.Drawing.Point(388, 84);
            this.btnURL2.Name = "btnURL2";
            this.btnURL2.Size = new System.Drawing.Size(111, 30);
            this.btnURL2.TabIndex = 7;
            this.btnURL2.Text = "Submit";
            this.btnURL2.UseVisualStyleBackColor = true;
            this.btnURL2.Click += new System.EventHandler(this.btnURL2_Click);
            // 
            // btnURL1
            // 
            this.btnURL1.Location = new System.Drawing.Point(388, 41);
            this.btnURL1.Name = "btnURL1";
            this.btnURL1.Size = new System.Drawing.Size(111, 30);
            this.btnURL1.TabIndex = 6;
            this.btnURL1.Text = "Submit";
            this.btnURL1.UseVisualStyleBackColor = true;
            this.btnURL1.Click += new System.EventHandler(this.btnURL1_Click);
            // 
            // lblURL6
            // 
            this.lblURL6.AutoSize = true;
            this.lblURL6.Location = new System.Drawing.Point(34, 262);
            this.lblURL6.Name = "lblURL6";
            this.lblURL6.Size = new System.Drawing.Size(22, 20);
            this.lblURL6.TabIndex = 5;
            this.lblURL6.Text = "6.";
            // 
            // lblURL5
            // 
            this.lblURL5.AutoSize = true;
            this.lblURL5.Location = new System.Drawing.Point(34, 219);
            this.lblURL5.Name = "lblURL5";
            this.lblURL5.Size = new System.Drawing.Size(22, 20);
            this.lblURL5.TabIndex = 4;
            this.lblURL5.Text = "5.";
            // 
            // lblURL4
            // 
            this.lblURL4.AutoSize = true;
            this.lblURL4.Location = new System.Drawing.Point(34, 177);
            this.lblURL4.Name = "lblURL4";
            this.lblURL4.Size = new System.Drawing.Size(22, 20);
            this.lblURL4.TabIndex = 3;
            this.lblURL4.Text = "4.";
            // 
            // lblURL3
            // 
            this.lblURL3.AutoSize = true;
            this.lblURL3.Location = new System.Drawing.Point(34, 136);
            this.lblURL3.Name = "lblURL3";
            this.lblURL3.Size = new System.Drawing.Size(22, 20);
            this.lblURL3.TabIndex = 2;
            this.lblURL3.Text = "3.";
            // 
            // lblURL2
            // 
            this.lblURL2.AutoSize = true;
            this.lblURL2.Location = new System.Drawing.Point(34, 89);
            this.lblURL2.Name = "lblURL2";
            this.lblURL2.Size = new System.Drawing.Size(22, 20);
            this.lblURL2.TabIndex = 1;
            this.lblURL2.Text = "2.";
            // 
            // lblURL1
            // 
            this.lblURL1.AutoSize = true;
            this.lblURL1.Location = new System.Drawing.Point(34, 46);
            this.lblURL1.Name = "lblURL1";
            this.lblURL1.Size = new System.Drawing.Size(22, 20);
            this.lblURL1.TabIndex = 0;
            this.lblURL1.Text = "1.";
            // 
            // linksTab
            // 
            this.linksTab.BackColor = System.Drawing.SystemColors.Control;
            this.linksTab.Controls.Add(this.linkLabel6);
            this.linksTab.Controls.Add(this.linkLabel5);
            this.linksTab.Controls.Add(this.linkLabel4);
            this.linksTab.Controls.Add(this.linkLabel3);
            this.linksTab.Controls.Add(this.linkLabel2);
            this.linksTab.Controls.Add(this.linkLabel1);
            this.linksTab.Location = new System.Drawing.Point(4, 29);
            this.linksTab.Name = "linksTab";
            this.linksTab.Padding = new System.Windows.Forms.Padding(3);
            this.linksTab.Size = new System.Drawing.Size(526, 350);
            this.linksTab.TabIndex = 2;
            this.linksTab.Text = "Links";
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(75, 200);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(0, 20);
            this.linkLabel6.TabIndex = 5;
            this.linkLabel6.Visible = false;
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(75, 168);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(0, 20);
            this.linkLabel5.TabIndex = 4;
            this.linkLabel5.Visible = false;
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(75, 135);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(0, 20);
            this.linkLabel4.TabIndex = 3;
            this.linkLabel4.Visible = false;
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(75, 105);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(0, 20);
            this.linkLabel3.TabIndex = 2;
            this.linkLabel3.Visible = false;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(75, 71);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(0, 20);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.Visible = false;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(75, 42);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 20);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // TabsWithCheckedListBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 407);
            this.Controls.Add(this.linksTabControl);
            this.Name = "TabsWithCheckedListBoxes";
            this.Text = "Tabs with CheckedListBoxes";
            this.linksTabControl.ResumeLayout(false);
            this.includesTab.ResumeLayout(false);
            this.includesTab.PerformLayout();
            this.urlsTab.ResumeLayout(false);
            this.urlsTab.PerformLayout();
            this.linksTab.ResumeLayout(false);
            this.linksTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl linksTabControl;
        private System.Windows.Forms.TabPage includesTab;
        private System.Windows.Forms.TabPage urlsTab;
        private System.Windows.Forms.TabPage linksTab;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckedListBox chkListBox;
        private System.Windows.Forms.Label lblIncludesTab;
        private System.Windows.Forms.TextBox txtURL6;
        private System.Windows.Forms.TextBox txtURL5;
        private System.Windows.Forms.TextBox txtURL4;
        private System.Windows.Forms.TextBox txtURL3;
        private System.Windows.Forms.TextBox txtURL2;
        private System.Windows.Forms.TextBox txtURL1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnURL5;
        private System.Windows.Forms.Button btnURL4;
        private System.Windows.Forms.Button btnURL3;
        private System.Windows.Forms.Button btnURL2;
        private System.Windows.Forms.Button btnURL1;
        private System.Windows.Forms.Label lblURL6;
        private System.Windows.Forms.Label lblURL5;
        private System.Windows.Forms.Label lblURL4;
        private System.Windows.Forms.Label lblURL3;
        private System.Windows.Forms.Label lblURL2;
        private System.Windows.Forms.Label lblURL1;
    }
}

