namespace WebApp.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int QuestionId { get; set; }
        public string Description { get; set; }
        public bool isAccepted { get; set; }
    }
}
