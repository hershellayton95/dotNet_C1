using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionController(IQuestionRepository questionRepository)
        {
            this._questionRepository = questionRepository;
        }

        // GET: QuestionAnswerController
        public ActionResult Index()
        {
            var questions = _questionRepository.GetAll();
            return View(questions);
        }

        // GET: QuestionAnswerController/Details/5
        public ActionResult Details(int id)
        {
            var question = _questionRepository.GetById(id);
            return View(question);
        }

        // GET: QuestionAnswerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuestionAnswerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Question quesAnsView)
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
