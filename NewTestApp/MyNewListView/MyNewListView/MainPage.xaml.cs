using MyNewListView.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyNewListView
{
    public partial class MainPage : ContentPage
    {
       // public List<string> MyListData { get; set; }
        public MainPage()
        {
          // MyListData = new List<string>()
          // {
          //     "Learn",
          //     "Hard work",
          //     "Smart Work",
          //     "Praying",
          //     "Praying"
          //
          // };
            InitializeComponent();
            BindingContext = new MyListViewModel();
          //  MyList.ItemSource = MyListData;
        }
    }
}
