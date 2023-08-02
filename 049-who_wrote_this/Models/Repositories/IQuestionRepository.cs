namespace MVCExercise.Models.Repositories
{
    public interface IQuestionRepository
    {
        IEnumerable<Question> GetAll();
        Question GetById(int id);
    }
}