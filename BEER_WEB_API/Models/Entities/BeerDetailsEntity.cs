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

        public BeerDetailsEntity(string beerStyle, decimal bottleSize)
        {
            BeerStyle=beerStyle;
            BottleSize=bottleSize;
        }

        [Key]
        public int Id { get; set; }

        [Required, Column(TypeName = "nvarchar(50)")]
        public string BeerStyle { get; set; }

        [Required, Column(TypeName = "decimal(3,0)")]
        public decimal BottleSize { get; set; }


        public virtual ICollection<BeerEntity> Beers { get; set; }

    }
}
