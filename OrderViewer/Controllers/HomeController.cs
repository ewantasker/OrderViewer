using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderViewer.Data;
using OrderViewer.Models;
using System.Diagnostics;

namespace OrderViewer.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var query = HttpContext.Request.Query;
            var queryable = _context.Orders.AsQueryable();

            var status = query["status"];
            var startDate = query["startDate"];
            var endDate = query["endDate"];
            var minTotal = query["minTotal"];
            var maxTotal = query["maxTotal"];

            if (!string.IsNullOrEmpty(status) && status != "All")
            {
                queryable = queryable.Where(o => o.Status == status);
            }

            if (DateTime.TryParse(startDate, out var start))
            {
                queryable = queryable.Where(o => o.CreatedDate >= start);
            }

            if (DateTime.TryParse(endDate, out var end))
            {
                queryable = queryable.Where(o => o.CreatedDate <= end);
            }

            if (decimal.TryParse(minTotal, out var min))
            {
                queryable = queryable.Where(o => o.Total >= min);
            }

            if (decimal.TryParse(maxTotal, out var max))
            {
                queryable = queryable.Where(o => o.Total <= max);
            }

            var orders = await queryable.ToListAsync();
            return View(orders);
        }

        [HttpPost]
        public async Task<IActionResult> MarkPaid([FromBody] OrderUpdate order)
        {
            var existingOrder = await _context.Orders.FindAsync(order.Id);
            if (existingOrder == null)
            {
                return NotFound();
            }

            existingOrder.Paid = order.Paid;
            await _context.SaveChangesAsync();

            return Json(new { success = true, message = $"Order #{existingOrder.Id} marked as {(existingOrder.Paid ? "Paid" : "Unpaid")}." });
        }
    }
}
