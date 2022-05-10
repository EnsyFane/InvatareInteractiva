
namespace Common.Entities
{
    public class Quiz
    {
        public int Id { get; set; }
        public string NoChapter { get; set; }
        public List<Question> Questions { get; set; }

    }
}
