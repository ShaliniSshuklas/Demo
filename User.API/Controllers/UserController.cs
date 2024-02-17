using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using User.Presentation.ViewModel;
using User.Service.IService;

namespace User.API.Controllers
{
    [ApiController]
    [Authorize]
    ///////I use Microsoft Entity Framework(EF Core)
    public class UserController: ControllerBase
    {
        private readonly IAreaService _areaService;
        public UserController(IAreaService areaService)
        {
                this._areaService = areaService;
        }

        [HttpGet]
        public async Task<List<AreaListViewModel>> GetAll()
        {
            return await _areaService.GetAll();
        }

        [HttpPost]
        public async Task<bool> AddArea(AddAreaRequestModel model)
        {
            return await _areaService.AddArea(model);
        }
    }
}
