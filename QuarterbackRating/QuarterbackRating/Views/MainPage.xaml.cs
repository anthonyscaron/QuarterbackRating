using QuarterbackRating.Data;
using QuarterbackRating.Models;
using QuarterbackRating.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace QuarterbackRating.Views
{
    public sealed partial class MainPage : Page
    {
        private List<Quarterback> Quarterbacks;
        private QuarterbackRepo repo = new QuarterbackRepo();
        
        public MainPage()
        {
            this.InitializeComponent();
            Quarterbacks = repo.ReadAll();
        }

        private void DetailsForward_Click(object sender, RoutedEventArgs e)
        {
            var parameter = (sender as Button).Name;
            this.Frame.Navigate(typeof(Details), parameter);
        }

        private void CreateForward_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Create));
        }
    }
}
