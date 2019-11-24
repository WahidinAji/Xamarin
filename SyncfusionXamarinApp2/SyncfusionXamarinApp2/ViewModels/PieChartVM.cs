using SyncfusionXamarinApp2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SyncfusionXamarinApp2.ViewModels
{
    public class PieChartVM
    {
        ObservableCollection<PieChartModels> Data { get; set; }
        public PieChartVM()
        {
            Data = new ObservableCollection<PieChartModels>();
            FillData();
        }
        private void FillData()
        {
            PieChartModels obj = new PieChartModels()
            {
                Name = "libro 1",
                Quantity = 23
            };
            Data.Add(obj);

            PieChartModels obj2 = new PieChartModels()
            {
                Name = "libro 2",
                Quantity = 12
            };
            Data.Add(obj2);

            PieChartModels obj3 = new PieChartModels()
            {
                Name = "libro 3",
                Quantity = 4
            };
            Data.Add(obj3);
        }
    }
}
