using Opdracht2.Models.Data;
using Opdracht2.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Opdracht2.Repositories
{
    public class BreweryDAO
    {
        private readonly BierenDbContext _dbContext;

        public BreweryDAO()
        {
            _dbContext = new BierenDbContext();
        }

        public IEnumerable<Brewery>? getAllBreweries()
        {
            try
            {
                return _dbContext.Breweries.ToList();
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                Debug.WriteLine("Can't find database", ex.ToString());
                return null;
            }
            catch (Exception ex)
            {
                return null;
            };
        }
    }
}