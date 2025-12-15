using EtteremApi.Models;
using EtteremApi.Models.Dtos;
using EtteremApi.Services.IRestaurant;

namespace EtteremApi.Services
{
    public class KapcsoloService : IKapcsolo
    {
        private readonly EtteremContext _context;
        private readonly ResultResponseDto resultResponseDto = new ResultResponseDto();
        public KapcsoloService(EtteremContext context, ResultResponseDto resultResponseDTO)
        {
            _context = context;
            resultResponseDto = resultResponseDTO;
        }
        public async Task<object> PostNewRelation(AddRelationDto addRelationDto)
        {
            try
            {
                var relation = new Kapcsolo
                {
                    RendelesId = addRelationDto.RendelesId,
                    TermekekId = addRelationDto.TermekekId
                };

                if(relation != null)
                {
                    await _context.Kapcsolos.AddAsync(relation);
                    await _context.SaveChangesAsync();
                    resultResponseDto.message = ("Sikeres összerendelés");
                    resultResponseDto.result = relation;

                    return resultResponseDto;
                }
                resultResponseDto.message = ("Sikertelen összerendelés");
                resultResponseDto.result = relation;

                return resultResponseDto;

            }
            catch (Exception ex)
            {
                resultResponseDto.message = ex.Message;
                resultResponseDto.result = null;

                return resultResponseDto;
            }
        }
    }
}
