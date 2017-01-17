namespace HybridXMLExperiment
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chartOutData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gridDataStream = new System.Windows.Forms.DataGridView();
            this.txtLiveOutput = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStartConversion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaveFile = new System.Windows.Forms.TextBox();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.cmbBoxElements = new System.Windows.Forms.ComboBox();
            this.txtOpenFile = new System.Windows.Forms.TextBox();
            this.btnOpenFileToConvert = new System.Windows.Forms.Button();
            this.OpenFileToConvert = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileLocation = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOutData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataStream)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1171, 526);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chartOutData);
            this.tabPage1.Controls.Add(this.gridDataStream);
            this.tabPage1.Controls.Add(this.txtLiveOutput);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1163, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Viewer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chartOutData
            // 
            chartArea3.Name = "ChartArea1";
            this.chartOutData.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartOutData.Legends.Add(legend3);
            this.chartOutData.Location = new System.Drawing.Point(636, 212);
            this.chartOutData.Name = "chartOutData";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartOutData.Series.Add(series3);
            this.chartOutData.Size = new System.Drawing.Size(514, 150);
            this.chartOutData.TabIndex = 2;
            this.chartOutData.Text = "chart1";
            // 
            // gridDataStream
            // 
            this.gridDataStream.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDataStream.Location = new System.Drawing.Point(6, 212);
            this.gridDataStream.Name = "gridDataStream";
            this.gridDataStream.Size = new System.Drawing.Size(624, 150);
            this.gridDataStream.TabIndex = 1;
            // 
            // txtLiveOutput
            // 
            this.txtLiveOutput.Location = new System.Drawing.Point(3, 37);
            this.txtLiveOutput.Multiline = true;
            this.txtLiveOutput.Name = "txtLiveOutput";
            this.txtLiveOutput.Size = new System.Drawing.Size(1154, 169);
            this.txtLiveOutput.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1163, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1163, 500);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "File Utilities";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStartConversion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSaveFile);
            this.groupBox1.Controls.Add(this.btnSaveFile);
            this.groupBox1.Controls.Add(this.cmbBoxElements);
            this.groupBox1.Controls.Add(this.txtOpenFile);
            this.groupBox1.Controls.Add(this.btnOpenFileToConvert);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convert String to Compressed Element";
            // 
            // btnStartConversion
            // 
            this.btnStartConversion.Location = new System.Drawing.Point(96, 151);
            this.btnStartConversion.Name = "btnStartConversion";
            this.btnStartConversion.Size = new System.Drawing.Size(167, 23);
            this.btnStartConversion.TabIndex = 6;
            this.btnStartConversion.Text = "Start Conversion";
            this.btnStartConversion.UseVisualStyleBackColor = true;
            this.btnStartConversion.Click += new System.EventHandler(this.btnStartConversion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Element to Compress";
            // 
            // txtSaveFile
            // 
            this.txtSaveFile.Location = new System.Drawing.Point(0, 71);
            this.txtSaveFile.Name = "txtSaveFile";
            this.txtSaveFile.Size = new System.Drawing.Size(192, 20);
            this.txtSaveFile.TabIndex = 4;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(198, 68);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(167, 23);
            this.btnSaveFile.TabIndex = 3;
            this.btnSaveFile.Text = "Select Output File";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // cmbBoxElements
            // 
            this.cmbBoxElements.FormattingEnabled = true;
            this.cmbBoxElements.Location = new System.Drawing.Point(0, 103);
            this.cmbBoxElements.Name = "cmbBoxElements";
            this.cmbBoxElements.Size = new System.Drawing.Size(153, 21);
            this.cmbBoxElements.TabIndex = 2;
            // 
            // txtOpenFile
            // 
            this.txtOpenFile.Location = new System.Drawing.Point(0, 32);
            this.txtOpenFile.Name = "txtOpenFile";
            this.txtOpenFile.Size = new System.Drawing.Size(192, 20);
            this.txtOpenFile.TabIndex = 1;
            // 
            // btnOpenFileToConvert
            // 
            this.btnOpenFileToConvert.Location = new System.Drawing.Point(198, 29);
            this.btnOpenFileToConvert.Name = "btnOpenFileToConvert";
            this.btnOpenFileToConvert.Size = new System.Drawing.Size(167, 23);
            this.btnOpenFileToConvert.TabIndex = 0;
            this.btnOpenFileToConvert.Text = "Browse For File to Convert";
            this.btnOpenFileToConvert.UseVisualStyleBackColor = true;
            this.btnOpenFileToConvert.Click += new System.EventHandler(this.btnOpenFileToConvert_Click);
            // 
            // OpenFileToConvert
            // 
            this.OpenFileToConvert.Filter = "XML Files|.xml;*.XML|All Files|*.*";
            this.OpenFileToConvert.RestoreDirectory = true;
            this.OpenFileToConvert.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileToConvert_FileOk);
            // 
            // SaveFileLocation
            // 
            this.SaveFileLocation.Filter = "XML Files|.xml;*.XML|All Files|*.*";
            this.SaveFileLocation.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileLocation_FileOk);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 525);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Hybrid XML Experiment";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOutData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataStream)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOutData;
        private System.Windows.Forms.DataGridView gridDataStream;
        private System.Windows.Forms.TextBox txtLiveOutput;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOpenFile;
        private System.Windows.Forms.Button btnOpenFileToConvert;
        private System.Windows.Forms.OpenFileDialog OpenFileToConvert;
        private System.Windows.Forms.ComboBox cmbBoxElements;
        private System.Windows.Forms.TextBox txtSaveFile;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.SaveFileDialog SaveFileLocation;
        private System.Windows.Forms.Button btnStartConversion;
        private System.Windows.Forms.Label label1;
    }
}

