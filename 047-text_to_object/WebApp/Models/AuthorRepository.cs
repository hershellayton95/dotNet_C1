namespace WebApp.Models
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly List<Author> _authors;

        public AuthorRepository() {
            _authors = new List<Author>
            {
                new Author
                {
                    Id = 1,
                    Name = "Filippo Di Marco"
                },
                new Author
                {
                    Id = 2,
                    Name = "Marco Di Filippo"
                }
            };
        }

        public List<Author> GetAll()
        {
            return new List<Author>(this._authors);
        }

        public Author GetById(int id)
        {
            return _authors.Where(author => author.Id == id).Select(author => new Author { Id = author.Id, Name = author.Name}).First();
        }

        public void Add(Author author)
        {
            var authorId = 1;
            if (_authors.Any())
            {
                authorId = _authors.Last().Id + 1;
            }
            
            _authors.Add(new Author { Id = authorId, Name = author.Name});
        }
    }
}
