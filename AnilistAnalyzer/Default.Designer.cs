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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Default));
            this.selectFileButton = new System.Windows.Forms.Button();
            this.fileNameText = new System.Windows.Forms.Label();
            this.dataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.helpButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.MonthChartTabPage = new System.Windows.Forms.TabPage();
            this.noFileLabel = new System.Windows.Forms.Label();
            this.TableTabPage = new System.Windows.Forms.TabPage();
            this.csvSaveButton = new System.Windows.Forms.Button();
            this.csvTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataChart)).BeginInit();
            this.tabControl.SuspendLayout();
            this.MonthChartTabPage.SuspendLayout();
            this.TableTabPage.SuspendLayout();
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
            this.tabControl.Controls.Add(this.TableTabPage);
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
            // TableTabPage
            // 
            this.TableTabPage.Controls.Add(this.csvSaveButton);
            this.TableTabPage.Controls.Add(this.csvTextBox);
            this.TableTabPage.Location = new System.Drawing.Point(4, 25);
            this.TableTabPage.Name = "TableTabPage";
            this.TableTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TableTabPage.Size = new System.Drawing.Size(1108, 553);
            this.TableTabPage.TabIndex = 1;
            this.TableTabPage.Text = "Data";
            this.TableTabPage.UseVisualStyleBackColor = true;
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
            this.TableTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Label fileNameText;
        private System.Windows.Forms.DataVisualization.Charting.Chart dataChart;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage TableTabPage;
        private System.Windows.Forms.TabPage MonthChartTabPage;
        private System.Windows.Forms.RichTextBox csvTextBox;
        private System.Windows.Forms.Button csvSaveButton;
        private System.Windows.Forms.Label noFileLabel;
    }
}

