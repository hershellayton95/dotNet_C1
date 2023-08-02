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

        public Answer GetById(int id)
        {
            return _answers
                .Where(x => x.Id == id)
                .Select(answer => new Answer
                {
                    Id = answer.Id,
                    Author = answer.Author,
                    Description = answer.Description,
                    IsAccepted = answer.IsAccepted,
                    Question = answer.Question
                })
                .First();
        }

        public void Add(Answer answer)
        {
            _answers.Add(answer);
        }
    }
}

