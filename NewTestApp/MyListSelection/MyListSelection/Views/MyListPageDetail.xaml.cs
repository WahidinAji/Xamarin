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
	public partial class MyListPageDetail : ContentPage
	{
		public MyListPageDetail (string Name, string Ingrediants, string source)
		{
			InitializeComponent ();
            MyItemNameShow.Text = Name;
            MyIngrediantsItemShow.Text = Ingrediants;
            MyImageCell.Source = new UriImageSource()
            {
                Uri = new Uri(source)
            };
		}
	}
}