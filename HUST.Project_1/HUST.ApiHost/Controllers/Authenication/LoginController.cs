using Hust.Models.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HUST.ApiHost.Controllers.Authenication
{
    public class LoginController : ApiController
    {
        [HttpGet]
        public int Login(string userName, string passWord, bool isLoginAdmin = false)
        {
            UserDao userDao = new UserDao();
            return userDao.Login(userName, passWord, isLoginAdmin);
        }
    }
}
