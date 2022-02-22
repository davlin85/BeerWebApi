using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BEER_WEB_API.Models.Entities
{
    public class BreweryEntity
    {
        public BreweryEntity()
        {
            BeersDetails = new HashSet<BeerDetailsEntity>();
        }

        public BreweryEntity(string brewery, string country)
        {
            Brewery=brewery;
            Country=country;
        }

        [Key]
        public int Id { get; set; }

        [Required, Column(TypeName = "nvarchar(50)")]
        public string Brewery { get; set; }

        [Required, Column(TypeName = "nvarchar(50)")]
        public string Country { get; set; }


        public virtual ICollection<BeerDetailsEntity> BeersDetails { get; set; }

    }

}
 