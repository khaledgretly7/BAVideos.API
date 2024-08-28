
using SolrNet;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BAVideoSearch.Models;
using SolrNet.Commands.Parameters;
using System.Text;

namespace BAVideoSearch.Services
{
    public class V
    {
        private readonly ISolrOperations<Video> _solr;

        public V(ISolrOperations<Video> solr)
        {
            _solr = solr;
        }

        public async Task AddVideo(Video video)
        {
            await _solr.AddAsync(video);
            await _solr.CommitAsync();
        }

        public async Task DeleteVideo(string videoId)
        {
            await _solr.DeleteAsync(videoId);
            await _solr.CommitAsync();
        }

        public async Task<SearchResultModel> SearchVideos(string title = null, string description = null, string uploaderId = null, DateTime? uploadDate = null, int startIndex = 0, int rows = 10)
        {
            var queryString = new StringBuilder();

            // Build query string based on the provided fields
            if (!string.IsNullOrEmpty(title))
            {
                queryString.Append($"video_title:\"{title}\"");
            }

            if (!string.IsNullOrEmpty(description))
            {
                if (queryString.Length > 0)
                    queryString.Append(" AND ");
                queryString.Append($"video_description:\"{description}\"");
            }

            if (!string.IsNullOrEmpty(uploaderId))
            {
                if (queryString.Length > 0)
                    queryString.Append(" AND ");
                queryString.Append($"uploader_id:\"{uploaderId}\"");
            }

            if (uploadDate.HasValue)
            {
                if (queryString.Length > 0)
                    queryString.Append(" AND ");
                // Solr expects dates in a specific format
                queryString.Append($"upload_date:[{uploadDate.Value.ToString("yyyy-MM-ddT00:00:00Z")} TO {uploadDate.Value.ToString("yyyy-MM-ddT23:59:59Z")}]");
            }

            // Default to match all if no specific search criteria is provided
            var finalQuery = queryString.Length > 0 ? queryString.ToString() : "*:*";

            var solrQuery = new SolrQuery(finalQuery);

            var queryOptions = new QueryOptions
            {
                Start = startIndex,
                Rows = rows,
                ExtraParams = new Dictionary<string, string>
    {
        { "hl", "true" }, // Enable highlighting
        { "hl.fl", "video_title,video_description" }, // Specify fields to highlight
        { "hl.simple.pre", "<em>" }, // Prefix for highlighted text
        { "hl.simple.post", "</em>" }, // Suffix for highlighted text
        { "fl", "video_id,video_title,video_description" } // Ensure fields are returned in the response
    }
            };

            var results = await _solr.QueryAsync(solrQuery, queryOptions);

            var searchResultModel = new SearchResultModel
            {
                TotalItems = (int)results.NumFound,
                NumberOfRows = rows,
                StartItemIndex = startIndex,
                Keyword = title ?? description ?? uploaderId ?? uploadDate?.ToString("yyyy-MM-dd") ?? "*",
                HighlightedResults = ExtractHighlightedResults(results)
            };

            return searchResultModel;
        }


        private List<HighlightedResult> ExtractHighlightedResults(SolrQueryResults<Video> results)
        {
            var highlightedResults = new List<HighlightedResult>();

            foreach (var doc in results)
            {
                var highlights = new Dictionary<string, List<string>>();
                if (results.Highlights.TryGetValue(doc.VideoId, out var highlightFields))
                {
                    foreach (var field in highlightFields)
                    {
                        highlights.Add(field.Key, field.Value.ToList());
                    }
                }

                highlightedResults.Add(new HighlightedResult
                {
                    VideoId = doc.VideoId,
                    VideoTitle = doc.VideoTitle.FirstOrDefault(), // Assuming `VideoTitle` is a list and taking the first one
                    VideoDescription = doc.VideoDescription.FirstOrDefault(), // Assuming `VideoDescription` is a list and taking the first one
                    Highlights = highlights
                });
            }

            return highlightedResults;
        }




    }
}




