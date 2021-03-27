using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Categories
    {
        public static   List<CategoryEntity> CategoriesList()
        {
            using (var db = new SurveyContext())
            {
                return db.Category.ToList();
            }
        }

        public static void CreateCategories(CategoryEntity OCategories)
        {
            using (var db = new SurveyContext())
            {
                db.Category.Add(OCategories);
                db.SaveChanges();
            }
        }
        public static void UpdateUsers(CategoryEntity OCategories)
        {
            using (var db = new SurveyContext())
            {
                db.Category.Update(OCategories);
                db.SaveChanges();
            }
        }

        public static CategoryEntity CategoriesById(string id)
        {
            using (var db = new SurveyContext())
            {
                return db.Category.ToList().LastOrDefault(C => C.IdCategory == id);
            }
        }
    }
}
