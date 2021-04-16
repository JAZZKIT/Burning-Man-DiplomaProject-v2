using BurnTest.Interfaces;
using BurnTest.Models;
using BurnTest.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BurnTest.Controllers
{
    public class ManageController : Controller
    {
        private IRepository<Order> db;

        public ManageController(ApplicationContext context)
        {
            db = new OrderRepository(context);
        }

        public IActionResult OrderHistory()
        {
            var model = db.GetAll().ToList();

            //TempData["OrdersList"] = order.GetAll().ToList();
            //TempData["UserList"] = user.GetAll().ToList();
            return View(model);
        }
    }
}
