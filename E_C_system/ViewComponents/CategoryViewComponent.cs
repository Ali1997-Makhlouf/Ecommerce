using E_C_system.Servises.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_C_system.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly ICategoryServices _category;


        public CategoryViewComponent (ICategoryServices category)
        {
            _category = category;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var services = await _category.GetCategory();

            return View(services);
        }
    }
}
