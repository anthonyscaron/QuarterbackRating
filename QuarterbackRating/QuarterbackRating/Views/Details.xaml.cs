using QuarterbackRating.Data;
using QuarterbackRating.Models;
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
    public sealed partial class Details : Page
    {
        private Quarterback Quarterback = new Quarterback();
        private QuarterbackRepo repo = new QuarterbackRepo();

        public Details()
        {
            this.InitializeComponent();
            this.DataContext = Quarterback;
        }

        private void DetailsBack_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var parameter = (string)e.Parameter;
            var id = Int32.Parse(parameter);
            Quarterback = repo.ReadbyId(id);
        }
    }
}
