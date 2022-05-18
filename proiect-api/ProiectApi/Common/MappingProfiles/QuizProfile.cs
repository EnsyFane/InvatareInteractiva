using AutoMapper;
using Common.DTOs;
using Common.Entities;
using Common.ViewModels;

namespace Common.MappingProfiles
{
    public class QuizProfile : Profile
    {
        public QuizProfile()
        {
            CreateMap<Quiz, QuizDto>().ReverseMap();
            CreateMap<Question, QuestionDto>().ReverseMap();
            CreateMap<Question, QuestionDto>().ReverseMap();
            CreateMap<QuizDto, QuizViewModel>();
            CreateMap<QuestionDto, QuestionViewModel>();
        }
    }
}
