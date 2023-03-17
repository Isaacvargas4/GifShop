using Microsoft.AspNetCore.Mvc;

namespace GifShop.API.Controllers
{

    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetCities()
        {
            return new JsonResult( CitiesDataStore.Current );
        }




        [HttpGet("{id}")]
        public JsonResult GetCity(int id) 
        {
            return new JsonResult(
                    CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id));
        }

        //[HttpGet]
        //public JsonResult GetCountries()
        //{
        //    return new JsonResult(
        //        new List<object> {
        //            new { id = 1, Name = "Mexico" },
        //            new { id = 2, Name = "Usa" }
        //        });
        //}

        //[HttpGet]
        //public JsonResult GetTowns()
        //{
        //    return new JsonResult(
        //        new List<object> {
        //            new { id = 1, Name = "Bacobampo" },
        //            new { id = 2, Name = "Alamos" }
        //        });
        //}
    }
}
