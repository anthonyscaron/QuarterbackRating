﻿using System;
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
            ResetFormStyle();
            ToggleConfirmationAndSave(false);

            var errorsExist = UserInputValidation(NameBox.Text, AttemptsBox.Text, CompletionsBox.Text, YardsBox.Text, TouchdownsBox.Text, InterceptionsBox.Text);

            if (!errorsExist)
            {
                ErrorAlert.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(false, null, null, null);

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

                ToggleConfirmationAndSave(true);
            }        
        }

        private bool UserInputValidation(string name, string attempts, string completions, string yards, string touchdowns, string interceptions)
        {
            RatingBox.Foreground = new SolidColorBrush(Colors.White);
            RatingBox.Text = "PENDING";

            var errorsExist = false;

            if (string.IsNullOrEmpty(name))
            {
                errorsExist = true;
                ErrorAlert.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                NameBoxLabel.Foreground = new SolidColorBrush(Colors.Red);
            }

            var attemptsIsNumber = Int32.TryParse(attempts, out int attemptsResult);

            if (string.IsNullOrEmpty(attempts) || !attemptsIsNumber || attemptsResult < 1)
            {
                errorsExist = true;
                ErrorAlert.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                AttemptsBoxLabel.Foreground = new SolidColorBrush(Colors.Red);
            }

            var completionsIsNumber = Int32.TryParse(completions, out int completionsResult);

            if (string.IsNullOrEmpty(completions) || !completionsIsNumber || completionsResult < 0)
            {
                errorsExist = true;
                ErrorAlert.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                CompletionsBoxLabel.Foreground = new SolidColorBrush(Colors.Red);
            }

            var yardsIsNumber = Int32.TryParse(yards, out int yardsResult);

            if (string.IsNullOrEmpty(yards) || !yardsIsNumber || yardsResult < 0)
            {
                errorsExist = true;
                ErrorAlert.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                YardsBoxLabel.Foreground = new SolidColorBrush(Colors.Red);
            }

            var touchdownsIsNumber = Int32.TryParse(touchdowns, out int touchdownsResult);

            if (string.IsNullOrEmpty(touchdowns) || !touchdownsIsNumber || touchdownsResult < 0)
            {
                errorsExist = true;
                ErrorAlert.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                TouchdownsBoxLabel.Foreground = new SolidColorBrush(Colors.Red);
            }

            var interceptionsIsNumber = Int32.TryParse(interceptions, out int interceptionsResult);

            if (string.IsNullOrEmpty(interceptions) || !interceptionsIsNumber || interceptionsResult < 0)
            {
                errorsExist = true;
                ErrorAlert.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                InterceptionsBoxLabel.Foreground = new SolidColorBrush(Colors.Red);
            }

            return errorsExist;
        }

        private void ToggleConfirmationAndSave(bool desiredVisibility)
        {
            RatingConfirmationIcon.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(desiredVisibility, null, null, null);
            RatingConfirmation.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(desiredVisibility, null, null, null);
            SaveButtonIcon.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(desiredVisibility, null, null, null);
            SaveButton.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(desiredVisibility, null, null, null);
        }

        private void ResetFormStyle()
        {
            ErrorAlert.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(false, null, null, null);

            var originalColor = new SolidColorBrush(Colors.White);
            NameBoxLabel.Foreground = originalColor;
            AttemptsBoxLabel.Foreground = originalColor;
            CompletionsBoxLabel.Foreground = originalColor;
            YardsBoxLabel.Foreground = originalColor;
            TouchdownsBoxLabel.Foreground = originalColor;
            InterceptionsBoxLabel.Foreground = originalColor;
            RatingBox.Foreground = originalColor;
            RatingBox.Text = "PENDING";
            RatingConfirmationBox.Text = "";
        }
    }
}
