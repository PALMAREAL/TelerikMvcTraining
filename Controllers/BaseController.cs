using AutoMapper;
using System.Web.Mvc;

namespace TelerikMvcTraining.Controllers
{
    public class BaseController : Controller
    {
        public IMapper Mapper { get; set; }

        public BaseController(IMapper mapper)
        {
            Mapper = mapper;
        }
    }
}