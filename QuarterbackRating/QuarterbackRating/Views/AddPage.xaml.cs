using System;

using QuarterbackRating.ViewModels;

using Windows.UI.Xaml.Controls;

namespace QuarterbackRating.Views
{
    public sealed partial class AddPage : Page
    {
        public AddViewModel ViewModel { get; } = new AddViewModel();

        public AddPage()
        {
            InitializeComponent();
        }
    }
}
