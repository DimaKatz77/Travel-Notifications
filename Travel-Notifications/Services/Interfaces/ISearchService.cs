using Travel_Notifications.Model.Search;

namespace Travel_Notifications.Services.Interfaces
{
    public interface ISearchService
    {
        Task<Guid> Search(SearchRequest request);
        Task<SearchResponse> GetSearchResults(int userId, int searchId);
    }
}
