using EtteremApi.Models;
using EtteremApi.Models.Dtos;
using EtteremApi.Services.IRestaurant;
using Microsoft.EntityFrameworkCore;

namespace EtteremApi.Services
{
    public class TermekekServices : ITermekek
    {
        private readonly EtteremContext _context;
        ResultResponseDto resultResponseDto = new ResultResponseDto();
        public TermekekServices(EtteremContext context)
        {
            _context = context;
        }
        public async Task<object> GetTermek()
        {
            try
            {
                var termekek = await _context.Termekeks.Select(x=> new {x.Etel, x.Ar}).ToListAsync();
                resultResponseDto.message = "Sikeres lekérdezés";
                resultResponseDto.result = termekek;

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
