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
        private readonly IRepo<Customer, int> _repo;

        public UserController(CinemaContext context, ILogger<UserController> logger, IRepo<Customer, int> repo)
        {
            _context = context;
            _logger = logger;
            _repo = repo;
        }
        public IActionResult Login(int movieId)
        {
            ViewBag.MovieId = movieId;
            User user = new User();
            return View(user);
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(int movieId, User user)
        {
            try
            {
                ViewBag.MovieId = movieId;
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
                    TempData["CustomerName"] = myCustomer.First_Name;
                    TempData["CustomerId"] = myCustomer.Id;
                    TempData.Keep("CustomerName");
                    TempData.Keep("CustomerId");
                    _logger.LogInformation("Login success");

                    if (movieId != 0)
                        return RedirectToAction("Index", "Booking", new { movieId = movieId });

                    return RedirectToAction("Index", "User");

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

        public IActionResult Index()
        {
            var id = (int)TempData.Peek("CustomerId");
            var cust = _repo.Get(id);
            if (cust == null)
            {
                ViewBag.Message = "No user available";
                return View();
            }

            return View(cust);

        }

        public IActionResult Logout()
        {
            TempData.Clear();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Edit(int id)
        {
            //return View();
            Customer myCustomer;
            try
            {
                myCustomer = _context.Customers.SingleOrDefault(itm => itm.Id == id);
            }
            catch (ArgumentNullException ane)
            {
                myCustomer = null;
                _logger.LogError("The argument is null " + ane.Message);
            }
            catch (InvalidOperationException ioe)
            {
                myCustomer = null;
                _logger.LogError("Could not edit customer details " + ioe.Message);
            }
            return View(myCustomer);

        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Customer customer)
        {
            try
            {
                //var myCustomer = _repo.Edit(id, customer);
                //if (myCustomer != null)
                //if (ModelState.IsValid)
                //{
                var myCustomer = _repo.Edit(id, customer);
                if (myCustomer != null)
                    //{

                    //    return RedirectToAction("Index", "User");
                    ViewBag.Message = "Update success";
                //}
                return View("Edit", customer);

                //}
            }
            catch (Exception e)
            {
                _logger.LogError("Could not update customer details " + e.Message);
            }
            //return View("Edit", customer);

            //Customer myCustomer = _context.Customers.Single(itm => itm.Id == id);

            //myCustomer.First_Name = customer.First_Name;
            //myCustomer.Last_Name = customer.Last_Name;
            //myCustomer.Address = customer.Address;
            //myCustomer.Phone = customer.First_Name;
            //myCustomer.Email = customer.First_Name;
            return RedirectToAction("Index", "User");
            //return View("Edit", customer);
            //return View();
        }
    }











        //private readonly CinemaContext _context;
        //    private readonly ILogger<UserController> _logger;


        //    public UserController(CinemaContext context, ILogger<UserController> logger)
        //    {
        //        _context = context;
        //        _logger = logger;
        //    }
        //    public IActionResult Login()
        //    {
        //        User user = new User();
        //        return View(user);
        //    }

        //    [HttpPost]
        //    [AllowAnonymous]
        //    public IActionResult Login(User user)
        //    {
        //        try
        //        {
        //            var myCustomer = _context.Customers.SingleOrDefault(e => e.Username == user.Username);
        //            if (myCustomer != null)
        //            {
        //                using var hmac = new HMACSHA512(myCustomer.PasswordSalt);
        //                var checkPass = hmac.ComputeHash(Encoding.UTF8.GetBytes(user.Password));
        //                for (int i = 0; i < checkPass.Length; i++)
        //                {
        //                    if (checkPass[i] != myCustomer.Password[i])
        //                    {
        //                        ViewBag.Message = "Invalid username or password";
        //                        return View();
        //                    }

        //                }
        //                ViewBag.Message = "Welcome " + myCustomer.First_Name;
        //                return RedirectToAction("Index", "Home");

        //            }
        //            else
        //                ViewBag.Message = "Invalid username or password";
        //            return View();
        //        }
        //        catch (Exception)
        //        {
        //            _logger.LogDebug("Login failed " + user);
        //        }
        //        return View();
        //    }

        //    public IActionResult Register()
        //    {
        //        CustomerViewModel customerViewModel = new CustomerViewModel();
        //        return View(customerViewModel);
        //    }

        //    [HttpPost]
        //    [AllowAnonymous]
        //    public IActionResult Register(CustomerViewModel customer)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            if (customer.Date_Of_Birth.Year <= 2009 && customer.Date_Of_Birth.Year > 1920)
        //            {

        //                Customer myCustomer = customer;
        //                using var hmac = new HMACSHA512();
        //                myCustomer.Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(customer.UserPassword));
        //                myCustomer.PasswordSalt = hmac.Key;
        //                _context.Customers.Add(myCustomer);
        //                _context.SaveChanges();
        //                _logger.LogInformation("User added", myCustomer);
        //                TempData["CustomerId"] = customer.Id;
        //                return RedirectToAction("Login");
        //            }

        //            else
        //            {
        //                ViewBag.Message = "You are not eligible to sign up at this time.";
        //                return View();
        //            }
        //        }

        //        CustomerViewModel customerViewModel = new CustomerViewModel();
        //        return View(customerViewModel);

        //    }



    }

