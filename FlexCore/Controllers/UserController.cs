using FlexCore.Models;
using Google.Apis.Auth;
using Members.dll.Dtos;
using Members.dll.Infa.Repositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Linq;

namespace FlexCore.Controllers
{    
    
    public class UserController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserRepository _repo;

        /// <summary>
        /// 建構式將AppDbContext注入UserController
        /// </summary>
        /// <param name="db"></param>
        public UserController(AppDbContext db)
        {
            _db = db;
        }

        //public UserController(UserRepository repo)
        //{
        //    _repo = repo;
        //}

        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Verified()
        {
            return View();
        }

        public IActionResult Login()
        {
            return RedirectToAction("Home/Index");
        }

    }
}
