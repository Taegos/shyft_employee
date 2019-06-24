using System;
using System.Collections.Generic;
using System.Text;
using ShyftEmployee.RestServices;
using ShyftEmployee.Views;
using Syncfusion.SfSchedule.XForms;
using Xamarin.Forms;

namespace ShyftEmployee.ViewModels
{
    public class MainPageViewModel
    {
        public string CompanyName { get; private set; }
        
        public Command OnScheduleButtonPressed { get; }
        public Command OnAvailabilityButtonPressed { get; }
        public Command OnMessagesButtonPressed { get; }

        public MainPageViewModel(IEmployeeService service)
        {
            CompanyName = service.GetCompanyName();
            OnScheduleButtonPressed = new Command(() => GotoSchedulePage());
            OnAvailabilityButtonPressed = new Command(() => GotoAvailabilityPage());
            OnMessagesButtonPressed = new Command(() => GotoMessagesPage());
        }

        private async void GotoSchedulePage()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SchedulePage());
        }

        private async void GotoAvailabilityPage()
        {
            Application.Current.MainPage.Navigation.PushAsync(new AvailabilityPage());
        }
        private async void GotoMessagesPage()
        {
            Application.Current.MainPage.Navigation.PushAsync(new MessagesPage());

        }


    }
}
