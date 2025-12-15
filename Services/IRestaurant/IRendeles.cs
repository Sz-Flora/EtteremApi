using EtteremApi.Models.Dtos;

namespace EtteremApi.Services.IRestaurant
{
    public interface IRendeles
    {
        Task<object> GetAllRendeles();
        Task<object> GetAllRendekesWithCard();
        Task<object> GetAllRendelesWithFood();
        Task<object> GetAllRendelesWithCola();
        Task<object> GetRendelesTetelLista();
        Task<object> GetTermekRendelesLegalabbEgyszer();

    }
}
