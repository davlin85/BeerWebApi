namespace BEER_WEB_API.Models.Models
{
    public class BeerModel
    {
        public BeerModel()
        {

        }

        public BeerModel(int id, string articleNumber, string beerName, decimal vintage, decimal price, string purchased, string bestBeforeDate, decimal quantity, BeerDetailsModel beersDetails)
        {
            Id=id;
            ArticleNumber=articleNumber;
            BeerName=beerName;
            Vintage=vintage;
            Price=price;
            Purchased=purchased;
            BestBeforeDate=bestBeforeDate;
            Quantity=quantity;
            BeersDetails=beersDetails;
        }


        public int Id { get; set; }

        public string ArticleNumber { get; set; }

        public string BeerName { get; set; }

        public decimal Vintage { get; set; }

        public decimal Price { get; set; }

        public string Purchased { get; set; }

        public string BestBeforeDate { get; set; }

        public decimal Quantity { get; set; }

        public BeerDetailsModel BeersDetails { get; set; }

    }
}
