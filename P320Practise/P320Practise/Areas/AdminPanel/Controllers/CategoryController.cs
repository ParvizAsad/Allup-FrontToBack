using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P320FrontToBack.Areas.AdminPanel.Data;
using P320Practise.Areas.AdminPanel.Data;
using P320Practise.DataAccessLayer;
using P320Practise.Models;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace P320Practise.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly IWebHostEnvironment _environment;


        public CategoryController(AppDbContext dbContext, IWebHostEnvironment environment)
        {
            _dbContext = dbContext;
            _environment = environment;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _dbContext.Categories.Where(x => x.IsDeleted == false)
                .ToListAsync();

            return View(categories);
        }

        public async Task<IActionResult> Create()
        {
            var parentCategories = await _dbContext.Categories
                .Where(x => x.IsDeleted == false && x.IsMain).ToListAsync();
            ViewBag.ParentCategories = parentCategories;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category, int parentCategoryId)
        {
            var parentCategories = await _dbContext.Categories
                .Where(x => x.IsDeleted == false && x.IsMain).ToListAsync();
            ViewBag.ParentCategories = parentCategories;

            if (!ModelState.IsValid)
                return View();

            if (category.IsMain)
            {
                if (category.Photo == null)
                {
                    ModelState.AddModelError("", "Shekil sechin.");
                    return View();
                }

                if (!category.Photo.IsImage())
                {
                    ModelState.AddModelError("", "Duzgun shekil formati sechin.");
                    return View();
                }

                if (!category.Photo.IsAllowedSize(1))
                {
                    ModelState.AddModelError("", "1Mb-dan artiq ola bilmez.");
                    return View();
                }

                var fileName = await category.Photo.GenerateFile(Constants.ImageFolderPath);

                category.Image = fileName;
            }
            else
            {
                if (parentCategoryId == 0)
                {
                    ModelState.AddModelError("", "Parent kateqoriyasi sechin.");
                    return View();
                }

                var existParentCategory = await _dbContext.Categories
                    .Include(x => x.Children.Where(y => y.IsDeleted == false))
                    .FirstOrDefaultAsync(x => x.IsDeleted == false && x.Id == parentCategoryId);
                if (existParentCategory == null)
                    return NotFound();

                var existChildCategory = existParentCategory.Children
                    .Any(x => x.Name.ToLower() == category.Name.ToLower());
                if (existChildCategory)
                {
                    ModelState.AddModelError("", "Bu adda kateqoriya var.");
                    return View();
                }

                category.Parent = existParentCategory;
            }

            category.IsDeleted = false;
            await _dbContext.Categories.AddAsync(category);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var category = await _dbContext.Categories
                .Where(x => x.Id == id && x.IsDeleted == false)
                .Include(x => x.Parent)
                .Include(x => x.Children.Where(y => y.IsDeleted == false))
                .FirstOrDefaultAsync();
            if (category == null)
                return NotFound();

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteCategory(int? id)
        {
            if (id == null)
                return NotFound();

            var category = await _dbContext.Categories
                .Where(x => x.Id == id && x.IsDeleted == false)
                .Include(x => x.Children.Where(y => y.IsDeleted == false))
                .FirstOrDefaultAsync();
            if (category == null)
                return NotFound();

            category.IsDeleted = true;
            if (category.IsMain)
            {
                foreach (var item in category.Children)
                {
                    item.IsDeleted = true;
                }
            }

            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int? id)
        {
            var parentCategories = await _dbContext.Categories
                   .Where(x => x.IsDeleted == false && x.IsMain).ToListAsync();
            ViewBag.ParentCategories = parentCategories;

            if (id == null)
                return NotFound();

            var category = await _dbContext.Categories.FirstOrDefaultAsync(x => x.Id == id);

            if (category == null)
                return NotFound();

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Category categorys)
        {
            if (id == null)
                return NotFound();

            if (id != categorys.Id)
                return NotFound();

            var parentCategories = await _dbContext.Categories
                .Where(x => x.IsDeleted == false && x.IsMain).ToListAsync();
            ViewBag.ParentCategories = parentCategories;

            var existCategory = await _dbContext.Categories.FindAsync(id);
            if (existCategory == null)
                return NotFound();


            if (categorys.IsMain)
            {
                if (categorys.Photo == null)
                {
                    ModelState.AddModelError("", "Shekil sechin.");
                    return View();
                }

                if (!categorys.Photo.IsImage())
                {
                    ModelState.AddModelError("", "Duzgun shekil formati sechin.");
                    return View();
                }

                if (!categorys.Photo.IsAllowedSize(1))
                {
                    ModelState.AddModelError("", "1Mb-dan artiq ola bilmez.");
                    return View();
                }

                var fileName = await categorys.Photo.GenerateFile(Constants.ImageFolderPath);

                categorys.Image = fileName;
            }
            else
            {
                if (id == 0)
                {
                    ModelState.AddModelError("", "Parent kateqoriyasi sechin.");
                    return View();
                }

                var existParentCategory = await _dbContext.Categories
                    .Include(x => x.Children.Where(y => y.IsDeleted == false))
                    .FirstOrDefaultAsync(x => x.IsDeleted == false && x.Id == id);
                if (existParentCategory == null)
                    return NotFound();

                var existChildCategory = existParentCategory.Children
                    .Any(x => x.Name.ToLower() == categorys.Name.ToLower());
                if (existChildCategory)
                {
                    ModelState.AddModelError("", "Bu adda kateqoriya var.");
                    return View();
                }

                categorys.Parent = existParentCategory;
            }


            var isExist = await _dbContext.Categories.Where(x => x.IsDeleted == false).AnyAsync(x =>
                x.Name.Trim().ToLower() == categorys.Name.Trim().ToLower() && x.Id != id);

            if (isExist)
            {
                ModelState.AddModelError("Name", "Bu adda category var");
                return View();
            }

            existCategory.Name = categorys.Name;
            existCategory.Parent = categorys.Parent;
            existCategory.IsMain = categorys.IsMain;
            existCategory.IsDeleted = categorys.IsDeleted;

            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

            

        

        }


        public async Task<IActionResult> Details(int? id)
        {
           if (id == null)
                return BadRequest();

            var category = await _dbContext.Categories
                .Where(x => x.Id == id && x.IsDeleted == false)
                .Include(x => x.Parent)
                .Include(x => x.Children.Where(y => y.IsDeleted == false))
                .FirstOrDefaultAsync();

            if (category == null)
                return NotFound();

            return View(category);

        }

    }
}
