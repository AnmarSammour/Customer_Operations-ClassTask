using Microsoft.AspNetCore.Mvc;
using Customer_Operations.Models;
using Customer_Operations.Models.Entities;
using System.Linq;

namespace Customer_Operations.Controllers
{
    public class CustomersController : Controller
    {
        private readonly Context _context;
        public CustomersController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var customerList = _context.Customers.ToList();
            return View(customerList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customers customers)
        {
            _context.Add(customers);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Update(int customerId)
        {
            var data = _context.Customers.Where(x => x.CustomerID == customerId).SingleOrDefault();
            return View(data);
        }
        [HttpPost]
        public IActionResult Update(int customerId, Customers model)
        {
            var data = _context.Customers.FirstOrDefault(x => x.CustomerID == customerId);
            if(data !=null)
            {
                data.CustomerName = model.CustomerName;
                data.CustomerNumber = model.CustomerNumber;
                data.CustomerAddress = model.CustomerAddress;
                data.CustomerMobileNumber = model.CustomerMobileNumber;

                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }

        }

        [HttpGet]
        public IActionResult Delete(int customerId)
        {
            var data = _context.Customers.Find(customerId); 
            return View(data);
        }
        [HttpPost]
        public IActionResult Delete(int customerId, Customers model)
        {
            var data = _context.Customers.FirstOrDefault(x => x.CustomerID == customerId);
            if (data != null)
            {
                _context.Customers.Remove(data);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }

        }

    }
}
