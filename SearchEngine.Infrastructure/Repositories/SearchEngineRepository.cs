using SearchEngines.Core.Entities;
using SearchEngines.Core.Repositories;
using SearchEngines.Infrastructure.Base.Repositories;
using SearchEngines.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngines.Infrastructure.Repositories
{
    public class SearchEngineRepository : Repository<SearchEngine> , ISearchEngineRepository
    {
        /// <summary>
        /// Other than generic CRUD operation go here
        /// </summary>
        /// <param name="dbContext"></param>
        public SearchEngineRepository(AppDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
