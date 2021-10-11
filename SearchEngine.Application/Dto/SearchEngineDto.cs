using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngines.Application.Dto
{
    public class SearchEngineDto
    {
        /// <summary>
        ///  Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the search Engine
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Actual base url link
        /// </summary>
        public string Address { get; set; }
    }
}
