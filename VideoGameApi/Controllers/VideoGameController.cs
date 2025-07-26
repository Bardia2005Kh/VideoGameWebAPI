using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using VideoGameApi.Data;

namespace VideoGameApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {
        private readonly VideoGameDbContext _Context;

        public VideoGameController(VideoGameDbContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<VideoGame>>> GetVideoGames()
        {
            return Ok(await _Context.VideoGames.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<VideoGame>> GetVideoGameById(int id)
            {
                var game = await _Context.VideoGames.FindAsync(id);
                if(game is null)
                    {
                        return NotFound();
                    }
                return Ok(game);
            }

        [HttpPost]
        public async Task<ActionResult<VideoGame>> AddVideoGame(VideoGame newGame)
        {
            if (newGame is null)
                return BadRequest();

            _Context.VideoGames.Add(newGame);
            await _Context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetVideoGameById), new { id = newGame.Id }, newGame);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVideoGame(int id, VideoGame updadetGame)
        {
            var game = await _Context.VideoGames.FindAsync(id);
            if (game is null)
                return NotFound();

            game.Title = updadetGame.Title;
            game.Platform = updadetGame.Platform;
            game.Developer = updadetGame.Developer;
            game.Publisher = updadetGame.Publisher;

            await _Context.SaveChangesAsync();

            return NoContent();

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVideoGame(int id)
        {
            var game = await _Context.VideoGames.FindAsync(id);
            if (game is null)
                return NotFound();

            _Context.VideoGames.Remove(game);
            await _Context.SaveChangesAsync();
            return NoContent();
        }

    }
}
