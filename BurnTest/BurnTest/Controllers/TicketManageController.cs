using BurnTest.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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

        public IActionResult TicketPreBuyPage()
        {
            return View();
        }
        
        public IActionResult TicketMainPage()
        {
            return View();
        }


        public IActionResult TicketSellPage(string OrdId)
        {
            @ViewBag.OrderId = OrdId; 
            return View();
        }
        [HttpPost]
        public IActionResult TicketPayCardPage(string ordId, string cardNum)
        {
            Order ConfirmPay = db.Get(Convert.ToInt32(ordId));
            ConfirmPay.Status = "Paid";
            ConfirmPay.CardCode = Convert.ToInt64(cardNum);
            db.Update(ConfirmPay);
            db.Save();
            return RedirectToAction("Index", "Home");
        }

        public TicketManageController(UserManager<User> userManager, ApplicationContext context)
        {
            _userManager = userManager;
            db = new OrderRepository(context);
        }


        [HttpPost]
        public IActionResult BdTest(string price, string qt)
        {
            Order Ord = new Order
            {
                Quantity = Convert.ToInt32(qt),
                Amount = Convert.ToDecimal(price),
                OrderDateTime = DateTime.Now,
                Mail = User.Identity.Name,
                //TicketId = 1,
                Status = "Unpaid",
                UserId = GetCurrentUserIdAsync()
            };
            db.Create(Ord);
            db.Save();
            return RedirectToAction("TicketSellPage", "TicketManage", new {OrdId = Ord.Id});
        }
    }
}
