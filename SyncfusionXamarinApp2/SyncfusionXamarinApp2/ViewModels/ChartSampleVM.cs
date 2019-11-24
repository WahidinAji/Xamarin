using SyncfusionXamarinApp2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SyncfusionXamarinApp2.ViewModels
{
    public class ChartSampleVM
    {
        public List<ChartSampleModel> Data { get; set; }
        public ChartSampleVM()
        {
            Data = new List<ChartSampleModel>()
            {
                new ChartSampleModel("Wahidin", 195),
                new ChartSampleModel("Aji", 175),
                new ChartSampleModel("John", 180),
                new ChartSampleModel("Michael", 150)
            };
        }
    }
}
