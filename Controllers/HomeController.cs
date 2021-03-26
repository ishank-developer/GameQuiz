using GameQuiz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameQuiz.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EasyQuiz()
        {
            QuizHandller QuesRepo = new QuizHandller();
            ModelState.Clear();
            return View(QuesRepo.GetAllEasyQuestions());
        }

        public ActionResult MediumQuiz()
        {
            QuizHandller QuesRepo = new QuizHandller();
            ModelState.Clear();
            return View(QuesRepo.GetAllMediumQuestions());
        }

        public ActionResult HardQuiz()
        {
            QuizHandller QuesRepo = new QuizHandller();
            ModelState.Clear();
            return View(QuesRepo.GetAllHardQuestions());
        }
    }
}