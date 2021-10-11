using SearchEngines.Application.Dto;
using SearchEngines.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngines.Application.Interfaces
{
    public interface ISearchEngineService
    {
        public Task<IReadOnlyList<SearchEngineDto>> GetAllSearchEngines();
        public Task<SearchEngineDto> CreateSearchEngine(SearchEngineDto input);
        public Task DeleteSearchEngine(int id);
        public Task<IReadOnlyList<SearchResultDto>> GetSearchResult(SearchInputDto input);
    }
}
