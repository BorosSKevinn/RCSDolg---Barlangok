using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RCSDolg.Data;
using RCSDolg.Models;

namespace RCSDolg.Pages
{
    public class IndexModel : PageModel
    {

        private readonly BarlangDbContext _context;

        public IndexModel(BarlangDbContext context)
        {
            _context = context;
        }

        public IList<Barlang> Barlang { get; set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string? SearchCity { get; set; }
        public string? CurrentFilter { get; set; }
        public List<string> Cities { get; set; } = new List<string>();


        public async Task OnGetAsync()
        {
            Barlang = await _context.Barlangok.ToListAsync();
            IQueryable<Barlang> query = _context.Barlangok;

            if (!string.IsNullOrEmpty(SearchCity))
            {
                query = query.Where(b => b.Telepules.Contains(SearchCity));
                CurrentFilter = SearchCity;
            }

            Cities = await _context.Barlangok
                .Select(b => b.Telepules)
                .Distinct()
                .OrderBy(t => t)
                .ToListAsync();

            Barlang = await query.ToListAsync();
        }
    }
}
