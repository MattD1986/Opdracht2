using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Opdracht2.Models.Entities;
using Opdracht2.Services;
using Opdracht2.ViewModels;

namespace Opdracht2.Controllers
{
    public class BrouwerijController : Controller
    {

        private BierService _bierService;

        public BrouwerijController()
        {
            _bierService = new BierService();
        }
        public IActionResult Index()
        {
            BrewerySearchVM vm = LaadDropDown();

            return View(vm);
        }

        [HttpPost]
        public IActionResult Index(BrewerySearchVM brewerySearchVM)
        {
            var nr = brewerySearchVM.Beer.Brouwernr;
            var vm = LaadDropDown();

            vm.Beers = new List<Beer>();

            foreach(Beer b in _bierService.GetAllBeers())
            {
                if(b.Brouwernr == nr)
                {
                    vm.Beers.Add(b);
                }
            }

            return View("Result",vm);
        }

        public BrewerySearchVM LaadDropDown()
        {
            BrewerySearchVM vm = new()
            {
                LijstvanBrouwerijen = _bierService.GetAllBreweries().Select(b => new SelectListItem
                {
                    Text = b.Naam,
                    Value = b.Brouwernr.ToString(),
                })
            };

            return vm;
        }
    }


}
