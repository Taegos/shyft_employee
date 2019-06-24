using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shyft.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoadingPage : ContentPage
	{
		private LoadingPage ()
		{
            InitializeComponent ();            
        }
        
        async public static Task<T> RunTask<T>(Task<T> task)
        {
            LoadingPage loadingPage = new LoadingPage();
            await Application.Current.MainPage.Navigation.PushModalAsync(loadingPage);
            T res = await task;
            await Application.Current.MainPage.Navigation.PopModalAsync();
            return res;
        }
	}
}