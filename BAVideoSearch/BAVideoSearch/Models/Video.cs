using SolrNet.Attributes;
using System;

namespace BAVideoSearch.Models
{
    public class Video
    {
        [SolrUniqueKey("video_id")]
        public string VideoId { get; set; }

        [SolrField("uploader_id")]
        public string UploaderId { get; set; }

        [SolrField("video_path")]
        public string VideoPath { get; set; }

        [SolrField("video_title")]
        public string VideoTitle { get; set; }

        [SolrField("video_description")]
        public string VideoDescription { get; set; }

        [SolrField("upload_date")]
        public DateTime UploadDate { get; set; }

        [SolrField("publish_date")]
        public DateTime PublishDate { get; set; }

        [SolrField("views")]
        public int Views { get; set; }

        [SolrField("transcript")]
        public List<string> Transcript { get; set; }

        [SolrField("duration")]
        public int Duration { get; set; }

        [SolrField("vis_id")]
        public string VisId { get; set; }

        [SolrField("category")]
        public string Category { get; set; }
    }
}
