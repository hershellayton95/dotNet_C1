using MVCExercise.Models.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCExercise.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionController(IQuestionRepository quesionRepository)
        {
            this._questionRepository = quesionRepository;
        }

        // GET: QuestionController
        public ActionResult Index()
        {
            var questions = _questionRepository.GetAll();
            return View(questions);
        }

        // GET: QuestionController/Details/5
        public ActionResult Details(int id)
        {
            var question = _questionRepository.GetById(id);
            return View(question);
        }

        // GET: QuestionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuestionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: QuestionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuestionController/Edit/5
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

        // GET: QuestionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuestionController/Delete/5
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
