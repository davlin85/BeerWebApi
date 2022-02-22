namespace BEER_WEB_API.Models.Input
{
    public class BeerInput
    {
        private string _articleNumber;
        private string _beerName;
        private decimal _vintage;
        private string _beerStyle;
        private decimal _price;
        private string _purchased;
        private string _bestBeforeDate;
        private decimal _alcolholContent;
        private decimal _bottleSize;
        private decimal _quantity;
        private string _brewery;
        private string _country;

        public string ArticleNumber
        {
            get { return _articleNumber; }
            set { _articleNumber = value.Trim(); }
        }

        public string BeerName
        {
            get { return _beerName; }
            set { _beerName = value.Trim(); }
        }

        public decimal Vintage
        {
            get { return _vintage; }
            set { _vintage = value; }
        }

        public string BeerStyle
        {
            get { return _beerStyle; }
            set { _beerStyle = value.Trim(); }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Purchased
        {
            get { return _purchased; }
            set { _purchased = value.Trim(); }
        }

        public string BestBeforeDate
        {
            get { return _bestBeforeDate; }
            set { _bestBeforeDate = value.Trim(); }
        }

        public decimal AlcoholContent
        {
            get { return _alcolholContent; }
            set { _alcolholContent = value; }
        }

        public decimal BottleSize
        {
            get { return _bottleSize; }
            set { _bottleSize = value; }
        }

        public decimal Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public string Brewery
        {
            get { return _brewery; }
            set { _brewery = value.Trim(); }
        }

        public string Country
        {
            get { return _country; }
            set { _country = value.Trim(); }
        }

    }
}
