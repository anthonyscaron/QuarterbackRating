using System;

using QuarterbackRating.Core.Models;
using QuarterbackRating.Core.Services;
using QuarterbackRating.Services;
using QuarterbackRating.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace QuarterbackRating.Views
{
    public sealed partial class QuarterbackDetailControl : UserControl
    {
        public Quarterback ListMenuItem
        {
            get { return GetValue(ListMenuItemProperty) as Quarterback; }
            set { SetValue(ListMenuItemProperty, value); }
        }

        public static readonly DependencyProperty ListMenuItemProperty = DependencyProperty.Register("ListMenuItem", typeof(Quarterback), typeof(QuarterbackDetailControl), new PropertyMetadata(null, OnListMenuItemPropertyChanged));

        public QuarterbackDetailControl()
        {
            InitializeComponent();
        }

        private static void OnListMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as QuarterbackDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }

        private void DeleteButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            Quarterback quarterback = new Quarterback();
            quarterback.Id = Int32.Parse(IdBox.Text);
            quarterback.Name = NameBox.Text;
            quarterback.Rating = Decimal.Parse(RatingBox.Text);
            quarterback.PassAttempts = Int32.Parse(AttemptsBox.Text);
            quarterback.PassCompletions = Int32.Parse(CompletionsBox.Text);
            quarterback.PassingYards = Int32.Parse(YardsBox.Text);
            quarterback.Touchdowns = Int32.Parse(TouchdownsBox.Text);
            quarterback.Interceptions = Int32.Parse(InterceptionsBox.Text);

            QuarterbackRepository repo = new QuarterbackRepository();
            repo.Delete(quarterback);

            var frame = NavigationService.Frame;
            frame.Navigate(typeof(Views.QuarterbackPage));
        }
    }
}
