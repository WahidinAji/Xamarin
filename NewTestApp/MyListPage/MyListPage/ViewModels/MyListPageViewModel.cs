using MyListPage.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyListPage.ViewModels
{
    public class MyListPageViewModel
    {
        public ObservableCollection<MyListPageModel> MyListCollector { get; set; }
        public MyListPageViewModel()
        {
            MyListCollector = new ObservableCollection<MyListPageModel>()
            {
                new MyListPageModel(){Id = 1, FoodName="Fresh Chicken Fresh", FoodDetail="Yummy yummi"},
                new MyListPageModel(){Id = 2, FoodName="Chicken Carry", FoodDetail="Rasa Ayam"},
                new MyListPageModel(){Id = 3, FoodName="Fresh Chicken Carry", FoodDetail="Ayam Segar"},
                new MyListPageModel(){Id = 4, FoodName="Chicken Step by Step", FoodDetail="Ayam Rasahmbayar"},
                new MyListPageModel(){Id = 5, FoodName="Chicken Mandala Fresh", FoodDetail="Ayam Yang Bikin Gemes"},
                new MyListPageModel(){Id = 6, FoodName="Fred Chicken Fresh", FoodDetail="Ayamnya Fred"},
                new MyListPageModel(){Id = 7, FoodName="Geprek Preksu", FoodDetail="Digeprek bukan di grepe"},
                new MyListPageModel(){Id = 8, FoodName="Geprek Bensu", FoodDetail="Bensunya di Geprek"},
                new MyListPageModel(){Id = 9, FoodName="Orak - Arik", FoodDetail="Ala Burjo"},
                new MyListPageModel(){Id = 10, FoodName="Magelangan", FoodDetail="Ala Jogja"},
                new MyListPageModel(){Id = 11, FoodName="Nasi Telor Ceplok", FoodDetail="Ada Telornya"},
                new MyListPageModel(){Id = 12, FoodName="Mie Dog-dog", FoodDetail="Gakada Anjinganya, loh kok ngegas"}
            };
        }
    }
}
