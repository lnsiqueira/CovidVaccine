using System.Collections.Generic;
using System.Collections.ObjectModel;
using MvvmHelpers;
using System.Net.Http;
using System;
using RestSharp;

namespace CovidVaccine.Models
{
    public class AppModel : BaseViewModel
    {
        private ObservableCollection<Countries> cart = new ObservableCollection<Countries>();
        private Countries selectedCountries;
        public AppModel()
        {
            var response = GetInfo();     
        }
 
        public ObservableCollection<Countries> Cart
        {
            get { return cart; }
            set
            {
                SetProperty(ref cart, value);
            }
        }

        public decimal perc { get; set; }

        public Countries SelectedCountries
        {
            get => selectedCountries;
            set
            {
                SetProperty(ref selectedCountries, value);
            }
        }

        public List<Countries> Countries { get; set; } = new List<Countries>();
        private IRestResponse GetInfo()
        {
            try
            {
                var httpClient = new HttpClient();    
                var client = new RestClient("http://graphics.thomsonreuters.com/");
                var request = new RestRequest("data/2020/coronavirus/owid-covid-vaccinations/latest-perpop-data-all.json", Method.GET);
                var queryResult = client.Execute<List<Countries>>(request).Data;               

                foreach (var item in queryResult)
                {
                    switch (item.country)
                    {
                        case "Israel":
                          perc = (Convert.ToDecimal(item.perPop));
                            perc = perc / 10000000m;

                            Countries.Add(new Countries
                            {
                                country = item.country,
                                ProductImage = "Israel.png",
                                peopleFullyVaccinated = item.peopleFullyVaccinated,
                                peopleVaccinated = item.peopleVaccinated,
                                perPop = perc.ToString("0.0%"),
                                population = item.population,
                                vaccineName = item.vaccineName
                            });
                            break;
                        case "Brazil":
                            perc = (Convert.ToDecimal(item.perPop));
                            perc = perc / 10000000m;

                            Countries.Add(new Countries
                            {
                                country = item.country,
                                ProductImage = "Brazil2.png",
                                peopleFullyVaccinated = item.peopleFullyVaccinated,
                                peopleVaccinated = item.peopleVaccinated,
                                perPop = perc.ToString("0.0%"),
                                population = item.population,
                                vaccineName = item.vaccineName
                            });
                            break;
                        case "Italy":
                            perc = (Convert.ToDecimal(item.perPop));
                            perc = perc / 10000000m;

                            Countries.Add(new Countries
                            {
                                country = item.country,
                                ProductImage = "Italy.png",
                                peopleFullyVaccinated = item.peopleFullyVaccinated,
                                peopleVaccinated = item.peopleVaccinated,
                                perPop = perc.ToString("0.0%"),
                                population = item.population,
                                vaccineName = item.vaccineName
                            });
                            break;
                        case "United States":
                            perc = (Convert.ToDecimal(item.perPop));
                            perc = perc / 10000000m;

                            Countries.Add(new Countries
                            {
                                country = item.country,
                                ProductImage = "Usa.png",
                                peopleFullyVaccinated = item.peopleFullyVaccinated,
                                peopleVaccinated = item.peopleVaccinated,
                                perPop = perc.ToString("0.0%"),
                                population = item.population,
                                vaccineName = item.vaccineName
                            });
                            break;
                        case "United Kingdom":
                            perc = (Convert.ToDecimal(item.perPop));
                            perc = perc / 10000000m;

                            Countries.Add(new Countries
                            {
                                country = item.country,
                                ProductImage = "England.png",
                                peopleFullyVaccinated = item.peopleFullyVaccinated,
                                peopleVaccinated = item.peopleVaccinated,
                                perPop = perc.ToString("0.0%"),
                                population = item.population,
                                vaccineName = item.vaccineName
                            });
                            break;

                        default:
                            break;
                    }

                }
                return client.Execute(request);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }

}
