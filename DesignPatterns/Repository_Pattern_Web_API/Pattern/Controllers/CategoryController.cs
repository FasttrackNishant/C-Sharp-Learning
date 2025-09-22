using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pattern.Model;
using Pattern.Repository;
using Pattern.UnitOfWork;

namespace Pattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        IRepository<Category> categoryRepository;
           
         public CategoryController(IUnitOfWork unitOfwork)
         {
            _unitOfWork = unitOfwork;
             categoryRepository = new CategoryRepository(_unitOfWork);
         }
         [HttpGet]
         public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
         { 
             var categories = await categoryRepository.Get();
             return categories;
         }

         [HttpPost]
         public async Task<ActionResult<Category>> CreateCategory(Category category)
         {
             var categories = await categoryRepository.Create(category);
             return categories;
         }

         [HttpDelete("{id}")]
         public async Task<IActionResult> DeleteCategory(int id)
         {
             var categories = await categoryRepository.Delete(id);
             return categories;
         }

         [HttpPut("{id}")]
         public async Task<IActionResult> UpdateCategory(int id, Category category)
         {
             var categories = await categoryRepository.Update(id,category);
             return categories;
         }
  }
}