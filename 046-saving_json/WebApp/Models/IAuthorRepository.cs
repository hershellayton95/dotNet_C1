namespace WebApp.Models
{
    public interface IAuthorRepository
    {
        public List<Author> GetAll();
        public Author GetById(int id);
        public void Add(Author author);
    }
}