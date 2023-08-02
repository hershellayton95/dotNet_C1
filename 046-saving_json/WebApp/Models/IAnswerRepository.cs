namespace WebApp.Models
{
    public interface IAnswerRepository
    {
        List<Answer> GetAll();
        Answer GetById(int id);
        void Add(Answer question);
    }
}
