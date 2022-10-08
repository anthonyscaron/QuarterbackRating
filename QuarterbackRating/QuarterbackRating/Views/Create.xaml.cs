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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace QuarterbackRating.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Create : Page
    {
        private QuarterbackRepo repo = new QuarterbackRepo();
        
        public Create()
        {
            this.InitializeComponent();
        }

        private void CreateCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void CreateSave_Click(object sender, RoutedEventArgs e)
        {
            var quarterback = new Quarterback();
            quarterback.Name = Name.Text;
            quarterback.PassAttempts = Int32.Parse(PassAttempts.Text);
            quarterback.PassCompletions = Int32.Parse(PassCompletions.Text);
            quarterback.PassingYards = Int32.Parse(PassingYards.Text);
            quarterback.Touchdowns = Int32.Parse(Touchdowns.Text);
            quarterback.Interceptions = Int32.Parse(Interceptions.Text);

            repo.Create(quarterback);
            
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
