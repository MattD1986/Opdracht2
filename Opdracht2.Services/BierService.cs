using Opdracht2.Models.Entities;
using Opdracht2.Repositories;

namespace Opdracht2.Services
{
    public class BierService
    {
        private BierDAO bierDAO;
        private BreweryDAO breweryDAO;

        public BierService()
        {
            bierDAO = new BierDAO();
            breweryDAO = new BreweryDAO();
             
    }

        public IEnumerable<Beer>? GetAllBeers()
        {
            return bierDAO.GetAllBeers();
        }

        public IEnumerable<Brewery>? GetAllBreweries()
        {
            return breweryDAO.getAllBreweries();
        }
    }
}