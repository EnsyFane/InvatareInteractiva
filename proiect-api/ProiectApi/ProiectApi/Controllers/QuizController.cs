using AutoMapper;
using Common.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace ProiectApi.Controllers
{
    [ApiController]
    [Route("api/quizzes")]
    public class QuizController : ControllerBase
    {
        private readonly IQuizService _quizService;
        private readonly IMapper _map;

        public QuizController(IQuizService quizService, IMapper map)
        {
            _quizService = quizService;
            _map = map;
        }

        [HttpGet("{noChapter}")]
        [ProducesResponseType(typeof(QuizViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetQuiz([FromRoute] int noChapter)
        {

            try
            {
                var result = await _quizService.GetQuiz(noChapter);
                if (result==null)
                {
                    return NoContent();
                }
                return Ok(_map.Map<QuizViewModel>(result));
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
