using Microsoft.AspNetCore.Mvc;
using SalesSites.Models;

namespace SalesSites.Controllers
{
    public class SuppliersController : Controller
    {
        //GET: Suppliers
        public ActionResult Index()
        {
            IEnumerable<SuppliersViewModel>? suppliersViewModels;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7019/Suppliers/getsuppliers");
                var response = client.GetAsync("getsuppliers");
                response.Wait();

                var results = response.Result;

                if (results.IsSuccessStatusCode)
                {
                    var readReasults = results.Content.ReadFromJsonAsync<List<SuppliersViewModel>>();
                    readReasults.Wait();
                    suppliersViewModels = readReasults.Result;
                }
                else
                {
                    suppliersViewModels = Enumerable.Empty<SuppliersViewModel>();
                    ModelState.AddModelError(String.Empty, "Server Error!");
                }
            }
            return View(suppliersViewModels);
        }

        // POST: Supplier
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(SuppliersViewModel suppliersViewModel)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7019/Suppliers/createPerson");
                var response = client.PostAsJsonAsync<SuppliersViewModel>("createPerson", suppliersViewModel);
                response.Wait();

                var results = response.Result;

                if (results.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError(string.Empty, "Server Error on POST");
            return View(suppliersViewModel);
        }
    }
}
