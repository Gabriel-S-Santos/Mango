namespace Mango.Services.CuponAPI.Models.DTO
{
    public class ResponseDTO
    {
        public Object? Result { get; set; }
        public bool IsSuccess { get; set; } = true;
        public String Message { get; set; }
    }
}
