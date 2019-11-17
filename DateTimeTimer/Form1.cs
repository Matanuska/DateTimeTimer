using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace DateTimeTimer
{
    public partial class Form1 : Form
    {

        DateTimeTimer dtt;
        public Form1()
        {
            InitializeComponent();
            dtt = new DateTimeTimer();            
            dtt.TimeChanged += Dtt_TimeChanged;            

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            loadCultureCombobox();
            timeZoneCombo1.TimeZoneChanged += TimeZoneCombo1_TimeZoneChanged;
        }

        private void TimeZoneCombo1_TimeZoneChanged(object sender, TimeZoneChangedEventArgs e)
        {
            dtt.TimeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneCombo1.TimeZone.Id);
        }

        private void Dtt_TimeChanged(object sender, ThresholdReachedEventArgs e)
        {
            label1.Text = e.LocalDate.ToString();
        }

        private void loadCultureCombobox()
        {

            var cultureList = CultureInfo.GetCultures(CultureTypes.AllCultures).ToList();
            cultureList.Sort((p1, p2) => string.Compare(p1.DisplayName, p2.DisplayName, true));

            int index = 0;
            foreach (CultureInfo ci in cultureList)
            {
                ComboboxItem item = new ComboboxItem();
                item.Value = ci.Name;
                item.Text = ci.DisplayName;
                comboBox1.Items.Add(item);
                if (ci.Name == CultureInfo.CurrentCulture.Name)
                {
                    index = cultureList.IndexOf(ci);
                }

            }

            comboBox1.SelectedIndex = index;
                                 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtt.CultureInfo = CultureInfo.GetCultureInfo(((ComboboxItem)comboBox1.SelectedItem).Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }

}
