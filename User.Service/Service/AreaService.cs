using Capex.DAL.UnitOfWork;
using User.Domain.Models;
using User.Presentation.ViewModel;
using User.Service.IService;

namespace User.Service.Service
{
    internal class AreaService : IAreaService
    {
        private readonly IUnitOfWork _uow;
        public AreaService(UnitOfWork unitOfWork)
        {
            this._uow = unitOfWork;
        }

        public async Task<List<AreaListViewModel>> GetAll()
        {
            var response = new List<AreaListViewModel>();

            try
            {
                var area = this._uow.GenericRepository<Area>().GetAllAsync();

                if (area == null)
                {
                    response.Add(new AreaListViewModel());
                }

                // we can also use mapper to show only necessary columns

                //var viewModel = area.ConvertToAreaListViewModel();

                return response;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<bool> AddArea(AddAreaRequestModel model)
        {
            var response = new bool();
            {
                try
                {
                    if (model != null)
                    {
                        Area obj = new Area();
                        obj.AreaId = 0;
                        obj.AreaDesc = model.AreaName;
                        obj.UpdatedBy = model.CreatedBy.ToString();
                        obj.UpdateTime = DateTime.Now;
                        await this._uow.GenericRepository<Area>().AddAsync(obj);
                        this._uow.SaveAsync();
                        return response == true;
                    };
                    return response == false;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
    }
}
