using System;

using QuarterbackRating.Core.Models;

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
    }
}
