using EtteremApi.Models.Dtos;

namespace EtteremApi.Services.IRestaurant
{
    public interface IRendeles
    {
        Task<object> GetAllRendeles();
        Task<object> GetAllRendekesWithCard();
    }
}
