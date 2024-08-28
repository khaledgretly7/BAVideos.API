using BAVideoSearch.Models;
using BAVideoSearch.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using BAVideoSearch.Models;
using BAVideoSearch.Services;
using System.Net;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace BAVideoSearch.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VideoController : ControllerBase
    {
        private readonly VideoService _videoService;

        public VideoController(VideoService videoService)
        {
            _videoService = videoService;
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost("add")]
        public async Task<IActionResult> AddVideo(Video video)
        {
            await _videoService.AddVideo(video);
            return Ok();
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteVideo(string id)
        {
            await _videoService.DeleteVideo(id);
            return Ok();
        }


        [HttpGet("search")]
        public async Task<IActionResult> SearchVideos([FromQuery] string title = null, [FromQuery] string UploaderID = null,[FromQuery] string description = null, [FromQuery] string Category = null, [FromQuery] DateTime? uploadDate = null, [FromQuery] int start = 0, [FromQuery] int rows = 10)
        {
            var results = await _videoService.SearchVideos(title, description, Category, UploaderID, uploadDate, start, rows);
            return Ok(results);
        }



    }
}
