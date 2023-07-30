namespace MVCExercise.Models.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly List<Question> _question;

        public QuestionRepository()
        {
            _question = new List<Question>();
        }

        public IEnumerable<Question> GetAll()
        {
            return new List<Question>(this._question);
        }
    }
}
