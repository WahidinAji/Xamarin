using MyListPage.Models;
using MyListPage.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyListPage.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyListPage : ContentPage
	{
		public MyListPage ()
		{
			InitializeComponent ();
            BindingContext = new MyListPageViewModel();
		}

        async private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var myselecteditem = e.Item as MyListPageModel;
            switch (myselecteditem.Id)
            {
                case 1:
                    await Navigation.PushAsync(new List1());
                    break;
                case 2:
                    await Navigation.PushAsync(new List2());
                    break;
                case 3:
                    await Navigation.PushAsync(new List3());
                    break;
                case 4:
                    await Navigation.PushAsync(new List4());
                    break;
                case 5:
                    await Navigation.PushAsync(new List5());
                    break;
                case 6:
                    await Navigation.PushAsync(new List6());
                    break;
                case 7:
                    await Navigation.PushAsync(new List7());
                    break;
                case 8:
                    await Navigation.PushAsync(new List8());
                    break;
                case 9:
                    await Navigation.PushAsync(new List9());
                    break;
                case 10:
                    await Navigation.PushAsync(new List10());
                    break;
                case 11:
                    await Navigation.PushAsync(new List11());
                    break;
                case 12:
                    await Navigation.PushAsync(new List12());
                    break;
            }
            ((ListView)sender).SelectedItem = null;
        }
    }
}