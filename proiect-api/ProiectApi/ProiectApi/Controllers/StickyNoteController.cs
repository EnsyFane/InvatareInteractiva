using AutoMapper;
using Common.DTOs;
using Common.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace ProiectApi.Controllers
{
    [ApiController]
    [Route("api/stickynotes")]
    public class StickyNoteController : ControllerBase
    {
        private readonly IStickyNoteService _stickyNoteService;
        private readonly IMapper _map;

        public StickyNoteController(IStickyNoteService stickyNoteService, IMapper map)
        {
            _stickyNoteService = stickyNoteService;
            _map = map;
        }

        [HttpGet("{noChapter}")]
        [ProducesResponseType(typeof(List<StickyNoteViewModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetStickyNote([FromRoute] int noChapter)
        {

            try
            {
                var result = await _stickyNoteService.GetStickyNotes(noChapter);
                if (result == null)
                {
                    return NoContent();
                }
                return Ok(_map.Map<List<StickyNoteViewModel>>(result));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    message = ex.Message,
                });
            }
        }

        [HttpPost]
        [ProducesResponseType(typeof(List<StickyNoteViewModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddStickyNote([FromBody] StickyNoteViewModel stickyNote)
        {

            try
            {
                var result = await _stickyNoteService.AddStickyNote(_map.Map<StickyNoteDto>(stickyNote));
                if (result == null)
                {
                    return NoContent();
                }
                return Ok(_map.Map<StickyNoteViewModel>(result));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    message = ex.Message,
                });
            }
        }
    }
}
