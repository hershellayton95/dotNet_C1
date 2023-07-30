namespace MVCExercise.Models.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly List<Question> _question;

        public QuestionRepository()
        {
            _question = new List<Question>()
            {
                new Question()
                {
                    Id = 1,
                    Title = "Filippo Birthday",
                    Description = "When Is Filippo Birthday?",
                    Author = "Filippo Di Marco",
                    Answers = new List<Answer>() {
                        new Answer
                        {
                            Id=1,
                            Author = "Filippo Di Marco",
                            Description= "05-07-1995",
                            IsAccepted= true,
                            Question = new Question()
                        },
                        new Answer
                        {
                            Id=2,
                            Author = "Filippo Di Marco",
                            Description= "05-08-1994",
                            IsAccepted= false,
                            Question = new Question()
                        },
                        new Answer
                        {
                            Id=3,
                            Author = "Filippo Di Marco",
                            Description= "01-07-1993",
                            IsAccepted= false,
                            Question = new Question()
                        },
                        new Answer
                        {
                            Id=4,
                            Author = "Filippo Di Marco",
                            Description= "21-12-1997",
                            IsAccepted= false,
                            Question = new Question()
                        },
                    }
                },
                new Question()
                {
                    Id = 2,
                    Title = "Test",
                    Description = "Test",
                    Author = "Test",
                    Answers = new List<Answer>() {}
                }
            };
        }

        public IEnumerable<Question> GetAll()
        {
            return new List<Question>(this._question);
        }

        public Question GetById(int id)
        {
            return _question.Where(question => question.Id == id).Select(question => new Question
            {
                Id = question.Id,
                Author = question.Author,
                Title = question.Title,
                Description = question.Description,
                Answers = question.Answers,
            }).First();
        }
    }
}
