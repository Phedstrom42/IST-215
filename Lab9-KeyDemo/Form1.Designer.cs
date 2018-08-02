namespace Lab9_KeyDemo
{
    partial class KeyDemo
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
            this.lblKeyPressed = new System.Windows.Forms.Label();
            this.rtxtKeyInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblKeyPressed
            // 
            this.lblKeyPressed.Location = new System.Drawing.Point(26, 25);
            this.lblKeyPressed.Name = "lblKeyPressed";
            this.lblKeyPressed.Size = new System.Drawing.Size(218, 26);
            this.lblKeyPressed.TabIndex = 0;
            // 
            // rtxtKeyInfo
            // 
            this.rtxtKeyInfo.Enabled = false;
            this.rtxtKeyInfo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.rtxtKeyInfo.Location = new System.Drawing.Point(30, 83);
            this.rtxtKeyInfo.Name = "rtxtKeyInfo";
            this.rtxtKeyInfo.ReadOnly = true;
            this.rtxtKeyInfo.Size = new System.Drawing.Size(280, 247);
            this.rtxtKeyInfo.TabIndex = 1;
            this.rtxtKeyInfo.Text = "";
            // 
            // KeyDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 374);
            this.Controls.Add(this.rtxtKeyInfo);
            this.Controls.Add(this.lblKeyPressed);
            this.KeyPreview = true;
            this.Name = "KeyDemo";
            this.Text = "Key Demo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDemo_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyDemo_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblKeyPressed;
        private System.Windows.Forms.RichTextBox rtxtKeyInfo;
    }
}

