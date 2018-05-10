using Microsoft.AspNetCore.Mvc;
using MyApp.ViewModels;

namespace MyApp.Web.Features.Customer.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Movies/Create
        public IActionResult Create()
        {
            return View("Index");
        }

        // POST: Movies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CustomerViewModel customer)
        {
            if (ModelState.IsValid)
            {
                // do something here...
            }
            return View("Index");
        }
    }
}