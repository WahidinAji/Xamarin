using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MyNewListView.ViewModels
{
    public class MyListViewModel
    {
        public List<string> MyListData { get; set; }
        public MyListViewModel()
        {
            MyListData = new List<string>()
            {
                "Learn",
                "Hard work",
                "Smart Work",
                "Praying",
                "Praying"

            };
        }
    }
}
