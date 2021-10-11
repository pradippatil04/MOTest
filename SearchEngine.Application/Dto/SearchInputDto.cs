using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngines.Application.Dto
{
    public class SearchInputDto
    {  
        /// <summary>
        /// Id of search engine against which search happens
        /// </summary>
        public int SearchEngineId { get; set; }
        /// <summary>
        /// Search query
        /// </summary>
        public string SearchText { get; set; }
    }
}
