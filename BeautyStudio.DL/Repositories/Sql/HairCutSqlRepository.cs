using BeautyStudio.DL.Interfaces;
using BeautyStudio.Models.Models.Requests;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Dapper;
using BeautyStudio.Models.Models.Responses;

namespace BeautyStudio.DL.Repositories.Sql
{
    public class HairCutSqlRepository : IHairCutRepository
    {
        private readonly IConfiguration _configuration;

        public HairCutSqlRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<HairCutRequest?> AddHairCut(HairCutRequest hairCut)
        {
            try
            {
                await using (var conn = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    await conn.OpenAsync();

                    var result = await conn.ExecuteAsync("INSERT INTO HairCut (Price) VALUES( @Price)", hairCut);
                    return hairCut;

                }
            }
            catch (Exception e)
            {
                //_logger.LogError($"Error in {nameof(AddhairCut)}: {e.Message}", e.Message);
            }
            return null;
        }

        public Task<HairCutRequest?> DeleteHairCut(int hairCutId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<HairCutResponse>> GetAllHairCuts()
        {
            try
            {
                await using (var conn = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    await conn.OpenAsync();

                    return await conn.QueryAsync<HairCutResponse>("SELECT * FROM HairCut WITH(NOLOCK)");
                }
            }
            catch (Exception e)
            {
                //_logger.LogError($"Error in {nameof(GetAllHairCuts)}: {e.Message}", e.Message);
            }

            return null;
        }

        public Task<HairCutResponse> GetHairCutById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<HairCutResponse> UpdateHairCut(HairCutRequest hairCut)
        {
            throw new NotImplementedException();
        }
    }
}
