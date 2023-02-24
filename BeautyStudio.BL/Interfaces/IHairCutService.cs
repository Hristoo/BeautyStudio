using BeautyStudio.Models.Models;
using BeautyStudio.Models.Models.Requests;
using BeautyStudio.Models.Models.Responses;

namespace BeautyStudio.BL.Interfaces
{
    public interface IHairCutService
    {
        public Task<IEnumerable<HairCutResponse>> GetAllHairCuts();

        public Task<HairCutRequest?> AddHairCut(HairCutRequest hairCut);

        public Task<HairCutResponse?> DeleteHairCut(int hairCutId);

        public Task<HairCutResponse> UpdateHairCut(HairCutRequest hairCut);

        public Task<HairCutResponse> GetHairCutById(int id);
    }
}
