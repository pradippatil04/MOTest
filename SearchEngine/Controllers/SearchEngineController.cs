using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SearchEngines.Application.Dto;
using SearchEngines.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchEngine.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SearchEngineController : ControllerBase
    {

        private readonly ISearchEngineService _searchEngineService ;

        public SearchEngineController(ISearchEngineService  searchEngineService)
        {
            _searchEngineService = searchEngineService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<SearchEngineDto> Get()
        {
            /*
              gets the result from _searchEngineService and returns;
              model validation will happen in controller if any
              dummy return empty collection
             */
            return Enumerable.Empty<SearchEngineDto>();
        }

        [HttpPost]
        [Route("CreateSearchEngine")]
        public async Task<SearchEngineDto> CreateSearchEngine([FromBody]SearchEngineDto input)
        {
            /*
            gets the result from _searchEngineService and returns;
            model validation will happen in controller if any
            Dummy return Null
             */
            await Task.CompletedTask; // aaded to remove warning of not use await
            return null;
        }

        [HttpPost]
        [Route("DeleteSearchEngine/{id}")]
        public async Task DeleteSearchEngine(int id)
        {
            /*
            gets the result from _searchEngineService and returns;
            model validation will happen in controller if any
             */
            await Task.CompletedTask; // aaded to remove warning of not use await
        }

        [HttpGet]
        [Route("Search")]
        public async Task<IEnumerable<SearchResultDto>> Search([FromQuery]SearchInputDto input)
        {
            /*
            gets the result from _searchEngineService and returns;
            model validation will happen in controller if any
            returning dummy emooty collection
             */
            await Task.CompletedTask; // aaded to remove warning of not use await
            return Enumerable.Empty<SearchResultDto>();
        }

    }
}
