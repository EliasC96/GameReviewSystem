using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GameReviewSystem.Data;
using GameReviewSystem.Models;

namespace GameReviewSystem.Pages.Platforms
{
    public class IndexModel : PageModel
    {
        private readonly GameReviewSystem.Data.GameReviewSystemContext _context;

        public IndexModel(GameReviewSystem.Data.GameReviewSystemContext context)
        {
            _context = context;
        }

        public IList<Platform> Platform { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Platform = await _context.Platform.ToListAsync();
        }
    }
}
