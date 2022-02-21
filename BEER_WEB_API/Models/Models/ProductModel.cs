namespace BEER_WEB_API.Models.Models
{
    public class ProductModel
    {
        public ProductModel()
        {

        }

        public ProductModel(string brewery, string beerStyle, string country)
        {
            Brewery=brewery;
            BeerStyle=beerStyle;
            Country=country;
        }

        public string Brewery { get; set; }

        public string BeerStyle { get; set; }

        public string Country { get; set; }

    }
}
