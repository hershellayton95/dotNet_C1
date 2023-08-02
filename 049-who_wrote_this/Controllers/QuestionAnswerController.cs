using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCExercise.Models;
using MVCExercise.Models.Repositories;

namespace MVCExercise.Controllers
{
    public class QuestionAnswerController : Controller
    {
        private readonly IAuthorsRepository _authorsRepository;
        private readonly IQuestionRepository _questionRepository;
        private readonly IAnswerRepository _answerRepository;

        public QuestionAnswerController(IAuthorsRepository authorsRepository, IQuestionRepository questionRepository, IAnswerRepository answerRepository)
        {
            this._authorsRepository = authorsRepository;
            this._questionRepository = questionRepository;
            this._answerRepository = answerRepository;
        }

        // GET: QuestionAnswerController
        public ActionResult Index()
        {
            return RedirectToAction(nameof(this.Create));
        }

        // GET: QuestionAnswerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuestionAnswerController/Create
        public ActionResult Create()
        {
            var model = new QuestionAnswer();
            model.AuthorsId = _authorsRepository.GetAll().Select(x => x.Id).ToList();
            return View(model);
        }

        // POST: QuestionAnswerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(QuestionAnswer collection)
        {
            try
            {
                var author = _authorsRepository.GetById(collection.AuthorIdSelected);
                var answerId = 1;
                var answersList = new List<Answer>();
                var interationCount = 1;

                var questionId = 1;
                if (_questionRepository.GetAll().Any())
                    questionId = _questionRepository.GetAll().Last().Id + 1;

                var question = new Question
                {
                    Id = questionId,
                    Title = collection.Title,
                    Author = author,
                    Description = collection.Question,
                    Answers = answersList
                };

                foreach (var item in collection.Answers)
                {
                    var isAccepted = false;
                    if (interationCount == collection.AcceptAnswer) isAccepted = true;
                    
                    interationCount++;

                    if (_answerRepository.GetAll().Any())
                         answerId = _answerRepository.GetAll().Last().Id + 1;

                    var answer = new Answer
                    {
                        Id = answerId,
                        Author = author,
                        Question = question,
                        IsAccepted = isAccepted,
                        Description = item
                    };
                    _answerRepository.Add(answer);
                    answersList.Add(answer);
                }

                _questionRepository.Add(question);

                return RedirectToAction("Index", "Question");
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
