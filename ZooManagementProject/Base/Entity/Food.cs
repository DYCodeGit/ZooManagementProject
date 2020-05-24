using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagementProject.Base.Entity
{
    public abstract class Food : ViewModelBase
    {
        public double CaloriesPerGram { get; set; }

        
        //private TimeSpan _assimilationTime;
       

        private double _countGram;

        public string Name { get; set; }
        

        public double CountGram
        {
            get => _countGram;
            set
            {
                _countGram = value;
                RaisePropertyChanged(nameof(CountGram));
            }
        }


    }
}
