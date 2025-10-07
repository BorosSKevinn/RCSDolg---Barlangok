using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RCSDolg.Data;

namespace RCSDolg.Pages
{
    public class SummaryModel : PageModel
    {
        private readonly BarlangDbContext _context;

        public SummaryModel(BarlangDbContext context)
        {
            _context = context;
        }

        public IList<SummaryItem> Summary { get; set; } = new List<SummaryItem>();

        public async Task OnGetAsync()
        {
            Summary = await _context.Barlangok
                .GroupBy(b => b.Telepules)
                .Select(g => new SummaryItem
                {
                    Telepules = g.Key,
                    Count = g.Count()
                }).ToListAsync();
        }
    }

    public class SummaryItem
    {
        public string Telepules { get; set; } = string.Empty;
        public int Count { get; set; }
    }
}
