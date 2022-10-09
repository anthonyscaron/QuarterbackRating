using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Uwp.UI.Controls;

using QuarterbackRating.Core.Models;
using QuarterbackRating.Core.Services;

namespace QuarterbackRating.ViewModels
{
    public class QuarterbackViewModel : ObservableObject
    {
        private Quarterback _selected;

        public Quarterback Selected
        {
            get { return _selected; }
            set { SetProperty(ref _selected, value); }
        }

        public ObservableCollection<Quarterback> Quarterbacks { get; private set; } = new ObservableCollection<Quarterback>();

        public QuarterbackViewModel()
        {
        }

        public async Task LoadDataAsync(ListDetailsViewState viewState)
        {
            Quarterbacks.Clear();

            var quarterbackData = await QuarterbackRepository.GetDataAsync();

            foreach (var quarterback in quarterbackData)
            {
                Quarterbacks.Add(quarterback);
            }

            if (viewState == ListDetailsViewState.Both)
            {
                Selected = Quarterbacks.First();
            }
        }
    }
}
