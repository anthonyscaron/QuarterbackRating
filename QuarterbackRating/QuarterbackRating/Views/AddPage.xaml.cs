using System;
using QuarterbackRating.Core.Models;
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

                GenerateQuarterback();

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
            var errorsExist = false;

            if (string.IsNullOrEmpty(name))
            {
                errorsExist = true;
                NameBoxLabel.Foreground = new SolidColorBrush(Colors.Red);
                NameError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null); ;
                NameError.Text = "- Name cannot be blank";
            }

            var attemptsIsNumber = Int32.TryParse(attempts, out int attemptsResult);
            // attemptsResult < 1, Need one attempt.
            if (string.IsNullOrEmpty(attempts) || !attemptsIsNumber || attemptsResult < 1)
            {
                errorsExist = true;
                AttemptsBoxLabel.Foreground = new SolidColorBrush(Colors.Red);

                if (string.IsNullOrEmpty(attempts))
                {
                    AttemptsError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                    AttemptsError.Text = "- Pass Attempts cannot be blank";
                }
                else if (!attemptsIsNumber)
                {
                    AttemptsError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                    AttemptsError.Text = "- Pass Attempts must be a number";
                }
                else if (attemptsResult < 1)
                {
                    AttemptsError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                    AttemptsError.Text = "- Pass Attempts cannot be less than 1";
                }
            }

            var completionsIsNumber = Int32.TryParse(completions, out int completionsResult);
            // completionsResult > attemptsResult, Can't have more completions than attempts.
            if (string.IsNullOrEmpty(completions) || !completionsIsNumber || completionsResult < 0 || completionsResult > attemptsResult)
            {
                errorsExist = true;
                CompletionsBoxLabel.Foreground = new SolidColorBrush(Colors.Red);

                if (string.IsNullOrEmpty(completions))
                {
                    CompletionsError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                    CompletionsError.Text = "- Pass Completions cannot be blank";
                }
                else if (!completionsIsNumber)
                {
                    CompletionsError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                    CompletionsError.Text = "- Pass Completions must be a number";
                }
                else if (completionsResult < 0)
                {
                    CompletionsError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                    CompletionsError.Text = "- Pass Completions cannot be less than 0";
                }
                else if (completionsResult > attemptsResult)
                {
                    CompletionsError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                    CompletionsError.Text = "- Pass Completions cannot be greater than Pass Attempts";
                }
            }

            var yardsIsNumber = Int32.TryParse(yards, out int yardsResult);
            var maxNegativeYards = completionsResult * -99;
            var maxPositiveYards = completionsResult * 99;
            // yardsResult < maxNegativeYards || yardsResult > maxPositiveYards, The max yards any pass can go for are
            // between -99 and 99 per completion depending on the specific field placement at the time of the completion.
            if (string.IsNullOrEmpty(yards) || !yardsIsNumber || yardsResult < maxNegativeYards || yardsResult > maxPositiveYards)
            {
                errorsExist = true;
                YardsBoxLabel.Foreground = new SolidColorBrush(Colors.Red);

                if (string.IsNullOrEmpty(yards))
                {
                    YardsError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                    YardsError.Text = "- Passing Yards cannot be blank";
                }
                else if (!yardsIsNumber)
                {
                    YardsError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                    YardsError.Text = "- Passing Yards must be a number";
                }
                else if (yardsResult < maxNegativeYards)
                {
                    YardsError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                    YardsError.Text = "- Passing Yards cannot be less than -99 yards per Pass Attempt";
                }
                else if (yardsResult > maxPositiveYards)
                {
                    YardsError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                    YardsError.Text = "- Passing Yards cannot be greater than 99 yards per Pass Attempt";
                }
            }

            var touchdownsIsNumber = Int32.TryParse(touchdowns, out int touchdownsResult);
            // touchdownsResult > completionsResult, Can't have more touchdowns than completions.
            // touchdownsResult > yardsResult, Can't have more touchdowns than yards because 1 touchdown would be for at least 1 yard.
            if (string.IsNullOrEmpty(touchdowns) || !touchdownsIsNumber || touchdownsResult < 0 || touchdownsResult > completionsResult || touchdownsResult > yardsResult)
            {
                errorsExist = true;
                TouchdownsBoxLabel.Foreground = new SolidColorBrush(Colors.Red);

                if (string.IsNullOrEmpty(touchdowns))
                {
                    TouchdownsError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                    TouchdownsError.Text = "- Passing Touchdowns cannot be blank";
                }
                else if (!touchdownsIsNumber)
                {
                    TouchdownsError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                    TouchdownsError.Text = "- Passing Touchdowns must be a number";
                }
                else if (touchdownsResult < 0)
                {
                    TouchdownsError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                    TouchdownsError.Text = "- Passing Touchdowns cannot be less than 0";
                }
                else if (touchdownsResult > completionsResult)
                {
                    TouchdownsError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                    TouchdownsError.Text = "- Passing Touchdowns cannot be greater than Pass Completions";
                }
                else if (touchdownsResult > yardsResult)
                {
                    TouchdownsError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                    TouchdownsError.Text = "- Passing Touchdowns cannot be greater than Passing Yards";
                }
            }

            var interceptionsIsNumber = Int32.TryParse(interceptions, out int interceptionsResult);
            var maxInterceptions = attemptsResult - completionsResult;
            // interceptionsResult > maxInterceptions, Can't have more interceptions than non-completion attempts.
            if (string.IsNullOrEmpty(interceptions) || !interceptionsIsNumber || interceptionsResult < 0 || interceptionsResult > maxInterceptions)
            {
                errorsExist = true;
                InterceptionsBoxLabel.Foreground = new SolidColorBrush(Colors.Red);

                if (string.IsNullOrEmpty(interceptions))
                {
                    InterceptionsError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                    InterceptionsError.Text = "- Interceptions cannot be blank";
                }
                else if (!interceptionsIsNumber)
                {
                    InterceptionsError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                    InterceptionsError.Text = "- Interceptions must be a number";
                }
                else if (interceptionsResult < 0)
                {
                    InterceptionsError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                    InterceptionsError.Text = "- Interceptions cannot be less than 0";
                }
                else if (interceptionsResult > maxInterceptions)
                {
                    InterceptionsError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
                    InterceptionsError.Text = "- Interceptions cannot be greater than Non-Completion Pass Attempts";
                }
            }

            if (errorsExist)
            {
                ErrorAlert.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(true, null, null, null);
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
            NameError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(false, null, null, null);
            AttemptsError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(false, null, null, null);
            CompletionsError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(false, null, null, null);
            YardsError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(false, null, null, null);
            TouchdownsError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(false, null, null, null);
            InterceptionsError.Visibility = (Windows.UI.Xaml.Visibility)ViewModel.Converter.Convert(false, null, null, null);

            NameError.Text = "";
            AttemptsError.Text = "";
            CompletionsError.Text = "";
            YardsError.Text = "";
            TouchdownsError.Text = "";
            InterceptionsError.Text = "";

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

        private void SaveButtonView_ItemClick(object sender, ItemClickEventArgs e)
        {
            ViewModel.Repository.Create(ViewModel.Quarterback);
            this.Frame.Navigate(typeof(QuarterbackPage));
        }

        private Quarterback GenerateQuarterback()
        {
            ViewModel.Quarterback.Name = NameBox.Text;
            ViewModel.Quarterback.PassAttempts = Int32.Parse(AttemptsBox.Text);
            ViewModel.Quarterback.PassCompletions = Int32.Parse(CompletionsBox.Text);
            ViewModel.Quarterback.PassingYards = Int32.Parse(YardsBox.Text);
            ViewModel.Quarterback.Touchdowns = Int32.Parse(TouchdownsBox.Text);
            ViewModel.Quarterback.Interceptions = Int32.Parse(InterceptionsBox.Text);

            return ViewModel.Quarterback;
        }
    }
}
