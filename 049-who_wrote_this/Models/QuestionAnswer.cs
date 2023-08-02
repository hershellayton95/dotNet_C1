namespace MVCExercise.Models
{
    public class QuestionAnswer
    {
        public string Title { get; set; }
        public string Question { get; set; }
        public List<string> Answers { get; set; }
        public int AcceptAnswer { get; set; }
        public List<int> AuthorsId { get; set; } 
        public int AuthorIdSelected { get; set; }
    }
}
