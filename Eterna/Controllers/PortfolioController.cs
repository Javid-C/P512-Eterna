using Eterna.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;

        public PortfolioController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Portfolio> model = _context.Portfolios.ToList();
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            Portfolio portfolio = _context.Portfolios.Include(p=>p.PortfolioImages).FirstOrDefault(p => p.Id == id);
            if (portfolio == null) return NotFound();
            return View(portfolio);
        }
    }
}
