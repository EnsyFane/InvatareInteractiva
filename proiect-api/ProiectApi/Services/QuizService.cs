using AutoMapper;
using Common.DTOs;
using DataPersistence;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    #region interface
    public interface IQuizService
    {
        Task<QuizDto> GetQuiz(int noChapter);
    }
    #endregion

    public class QuizService : IQuizService
    {
        private readonly DataContext _context;
        private readonly IMapper _map;

        public QuizService(DataContext context, IMapper map)
        {
            _context = context;
            _map = map;
        }

        public async Task<QuizDto> GetQuiz(int noChapter)
        {
            var quiz = _map.Map<QuizDto>(await _context.Quizzes.FirstOrDefaultAsync(x => x.NoChapter == noChapter));
            var questions = _map.Map<List<QuestionDto>>(await _context.Questions.Where(x => x.Quiz.Id == quiz.Id).ToListAsync());
            quiz.Questions = questions;
            return quiz;
        }
    }
}
