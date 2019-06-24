using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using ShyftEmployee.RestServices;
using ShyftEmployee.Views.Popups;
using Syncfusion.SfSchedule.XForms;
using Syncfusion.XForms.PopupLayout;
using Xamarin.Forms;

namespace ShyftEmployee.ViewModels
{
    public class ScheduleViewModel : INotifyPropertyChanged
    {
        public ScheduleAppointmentCollection Schedule { get; }

        public ICommand ScheduleCellTapped { get; }
        public event PropertyChangedEventHandler PropertyChanged;

        private ShiftPopup popup;

        public ScheduleViewModel(IEmployeeService service)
        {
            Schedule = service.GetShifts();
            popup = new ShiftPopup();
            OnPropertyChanged("Schedule");
            ScheduleCellTapped = new Command<CellTappedEventArgs>(CellTapped);
        }

        private void CellTapped(CellTappedEventArgs args)
        {
            //  ShiftPopup popup = new ShiftPopup();
            ScheduleAppointment appointment = (ScheduleAppointment) args.Appointment;
            popup.Show(
                "role",
                appointment.StartTime,
                appointment.EndTime,
                "some notes"
                );
           // Application.Current.MainPage.Navigation.PushAsync(new ShiftPopup());
        }

        private void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

    }
}
