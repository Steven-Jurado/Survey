using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Answer
    {
        public static   List<AnswerEntity> AnswersList()
        {
            using (var db = new SurveyContext())
            {
                return db.Answer.ToList();
            }
        }

        public static void CreateAnswer(AnswerEntity OAnswers)
        {
            using (var db = new SurveyContext())
            {
                db.Answer.Add(OAnswers);
                db.SaveChanges();
            }
        }
        public static void UpdateAnswer(AnswerEntity OAnswers)
        {
            using (var db = new SurveyContext())
            {
                db.Answer.Update(OAnswers);
                db.SaveChanges();
            }
        }

        public static AnswerEntity AnswersById(string id)
        {
            using (var db = new SurveyContext())
            {
                return db.Answer.ToList().LastOrDefault(C => C.IdAnswer == id);
            }
        }
    }
}
