using MvvmHelpers;
using Xamarin.Forms;

namespace CovidVaccine.Models
{
    public class Countries : BaseViewModel
    { 
        public string Name { get; set; }
        
        public string ProductImage { get; set; }
        public LinearGradientBrush Gradient { get; set; }

        public string country { get; set; }
        public string countryISO { get; set; }
        public string date { get; set; }
        public long totalDoses { get; set; }
        public long? peopleVaccinated { get; set; }
        public long? peopleFullyVaccinated { get; set; }
        public string vaccineName { get; set; }
        public string perPop { get; set; }
        public long population { get; set; }
    }
}
