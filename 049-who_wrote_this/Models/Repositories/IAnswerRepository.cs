namespace MVCExercise.Models.Repositories
{
    public interface IAnswerRepository
    {
        IEnumerable<Answer> GetAll();
        Answer GetById(int id);
        void Add(Answer answer);
    }
}