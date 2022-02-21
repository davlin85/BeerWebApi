using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BEER_WEB_API.Models.Entities
{
    public class ProductEntity
    {

        public ProductEntity()
        {
            Beers = new HashSet<BeerEntity>();
        }

        public ProductEntity(string brewery, string beerStyle, string country)
        {
            Brewery=brewery;
            BeerStyle=beerStyle;
            Country=country;
        }

        [Key]
        public int Id { get; set; }

        [Required, Column(TypeName = "nvarchar(50)")]
        public string Brewery { get; set; }

        [Required, Column(TypeName = "nvarchar(50)")]
        public string BeerStyle { get; set; }

        [Required, Column(TypeName = "nvarchar(50)")]
        public string Country { get; set; }


        public virtual ICollection<BeerEntity> Beers { get; set; }

    }

}
 