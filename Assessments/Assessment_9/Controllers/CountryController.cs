using Assessment_9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assessment_9.Controllers
{
    public class CountryController : ApiController
    {
        
        static List<Country> countries = new List<Country>
        {
            new Country { ID = 1, CountryName = "India", Capital = "New Delhi" },
            new Country { ID = 2, CountryName = "USA", Capital = "Washington." },
            new Country{ ID=3,CountryName="China",Capital="Beijing"}
        };

        
        public IHttpActionResult Get()
        {
            return Ok(countries);
        }

      
        public IHttpActionResult Get(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
                return NotFound();
            return Ok(country);
        }

        
        public IHttpActionResult Post(Country country)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            countries.Add(country);
            return Created($"api/country/{country.ID}", country);
        }

       
        public IHttpActionResult Put(int id, Country updatedCountry)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
                return NotFound();

            country.CountryName = updatedCountry.CountryName;
            country.Capital = updatedCountry.Capital;

            return Ok(country);
        }

       
        public IHttpActionResult Delete(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
                return NotFound();

            countries.Remove(country);
            return Ok();
        }
    }
}
