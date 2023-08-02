namespace MVCExercise.Models.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly List<Question> _questions;

        public QuestionRepository()
        {
            _questions = new List<Question>();
        }

        public IEnumerable<Question> GetAll()
        {
            return new List<Question>(this._questions);
        }

        public Question GetById(int id)
        {
            return _questions.Where(question => question.Id == id).Select(question => new Question
            {
                Id = question.Id,
                Author = question.Author,
                Title = question.Title,
                Description = question.Description,
                Answers = question.Answers,
            }).First();
        }
        public void Add(Question question)
        {
            _questions.Add(question);
        }
    }
}
