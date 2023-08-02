namespace WebApp.Models
{
    public class QuestionAnswerViewModel
    {
        public int AuthorId { get; set; }
        public List<int> AuthorsId { get; set; }
        public string Title { get; set; }
        public string Question { get; set; }
        public string[] Answers { get; set; }
        public int AcceptAnswer { get; set; }
    }
}
