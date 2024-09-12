using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AnilistAnalyzer
{
    public partial class Default : Form
    {
        private readonly List<string> WEEKDAYNAMES = new List<string>
        {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"
        };

        public Default()
        {
            InitializeComponent();
            dataChart.Visible = false;
            csvTextBox.Visible = false;
            tabControl.Enabled = false;
            fileNameText.Text = "";
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            // show file dialog to pick a file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a .json file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName != "")
                {
                    fileNameText.Text = openFileDialog.FileName.Substring(openFileDialog.FileName.LastIndexOf("\\") + 1);
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        // parse data and update visual controls
                        List<DateTime> activity = parseData(reader.ReadLine());
                        if (activity != null)
                        {
                            displayMonthlyChart(activity);
                            displayInsights(activity);
                        }
                    }
                }
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            // open help window
            HelpWindow newHelpWindow = new HelpWindow();
            newHelpWindow.ShowDialog();
        }
        private void csvSaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV File|*.csv";
            saveFileDialog.Title = "Save File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
            {
                using (StreamWriter fs = new StreamWriter(saveFileDialog.FileName))
                {
                    fs.Write(csvTextBox.Text);
                }
            }
        }

        private List<DateTime> parseData(string line)
        {
            List<DateTime> activity = new List<DateTime>();
            try
            {
                // look for activity section in json
                var startIndex = line.IndexOf("\"activity\":[") + "\"activity\":[".Length;
                line = line.Substring(startIndex);
                var endIndex = line.IndexOf("]");
                line = line.Substring(0, endIndex);
                if(startIndex == -1 || endIndex == -1)
                {
                    throw new Exception();
                }

                // parse activity dates
                while (line.Contains("created_at"))
                {
                    string currEntry = line.Substring(line.IndexOf("\"created_at\":\"") + "\"created_at\":\"".Length);
                    currEntry = currEntry.Substring(0, currEntry.IndexOf('"'));

                    var year = int.Parse(currEntry.Substring(0, 4));
                    var month = int.Parse(currEntry.Substring(5, 2));
                    var day = int.Parse(currEntry.Substring(8, 2));
                    var hour = int.Parse(currEntry.Substring(11, 2));
                    var minute = int.Parse(currEntry.Substring(14, 2));
                    var second = int.Parse(currEntry.Substring(17, 2));
                    DateTime activityDate = new DateTime(year, month, day, hour, minute, second);

                    activity.Add(activityDate);

                    line = line.Substring(line.IndexOf("}") + 1);
                }
            }
            catch
            {
                MessageBox.Show("File had bad format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
            return activity;
        }

        private void displayMonthlyChart(List<DateTime> activity)
        {
            // enable tab control/hide no file label
            tabControl.Enabled = true;
            noFileLabel.Visible = false;

            // count activity per month
            List<ActivityMonth> activityList = new List<ActivityMonth>();
            ActivityMonth lowMonth = null;
            ActivityMonth highMonth = null;
            for (int i = 0; i < activity.Count; i++)
            {
                ActivityMonth currActivityMonth = new ActivityMonth(activity[i].Year, activity[i].Month, 1);
                if (activityList.Contains(currActivityMonth))
                {
                    activityList[activityList.IndexOf(currActivityMonth)].activity++;
                }
                else
                {
                    activityList.Add(currActivityMonth);

                    // find outer bounds
                    if(lowMonth == null || currActivityMonth.CompareTo(lowMonth) < 0)
                    {
                        lowMonth = currActivityMonth;
                    }
                    if (highMonth == null || currActivityMonth.CompareTo(highMonth) > 0)
                    {
                        highMonth = currActivityMonth;
                    }
                }
            }

            // fill out empty months in the bounds
            for(int currY = lowMonth.year; currY <= highMonth.year; currY++)
            {
                for(int currM = 1; currM <= 12; currM++)
                {
                    ActivityMonth tempMonth = new ActivityMonth(currY, currM, 0);
                    if(!(currY == lowMonth.year && currM < lowMonth.month) && 
                        !(currY == highMonth.year && currM > highMonth.month) &&
                        !activityList.Contains(tempMonth))
                    {
                        activityList.Add(tempMonth);
                    }
                }
            }

            // sort so the line displays correctly
            activityList.Sort();

            // set up and display chart/csv data
            dataChart.Series.Clear();
            dataChart.Series.Add("Activity");
            dataChart.Series["Activity"].ChartType = SeriesChartType.Line;
            dataChart.Series["Activity"].BorderWidth = 3;
            csvTextBox.Text = "";

            for (int i = 0; i < activityList.Count; i++)
            {
                dataChart.Series["Activity"].Points.AddXY(activityList[i].ToString(), activityList[i].activity);
                csvTextBox.Text += activityList[i].ToString() + ", " + activityList[i].activity + "\n";
            }

            dataChart.Visible = true;
            csvTextBox.Visible = true;
        }

        private void displayInsights(List<DateTime> activity)
        {
            displayDayOfWeekChart(activity);
            displayAverageActivity(activity);
        }

        private void displayDayOfWeekChart(List<DateTime> activity)
        {
            // analyze activity
            int[] weekdayActivity = new int[7];
            foreach(DateTime curr in activity)
            {
                weekdayActivity[WEEKDAYNAMES.IndexOf(curr.DayOfWeek.ToString())]++;
            }

            // set up and display day of week chart
            dayOfWeekChart.Series.Clear();
            dayOfWeekChart.Series.Add("Activity");
            dayOfWeekChart.Series["Activity"].ChartType = SeriesChartType.Column;

            for(int i = 0; i < 7; i++)
            {
                dayOfWeekChart.Series["Activity"].Points.AddXY(WEEKDAYNAMES[i], weekdayActivity[i]);
            }
        }

        private void displayAverageActivity(List<DateTime> activity)
        {
            // analyze activity
            DateTime first = activity[0];
            DateTime last = activity[0];
            foreach(DateTime i in activity)
            {
                if(i.CompareTo(first) < 0)
                {
                    first = i;
                }
                if(i.CompareTo(last) > 0)
                {
                    last = i;
                }
            }

            var days = last.Subtract(first).TotalDays;
            var avg = activity.Count / days;

            // display average
            activityPerDayLabel.Text = Math.Round(avg,1).ToString();
        }
    }


    // used for the line graph - contains the month and year as well as the amount of activity in that month
    public class ActivityMonth : IComparable<ActivityMonth>
    {
        public int year
        {
            get;
        }
        
        public int month
        {
            get;
        }

        public int activity
        {
            get;
            set;
        }

        public ActivityMonth(int year, int month, int activity)
        {
            this.year = year;
            this.month = month;
            this.activity = activity;
        }

        override public string ToString()
        {
            return year + "/" + (month < 10 ? "0" : "") + month;
        }

        override public bool Equals(object other)
        {
            return year == ((ActivityMonth)other).year && month == ((ActivityMonth)other).month;
        }

        public override int GetHashCode()
        {
            return (month * 10000) + year;
        }

        public int CompareTo(ActivityMonth other)
        {
            return (year * 12) + month - ((other.year * 12) + other.month); 
        }
    }
}
