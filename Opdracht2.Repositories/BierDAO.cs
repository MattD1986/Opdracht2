using Opdracht2.Models.Data;
using Opdracht2.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Opdracht2.Repositories
{
    public class BierDAO
    {
        private readonly BierenDbContext _dbContext;

        public BierDAO()
        {
            _dbContext = new BierenDbContext();
        }

        public IEnumerable<Beer>? GetAllBeers()
        {
            try
            {
                return _dbContext.Beers.Include(b => b.BrouwernrNavigation).Include(b => b.SoortnrNavigation).ToList();

            } catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                Debug.WriteLine("Can't find database", ex.ToString());
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}