using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFXCalendarPluginSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CalendarView_DateSelectionChanged(object sender, EventArgs arg)
        {
            DisplayAlert("Date Changed", calendar.SelectedDate.ToString(), "OK");
        }
    }
}

