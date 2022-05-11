
namespace Common.DTOs
{
    public class QuestionDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<AnswerDto> Answers { get; set; }
    }
}
