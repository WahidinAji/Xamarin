using System;
using System.Collections.Generic;
using System.Text;

namespace SyncfusionXamarinApp2.Models
{
    public class ChartSampleModel
    {
        public string Name { get; set; }

        public double Height { get; set; }

        public ChartSampleModel(string name, double height)
        {
            this.Name = name;
            this.Height = height;
        }
    }
}
