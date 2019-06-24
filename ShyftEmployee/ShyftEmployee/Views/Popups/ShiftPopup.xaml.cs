using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.XForms.PopupLayout;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShyftEmployee.Views.Popups
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ShiftPopup : ContentPage
    {
        private string roleName;
        private DateTime startTime;
        private DateTime endTime;
        private string notes;
        private bool isOpen;

        public bool IsOpen
        {
            get { return isOpen; }
            private set
            {
                isOpen = value;
                OnPropertyChanged();
            }
        }

        public string RoleName
        {
            get { return roleName; }
            private set
            {
                roleName = value;
                OnPropertyChanged();
            }
        }

        public DateTime StartTime
        {
            get { return startTime; }
            private set
            {
                startTime = value;
                OnPropertyChanged();
            }
        }

        public DateTime EndTime
        {
            get { return endTime; }
            private set
            {
                endTime = value;
                OnPropertyChanged();
            }
        }

        public string Notes
        {
            get { return notes; }
            private set
            {
                notes = value;
                OnPropertyChanged();
            }
        }

        public ShiftPopup ()
		{
			InitializeComponent ();
            BindingContext = this;
        }

        //public void 

        public void Show(string roleName, DateTime startTime, DateTime endTime, string notes = "")
        {
            RoleName = roleName;
            StartTime = startTime;
            EndTime = endTime;
            Notes = notes;
            IsOpen = true;
            //popupLayout.Show();
        }
    }
}