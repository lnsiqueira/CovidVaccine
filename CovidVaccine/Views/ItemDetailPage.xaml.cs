﻿using CovidVaccine.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CovidVaccine.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}