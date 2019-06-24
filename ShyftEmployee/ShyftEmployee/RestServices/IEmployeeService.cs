using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.SfSchedule.XForms;

namespace ShyftEmployee.RestServices
{
    public interface IEmployeeService
    {
        string GetCompanyName();
        ScheduleAppointmentCollection GetShifts();
    }
}
