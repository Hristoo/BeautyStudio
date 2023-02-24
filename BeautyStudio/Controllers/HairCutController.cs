using BeautyStudio.BL.Interfaces;
using BeautyStudio.Models.Models. Responses;
using BeautyStudio.Models.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace BeautyStudio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HairCutController : ControllerBase
    {

        private readonly IHairCutService _hairCutService;

        public HairCutController(IHairCutService hairCutService)
        {
            _hairCutService = hairCutService;
        }

        [HttpGet(nameof(GetAllHairCuts))]
        public async Task<IActionResult> GetAllHairCuts()
        {
            return Ok(await _hairCutService.GetAllHairCuts());
        }

        [HttpPost(nameof(AddHairCut))]
        public async Task<IActionResult?> AddHairCut(HairCutRequest hairCut)
        {
            var result = await _hairCutService.AddHairCut(hairCut);

            var addedHairCut = (await _hairCutService.GetAllHairCuts()).LastOrDefault();

            if (addedHairCut != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
