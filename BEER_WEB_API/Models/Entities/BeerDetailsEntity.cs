using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BEER_WEB_API.Models.Entities
{
    public class BeerDetailsEntity
    {
        public BeerDetailsEntity()
        {
            Beers = new HashSet<BeerEntity>();
        }

        public BeerDetailsEntity(string beerStyle, decimal alcoholContent, decimal bottleSize)
        {
            BeerStyle=beerStyle;
            AlcoholContent=alcoholContent;
            BottleSize=bottleSize;
        }

        [Key]
        public int Id { get; set; }

        [Required, Column(TypeName = "nvarchar(50)")]
        public string BeerStyle { get; set; }

        [Required, Column(TypeName = "decimal(4,1)")]
        public decimal AlcoholContent { get; set; }

        [Required, Column(TypeName = "decimal(3,0)")]
        public decimal BottleSize { get; set; }


        [Required]
        public int BreweriesId { get; set; }
        public virtual BreweryEntity Breweries { get; set; }


        public virtual ICollection<BeerEntity> Beers { get; set; }

    }
}
