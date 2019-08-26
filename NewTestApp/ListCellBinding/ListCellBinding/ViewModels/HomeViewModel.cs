using ListCellBinding.Models;
using System;
using System.Collections.ObjectModel;

namespace ListCellBinding.ViewModels
{
    public class HomeViewModel
    {
        public ObservableCollection<HomeModel> MyHomeDetailsCollection { get; set; }

        public HomeViewModel()
        {
            MyHomeDetailsCollection = new ObservableCollection<HomeModel>()
            {
                new HomeModel(){id = 0, HomeName="Orchard", HomeDetails="Popular amongst literary dans as well as those of us lucky" },
                new HomeModel(){id = 1, HomeName="Meadow ", HomeDetails="if ur lucky enough to have stunning  views if Meadows"},
                new HomeModel(){id = 2, HomeName="Rose", HomeDetails="Giving the impression of an idyllic way of life."},
                new HomeModel(){id = 3, HomeName="Lilly", HomeDetails="Giving the impression of an idyllic way of life."},
                new HomeModel(){id = 4, HomeName="Demi", HomeDetails="Giving the impression of an idyllic way of life."},
                new HomeModel(){id = 5, HomeName="Test", HomeDetails="Giving the impression of an idyllic way of life."},
                new HomeModel(){id = 6, HomeName="Best", HomeDetails="Giving the impression of an idyllic way of life."},
                new HomeModel(){id = 7, HomeName="Rose", HomeDetails="Giving the impression of an idyllic way of life."},
            };
        }
    }
}
