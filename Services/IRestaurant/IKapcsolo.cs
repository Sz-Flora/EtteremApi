using EtteremApi.Models.Dtos;

namespace EtteremApi.Services.IRestaurant
{
    public interface IKapcsolo
    {
        Task<object> PostNewRelation(AddRelationDto addRelationDto);
    }
}
