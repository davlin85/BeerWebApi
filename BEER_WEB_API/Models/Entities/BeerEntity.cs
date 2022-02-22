using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BEER_WEB_API.Models.Entities
{
    public class BeerEntity
    {
        public BeerEntity()
        {

        }

        public BeerEntity(string articleNumber, string beerName, decimal vintage, string beerStyle, decimal price, string purchased, string bestBeforeDate, decimal alcoholContent, decimal bottleSize, decimal quantity)
        {
            ArticleNumber=articleNumber;
            BeerName=beerName;
            Vintage=vintage;
            BeerStyle=beerStyle;
            Price=price;
            Purchased=purchased;
            BestBeforeDate=bestBeforeDate;
            AlcoholContent=alcoholContent;
            BottleSize=bottleSize;
            Quantity=quantity;
        }

        [Key]
        public int Id { get; set; }

        [Required, Column(TypeName="nvarchar(50)")]
        public string ArticleNumber { get; set; }

        [Required, Column(TypeName = "nvarchar(50)")]
        public string BeerName { get; set; }

        [Required, Column(TypeName = "decimal(4,0)")]
        public decimal Vintage { get; set; }

        [Required, Column(TypeName = "nvarchar(50)")]
        public string BeerStyle { get; set; }

        [Required, Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }

        [Required, Column(TypeName = "nvarchar(50)")]
        public string Purchased { get; set; }

        [Required, Column(TypeName = "nvarchar(50)")]
        public string BestBeforeDate { get; set; }

        [Required, Column(TypeName = "decimal(4,1)")]
        public decimal AlcoholContent { get; set; }

        [Required, Column(TypeName = "decimal(3,0)")]
        public decimal BottleSize { get; set; }

        [Required, Column(TypeName = "decimal(3,0)")]
        public decimal Quantity { get; set; }


        [Required]
        public int BreweriesId { get; set; }
        public virtual BreweryEntity Breweries { get; set; }

    }

}
