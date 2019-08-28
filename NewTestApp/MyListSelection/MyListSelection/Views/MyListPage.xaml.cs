using MyListSelection.Models;
using MyListSelection.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyListSelection.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyListPage : ContentPage
	{
		public MyListPage ()
		{
			InitializeComponent ();
            BindingContext = new MyListPageViewModel();
		}
        
        private async void OnItemSelected(object sender, ItemTappedEventArgs e)
        {
            var mydetails = e.Item as MyListModel;
            await Navigation.PushAsync(new MyListPageDetail(mydetails.Name, mydetails.Ingrediants, mydetails.Image));
        }
	}
}