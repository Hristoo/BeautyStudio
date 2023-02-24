using BeautyStudio.Models.Models;
using BeautyStudio.Models.Models.Requests;
using BeautyStudio.Models.Models.Responses;

namespace BeautyStudio.DL.Interfaces
{
    public interface IHairCutRepository
    {
        public Task<IEnumerable<HairCutResponse>> GetAllHairCuts();

        public Task<HairCutRequest?> AddHairCut(HairCutRequest hairCut);

        public Task<HairCutRequest?> DeleteHairCut(int hairCutId);

        public Task<HairCutResponse> UpdateHairCut(HairCutRequest hairCut);

        public Task<HairCutResponse> GetHairCutById(int id);
    }
}
