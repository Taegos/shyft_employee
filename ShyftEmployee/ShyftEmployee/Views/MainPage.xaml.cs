using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShyftEmployee.RestServices.Mocks;
using ShyftEmployee.ViewModels;
using Syncfusion.SfSchedule.XForms;
using Xamarin.Forms;

namespace ShyftEmployee
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(new EmployeeServiceMock());
            //ScheduleAppointmentCollection scheduleAppointmentCollection = new ScheduleAppointmentCollection();
            ////Adding schedule appointment in schedule appointment collection 
            //scheduleAppointmentCollection.Add(new ScheduleAppointment()
            //{
            //    StartTime = new DateTime(2019, 06, 23, 10, 0, 0),
            //    EndTime = new DateTime(2019, 06, 23, 12, 0, 0),
            //    Subject = "Meeting",
            //    Location = "Hutchison road",
            //});

            ////Adding schedule appointment collection to DataSource of SfSchedule
            //schedule.DataSource = scheduleAppointmentCollection;
        }
    }
}
