namespace BEER_WEB_API.Models.Models
{
    public class BeerDetailsModel
    {
        public BeerDetailsModel()
        {

        }

        public BeerDetailsModel(string beerStyle, decimal bottleSize, BreweyModel breweries)
        {
            BeerStyle=beerStyle;
            BottleSize=bottleSize;
            Breweries=breweries;
        }

        public string BeerStyle { get; set; }

        public decimal BottleSize { get; set; }


        public BreweyModel Breweries { get; set; }
    }
}
