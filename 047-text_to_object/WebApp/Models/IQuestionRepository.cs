namespace WebApp.Models
{
    public interface IQuestionRepository
    {
        List<Question> GetAll();
        Question GetById(int id);
        void Add(Question question);
    }
}
