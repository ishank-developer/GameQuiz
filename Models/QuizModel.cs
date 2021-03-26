using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameQuiz.Models
{
    public class QuizModel
    {
        [Display(Name ="id")]
        public int id { get; set; }
        [Display(Name = "Question")]
        public string Question { get; set; }

        [Display(Name = "Option1")]
        public string Option1 { get; set; }

        [Display(Name = "Option2")]
        public string Option2 { get; set; }

        [Display(Name = "Option3")]
        public string Option3 { get; set; }

        [Display(Name = "Option4")]
        public string Option4 { get; set; }

        [Display(Name = "CorrectOption")]
        public string CorrectOption { get; set; }
    }
}