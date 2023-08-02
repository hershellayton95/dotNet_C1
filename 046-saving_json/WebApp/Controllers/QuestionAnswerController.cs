using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class QuestionAnswerController : Controller
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IQuestionRepository _questionRepository;
        private readonly IAnswerRepository _answerRepository;

        public QuestionAnswerController(IAuthorRepository authorRepository, IQuestionRepository questionRepository, IAnswerRepository answerRepository )
        {
            this._authorRepository = authorRepository;
            this._questionRepository = questionRepository;
            this._answerRepository = answerRepository;
        }

        // GET: QuestionAnswerController
        public ActionResult Index()
        {
            try
            {
                return RedirectToAction(nameof(Create));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestionAnswerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuestionAnswerController/Create
        public ActionResult Create()
        {

            var authorsId = _authorRepository.GetAll().Select(author => author.Id).ToList();
            return View(new QuestionAnswerViewModel { AuthorsId = authorsId});
        }

        // POST: QuestionAnswerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(QuestionAnswerViewModel quesAnsView)
        {
            try
            {
                var answerCount = 1;
                
                var questionId = 1;
                var answersId = new List<int>();
                var answerId = 1;

                if (_questionRepository.GetAll().Any())
                {
                    questionId = _questionRepository.GetAll().Last().Id + 1;
                }
 
                var question = new Question
                {
                    Id = questionId,
                    AuthorId = quesAnsView.AuthorId,
                    Title = quesAnsView.Title,
                    Description = quesAnsView.Question,
                    AnswersId = answersId,
                };

                foreach(var answer in quesAnsView.Answers)
                {
                    var isAccepted = false;

                    if (_answerRepository.GetAll().Any())
                        answerId = _answerRepository.GetAll().Last().Id + 1; 

                    answersId.Add(answerId);

                    if (quesAnsView.AcceptAnswer == answerCount)
                        isAccepted = true;

                    _answerRepository.Add(new Answer
                    {
                        Id = answerId,
                        AuthorId = quesAnsView.AuthorId,
                        QuestionId = questionId,
                        Description = answer,
                        isAccepted = isAccepted
                    });
                }

                _questionRepository.Add(question);

                return RedirectToAction("Index");
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
