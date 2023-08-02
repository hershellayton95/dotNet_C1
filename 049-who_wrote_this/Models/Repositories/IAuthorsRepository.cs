namespace MVCExercise.Models.Repositories
{
    public interface IAuthorsRepository
    {
        List<Author> GetAll();
        Author GetById(int id);

        void Add(Author author);
    }
}