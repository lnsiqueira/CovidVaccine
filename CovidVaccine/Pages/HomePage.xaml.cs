using CovidVaccine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CovidVaccine.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentView
    {
        public HomePage()
        {
            BindingContext = this;
            InitializeComponent();
        }

        public List<Countries> Countries { get; set; } = App.Model.Countries.Take(5).OrderByDescending(o => o.peopleVaccinated).ToList();

        public List<Countries> PopularCountries
        {
            get
            {
                var rand = new Random();
                var randomList = App.Model.Countries.OrderBy(x => rand.Next()).ToList();
                return randomList.Take(5).ToList();
            }
        }
    }
}