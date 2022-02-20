using Microsoft.AspNetCore.Mvc.Rendering;
using Opdracht2.Models.Entities;

namespace Opdracht2.ViewModels
{
    public class BrewerySearchVM
    {
       //public Brewery Brewery { get; set; }
        public Beer Beer { get; set; }
        public List<Beer> Beers { get; set; }
        public IEnumerable<SelectListItem> LijstvanBrouwerijen { get; set; }
    }
}
