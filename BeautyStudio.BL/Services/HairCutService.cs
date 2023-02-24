using BeautyStudio.BL.Interfaces;
using BeautyStudio.DL.Interfaces;
using BeautyStudio.Models.Models;
using BeautyStudio.Models.Models.Requests;
using BeautyStudio.Models.Models.Responses;

namespace BeautyStudio.BL.Services
{
    public class HairCutService : IHairCutService
    {
        private readonly IHairCutRepository _hairCutRepository;

        public HairCutService(IHairCutRepository hairCutRepository)
        {
            _hairCutRepository = hairCutRepository;
        }

        public async Task<HairCutRequest?> AddHairCut(HairCutRequest hairCut)
        {
            var result = await _hairCutRepository.AddHairCut(hairCut);

            return result;
        }

        public Task<HairCutResponse?> DeleteHairCut(int hairCutId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<HairCutResponse>> GetAllHairCuts()
        {
            return await _hairCutRepository.GetAllHairCuts();
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
