using Mango.Services.CuponAPI.Data;
using Mango.Services.CuponAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.CuponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuponAPIControler : ControllerBase
    {
        private readonly AppDbContext _db;

        public CuponAPIControler(AppDbContext db) 
        {
            _db = db;
        }


        [HttpGet]
        public object Get() 
        {
            try
            {
               IEnumerable<Cupon> objList = _db.Cupons.ToList();
                return objList;
            }
            catch (Exception ex) 
            {
                
            }
            return null;
        }

        [HttpGet]
        [Route("{id:int}")]
        public object Get(int id)
        {
            try
            {
                Cupon objList = _db.Cupons.First(u=>u.CuponId==id);
                return objList;
            }
            catch (Exception ex)
            {

            }
            return null;
        }
    }
}
