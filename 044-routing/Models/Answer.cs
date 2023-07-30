namespace MVCExercise.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public bool IsAccepted { get; set; }
        public Question Question { get; set; }
    }
}
