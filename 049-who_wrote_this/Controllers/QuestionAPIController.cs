using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCExercise.Models;
using MVCExercise.Models.Repositories;

namespace MVCExercise.Controllers
{
    [Route("api/question")]
    [ApiController]
    public class QuestionAPIController : ControllerBase
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionAPIController(IQuestionRepository questionRepository)
        {
            this._questionRepository = questionRepository;
        }
        [HttpGet(Name = "GetAll")]
        public IEnumerable<Question> GetAll()
        {
            return _questionRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetById")]
        public ActionResult GetById(int id)
        {
            var question = this._questionRepository.GetById(id);
            return new JsonResult(question);
        }
    }
}
