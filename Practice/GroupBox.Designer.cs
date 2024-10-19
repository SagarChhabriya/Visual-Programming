namespace Practice
{
    partial class GroupBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.cmsTextBox = new System.Windows.Forms.TextBox();
            this.genderGroupBox = new System.Windows.Forms.GroupBox();
            this.gmailRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.colorChangerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureChangerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CMS";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(183, 96);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // cmsTextBox
            // 
            this.cmsTextBox.Location = new System.Drawing.Point(183, 161);
            this.cmsTextBox.Name = "cmsTextBox";
            this.cmsTextBox.Size = new System.Drawing.Size(100, 20);
            this.cmsTextBox.TabIndex = 3;
            // 
            // genderGroupBox
            // 
            this.genderGroupBox.Controls.Add(this.gmailRadioButton);
            this.genderGroupBox.Controls.Add(this.femaleRadioButton);
            this.genderGroupBox.Controls.Add(this.maleRadioButton);
            this.genderGroupBox.Location = new System.Drawing.Point(124, 239);
            this.genderGroupBox.Name = "genderGroupBox";
            this.genderGroupBox.Size = new System.Drawing.Size(159, 100);
            this.genderGroupBox.TabIndex = 4;
            this.genderGroupBox.TabStop = false;
            this.genderGroupBox.Text = "Gender";
            // 
            // gmailRadioButton
            // 
            this.gmailRadioButton.AutoSize = true;
            this.gmailRadioButton.Location = new System.Drawing.Point(17, 65);
            this.gmailRadioButton.Name = "gmailRadioButton";
            this.gmailRadioButton.Size = new System.Drawing.Size(51, 17);
            this.gmailRadioButton.TabIndex = 7;
            this.gmailRadioButton.TabStop = true;
            this.gmailRadioButton.Text = "Gmail";
            this.gmailRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(17, 42);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.femaleRadioButton.TabIndex = 6;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(17, 19);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.maleRadioButton.TabIndex = 5;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(394, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(334, 150);
            this.dataGridView1.TabIndex = 7;
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
            this.menuStrip1.TabIndex = 8;
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
            // GroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.genderGroupBox);
            this.Controls.Add(this.cmsTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GroupBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupBox";
            this.genderGroupBox.ResumeLayout(false);
            this.genderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox cmsTextBox;
        private System.Windows.Forms.GroupBox genderGroupBox;
        private System.Windows.Forms.RadioButton gmailRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem colorChangerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pictureChangerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateTimePickerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileDialogToolStripMenuItem;
    }
}