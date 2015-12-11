namespace SetReportPageSettings
{
    partial class pageSetupFinished
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pageSetupFinished));
            this.headerWorksheetList = new System.Windows.Forms.ComboBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.setHeaderInfo = new System.Windows.Forms.Label();
            this.portraitRadioButton = new System.Windows.Forms.RadioButton();
            this.landscapeRadioButton = new System.Windows.Forms.RadioButton();
            this.selectWorksheetLabel = new System.Windows.Forms.Label();
            this.setHeaderLabel = new System.Windows.Forms.Label();
            this.customHeaderList = new System.Windows.Forms.ComboBox();
            this.saveHeader = new System.Windows.Forms.Button();
            this.setThisWorksheet = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.deleteHeader = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerWorksheetList
            // 
            this.headerWorksheetList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.headerWorksheetList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerWorksheetList.FormattingEnabled = true;
            this.headerWorksheetList.Location = new System.Drawing.Point(6, 92);
            this.headerWorksheetList.MaxDropDownItems = 15;
            this.headerWorksheetList.Name = "headerWorksheetList";
            this.headerWorksheetList.Size = new System.Drawing.Size(323, 23);
            this.headerWorksheetList.TabIndex = 0;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(12, 9);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(227, 78);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.Text = "Initial page setup completed for all worksheets.\r\n\r\n    Left Margin = 0\r\n    Righ" +
    "t Margin = 0\r\n    Print Gridlines = True\r\n    Footer = Page X of N";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteHeader);
            this.groupBox1.Controls.Add(this.setThisWorksheet);
            this.groupBox1.Controls.Add(this.saveHeader);
            this.groupBox1.Controls.Add(this.customHeaderList);
            this.groupBox1.Controls.Add(this.setHeaderLabel);
            this.groupBox1.Controls.Add(this.selectWorksheetLabel);
            this.groupBox1.Controls.Add(this.landscapeRadioButton);
            this.groupBox1.Controls.Add(this.portraitRadioButton);
            this.groupBox1.Controls.Add(this.setHeaderInfo);
            this.groupBox1.Controls.Add(this.headerWorksheetList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 267);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Headers && Page Orientation";
            // 
            // setHeaderInfo
            // 
            this.setHeaderInfo.AutoSize = true;
            this.setHeaderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setHeaderInfo.Location = new System.Drawing.Point(15, 22);
            this.setHeaderInfo.Name = "setHeaderInfo";
            this.setHeaderInfo.Size = new System.Drawing.Size(282, 30);
            this.setHeaderInfo.TabIndex = 1;
            this.setHeaderInfo.Text = "Set custom headers for specific worksheets.\r\nAdditionally, save custom headers fo" +
    "r future usage.";
            // 
            // portraitRadioButton
            // 
            this.portraitRadioButton.AutoSize = true;
            this.portraitRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portraitRadioButton.Location = new System.Drawing.Point(11, 224);
            this.portraitRadioButton.Name = "portraitRadioButton";
            this.portraitRadioButton.Size = new System.Drawing.Size(64, 19);
            this.portraitRadioButton.TabIndex = 3;
            this.portraitRadioButton.TabStop = true;
            this.portraitRadioButton.Text = "Portrait";
            this.portraitRadioButton.UseVisualStyleBackColor = true;
            // 
            // landscapeRadioButton
            // 
            this.landscapeRadioButton.AutoSize = true;
            this.landscapeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landscapeRadioButton.Location = new System.Drawing.Point(81, 225);
            this.landscapeRadioButton.Name = "landscapeRadioButton";
            this.landscapeRadioButton.Size = new System.Drawing.Size(86, 19);
            this.landscapeRadioButton.TabIndex = 4;
            this.landscapeRadioButton.TabStop = true;
            this.landscapeRadioButton.Text = "Landscape";
            this.landscapeRadioButton.UseVisualStyleBackColor = true;
            // 
            // selectWorksheetLabel
            // 
            this.selectWorksheetLabel.AutoSize = true;
            this.selectWorksheetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectWorksheetLabel.Location = new System.Drawing.Point(7, 72);
            this.selectWorksheetLabel.Name = "selectWorksheetLabel";
            this.selectWorksheetLabel.Size = new System.Drawing.Size(114, 16);
            this.selectWorksheetLabel.TabIndex = 5;
            this.selectWorksheetLabel.Text = "Select Worksheet";
            // 
            // setHeaderLabel
            // 
            this.setHeaderLabel.AutoSize = true;
            this.setHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setHeaderLabel.Location = new System.Drawing.Point(7, 125);
            this.setHeaderLabel.Name = "setHeaderLabel";
            this.setHeaderLabel.Size = new System.Drawing.Size(143, 16);
            this.setHeaderLabel.TabIndex = 6;
            this.setHeaderLabel.Text = "Select Custom Header";
            // 
            // customHeaderList
            // 
            this.customHeaderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customHeaderList.FormattingEnabled = true;
            this.customHeaderList.Location = new System.Drawing.Point(6, 144);
            this.customHeaderList.Name = "customHeaderList";
            this.customHeaderList.Size = new System.Drawing.Size(323, 24);
            this.customHeaderList.TabIndex = 7;
            // 
            // saveHeader
            // 
            this.saveHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveHeader.Location = new System.Drawing.Point(87, 174);
            this.saveHeader.Name = "saveHeader";
            this.saveHeader.Size = new System.Drawing.Size(75, 23);
            this.saveHeader.TabIndex = 9;
            this.saveHeader.Text = "Save";
            this.saveHeader.UseVisualStyleBackColor = true;
            this.saveHeader.Click += new System.EventHandler(this.saveHeader_Click);
            // 
            // setThisWorksheet
            // 
            this.setThisWorksheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setThisWorksheet.Location = new System.Drawing.Point(173, 213);
            this.setThisWorksheet.Name = "setThisWorksheet";
            this.setThisWorksheet.Size = new System.Drawing.Size(156, 44);
            this.setThisWorksheet.TabIndex = 10;
            this.setThisWorksheet.Text = "Set This Worksheet";
            this.setThisWorksheet.UseVisualStyleBackColor = true;
            this.setThisWorksheet.Click += new System.EventHandler(this.setThisWorksheet_Click);
            // 
            // finishButton
            // 
            this.finishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishButton.Location = new System.Drawing.Point(141, 373);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 33);
            this.finishButton.TabIndex = 3;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // deleteHeader
            // 
            this.deleteHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteHeader.Location = new System.Drawing.Point(6, 174);
            this.deleteHeader.Name = "deleteHeader";
            this.deleteHeader.Size = new System.Drawing.Size(75, 23);
            this.deleteHeader.TabIndex = 11;
            this.deleteHeader.Text = "Delete";
            this.deleteHeader.UseVisualStyleBackColor = true;
            this.deleteHeader.Click += new System.EventHandler(this.deleteHeader_Click);
            // 
            // pageSetupFinished
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 414);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.messageLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pageSetupFinished";
            this.Text = "Initial Page Setup Complete";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label setHeaderInfo;
        private System.Windows.Forms.Button setThisWorksheet;
        private System.Windows.Forms.Button saveHeader;
        private System.Windows.Forms.Label setHeaderLabel;
        private System.Windows.Forms.Label selectWorksheetLabel;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button deleteHeader;
        internal System.Windows.Forms.ComboBox headerWorksheetList;
        internal System.Windows.Forms.ComboBox customHeaderList;
        internal System.Windows.Forms.RadioButton landscapeRadioButton;
        internal System.Windows.Forms.RadioButton portraitRadioButton;
    }
}