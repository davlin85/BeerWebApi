namespace BEER_WEB_API.Models.Models
{
    public class BreweyModel
    {
        public BreweyModel()
        {

        }

        public BreweyModel(string brewery, string country)
        {
            Brewery=brewery;
            Country=country;
        }

        public string Brewery { get; set; }

        public string Country { get; set; }

    }
}
