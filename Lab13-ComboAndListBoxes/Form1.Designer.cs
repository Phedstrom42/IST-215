namespace Lab13_ComboAndListBoxes
{
    partial class StatesForm
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
            this.components = new System.ComponentModel.Container();
            this.lblSelectState = new System.Windows.Forms.Label();
            this.statesComboBox = new System.Windows.Forms.ComboBox();
            this.stateListBox = new System.Windows.Forms.ListBox();
            this.lblState = new System.Windows.Forms.Label();
            this.picBoxStateFlag = new System.Windows.Forms.PictureBox();
            this.popupMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.putBackToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStateFlag)).BeginInit();
            this.popupMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectState
            // 
            this.lblSelectState.AutoSize = true;
            this.lblSelectState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectState.Location = new System.Drawing.Point(39, 46);
            this.lblSelectState.Name = "lblSelectState";
            this.lblSelectState.Size = new System.Drawing.Size(146, 28);
            this.lblSelectState.TabIndex = 0;
            this.lblSelectState.Text = "Select a State:";
            // 
            // statesComboBox
            // 
            this.statesComboBox.FormattingEnabled = true;
            this.statesComboBox.Location = new System.Drawing.Point(44, 89);
            this.statesComboBox.Name = "statesComboBox";
            this.statesComboBox.Size = new System.Drawing.Size(208, 28);
            this.statesComboBox.TabIndex = 1;
            this.statesComboBox.SelectedIndexChanged += new System.EventHandler(this.statesComboBox_SelectedIndexChanged);
            // 
            // stateListBox
            // 
            this.stateListBox.ContextMenuStrip = this.popupMenu;
            this.stateListBox.FormattingEnabled = true;
            this.stateListBox.ItemHeight = 20;
            this.stateListBox.Location = new System.Drawing.Point(44, 136);
            this.stateListBox.Name = "stateListBox";
            this.stateListBox.Size = new System.Drawing.Size(208, 224);
            this.stateListBox.TabIndex = 2;
            this.stateListBox.SelectedIndexChanged += new System.EventHandler(this.stateListBox_SelectedIndexChanged);
            this.stateListBox.DoubleClick += new System.EventHandler(this.stateListBox_DoubleClick);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(287, 96);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(0, 28);
            this.lblState.TabIndex = 3;
            // 
            // picBoxStateFlag
            // 
            this.picBoxStateFlag.Location = new System.Drawing.Point(292, 136);
            this.picBoxStateFlag.Name = "picBoxStateFlag";
            this.picBoxStateFlag.Size = new System.Drawing.Size(189, 139);
            this.picBoxStateFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxStateFlag.TabIndex = 4;
            this.picBoxStateFlag.TabStop = false;
            // 
            // popupMenu
            // 
            this.popupMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.popupMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.putBackToolToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.popupMenu.Name = "popupMenu";
            this.popupMenu.Size = new System.Drawing.Size(152, 64);
            // 
            // putBackToolToolStripMenuItem
            // 
            this.putBackToolToolStripMenuItem.Name = "putBackToolToolStripMenuItem";
            this.putBackToolToolStripMenuItem.Size = new System.Drawing.Size(151, 30);
            this.putBackToolToolStripMenuItem.Text = "Put Back";
            this.putBackToolToolStripMenuItem.Click += new System.EventHandler(this.putBackToolToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(151, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // StatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 440);
            this.Controls.Add(this.picBoxStateFlag);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.stateListBox);
            this.Controls.Add(this.statesComboBox);
            this.Controls.Add(this.lblSelectState);
            this.Name = "StatesForm";
            this.Text = "States";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStateFlag)).EndInit();
            this.popupMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectState;
        private System.Windows.Forms.ComboBox statesComboBox;
        private System.Windows.Forms.ListBox stateListBox;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.PictureBox picBoxStateFlag;
        private System.Windows.Forms.ContextMenuStrip popupMenu;
        private System.Windows.Forms.ToolStripMenuItem putBackToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

