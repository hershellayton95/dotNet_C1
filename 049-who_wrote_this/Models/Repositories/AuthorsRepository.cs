namespace MVCExercise.Models.Repositories
{
    public class AuthorsRepository : IAuthorsRepository
    {
        private readonly List<Author> _authors;
        public AuthorsRepository()
        {
            _authors = new List<Author>();
        }

        public List<Author> GetAll()
        {
            return new List<Author>(this._authors);
        }
        public Author GetById(int id)
        {
            return _authors
                .Where(x => x.Id == id)
                .Select(question => new Author
                {
                    Id = question.Id,
                    Name = question.Name
                })
                .First();
        }

        public void Add(Author author)
        {
            _authors.Add(author);
        }

    }
}
