using MyListSelection.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyListSelection.ViewModels
{
    public class MyListPageViewModel
    {
        public ObservableCollection<MyListModel> FoodList { get; set; }
        public MyListPageViewModel()
        {
            FoodList = new ObservableCollection<MyListModel>();
            FoodList.Add(new MyListModel { Name = "Test1", Image = "https://bk-ca-prd.s3.amazonaws.com/sites/burgerking.ca/files/02750-2%20BK_Web_DblQtrPndKing_300x270px_CR_0.png",
                Detail = "This's our burger", Ingrediants = "This;s our detail page details to be listed" });
        }
    }
}
