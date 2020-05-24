using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManagementProject.Base.Enum;

namespace ZooManagementProject.Base.Entity
{
   public abstract class Animal : ViewModelBase
    {

        private string _name;
        private DateTime _dayOfBith;
        private double _weight;
       
        private DateTime _lastTimeAte;
        private bool _isHungry;



        public int TimeFeed { get; set; }


        public bool IsHungry
        {
            get => _isHungry;
            set
            {
                _isHungry = value;
                RaisePropertyChanged(nameof(IsHungry));
            }
        }

        public DateTime LastTimeAte
        {
            get => _lastTimeAte;
            set
            {
                _lastTimeAte = value;
                RaisePropertyChanged(nameof(LastTimeAte));
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }

        public DateTime DayOfBith
        {
            get => _dayOfBith;
            set
            {
                _dayOfBith = value;
                RaisePropertyChanged(nameof(DayOfBith));
            }
        }


        public double Weight
        {
            get => _weight;
            set
            {
                _weight = value;
                RaisePropertyChanged(nameof(Weight));
            }
        }
    }
}
