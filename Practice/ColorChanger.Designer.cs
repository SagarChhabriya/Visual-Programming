namespace Practice
{
    partial class ColorChanger
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.colorChangerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureChangerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Change It";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorChangerToolStripMenuItem,
            this.groupBoxToolStripMenuItem,
            this.timerToolStripMenuItem,
            this.pictureChangerToolStripMenuItem,
            this.dateTimePickerToolStripMenuItem,
            this.fileDialogToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // colorChangerToolStripMenuItem
            // 
            this.colorChangerToolStripMenuItem.Name = "colorChangerToolStripMenuItem";
            this.colorChangerToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.colorChangerToolStripMenuItem.Text = "Color Changer";
            this.colorChangerToolStripMenuItem.Click += new System.EventHandler(this.colorChangerToolStripMenuItem_Click);
            // 
            // groupBoxToolStripMenuItem
            // 
            this.groupBoxToolStripMenuItem.Name = "groupBoxToolStripMenuItem";
            this.groupBoxToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.groupBoxToolStripMenuItem.Text = "Group Box";
            this.groupBoxToolStripMenuItem.Click += new System.EventHandler(this.groupBoxToolStripMenuItem_Click);
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.timerToolStripMenuItem.Text = "Timer";
            this.timerToolStripMenuItem.Click += new System.EventHandler(this.timerToolStripMenuItem_Click);
            // 
            // pictureChangerToolStripMenuItem
            // 
            this.pictureChangerToolStripMenuItem.Name = "pictureChangerToolStripMenuItem";
            this.pictureChangerToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.pictureChangerToolStripMenuItem.Text = "Picture Changer";
            this.pictureChangerToolStripMenuItem.Click += new System.EventHandler(this.pictureChangerToolStripMenuItem_Click);
            // 
            // dateTimePickerToolStripMenuItem
            // 
            this.dateTimePickerToolStripMenuItem.Name = "dateTimePickerToolStripMenuItem";
            this.dateTimePickerToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.dateTimePickerToolStripMenuItem.Text = "Date Time Picker";
            this.dateTimePickerToolStripMenuItem.Click += new System.EventHandler(this.dateTimePickerToolStripMenuItem_Click);
            // 
            // fileDialogToolStripMenuItem
            // 
            this.fileDialogToolStripMenuItem.Name = "fileDialogToolStripMenuItem";
            this.fileDialogToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.fileDialogToolStripMenuItem.Text = "File Dialog";
            this.fileDialogToolStripMenuItem.Click += new System.EventHandler(this.fileDialogToolStripMenuItem_Click);
            // 
            // ColorChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Name = "ColorChanger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorChanger";
            this.Load += new System.EventHandler(this.ColorChanger_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem colorChangerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pictureChangerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateTimePickerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileDialogToolStripMenuItem;
    }
}