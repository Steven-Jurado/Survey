using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Users
    {
        public static   List<UserEntity> UsersList()
        {
            using (var db = new SurveyContext())
            {
                return db.User.ToList();
            }
        }

        public static void CreateUsers(UserEntity OUser)
        {
            using (var db = new SurveyContext())
            {
                db.User.Add(OUser);
                db.SaveChanges();
            }
        }
        public static void UpdateUsers(UserEntity OUser)
        {
            using (var db = new SurveyContext())
            {
                db.User.Update(OUser);
                db.SaveChanges();
            }
        }

        public static UserEntity UsersById(string id)
        {

            using (var db = new SurveyContext())
            {
                return db.User.ToList().LastOrDefault(c =>c.IdUser == id);
            }
        }
    }
}
