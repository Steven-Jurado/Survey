using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Surey
    {
        public static List<SurveyEntity> SureyList()
        {
            using (var db = new SurveyContext())
            {
                return db.Survey.ToList();
            }
        }

        public static void CreateSurey(SurveyEntity OSurvey)
        {
            using (var db = new SurveyContext())
            {
                db.Survey.Add(OSurvey);
                db.SaveChanges();
            }
        }
        public static void UpdateSurvey(SurveyEntity OSurvey)
        {
            using (var db = new SurveyContext())
            {
                db.Survey.Update(OSurvey);
                db.SaveChanges();
            }
        }

        public static SurveyEntity SurveyById(string id)
        {
            using (var db = new SurveyContext())
            {
                return db.Survey.ToList().LastOrDefault(C => C.IdSuvey == id);
            }
        }
    }
}
