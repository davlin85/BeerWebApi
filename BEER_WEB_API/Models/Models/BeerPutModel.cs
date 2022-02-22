namespace BEER_WEB_API.Models.Models
{
    public class BeerPutModel
    {
        public BeerPutModel()
        {

        }

        public int Id { get; set; }

        public string ArticleNumber { get; set; }

        public string BeerName { get; set; }

        public decimal Vintage { get; set; }

        public decimal Price { get; set; }

        public string Purchased { get; set; }

        public string BestBeforeDate { get; set; }

        public decimal Quantity { get; set; }

        public string BeerStyle { get; set; }

        public decimal AlcoholContent { get; set; }

        public decimal BottleSize { get; set; }

        public string Brewery { get; set; }

        public string Country { get; set; }
    }
}
