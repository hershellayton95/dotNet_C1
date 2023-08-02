namespace WebApp.Models
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly List<Answer> _answers;
        public AnswerRepository() {
            _answers = new List<Answer>()
            {
                new Answer
                {
                    Id = 1,
                    AuthorId = 1,
                    QuestionId = 1,
                    Description = "Note",
                    isAccepted = false
                },
                new Answer
                {
                    Id = 2,
                    AuthorId = 1,
                    QuestionId = 1,
                    Description = "Programming Language",
                    isAccepted = true
                },
                new Answer
                {
                    Id = 3,
                    AuthorId = 1,
                    QuestionId = 1,
                    Description = "A Smarthphone",
                    isAccepted = false
                },
                new Answer
                {
                    Id = 4,
                    AuthorId = 1,
                    QuestionId = 1,
                    Description = "A PC",
                    isAccepted = false
                }
            };
        }
        public List<Answer> GetAll()
        {
            return new List<Answer>(this._answers);
        }

        public Answer GetById(int id)
        {
            return _answers
                .Where(answer => answer.Id == id)
                .Select(answer => new Answer
            {
                    Id = answer.Id,
                    AuthorId = answer.AuthorId,
                    QuestionId = answer.QuestionId,
                    Description = answer.Description,
                }).First();
        }

        public void Add(Answer answer)
        {
            var answerId = 1;
            if (_answers.Any())
            {
                answerId = _answers.Last().Id + 1;
            }

            _answers.Add(new Answer
            {
                Id = answerId,
                AuthorId = answer.AuthorId,
                QuestionId = answer.QuestionId,
                Description = answer.Description,
            });
        }
    }
}
