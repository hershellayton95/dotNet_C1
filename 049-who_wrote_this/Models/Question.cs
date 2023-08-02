namespace MVCExercise.Models
{
    public class Question
    {
        public int Id { get; set; }
        public Author Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<Answer> Answers { get; set; }
    }
}
