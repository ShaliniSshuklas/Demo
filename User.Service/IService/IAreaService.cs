using User.Presentation.ViewModel;

namespace User.Service.IService
{
    public interface IAreaService
    {
      Task<List<AreaListViewModel>> GetAll();
      Task<bool> AddArea(AddAreaRequestModel model);
    }
}
