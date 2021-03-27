using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Questions
    {
        public static   List<QuestionEntity> QuestionsList()
        {
            using (var db = new SurveyContext())
            {
                return db.Question.ToList();
            }
        }

        public static void CreateQuestions(QuestionEntity OQuestions)
        {
            using (var db = new SurveyContext())
            {
                db.Question.Add(OQuestions);
                db.SaveChanges();
            }
        }
        public static void UpdateQuestions(QuestionEntity OQuestions)
        {
            using (var db = new SurveyContext())
            {
                db.Question.Update(OQuestions);
                db.SaveChanges();
            }
        }

        public static QuestionEntity QuestionsById(string id)
        {
            using (var db = new SurveyContext())
            {
                return db.Question.ToList().LastOrDefault(C => C.IdQuestions == id);
            }
        }
    }
}
