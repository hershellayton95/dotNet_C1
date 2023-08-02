using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class AnswerController : Controller
    {
        private readonly IAnswerRepository _answerRepository;

        public AnswerController(IAnswerRepository answerRepository )
        {
            this._answerRepository = answerRepository;
        }

        // GET: QuestionAnswerController
        public ActionResult Index()
        {
            var answers = _answerRepository.GetAll();
                return View(answers);
        }

        // GET: QuestionAnswerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuestionAnswerController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: QuestionAnswerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Answer quesAnsView)
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

        // GET: QuestionAnswerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuestionAnswerController/Edit/5
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

        // GET: QuestionAnswerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuestionAnswerController/Delete/5
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
