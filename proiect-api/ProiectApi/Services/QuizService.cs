using AutoMapper;
using Common.DTOs;
using DataPersistence;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    #region interface
    public interface IQuizService
    {
        Task<QuizDto> GetQuiz(string noChapter);
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

        public async Task<QuizDto> GetQuiz(string noChapter)
        {
            var quiz = _map.Map<QuizDto>(await _context.Quizzes.FirstOrDefaultAsync(x => x.NoChapter == noChapter));
            var questions = _map.Map<List<QuestionDto>>(await _context.Questions.Where(x => x.Quiz.Id == quiz.Id).ToListAsync());
            List<AnswerDto> answers = new List<AnswerDto>();
            foreach (var q in questions)
            {
                var ans = _map.Map<List<AnswerDto>>(await _context.Answers.Where(x => x.Question.Id == q.Id).ToListAsync());
                q.Answers = ans;
            }
            quiz.Questions = questions;
            return quiz;
        }

    }
}
