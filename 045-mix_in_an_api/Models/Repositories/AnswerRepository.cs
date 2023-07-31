namespace MVCExercise.Models.Repositories
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly List<Answer> _answers;

        public AnswerRepository()
        {
            _answers = new List<Answer>();
        }

        public IEnumerable<Answer> GetAll()
        {
            return new List<Answer>(this._answers);
        }
    }
}
