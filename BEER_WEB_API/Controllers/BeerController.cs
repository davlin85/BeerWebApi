using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BEER_WEB_API.Data;
using BEER_WEB_API.Models.Entities;
using BEER_WEB_API.Models.Models;
using BEER_WEB_API.Models.Input;

namespace BEER_WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        private readonly SqlContext _context;

        public BeerController(SqlContext context)
        {
            _context = context;
        }

        // GET: api/Beer 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BeerModel>>> GetBeers()
        {
            var beers = new List<BeerModel>();
            foreach (var beer in await _context.Beers
                .Include(x => x.Breweries)
                .ToListAsync())

                beers.Add(new BeerModel(
                    beer.Id,
                    beer.ArticleNumber,
                    beer.BeerName,
                    beer.Vintage,
                    beer.Price,
                    beer.Purchased,
                    beer.BestBeforeDate,
                    beer.AlcoholContent,
                    beer.BottleSize,
                    beer.Quantity,
                        new BreweyModel(
                            beer.Breweries.Brewery,
                            beer.Breweries.BeerStyle,
                            beer.Breweries.Country)));

            return beers;
        }

        // GET: api/Beer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BeerModel>> GetBeer(int id)
        {
            var beerEntity = await _context.Beers
                .Include(x => x.Breweries)
                .FirstOrDefaultAsync(x => x.Id == id);

            if(beerEntity == null)
            {
                return NotFound("Beer Id doesn't exist! Try again!");
            }

            return new BeerModel(
                beerEntity.Id,
                beerEntity.ArticleNumber,
                beerEntity.BeerName,
                beerEntity.Vintage,
                beerEntity.Price,
                beerEntity.Purchased,
                beerEntity.BestBeforeDate,
                beerEntity.AlcoholContent,
                beerEntity.BottleSize,
                beerEntity.Quantity,
                    new BreweyModel(
                        beerEntity.Breweries.Brewery,
                        beerEntity.Breweries.BeerStyle,
                        beerEntity.Breweries.Country));
        }

        // PUT: api/Beer/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<BeerPutModel>> UpdateBeer(int id, BeerPutModel model)
        {
            if (id != model.Id)
            {
                return BadRequest("Beer Id doesn't exist! Try again!");
            }

            var beerEntity = await _context.Beers
                .FindAsync(model.Id);

            beerEntity.ArticleNumber = model.ArticleNumber;
            beerEntity.BeerName = model.BeerName;
            beerEntity.Vintage = model.Vintage;
            beerEntity.Price = model.Price;
            beerEntity.Purchased = model.Purchased;
            beerEntity.BestBeforeDate = model.BestBeforeDate;
            beerEntity.AlcoholContent = model.AlcoholContent;
            beerEntity.BottleSize = model.BottleSize;
            beerEntity.Quantity = model.Quantity;

            var breweries = await _context.Breweries
                .FirstOrDefaultAsync(x => x.Brewery == model.Brewery
                && x.BeerStyle == model.BeerStyle
                && x.Country == model.Country);

            if (breweries != null)
                beerEntity.BreweriesId = breweries.Id;
            else
                beerEntity.Breweries = new BreweryEntity(
                    model.Brewery,
                    model.BeerStyle,
                    model.Country);

            _context.Entry(beerEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if(!BeerEntityExists(id))
                {
                    return NotFound("Something went wrong! Try again!");
                }
                else
                {
                    throw;
                }
            }

            return Ok("Beer is Updated!");
            
        }

        // POST: api/Beer
        [HttpPost]
        public async Task<ActionResult<BeerModel>> PostBeer(BeerInput model)
        {
            var beerEntity = new BeerEntity(
                model.ArticleNumber,
                model.BeerName,
                model.Vintage,
                model.Price,
                model.Purchased,
                model.BestBeforeDate,
                model.AlcoholContent,
                model.BottleSize,
                model.Quantity);

            var breweries = await _context.Breweries
                .FirstOrDefaultAsync(x => x.Brewery == model.Brewery
                && x.BeerStyle == model.BeerStyle
                && x.Country == model.Country);

            if (breweries != null)
                beerEntity.BreweriesId = breweries.Id;
            else
                beerEntity.Breweries = new BreweryEntity(
                    model.Brewery,
                    model.BeerStyle,
                    model.Country);

            _context.Beers.Add(beerEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBeer", new {id = beerEntity.Id},
                new BeerModel(
                    beerEntity.Id,
                    beerEntity.ArticleNumber,
                    beerEntity.BeerName,
                    beerEntity.Vintage,
                    beerEntity.Price,
                    beerEntity.Purchased,
                    beerEntity.BestBeforeDate,
                    beerEntity.AlcoholContent,
                    beerEntity.BottleSize,
                    beerEntity.Quantity,
                        new BreweyModel(
                            beerEntity.Breweries.Brewery,
                            beerEntity.Breweries.BeerStyle,
                            beerEntity.Breweries.Country)));

        }

        // DELETE: api/Beer/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBeerEntity(int id)
        {
            var beerEntity = await _context.Beers.FindAsync(id);
            if (beerEntity == null)
            {
                return NotFound("Beer Id doesn't exist! Try again!");
            }

            _context.Beers.Remove(beerEntity);
            await _context.SaveChangesAsync();

            return Ok("Beer is deleted!");
        }

        private bool BeerEntityExists(int id)
        {
            return _context.Beers.Any(e => e.Id == id);
        }
    }
}
