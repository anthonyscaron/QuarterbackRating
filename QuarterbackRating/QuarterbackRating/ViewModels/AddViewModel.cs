using System;
using System.Collections.Generic;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using QuarterbackRating.Core.Models;
using QuarterbackRating.Core.Services;

namespace QuarterbackRating.ViewModels
{
    public class AddViewModel : ObservableObject
    {
        public Quarterback Quarterback = new Quarterback();
        public RatingCalculator Calculator = new RatingCalculator();
        public QuarterbackRepository Repository = new QuarterbackRepository();
        public BooleanToVisibilityConverter Converter = new BooleanToVisibilityConverter();

        public AddViewModel()
        {
        }
    }
}
