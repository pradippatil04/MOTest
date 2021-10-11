using SearchEngines.Application.Dto;
using SearchEngines.Application.Interfaces;
using SearchEngines.Core.Base.Repositories;
using SearchEngines.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SearchEngines.Application.AppServices
{
    /// <summary>
    /// Search Engine App Service with dummy implementation
    /// Mapping of Dto to Entiy and vice-versa 
    /// </summary>
    public class SearchEngineService : ISearchEngineService
    {
        private IRepository<SearchEngine> _searchEngineRepository;
        public SearchEngineService(IRepository<SearchEngine> searchRepository)
        {
            _searchEngineRepository = searchRepository;
        }

        /// <summary>
        /// Create Search Engine
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public Task<SearchEngineDto> CreateSearchEngine(SearchEngineDto input)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete Search Engine
        /// </summary>
        /// <returns></returns>
        public Task DeleteSearchEngine(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns all registered search enignes
        /// </summary>
        /// <returns></returns>
        public Task<IReadOnlyList<SearchEngineDto>> GetAllSearchEngines()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Actual search engine logic goes here.
        /// based on input.SearchEngineId different search engine can be targated
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public Task<IReadOnlyList<SearchResultDto>> GetSearchResult(SearchInputDto input)
        {
            throw new NotImplementedException();
        }
    }
}
