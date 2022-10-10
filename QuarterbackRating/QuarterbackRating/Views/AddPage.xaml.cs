using System;
using QuarterbackRating.Core.Services;
using QuarterbackRating.ViewModels;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace QuarterbackRating.Views
{
    public sealed partial class AddPage : Page
    {
        public AddViewModel ViewModel { get; } = new AddViewModel();

        public AddPage()
        {
            InitializeComponent();
        }

        private void CalculateButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            var errorsExist = UserInputValidation(NameBox.Text, AttemptsBox.Text, CompletionsBox.Text, YardsBox.Text, TouchdownsBox.Text, InterceptionsBox.Text);

            if (!errorsExist)
            {
                ErrorAlert.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(false, null, null, null);
                NameBoxLabel.Foreground = new SolidColorBrush(Colors.White);

                ViewModel.Quarterback.Name = NameBox.Text;
                ViewModel.Quarterback.PassAttempts = Int32.Parse(AttemptsBox.Text);
                ViewModel.Quarterback.PassCompletions = Int32.Parse(CompletionsBox.Text);
                ViewModel.Quarterback.PassingYards = Int32.Parse(YardsBox.Text);
                ViewModel.Quarterback.Touchdowns = Int32.Parse(TouchdownsBox.Text);
                ViewModel.Quarterback.Interceptions = Int32.Parse(InterceptionsBox.Text);

                var checkRating = ViewModel.Calculator.CalculateRating(ViewModel.Quarterback);
                RatingBox.Foreground = new SolidColorBrush(Colors.LightGreen);
                RatingBox.Text = checkRating.ToString();
                var checkString = ViewModel.Quarterback.Name + "'s QB Rating is: " + checkRating;
                RatingConfirmationBox.Text = checkString;

                RatingConfirmationIcon.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                RatingConfirmation.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                SaveButtonIcon.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                SaveButton.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
            }        
        }

        private bool UserInputValidation(string name, string attempts, string completions, string yards, string touchdowns, string interceptions)
        {
            var errorsExist = false;

            if (string.IsNullOrEmpty(name))
            {
                errorsExist = true;
                ErrorAlert.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                NameBoxLabel.Foreground = new SolidColorBrush(Colors.Red);
            }

            return errorsExist;
        }
    }
}
