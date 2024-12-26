using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface ICuponService
    {
        Task<ResponseDTO?> GetCuponAsync(string cuponCode);
        Task<ResponseDTO?> GetAllCuponsAsync();
        Task<ResponseDTO?> GetCuponByIdAsync(int id);
        Task<ResponseDTO?> CreateCuponsAsync(CuponDto cuponDto);
        Task<ResponseDTO?> UpdateCuponsAsync(CuponDto cuponDto);
        Task<ResponseDTO?> DeleteCuponAsync(int id);

    }
}
