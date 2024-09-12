namespace AnilistAnalyzer
{
    partial class Default
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Default));
            this.selectFileButton = new System.Windows.Forms.Button();
            this.fileNameText = new System.Windows.Forms.Label();
            this.dataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.helpButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.MonthChartTabPage = new System.Windows.Forms.TabPage();
            this.noFileLabel = new System.Windows.Forms.Label();
            this.MonthDataTabPage = new System.Windows.Forms.TabPage();
            this.csvSaveButton = new System.Windows.Forms.Button();
            this.csvTextBox = new System.Windows.Forms.RichTextBox();
            this.InsightsTabPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dayOfWeekLabel = new System.Windows.Forms.Label();
            this.dayOfWeekChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.activityPerDayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataChart)).BeginInit();
            this.tabControl.SuspendLayout();
            this.MonthChartTabPage.SuspendLayout();
            this.MonthDataTabPage.SuspendLayout();
            this.InsightsTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayOfWeekChart)).BeginInit();
            this.SuspendLayout();
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(12, 10);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(103, 30);
            this.selectFileButton.TabIndex = 0;
            this.selectFileButton.Text = "Select File";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // fileNameText
            // 
            this.fileNameText.AutoSize = true;
            this.fileNameText.Location = new System.Drawing.Point(121, 17);
            this.fileNameText.Name = "fileNameText";
            this.fileNameText.Size = new System.Drawing.Size(127, 16);
            this.fileNameText.TabIndex = 1;
            this.fileNameText.Text = "SELECT FILE TEXT";
            // 
            // dataChart
            // 
            chartArea1.AxisX.Title = "Month";
            chartArea1.AxisY.Title = "Activity";
            chartArea1.Name = "ChartArea1";
            this.dataChart.ChartAreas.Add(chartArea1);
            this.dataChart.Location = new System.Drawing.Point(3, 3);
            this.dataChart.Name = "dataChart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.dataChart.Series.Add(series1);
            this.dataChart.Size = new System.Drawing.Size(1102, 547);
            this.dataChart.TabIndex = 2;
            this.dataChart.Text = "dataChart";
            this.dataChart.Visible = false;
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(1035, 10);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(93, 30);
            this.helpButton.TabIndex = 3;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.MonthChartTabPage);
            this.tabControl.Controls.Add(this.MonthDataTabPage);
            this.tabControl.Controls.Add(this.InsightsTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 46);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1116, 582);
            this.tabControl.TabIndex = 5;
            // 
            // MonthChartTabPage
            // 
            this.MonthChartTabPage.Controls.Add(this.noFileLabel);
            this.MonthChartTabPage.Controls.Add(this.dataChart);
            this.MonthChartTabPage.Location = new System.Drawing.Point(4, 25);
            this.MonthChartTabPage.Name = "MonthChartTabPage";
            this.MonthChartTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MonthChartTabPage.Size = new System.Drawing.Size(1108, 553);
            this.MonthChartTabPage.TabIndex = 0;
            this.MonthChartTabPage.Text = "Monthly Activity Graph";
            this.MonthChartTabPage.UseVisualStyleBackColor = true;
            // 
            // noFileLabel
            // 
            this.noFileLabel.AutoSize = true;
            this.noFileLabel.Location = new System.Drawing.Point(508, 252);
            this.noFileLabel.Name = "noFileLabel";
            this.noFileLabel.Size = new System.Drawing.Size(76, 16);
            this.noFileLabel.TabIndex = 3;
            this.noFileLabel.Text = "Select a file";
            // 
            // MonthDataTabPage
            // 
            this.MonthDataTabPage.Controls.Add(this.csvSaveButton);
            this.MonthDataTabPage.Controls.Add(this.csvTextBox);
            this.MonthDataTabPage.Location = new System.Drawing.Point(4, 25);
            this.MonthDataTabPage.Name = "MonthDataTabPage";
            this.MonthDataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MonthDataTabPage.Size = new System.Drawing.Size(1108, 553);
            this.MonthDataTabPage.TabIndex = 1;
            this.MonthDataTabPage.Text = "MonthlyData";
            this.MonthDataTabPage.UseVisualStyleBackColor = true;
            // 
            // csvSaveButton
            // 
            this.csvSaveButton.Location = new System.Drawing.Point(1023, 524);
            this.csvSaveButton.Name = "csvSaveButton";
            this.csvSaveButton.Size = new System.Drawing.Size(75, 23);
            this.csvSaveButton.TabIndex = 2;
            this.csvSaveButton.Text = "Save as...";
            this.csvSaveButton.UseVisualStyleBackColor = true;
            this.csvSaveButton.Click += new System.EventHandler(this.csvSaveButton_Click);
            // 
            // csvTextBox
            // 
            this.csvTextBox.Location = new System.Drawing.Point(3, 3);
            this.csvTextBox.Name = "csvTextBox";
            this.csvTextBox.ReadOnly = true;
            this.csvTextBox.Size = new System.Drawing.Size(1102, 515);
            this.csvTextBox.TabIndex = 1;
            this.csvTextBox.Text = "";
            // 
            // InsightsTabPage
            // 
            this.InsightsTabPage.Controls.Add(this.panel1);
            this.InsightsTabPage.Location = new System.Drawing.Point(4, 25);
            this.InsightsTabPage.Name = "InsightsTabPage";
            this.InsightsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.InsightsTabPage.Size = new System.Drawing.Size(1108, 553);
            this.InsightsTabPage.TabIndex = 2;
            this.InsightsTabPage.Text = "Insights";
            this.InsightsTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.activityPerDayLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dayOfWeekLabel);
            this.panel1.Controls.Add(this.dayOfWeekChart);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 547);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Average activity per day:";
            // 
            // dayOfWeekLabel
            // 
            this.dayOfWeekLabel.AutoSize = true;
            this.dayOfWeekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOfWeekLabel.Location = new System.Drawing.Point(17, 13);
            this.dayOfWeekLabel.Name = "dayOfWeekLabel";
            this.dayOfWeekLabel.Size = new System.Drawing.Size(264, 25);
            this.dayOfWeekLabel.TabIndex = 1;
            this.dayOfWeekLabel.Text = "Activity based on week days:";
            // 
            // dayOfWeekChart
            // 
            chartArea2.Name = "ChartArea1";
            this.dayOfWeekChart.ChartAreas.Add(chartArea2);
            this.dayOfWeekChart.Location = new System.Drawing.Point(26, 41);
            this.dayOfWeekChart.Name = "dayOfWeekChart";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.dayOfWeekChart.Series.Add(series2);
            this.dayOfWeekChart.Size = new System.Drawing.Size(1054, 300);
            this.dayOfWeekChart.TabIndex = 0;
            // 
            // activityPerDayLabel
            // 
            this.activityPerDayLabel.AutoSize = true;
            this.activityPerDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityPerDayLabel.Location = new System.Drawing.Point(256, 367);
            this.activityPerDayLabel.Name = "activityPerDayLabel";
            this.activityPerDayLabel.Size = new System.Drawing.Size(227, 25);
            this.activityPerDayLabel.TabIndex = 2;
            this.activityPerDayLabel.Text = "AVGACTIVITYPERDAY";
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 640);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.fileNameText);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Default";
            this.Text = "Anilist Activity Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.dataChart)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.MonthChartTabPage.ResumeLayout(false);
            this.MonthChartTabPage.PerformLayout();
            this.MonthDataTabPage.ResumeLayout(false);
            this.InsightsTabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayOfWeekChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Label fileNameText;
        private System.Windows.Forms.DataVisualization.Charting.Chart dataChart;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage MonthDataTabPage;
        private System.Windows.Forms.TabPage MonthChartTabPage;
        private System.Windows.Forms.RichTextBox csvTextBox;
        private System.Windows.Forms.Button csvSaveButton;
        private System.Windows.Forms.Label noFileLabel;
        private System.Windows.Forms.TabPage InsightsTabPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart dayOfWeekChart;
        private System.Windows.Forms.Label dayOfWeekLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label activityPerDayLabel;
    }
}

