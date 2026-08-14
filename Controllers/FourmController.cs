using Microsoft.AspNetCore.Mvc;
using rpgGame.Data;
using rpgGame.Models;
using System;
using System.Linq;

namespace rpgGame.Controllers
{
    public class ForumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}