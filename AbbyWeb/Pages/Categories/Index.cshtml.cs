using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbbyWeb.Data;
using AbbyWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Categories
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public IEnumerable<Category> Categories { get; set; } = Enumerable.Empty<Category>();
        public IndexModel(ApplicationDbContext db)
        {
            _db=db;
        }
        public void OnGet()
        {
            Categories = _db.Category;
        }
    }
}
