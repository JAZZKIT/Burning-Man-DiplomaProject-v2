using BurnTest.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Identity;
using BurnTest.Interfaces;
using BurnTest.Repositories;

namespace BurnTest.Controllers
{
    public class TicketManageController : Controller
    {
        private readonly UserManager<User> _userManager;
        private string GetCurrentUserIdAsync() => _userManager.GetUserId(HttpContext.User);
        private IRepository<Order> db;

        public IActionResult TicketMainPage()
        {
            return View();
        }

        public TicketManageController(UserManager<User> userManager, ApplicationContext context)
        {
            _userManager = userManager;
            db = new OrderRepository(context);
        }


        [HttpPost]
        public string BdTest(string price, string qt)
        {
            Order Ord = new Order
            {
                Quantity = Convert.ToInt32(qt),
                Amount = Convert.ToDecimal(price),
                OrderDateTime = DateTime.Now,
                TicketId = 1,
                UserId = GetCurrentUserIdAsync()
            };
            db.Create(Ord);
            db.Save();
            return qt;
        }
    }
}
