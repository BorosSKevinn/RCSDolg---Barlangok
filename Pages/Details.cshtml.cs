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
    public class DetailsModel : PageModel
    {
        private readonly RCSDolg.Data.BarlangDbContext _context;

        public DetailsModel(RCSDolg.Data.BarlangDbContext context)
        {
            _context = context;
        }

        public Barlang Barlang { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var barlang = await _context.Barlangok.FirstOrDefaultAsync(m => m.Id == id);
            if (barlang == null)
            {
                return NotFound();
            }
            else
            {
                Barlang = barlang;
            }
            return Page();
        }
    }
}
