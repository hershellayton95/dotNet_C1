namespace MVCExercise.Models.Repositories
{
    public interface IAnswerRepository
    {
        IEnumerable<Answer> GetAll();
    }
}