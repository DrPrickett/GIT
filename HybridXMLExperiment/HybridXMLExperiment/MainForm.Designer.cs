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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnStartExperiment = new System.Windows.Forms.Button();
            this.chartOutData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gridDataStream = new System.Windows.Forms.DataGridView();
            this.txtLiveOutput = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datagridKeywords = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCommonWords = new System.Windows.Forms.TextBox();
            this.btnStartKeywordGeneration = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaveFileKeywords = new System.Windows.Forms.TextBox();
            this.btnSaveFileKeywords = new System.Windows.Forms.Button();
            this.cmbBoxElementsKeywords = new System.Windows.Forms.ComboBox();
            this.txtOpenFileKeywords = new System.Windows.Forms.TextBox();
            this.btnOpenFileKeywords = new System.Windows.Forms.Button();
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
            this.OpenFileToGenerateKeywords = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileLocationKeywords = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOutData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataStream)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridKeywords)).BeginInit();
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
            this.tabPage1.Controls.Add(this.btnStartExperiment);
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
            // btnStartExperiment
            // 
            this.btnStartExperiment.Location = new System.Drawing.Point(11, 20);
            this.btnStartExperiment.Name = "btnStartExperiment";
            this.btnStartExperiment.Size = new System.Drawing.Size(166, 23);
            this.btnStartExperiment.TabIndex = 3;
            this.btnStartExperiment.Text = "START EXPERIMENT";
            this.btnStartExperiment.UseVisualStyleBackColor = true;
            this.btnStartExperiment.Click += new System.EventHandler(this.btnStartExperiment_Click);
            // 
            // chartOutData
            // 
            chartArea1.Name = "ChartArea1";
            this.chartOutData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartOutData.Legends.Add(legend1);
            this.chartOutData.Location = new System.Drawing.Point(454, 382);
            this.chartOutData.Name = "chartOutData";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartOutData.Series.Add(series1);
            this.chartOutData.Size = new System.Drawing.Size(514, 150);
            this.chartOutData.TabIndex = 2;
            this.chartOutData.Text = "chart1";
            // 
            // gridDataStream
            // 
            this.gridDataStream.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDataStream.Location = new System.Drawing.Point(6, 212);
            this.gridDataStream.Name = "gridDataStream";
            this.gridDataStream.Size = new System.Drawing.Size(1151, 150);
            this.gridDataStream.TabIndex = 1;
            // 
            // txtLiveOutput
            // 
            this.txtLiveOutput.Location = new System.Drawing.Point(3, 66);
            this.txtLiveOutput.Multiline = true;
            this.txtLiveOutput.Name = "txtLiveOutput";
            this.txtLiveOutput.Size = new System.Drawing.Size(1154, 140);
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
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1163, 500);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "File Utilities";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datagridKeywords);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCommonWords);
            this.groupBox2.Controls.Add(this.btnStartKeywordGeneration);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSaveFileKeywords);
            this.groupBox2.Controls.Add(this.btnSaveFileKeywords);
            this.groupBox2.Controls.Add(this.cmbBoxElementsKeywords);
            this.groupBox2.Controls.Add(this.txtOpenFileKeywords);
            this.groupBox2.Controls.Add(this.btnOpenFileKeywords);
            this.groupBox2.Location = new System.Drawing.Point(562, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 461);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generate Keywords from Element";
            // 
            // datagridKeywords
            // 
            this.datagridKeywords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridKeywords.Location = new System.Drawing.Point(77, 283);
            this.datagridKeywords.Name = "datagridKeywords";
            this.datagridKeywords.Size = new System.Drawing.Size(298, 172);
            this.datagridKeywords.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Common words to be eliminated for keyword generation";
            // 
            // txtCommonWords
            // 
            this.txtCommonWords.Location = new System.Drawing.Point(0, 189);
            this.txtCommonWords.Multiline = true;
            this.txtCommonWords.Name = "txtCommonWords";
            this.txtCommonWords.Size = new System.Drawing.Size(437, 59);
            this.txtCommonWords.TabIndex = 7;
            this.txtCommonWords.Text = "a,at,the,we,you,us,them,their,there,I,when,and,of,to,his,her,in,it,was,that,he,ha" +
    "d,with,\",as,him,not,for,is,my,me,but,this,i,by,which,have,weere,from,she,on,be,t" +
    "hey,so,no,or,who,was,are,would,-,\'";
            // 
            // btnStartKeywordGeneration
            // 
            this.btnStartKeywordGeneration.Location = new System.Drawing.Point(142, 254);
            this.btnStartKeywordGeneration.Name = "btnStartKeywordGeneration";
            this.btnStartKeywordGeneration.Size = new System.Drawing.Size(167, 23);
            this.btnStartKeywordGeneration.TabIndex = 6;
            this.btnStartKeywordGeneration.Text = "Start Keyword Generation";
            this.btnStartKeywordGeneration.UseVisualStyleBackColor = true;
            this.btnStartKeywordGeneration.Click += new System.EventHandler(this.btnStartKeywordGeneration_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Element to GenerateKeywords";
            // 
            // txtSaveFileKeywords
            // 
            this.txtSaveFileKeywords.Location = new System.Drawing.Point(0, 97);
            this.txtSaveFileKeywords.Name = "txtSaveFileKeywords";
            this.txtSaveFileKeywords.Size = new System.Drawing.Size(192, 20);
            this.txtSaveFileKeywords.TabIndex = 4;
            // 
            // btnSaveFileKeywords
            // 
            this.btnSaveFileKeywords.Location = new System.Drawing.Point(198, 94);
            this.btnSaveFileKeywords.Name = "btnSaveFileKeywords";
            this.btnSaveFileKeywords.Size = new System.Drawing.Size(167, 23);
            this.btnSaveFileKeywords.TabIndex = 3;
            this.btnSaveFileKeywords.Text = "Select Output File";
            this.btnSaveFileKeywords.UseVisualStyleBackColor = true;
            this.btnSaveFileKeywords.Click += new System.EventHandler(this.btnSaveFileKeywords_Click);
            // 
            // cmbBoxElementsKeywords
            // 
            this.cmbBoxElementsKeywords.FormattingEnabled = true;
            this.cmbBoxElementsKeywords.Location = new System.Drawing.Point(0, 129);
            this.cmbBoxElementsKeywords.Name = "cmbBoxElementsKeywords";
            this.cmbBoxElementsKeywords.Size = new System.Drawing.Size(153, 21);
            this.cmbBoxElementsKeywords.TabIndex = 2;
            // 
            // txtOpenFileKeywords
            // 
            this.txtOpenFileKeywords.Location = new System.Drawing.Point(0, 58);
            this.txtOpenFileKeywords.Name = "txtOpenFileKeywords";
            this.txtOpenFileKeywords.Size = new System.Drawing.Size(192, 20);
            this.txtOpenFileKeywords.TabIndex = 1;
            // 
            // btnOpenFileKeywords
            // 
            this.btnOpenFileKeywords.Location = new System.Drawing.Point(198, 55);
            this.btnOpenFileKeywords.Name = "btnOpenFileKeywords";
            this.btnOpenFileKeywords.Size = new System.Drawing.Size(167, 23);
            this.btnOpenFileKeywords.TabIndex = 0;
            this.btnOpenFileKeywords.Text = "Browse For File to Convert";
            this.btnOpenFileKeywords.UseVisualStyleBackColor = true;
            this.btnOpenFileKeywords.Click += new System.EventHandler(this.btnOpenFileKeywords_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(3, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 461);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convert String to Compressed Element";
            // 
            // btnStartConversion
            // 
            this.btnStartConversion.Location = new System.Drawing.Point(96, 177);
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
            this.label1.Location = new System.Drawing.Point(211, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Element to Compress";
            // 
            // txtSaveFile
            // 
            this.txtSaveFile.Location = new System.Drawing.Point(0, 97);
            this.txtSaveFile.Name = "txtSaveFile";
            this.txtSaveFile.Size = new System.Drawing.Size(192, 20);
            this.txtSaveFile.TabIndex = 4;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(198, 94);
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
            this.cmbBoxElements.Location = new System.Drawing.Point(0, 129);
            this.cmbBoxElements.Name = "cmbBoxElements";
            this.cmbBoxElements.Size = new System.Drawing.Size(153, 21);
            this.cmbBoxElements.TabIndex = 2;
            // 
            // txtOpenFile
            // 
            this.txtOpenFile.Location = new System.Drawing.Point(0, 58);
            this.txtOpenFile.Name = "txtOpenFile";
            this.txtOpenFile.Size = new System.Drawing.Size(192, 20);
            this.txtOpenFile.TabIndex = 1;
            // 
            // btnOpenFileToConvert
            // 
            this.btnOpenFileToConvert.Location = new System.Drawing.Point(198, 55);
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
            // OpenFileToGenerateKeywords
            // 
            this.OpenFileToGenerateKeywords.Filter = "XML Files|.xml;*.XML|All Files|*.*";
            this.OpenFileToGenerateKeywords.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileToGenerateKeywords_FileOk);
            // 
            // SaveFileLocationKeywords
            // 
            this.SaveFileLocationKeywords.Filter = "XML Files|.xml;*.XML|All Files|*.*";
            this.SaveFileLocationKeywords.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileLocationKeywords_FileOk);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridKeywords)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStartKeywordGeneration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaveFileKeywords;
        private System.Windows.Forms.Button btnSaveFileKeywords;
        private System.Windows.Forms.ComboBox cmbBoxElementsKeywords;
        private System.Windows.Forms.TextBox txtOpenFileKeywords;
        private System.Windows.Forms.Button btnOpenFileKeywords;
        private System.Windows.Forms.OpenFileDialog OpenFileToGenerateKeywords;
        private System.Windows.Forms.SaveFileDialog SaveFileLocationKeywords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCommonWords;
        private System.Windows.Forms.DataGridView datagridKeywords;
        private System.Windows.Forms.Button btnStartExperiment;
    }
}

