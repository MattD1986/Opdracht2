using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Opdracht2.Services;
using Opdracht2.ViewModels;

namespace Opdracht2.Controllers
{
    public class BierController : Controller
    {
        private BierService _bierService;

        public BierController()
        {
            _bierService = new BierService();
        }

        public IActionResult Index()
        {
            var bierLijst = _bierService.GetAllBeers();

            
            return View(bierLijst);
        }

    }
}
