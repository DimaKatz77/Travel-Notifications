using Travel_Notifications.Model.Search;
using Travel_Notifications.Services.Interfaces;

namespace Travel_Notifications.Services
{
    public class SearchService : ISearchService
    {

        //User Search for Flight in the our search for flights site
        //Start Process -> User Recive the SearchID
        public Task<Guid> Search(SearchRequest request) {
            //Steps
            // 1. Create new Guid, Join to SearchRequest Object
            // 2. Produce created object to Queue as Json 
            // 3. Response Created Id to Client

            //On the Background Job Concumer collect the request and start to collect the information.
            //The collected data is stored in Blobs (Backets)
            //The Path (UserId/searchId)
            return Task.FromResult(Guid.NewGuid());
        }

        //Ask For Search Resuts with Search Id
        public Task<SearchResponse> GetSearchResults(int userId, int searchId)
        {
            //Steps
            //The Method is open the Blob storage  - The Path (UserId/searchId)
            //Read the Search results Files (Json's format) 
            //Convert data to SearchResult Object
            //Return Data to Client

            return Task.FromResult(new SearchResponse());
        }
    }
}
