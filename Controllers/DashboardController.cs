using GrowthDashboard.Data;
using GrowthDashboard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace GrowthDashboard.Controllers
{
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.ChartPoints
                .FromSqlRaw("EXEC sp_EmployeeGrowth")
                .ToList();

            return View(data);
        }


    }
}
