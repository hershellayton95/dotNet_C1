﻿using MVCExercise.Models.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _042_devoverflow.Controllers
{
    public class AnswerController : Controller
    {
        private readonly IAnswerRepository _answerRepository;

        public AnswerController(IAnswerRepository answerRepository)
        {
            this._answerRepository = answerRepository;
        }

        // GET: AnswerController
        public ActionResult Index()
        {
            var answers = _answerRepository.GetAll();
            return View(answers);
        }

        // GET: AnswerController/Details/5
        public ActionResult Details(int id)
        {
            var answer = _answerRepository.GetById(id);
            return View(answer);
        }

        // GET: AnswerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnswerController/Create
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

        // GET: AnswerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AnswerController/Edit/5
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

        // GET: AnswerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AnswerController/Delete/5
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
