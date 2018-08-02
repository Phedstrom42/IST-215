namespace Lab10_Drawing_Panel
{
    partial class DrawingPanel
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
            this.gpColor = new System.Windows.Forms.GroupBox();
            this.rbColorBlack = new System.Windows.Forms.RadioButton();
            this.rbColorGreen = new System.Windows.Forms.RadioButton();
            this.rbColorBlue = new System.Windows.Forms.RadioButton();
            this.rdColorRed = new System.Windows.Forms.RadioButton();
            this.gpSize = new System.Windows.Forms.GroupBox();
            this.rbSizeLarge = new System.Windows.Forms.RadioButton();
            this.rbSizeMedium = new System.Windows.Forms.RadioButton();
            this.rbSizeSmall = new System.Windows.Forms.RadioButton();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.gpColor.SuspendLayout();
            this.gpSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpColor
            // 
            this.gpColor.Controls.Add(this.rbColorBlack);
            this.gpColor.Controls.Add(this.rbColorGreen);
            this.gpColor.Controls.Add(this.rbColorBlue);
            this.gpColor.Controls.Add(this.rdColorRed);
            this.gpColor.Location = new System.Drawing.Point(17, 12);
            this.gpColor.Name = "gpColor";
            this.gpColor.Size = new System.Drawing.Size(117, 170);
            this.gpColor.TabIndex = 0;
            this.gpColor.TabStop = false;
            this.gpColor.Text = "Color";
            // 
            // rbColorBlack
            // 
            this.rbColorBlack.Checked = true;
            this.rbColorBlack.Location = new System.Drawing.Point(21, 115);
            this.rbColorBlack.Name = "rbColorBlack";
            this.rbColorBlack.Size = new System.Drawing.Size(73, 24);
            this.rbColorBlack.TabIndex = 3;
            this.rbColorBlack.TabStop = true;
            this.rbColorBlack.Text = "Black";
            this.rbColorBlack.UseVisualStyleBackColor = true;
            this.rbColorBlack.CheckedChanged += new System.EventHandler(this.paintColor_CheckedChanged);
            // 
            // rbColorGreen
            // 
            this.rbColorGreen.AutoSize = true;
            this.rbColorGreen.Location = new System.Drawing.Point(21, 85);
            this.rbColorGreen.Name = "rbColorGreen";
            this.rbColorGreen.Size = new System.Drawing.Size(79, 24);
            this.rbColorGreen.TabIndex = 2;
            this.rbColorGreen.TabStop = true;
            this.rbColorGreen.Text = "Green";
            this.rbColorGreen.UseVisualStyleBackColor = true;
            this.rbColorGreen.CheckedChanged += new System.EventHandler(this.paintColor_CheckedChanged);
            // 
            // rbColorBlue
            // 
            this.rbColorBlue.AutoSize = true;
            this.rbColorBlue.Location = new System.Drawing.Point(21, 55);
            this.rbColorBlue.Name = "rbColorBlue";
            this.rbColorBlue.Size = new System.Drawing.Size(66, 24);
            this.rbColorBlue.TabIndex = 1;
            this.rbColorBlue.TabStop = true;
            this.rbColorBlue.Text = "Blue";
            this.rbColorBlue.UseVisualStyleBackColor = true;
            this.rbColorBlue.CheckedChanged += new System.EventHandler(this.paintColor_CheckedChanged);
            // 
            // rdColorRed
            // 
            this.rdColorRed.AutoSize = true;
            this.rdColorRed.Location = new System.Drawing.Point(21, 25);
            this.rdColorRed.Name = "rdColorRed";
            this.rdColorRed.Size = new System.Drawing.Size(64, 24);
            this.rdColorRed.TabIndex = 0;
            this.rdColorRed.TabStop = true;
            this.rdColorRed.Text = "Red";
            this.rdColorRed.UseVisualStyleBackColor = true;
            this.rdColorRed.CheckedChanged += new System.EventHandler(this.paintColor_CheckedChanged);
            // 
            // gpSize
            // 
            this.gpSize.Controls.Add(this.rbSizeLarge);
            this.gpSize.Controls.Add(this.rbSizeMedium);
            this.gpSize.Controls.Add(this.rbSizeSmall);
            this.gpSize.Location = new System.Drawing.Point(17, 185);
            this.gpSize.Name = "gpSize";
            this.gpSize.Size = new System.Drawing.Size(117, 120);
            this.gpSize.TabIndex = 1;
            this.gpSize.TabStop = false;
            this.gpSize.Text = "size";
            // 
            // rbSizeLarge
            // 
            this.rbSizeLarge.AutoSize = true;
            this.rbSizeLarge.Location = new System.Drawing.Point(21, 85);
            this.rbSizeLarge.Name = "rbSizeLarge";
            this.rbSizeLarge.Size = new System.Drawing.Size(75, 24);
            this.rbSizeLarge.TabIndex = 3;
            this.rbSizeLarge.TabStop = true;
            this.rbSizeLarge.Text = "Large";
            this.rbSizeLarge.UseVisualStyleBackColor = true;
            this.rbSizeLarge.CheckedChanged += new System.EventHandler(this.brushSize_CheckedChanged);
            // 
            // rbSizeMedium
            // 
            this.rbSizeMedium.AutoSize = true;
            this.rbSizeMedium.Checked = true;
            this.rbSizeMedium.Location = new System.Drawing.Point(21, 55);
            this.rbSizeMedium.Name = "rbSizeMedium";
            this.rbSizeMedium.Size = new System.Drawing.Size(90, 24);
            this.rbSizeMedium.TabIndex = 2;
            this.rbSizeMedium.TabStop = true;
            this.rbSizeMedium.Text = "Medium";
            this.rbSizeMedium.UseVisualStyleBackColor = true;
            this.rbSizeMedium.CheckedChanged += new System.EventHandler(this.brushSize_CheckedChanged);
            // 
            // rbSizeSmall
            // 
            this.rbSizeSmall.AutoSize = true;
            this.rbSizeSmall.Location = new System.Drawing.Point(21, 25);
            this.rbSizeSmall.Name = "rbSizeSmall";
            this.rbSizeSmall.Size = new System.Drawing.Size(73, 24);
            this.rbSizeSmall.TabIndex = 1;
            this.rbSizeSmall.TabStop = true;
            this.rbSizeSmall.Text = "Small";
            this.rbSizeSmall.UseVisualStyleBackColor = true;
            this.rbSizeSmall.CheckedChanged += new System.EventHandler(this.brushSize_CheckedChanged);
            // 
            // panelCanvas
            // 
            this.panelCanvas.BackColor = System.Drawing.Color.White;
            this.panelCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCanvas.Location = new System.Drawing.Point(160, 12);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(414, 338);
            this.panelCanvas.TabIndex = 2;
            this.panelCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseDown);
            this.panelCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseMove);
            this.panelCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseUp);
            // 
            // DrawingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 371);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.gpSize);
            this.Controls.Add(this.gpColor);
            this.Name = "DrawingPanel";
            this.Text = "Drawing Panel";
            this.gpColor.ResumeLayout(false);
            this.gpColor.PerformLayout();
            this.gpSize.ResumeLayout(false);
            this.gpSize.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpColor;
        private System.Windows.Forms.RadioButton rbColorBlack;
        private System.Windows.Forms.RadioButton rbColorGreen;
        private System.Windows.Forms.RadioButton rbColorBlue;
        private System.Windows.Forms.RadioButton rdColorRed;
        private System.Windows.Forms.GroupBox gpSize;
        private System.Windows.Forms.RadioButton rbSizeLarge;
        private System.Windows.Forms.RadioButton rbSizeMedium;
        private System.Windows.Forms.RadioButton rbSizeSmall;
        private System.Windows.Forms.Panel panelCanvas;
    }
}

