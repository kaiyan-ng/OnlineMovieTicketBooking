using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineMovieTicketBookingApp.Models;
using OnlineMovieTicketBookingApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingApp.Controllers
{
    public class UserController : Controller
    {
        private readonly CinemaContext _context;
        private readonly ILogger<UserController> _logger;
       

        public UserController(CinemaContext context, ILogger<UserController> logger)
        {
            _context = context;
            _logger = logger;
        }
        public IActionResult Login()
        {
            User user = new User();
            return View(user);
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(User user)
        {
            try
            {
                        var myCustomer = _context.Customers.SingleOrDefault(e => e.Username == user.Username);
                        if (myCustomer != null)
                        {
                            using var hmac = new HMACSHA512(myCustomer.PasswordSalt);
                            var checkPass = hmac.ComputeHash(Encoding.UTF8.GetBytes(user.Password));
                            for (int i = 0; i < checkPass.Length; i++)
                            {
                                if (checkPass[i] != myCustomer.Password[i])
                                {
                                ViewBag.Message = "Invalid username or password";
                                return View();
                                 }

                            }
                        ViewBag.Message = "Welcome " + myCustomer.First_Name;
                        return RedirectToAction("Index","Home");

                        }
                        else
                        ViewBag.Message = "Invalid username or password";
                        return View();
            }
            catch (Exception)
            {
                _logger.LogDebug("Login failed " + user);
            }
            return View();
        }

        public IActionResult Register()
        {
            // var genderList = _context.Customers
            //.Select(sl => new SelectListItem() { Text = sl.Gender, Value = sl.Id.ToString() }).Distinct()
            //.ToList();
            // genderList.Insert(0, new SelectListItem { Value = string.Empty, Text = "---Select Gender---" });
            //CustomerViewModel customerViewModel = new CustomerViewModel();
            //customerViewModel.GenderList = genderList;
            //return View(customerViewModel);
            CustomerViewModel customerViewModel = new CustomerViewModel();
            return View(customerViewModel);
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Register(CustomerViewModel customer)
        {
                if (ModelState.IsValid)
                {
                    if (customer.Date_Of_Birth.Year <= 2009 && customer.Date_Of_Birth.Year > 1920)
                    {
                    
                    Customer myCustomer = customer;
                    using var hmac = new HMACSHA512();
                    myCustomer.Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(customer.UserPassword));
                    myCustomer.PasswordSalt = hmac.Key;
                    _context.Customers.Add(myCustomer);
                    _context.SaveChanges();
                    _logger.LogInformation("User added", myCustomer);
                    TempData["CustomerId"] = customer.Id;
                    return RedirectToAction("Login");
                    }

                    else
                    {
                        ViewBag.Message = "You are not eligible to sign up at this time.";
                        return View();
                    }
                }

            CustomerViewModel customerViewModel = new CustomerViewModel();
            return View(customerViewModel);

        }

       

    }
}
