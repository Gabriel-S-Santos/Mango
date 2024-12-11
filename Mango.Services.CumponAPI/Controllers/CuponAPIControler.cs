using Mango.Services.CuponAPI.Data;
using Mango.Services.CuponAPI.Models;
using Mango.Services.CuponAPI.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.CuponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuponAPIControler : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDTO _response;

        public CuponAPIControler(AppDbContext db) 
        {
            _db = db;
            _response = new ResponseDTO();
        }


        [HttpGet]
        public ResponseDTO Get() 
        {
            try
            {
               IEnumerable<Cupon> objList = _db.Cupons.ToList();
                _response.Result = objList;
            }
            catch (Exception ex) 
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ResponseDTO Get(int id)
        {
            try
            {
                Cupon obj = _db.Cupons.First(u=>u.CuponId==id);
                _response.Result = obj;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }
    }
}
