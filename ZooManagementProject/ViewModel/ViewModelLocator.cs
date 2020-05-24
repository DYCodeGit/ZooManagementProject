/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:ZooManagementProject"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using System;
using ZooManagementProject.Base.Enum;
using System.Collections.Generic;
using System.Windows.Controls;
using ZooManagementProject.Infrastructure;
using GalaSoft.MvvmLight.Views;
using ZooManagementProject.View.UserControls;
//using Microsoft.Practices.ServiceLocation;

namespace ZooManagementProject.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {


        private static Dictionary<ControlType, Lazy<UserControl>> controls =
          new Dictionary<ControlType, Lazy<UserControl>>();

        public const string MainPage = "MainPage";
        public const string MenuPage = "MenuPage";
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            NavigationService navigationService = new NavigationService();
            SimpleIoc.Default.Register<INavigationService>(() => navigationService);


            navigationService.Configure(MainPage, new Uri("../View/Pages/MainPage.xaml", UriKind.Relative));
            navigationService.Configure(MenuPage, new Uri("../View/Pages/MenuPage.xaml", UriKind.Relative));
            //   ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);


            controls.Add(ControlType.AnimalList, new Lazy<UserControl>(() => new AnimalListUserControl()));
            controls.Add(ControlType.FeedAnimal, new Lazy<UserControl>(() => new FeedAnimalUserControl1()));
            controls.Add(ControlType.FoodList, new Lazy<UserControl>(() => new FoodsListUserControl1()));

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}

            SimpleIoc.Default.Register<MainViewModel>();
        }

        public MainViewModel Main
        {
            get
            {
                return SimpleIoc.Default.GetInstance<MainViewModel>();
            }
        }


        public static UserControl GetControl(ControlType controlType)
        {
            if (controls.ContainsKey(controlType))
            {
                return controls[controlType].Value;
            }

            return new UserControl();
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}