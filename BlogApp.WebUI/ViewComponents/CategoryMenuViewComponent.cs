using BlogApp.Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.WebUI.ViewComponents
{
    
    public class CategoryMenuViewComponent:ViewComponent
    {
        private ICategoryRepository _repository;
        public CategoryMenuViewComponent(ICategoryRepository repo)
        {
            _repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["id"];
            return View(_repository.GetAll());
        }
    }
}
