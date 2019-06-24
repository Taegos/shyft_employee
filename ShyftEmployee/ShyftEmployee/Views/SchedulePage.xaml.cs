using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShyftEmployee.RestServices.Mocks;
using ShyftEmployee.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShyftEmployee.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SchedulePage : ContentPage
	{
		public SchedulePage ()
		{
			InitializeComponent ();
            BindingContext = new ScheduleViewModel(new EmployeeServiceMock());
        }
	}
}