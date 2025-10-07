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
        private readonly RCSDolg.Data.BarlangDbContext _context;

        public IndexModel(RCSDolg.Data.BarlangDbContext context)
        {
            _context = context;
        }

        public IList<Barlang> Barlang { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Barlang = await _context.Barlangok.ToListAsync();
        }
    }
}
