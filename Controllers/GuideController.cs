using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rpgGame.Models;
using rpgGame.Data;
using Microsoft.Extensions.Logging;

namespace rpgGame.Controllers
{
    public class GuideController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ILogger<GuideController> _logger;

        public GuideController(ILogger<GuideController> logger, AppDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var viewModel = new GuideViewModel
            {
                Items = _context.ItemDatas.ToList(),
                Monsters = _context.MonsterDatas.ToList(),
                Events = _context.EventsDatas.ToList(),
                Statuses = _context.StatusDatas.ToList(),
                Jobs = _context.JobDatas.ToList(),
                Natures = _context.NatureDatas.ToList()
            };
            
            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}