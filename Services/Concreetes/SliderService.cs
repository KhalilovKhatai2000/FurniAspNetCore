using Furni.Entities;
using Furni.Services.Abstracts;
using Furni.Services.Commons;
using Furni.UnitOfWorks;

namespace Furni.Service.Concreetes
{
    public class SliderService : Service<Slider>, ISliderService
    {
        public SliderService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
