﻿
namespace Common.DTOs
{
    public class QuizDto
    {
        public int Id { get; set; }
        public int NoChapter { get; set; }
        public List<QuestionDto> Questions { get; set; }
    }
}
