using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCExercise.Models;
using MVCExercise.Models.Repositories;

namespace MVCExercise.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorsRepository _authorsRepository;

        public AuthorController(IAuthorsRepository authorsRepository)
        {
            this._authorsRepository = authorsRepository;
        }
        // GET: AuthorController
        public ActionResult Index()
        {
            var authors = _authorsRepository.GetAll();
            return View(authors);
        }

        // GET: AuthorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AuthorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Author collection)
        {
            try
            {
                var authorId = 1;
                if (_authorsRepository.GetAll().Any())
                    authorId = _authorsRepository.GetAll().Last().Id + 1;

                var author = new Author
                {
                    Id = authorId,
                    Name = collection.Name
                };

                _authorsRepository.Add(author);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AuthorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AuthorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
