using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace DateTimeTimer
{   
    class DateTimeTimer : Timer
    {
        DateTime timeUtc = DateTime.UtcNow;
        private string timeformat = "HH:mm:ss";
        private string dateformat = "HH:mm:ss";
        private CultureInfo cInfo = CultureInfo.CurrentCulture;

        //public event EventHandler<ThresholdReachedEventArgs> DateTimeChanged;
        public event EventHandler<ThresholdReachedEventArgs> TimeChanged;

        public DateTimeTimer()
        {
            this.TimeZone = TimeZoneInfo.Local;
            Tick += new EventHandler(getTime);
            this.Interval = 1;
            this.Enabled = true;

            this.Interval = 1000;
        }

        private void getTime(object sender, EventArgs e)
        {
            timeUtc = DateTime.UtcNow;

            DateTime cstTime = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, this.TimeZone);

            ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
            args.Time = cstTime.ToString(TimeFormat, cInfo);

            args.DateTime = cstTime;

            args.LocalDate = cstTime.ToString(new CultureInfo(CultureInfo.Name));

            EventHandler<ThresholdReachedEventArgs> handler = TimeChanged;
            if (handler != null)
            {
                handler(this, args);
            }
        }

        public TimeZoneInfo TimeZone { get; set; }

        public CultureInfo CultureInfo
        {
            get { return cInfo; }
            set { cInfo = value;}
        }



        public string TimeFormat
        {
            private get { return timeformat; }
            set { timeformat = value; }
        }

        

        public string DateFormat
        {
            private get { return dateformat; }
            set { dateformat = value; }
        }


    }

    public class ThresholdReachedEventArgs : EventArgs
    {
        public DateTime DateTime { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }

        public string LocalDate { get; set; }

    }

}
