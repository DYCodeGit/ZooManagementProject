using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ZooManagementProject.Base.Entity;
using ZooManagementProject.Model.Entity.FoodEntity;
using ZooManagementProject.Base.Enum;
using ZooManagementProject.Model.Entity;
using ZooManagementProject.Model.Entity.AnimalEntity;
using ZooManagementProject.Helper;
using GalaSoft.MvvmLight.Command;
using System.Drawing;
using System.Windows.Media;

namespace ZooManagementProject.ViewModel
{
    public class MenuViewModel : ViewModelBase
    {
        private MainViewModel _mainViewModel;
        private UserControl _mainContent;
        private ObservableCollection<ViewContent> _elementMenu;
        private ViewContent _selectViewContent;

        private ObservableCollection<Food> _foods;
        private ObservableCollection<Animal> _animal;

        private ObservableCollection<Animal> _hungyAnumal;

        private SolidColorBrush _errorColor;
        private SolidColorBrush _notEnoughFood;

        public CountingCaloriesHelper CountingCaloriesHelper { get; set; }

        public MenuViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            Init();
            CountingCaloriesHelper = new CountingCaloriesHelper();

            ElementMenu = new ObservableCollection<ViewContent>()
            {
                new ViewContent()
                {
                    Name = "Список тварин",
                    ControlType = ControlType.AnimalList
                },
                new ViewContent()
                {
                    Name = "Кухня",
                    ControlType = ControlType.FoodList,

                },
                new ViewContent()
                {
                    Name = "Погодувати тварин",
                    ControlType = ControlType.FeedAnimal
                } 
            };

            ChangeTime = new RelayCommand(ConcvertTime);
            HungyAnumal = CountHungry();
            Feed = new RelayCommand(FeedAnimal);

            DateTime dateTime = DateTime.Now;
            Month = dateTime.Month.ToString();
            Day = dateTime.Day.ToString();
            Hour = dateTime.Hour.ToString();
            // MainContent = ViewModelLocator.GetControl(ControlType.AnimalList);

            ErrorColor = new SolidColorBrush(Colors.Transparent);
            NotEnoughFood = new SolidColorBrush(Colors.Transparent);
        }

        public RelayCommand Feed { get; }


        public UserControl MainContent
        {
            get => _mainContent;
            set
            {
                _mainContent = value;
                RaisePropertyChanged(nameof(MainContent));
            }
        }

        public SolidColorBrush ErrorColor
        {
            get => _errorColor;
            set
            {
                _errorColor = value;
                RaisePropertyChanged(nameof(ErrorColor));
            }
        }

        public ObservableCollection<ViewContent> ElementMenu
        {
            get => _elementMenu;
            set
            {
                _elementMenu = value;
                RaisePropertyChanged(nameof(ElementMenu));
            }
        }


        public ObservableCollection<Animal> HungyAnumal
        {
            get => _hungyAnumal;
            set
            {
                _hungyAnumal = CountHungry();
                RaisePropertyChanged(nameof(HungyAnumal));
            }
        }

        public ObservableCollection<Animal> CountHungry()
        {
            var i = new ObservableCollection<Animal>(Animals.Where(p => p.IsHungry));
            return i;
        }


        public ObservableCollection<Food> Foods
        {
            get => _foods;
            set
            {
                _foods = value;
                RaisePropertyChanged(nameof(Foods));
            }
        }

        public ObservableCollection<Animal> Animals
        {
            get => _animal;
            set
            {
                _animal = value;
                RaisePropertyChanged(nameof(Animals));
            }
        }

       public void Init()
        {
            _foods = new ObservableCollection<Food>();
            _animal = new ObservableCollection<Animal>();
            Random random = new Random(1000);
            Random randomAnimalType = new Random(3);

            for (int i = 0; i < 20; i++)
            {
                if(i % 2 == 0)
                {
                    _foods.Add(new Model.Entity.FoodEntity.Meat()
                    {
                        Name = $"Яловичина{i} ",
                        CountGram = i * random.Next(2, 100),
                        CaloriesPerGram = random.Next(2, 6)
                    });
                }
                else
                {
                    _foods.Add(new Model.Entity.FoodEntity.Corn()
                    {
                        Name = $"Кукурудза{i} ",
                        CountGram = i * random.Next(2, 100),
                        CaloriesPerGram = random.Next(2, 6)
                    });
                }
            }
            

            for (int i = 0; i < 20; i++)
            {
                switch (randomAnimalType.Next(3))
                {
                    case 1:
                        _animal.Add(new Falcon()
                        {
                            Name = $"Яструб {i}",
                            DayOfBith = new DateTime(random.Next(2015, 2020), random.Next(1,12), random.Next(1,28)),
                            IsHungry = true,
                            LastTimeAte = DateTime.Now,
                            TimeFeed = random.Next(1, 23),
                            Weight = random.Next(2, 10)
                        });
                        break;
                    case 2:
                        _animal.Add(new Lynx()
                        {
                            Name = $"Рись {i}",
                            DayOfBith = new DateTime(random.Next(2013, 2020), random.Next(1, 12), random.Next(1,28)),
                            IsHungry = true,
                            LastTimeAte = DateTime.Now,
                            TimeFeed = random.Next(1, 23),
                            Weight = random.Next(2, 20)
                        });
                        break;
                    default:
                        _animal.Add(new Trout()
                        {
                            Name = $"Форель {i}",
                            DayOfBith = new DateTime(random.Next(2013, 2020), random.Next(1,12), random.Next(1, 28)),
                            IsHungry = true,
                            LastTimeAte = DateTime.Now,
                            TimeFeed = random.Next(1, 23),
                            Weight = random.Next(0, 5)
                        });
                        break;
                }
            }
        }


        public void FeedAnimal()
        {
            foreach(var animal in _animal)
            {
                if (animal.IsHungry)
                {
                    if(animal is BirdsAnimalType)
                    {
                        GetFood(FoodType.AnimalOrigin, animal);
                    }
                    else if(animal is FishesAnimalType)
                    {
                        GetFood(FoodType.VegetableOrigin, animal);
                    }
                    else if(animal is MammalsAnimalType)
                    {
                        GetFood(FoodType.AnimalOrigin, animal);
                    }
                }
            }


            HungyAnumal = CountHungry();
        }


        public void GetFood(FoodType type, Animal animal)
        {
            if(type == FoodType.AnimalOrigin)
            {
                foreach(var food in _foods)
                {
                    if(food is AnimalOriginFood)
                    {
                        var calories = CountingCaloriesHelper.GetCalories(animal);
                        double allCalories = food.CountGram * food.CaloriesPerGram;

                        if(allCalories > calories)
                        {
                            food.CountGram -= calories / food.CaloriesPerGram;   // годую

                            Animals.FirstOrDefault(p => p.Name == animal.Name).IsHungry = false;
                            Animals.FirstOrDefault(p => p.Name == animal.Name).LastTimeAte = DateTime.Now;

                            return;
                        }
                    }
                }
            }
            else
            {
                foreach (var food in _foods)
                {
                    if (food is  VegetableOriginFood)
                    {
                        var calories = CountingCaloriesHelper.GetCalories(animal);
                        double allCalories = food.CountGram * food.CaloriesPerGram;

                        if (allCalories > calories)
                        {
                            food.CountGram -= calories / food.CaloriesPerGram;   // годую

                            Animals.FirstOrDefault(p => p.Name == animal.Name).IsHungry = false;
                            Animals.FirstOrDefault(p => p.Name == animal.Name).LastTimeAte = DateTime.Now;

                            //Animal animals = Animals.FirstOrDefault(p => p.Name == animal.Name);
                            //animals.IsHungry = true;

                            //animal.LastTimeAte = DateTime.Now;

                            //Animals.FirstOrDefault(p => p.Name == animal.Name).IsHungry = false;

                            return;
                        }


                    }
                }
            }
            NotEnoughFood = new SolidColorBrush(Colors.Red);

        }

        public SolidColorBrush NotEnoughFood
        {
            get => _notEnoughFood;
            set
            {
                _notEnoughFood = value;
                RaisePropertyChanged(nameof(NotEnoughFood));
            }
        }

        public ViewContent SelectViewContent
        {
            get => _selectViewContent;
            set
            {
                _selectViewContent = value;
                MainContent = ViewModelLocator.GetControl(_selectViewContent.ControlType);
                RaisePropertyChanged(nameof(SelectViewContent));
            }
        }


        private string _month;
        private string _day;
        private string _hour;


        public string Month
        {
            get => _month;
            set
            {
                _month = value;
              //  ConcvertTime();
                RaisePropertyChanged(nameof(Month));
            }
        }

        public string Day
        {
            get => _day;
            set
            {
                _day = value;
              //  ConcvertTime();
                RaisePropertyChanged(nameof(Day));
            }
        }

        public string Hour
        {
            get => _hour;
            set
            {
                _hour = value;
                //ConcvertTime();
                RaisePropertyChanged(nameof(Hour));
            }
        }

        public RelayCommand ChangeTime { get; }


        public void ConcvertTime()
        {
            try
            {
                int month = Convert.ToInt32(Month);
                int day = Convert.ToInt32(Day);
                int hour = Convert.ToInt32(Hour);

                DateTime dateTime = new DateTime(2020, month, day, hour, 0, 0);


                TimeSpan isHung = new TimeSpan();
                int h;
                foreach (var animal in Animals)
                {
                    isHung = dateTime - animal.LastTimeAte;
                    h = (dateTime - animal.LastTimeAte).Hours;

                    if ((dateTime - animal.LastTimeAte).Hours > animal.TimeFeed)
                    {
                        animal.IsHungry = true;
                    }
                }

                HungyAnumal = CountHungry();
                ErrorColor = new SolidColorBrush(Colors.Transparent);
            }
            catch(Exception ex)
            {
                ErrorColor = new SolidColorBrush(Colors.Red);
            }

        }

    }
}
