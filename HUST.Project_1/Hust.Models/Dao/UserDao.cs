using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hust.Models.Domain;
using Hust.Models.Share;

namespace Hust.Models.Dao
{
    public class UserDao
    {
        AppHustContext db = null;
        public UserDao()
        {
            db = new AppHustContext();
        }

        public string Insert(UserCompany entity)
        {
            db.UserCompanies.Add(entity);
            db.SaveChanges();
            return entity.UserID;
        }
        public string InsertForFacebook(UserCompany entity)
        {
            var user = db.UserCompanies.SingleOrDefault(x => x.Username == entity.Username);
            if (user == null)
            {
                db.UserCompanies.Add(entity);
                db.SaveChanges();
                return entity.UserID;
            }
            else
            {
                return user.UserID;
            }

        }

        public UserCompany GetById(string userName)
        {
            return db.UserCompanies.SingleOrDefault(x => x.Username == userName);
        }
        public UserCompany ViewDetail(int id)
        {
            return db.UserCompanies.Find(id);
        }
     
        public int Login(string userName, string passWord, bool isLoginAdmin = false)
        {
            var result = db.UserCompanies.SingleOrDefault(x => x.Username == userName);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if (isLoginAdmin == true)
                {
                    if (result.JobPositionID == Constants.ConfigSystems.ADMIN_GROUP || result.JobPositionID == Constants.ConfigSystems.MOD_GROUP)
                    {
                        //Guild 
                        if (result.StatusID == "e480d7b7-7b23-4ad5-99fc-e0567e800f59")
                        {
                            return -1;
                        }
                        else
                        {
                            if (result.Password == passWord)
                                return 1;
                            else
                                return -2;
                        }
                    }
                    else
                    {
                        return -3;
                    }
                }
                else
                {
                    if (result.StatusID == "e480d7b7-7b23-4ad5-99fc-e0567e800f59")
                    {
                        return -1;
                    }
                    else
                    {
                        if (result.Password == passWord)
                            return 1;
                        else
                            return -2;
                    }
                }
            }
        }

        //public bool ChangeStatus(long id)
        //{
        //    var user = db.UserCompanies.Find(id);
        //    user.Status = !user.Status;
        //    db.SaveChanges();
        //    return user.Status;
        //}
        //public bool Delete(int id)
        //{
        //    try
        //    {
        //        var user = db.Users.Find(id);
        //        db.Users.Remove(user);
        //        db.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }

        //}

        public bool CheckUserName(string userName)
        {
            return db.UserCompanies.Count(x => x.Username == userName) > 0;
        }
        public bool CheckEmail(string email)
        {
            return db.UserCompanies.Count(x => x.Email == email) > 0;
        }
    }
}
