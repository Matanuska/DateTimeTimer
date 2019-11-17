using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeTimer
{
    public partial class TimeZoneCombo : UserControl
    {
        public event EventHandler<TimeZoneChangedEventArgs> TimeZoneChanged;
        public TimeZoneCombo()
        {
            InitializeComponent();
        }

        private void TimeZoneCombo_Load(object sender, EventArgs e)
        {
            lstTimezones.DataSource = TimeZoneInfo.GetSystemTimeZones();
            lstTimezones.DisplayMember = "DisplayName";
            lstTimezones.ValueMember = "Id";

            lstTimezones.SelectedValue = TimeZoneInfo.Local.Id;
        }


        public TimeZoneInfo TimeZone
        {
            get
            {
                return (lstTimezones.SelectedValue != null) ? (TimeZoneInfo)lstTimezones.SelectedItem : null;

            }
            set
            {
                if (value != null)
                {
                    lstTimezones.SelectedValue = value.Id;
                }
            }
        }

        TimeZoneInfo initTZ;
        private void lstTimezones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (initTZ != (TimeZoneInfo)lstTimezones.SelectedItem)
            {
                TimeZoneChangedEventArgs args = new TimeZoneChangedEventArgs();
                args.NewTimeZone = (TimeZoneInfo)lstTimezones.SelectedItem;

                EventHandler<TimeZoneChangedEventArgs> handler = TimeZoneChanged;
                if (handler != null)
                {
                    handler(this, args);
                }

                initTZ = (TimeZoneInfo)lstTimezones.SelectedItem;
            }
        }
    }
    public class TimeZoneChangedEventArgs : EventArgs
    {
        public TimeZoneInfo NewTimeZone { get; set; }

    }
}
