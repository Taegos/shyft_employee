using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.SfSchedule.XForms;

namespace ShyftEmployee.RestServices.Mocks
{
    class EmployeeServiceMock : IEmployeeService
    {
        public string GetCompanyName()
        {
            return "McDonalds";
        }

        public ScheduleAppointmentCollection GetShifts()
        {
            ScheduleAppointmentCollection scheduleAppointmentCollection = new ScheduleAppointmentCollection();
            //Adding schedule appointment in schedule appointment collection 
            scheduleAppointmentCollection.Add(new ScheduleAppointment()
            {
                StartTime = new DateTime(2019, 06, 23, 10, 0, 0),
                EndTime = new DateTime(2019, 06, 23, 12, 0, 0),
                Subject = "Meeting",
                Location = "Hutchison road",
            });
            scheduleAppointmentCollection.Add(new ScheduleAppointment()
            {
                StartTime = new DateTime(2019, 06, 20, 07, 0, 0),
                EndTime = new DateTime(2019, 06, 20, 13, 20, 0),
                Subject = "Meeting",
                Location = "Hutchison road",
            });
            scheduleAppointmentCollection.Add(new ScheduleAppointment()
            {
                StartTime = new DateTime(2019, 06, 17, 13, 25, 0),
                EndTime = new DateTime(2019, 06, 17, 19, 40, 0),
                Subject = "Meeting",
                Location = "Hutchison road",
            });
            scheduleAppointmentCollection.Add(new ScheduleAppointment()
            {
                StartTime = new DateTime(2019, 06, 21, 22, 15, 0),
                EndTime = new DateTime(2019, 06, 21, 23, 56, 0),
                Subject = "Meeting",
                Location = "Hutchison road",
            });
            return scheduleAppointmentCollection;
        }
    }
}
