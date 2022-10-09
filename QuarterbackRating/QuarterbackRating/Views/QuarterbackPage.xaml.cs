using System;

using QuarterbackRating.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace QuarterbackRating.Views
{
    public sealed partial class QuarterbackPage : Page
    {
        public QuarterbackViewModel ViewModel { get; } = new QuarterbackViewModel();

        public QuarterbackPage()
        {
            InitializeComponent();
            Loaded += QuarterbackPage_Loaded;
        }

        private async void QuarterbackPage_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadDataAsync(ListDetailsViewControl.ViewState);
        }
    }
}
