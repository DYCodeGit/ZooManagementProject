using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;

namespace ZooManagementProject.Infrastructure
{
    public class NavigationService : ViewModelBase, INavigationService
    {
        private readonly Dictionary<string, Uri> _pagesByKey;
        private readonly List<string> _historic;
        private string _currentPageKey;


        public void NavigateTo(string pageKey)
        {
            NavigateTo(pageKey, null);
        }

        public void NavigateTo(string pageKey, object parameter)
        {
            lock (_pagesByKey)
            {

                if (string.IsNullOrEmpty(pageKey))
                {
                    return;
                }
                if (!_pagesByKey.ContainsKey(pageKey))
                    return;
                // throw new ArgumentException(string.Format("No such page: {0} ", pageKey), "pageKey");

                if (GetDescendantFromName(System.Windows.Application.Current.MainWindow, "MainFrame") is Frame frame) frame.Source = _pagesByKey[pageKey];
                Parameter = parameter;
                _historic.Add(pageKey);
                CurrentPageKey = pageKey;
            }
        }


        private FrameworkElement GetDescendantFromName(DependencyObject parent, string name)
        {
            var count = VisualTreeHelper.GetChildrenCount(parent);

            if (count < 1) return null;

            for (var i = 0; i < count; i++)
            {
                if (VisualTreeHelper.GetChild(parent, i) is FrameworkElement frameworkElement)
                {
                    if (frameworkElement.Name == name) return frameworkElement;

                    frameworkElement = GetDescendantFromName(frameworkElement, name);
                    if (frameworkElement != null) return frameworkElement;
                }
            }
            return null;
        }




        public string CurrentPageKey
        {
            get => _currentPageKey;

            private set
            {
                if (_currentPageKey == value) return;

                _currentPageKey = value;
                RaisePropertyChanged("CurrentPageKey");
            }
        }


        public object Parameter { get; private set; }
        public NavigationService()
        {
            _pagesByKey = new Dictionary<string, Uri>();
            _historic = new List<string>();
        }
        public void Configure(string key, Uri pageType)
        {
            lock (_pagesByKey)
            {
                if (_pagesByKey.ContainsKey(key))
                    _pagesByKey[key] = pageType;
                else
                    _pagesByKey.Add(key, pageType);
            }
        }

        public void GoBack()
        {
            if (_historic.Count > 1)
            {
                _historic.RemoveAt(_historic.Count - 1);
                NavigateTo(_historic.Last(), null);
            }
        }

    }
}
