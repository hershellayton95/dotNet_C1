﻿namespace WebApp.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public IEnumerable<int> AnswersId { get; set; }

    }
}
