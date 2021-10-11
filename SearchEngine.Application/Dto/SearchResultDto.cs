
namespace SearchEngines.Application.Dto
{
    public class SearchResultDto
    {
        /// <summary>
        /// Some Random Id / Get From Search Engine Result
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Title i.e Highlighed text on search result links
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Actual link for the page
        /// </summary>
        public string Address { get; set; }
    }
}
