using Microsoft.AspNetCore.Mvc;
using Services.Dtos;
using Services.IServices;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MvcTemplate.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IService service;

        public CategoryController(IService s)
        {
            service = s;
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            var model = new CategoryModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            await service.AddCategory(model);
            return RedirectToAction("AddCategory");
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            List<CategoryModel> categories = await service.GetAllCategories();
            return View(categories);
        }
    }
}
