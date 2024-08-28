namespace BAVideoSearch.Models
{
    public class SearchResultModel
    {
        public int TotalItems { get; set; }
        public int NumberOfRows { get; set; }
        public int StartItemIndex { get; set; }
        public string Keyword { get; set; }
        public List<HighlightedResult> HighlightedResults { get; set; }

    }

    public class HighlightedResult
    {
        public string VideoId { get; set; }
        public string VideoTitle { get; set; } 
        public string VideoDescription { get; set; } 
        public Dictionary<string, List<string>> Highlights { get; set; }
    }



}
