using Microsoft.AspNetCore.Mvc;
using Travel_Notifications.Model.Search;
using Travel_Notifications.Services.Interfaces;

namespace Travel_Notifications.Controllers
{
    public class SearchController : Controller
    {

        private readonly ISearchService _searchService;

      
        public  SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpPost("search")]
        public IActionResult SearchFlights(SearchRequest request)
        {
            return Ok(_searchService.Search(request));
        }

        [HttpGet("get")]
        public  IActionResult GetFlightsBySearchId(int userId, int searchId) {
            return Ok(_searchService.GetSearchResults(userId,searchId));
        }
    }
}
