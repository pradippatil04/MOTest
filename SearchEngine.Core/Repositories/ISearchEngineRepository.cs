using SearchEngines.Core.Base.Repositories;
using SearchEngines.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngines.Core.Repositories
{
    /// <summary>
    ///   Other than generic CRUD operation go here
    /// </summary>
    public interface ISearchEngineRepository : IRepository<SearchEngine>
    {
    }
}
