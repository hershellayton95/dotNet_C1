namespace WebApp.Models
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly List<Question> _questions;
        public QuestionRepository() {
            _questions = new List<Question>()
            {
                new Question
                {
                    Id = 1,
                    AuthorId = 1,
                    Title = "Language",
                    Description = "Which is C#",
                    AnswersId = new List<int>{ 1,2,3,4 }
                }
            };
        }
        public List<Question> GetAll()
        {
            return new List<Question>(this._questions);
        }

        public Question GetById(int id)
        {
            return _questions.Where(question => question.Id == id).Select(question => new Question
            {
                Id = question.Id,
                AuthorId = question.AuthorId,
                Title = question.Title,
                Description = question.Description,
                AnswersId = question.AnswersId,
            }).First();
        }

        public void Add(Question question)
        {
            var questionId = 1;
            if (_questions.Any())
            {
                questionId = _questions.Last().Id + 1;
            }

            _questions.Add(new Question {
                Id = questionId,
                AuthorId = question.AuthorId,
                Title = question.Title,
                Description = question.Description,
                AnswersId = question.AnswersId,
            });
        }
    }
}
