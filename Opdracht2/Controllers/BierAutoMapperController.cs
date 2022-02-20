using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Opdracht2.Services;
using Opdracht2.ViewModels;

namespace Opdracht2.Controllers
{
    public class BierAutoMapperController : Controller
    {
        private BierService _bierService;

        private readonly IMapper _mapper;

        public BierAutoMapperController(IMapper mapper)
        {
            _mapper = mapper;
            _bierService = new BierService();
        }

        public IActionResult Index()
        {

            var lstBieren = _bierService.GetAllBeers();
            

            return View(lstBieren);
        }
    }
}
